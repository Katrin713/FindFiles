using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WorkingWithFiles
{
    public partial class Form1 : Form
    {
        static int countFiles = 0; // counting all files
        Stopwatch startTime;
        long resultTime;

        public Form1()
        {
            InitializeComponent();
            ResultBox.Visible = false;
        }

        private string getPattern(string userPattern)
        {
            string regexPattern = "";
            foreach (char el in userPattern)
            {
                if (el == '*')
                    regexPattern += "\\d*.";
                else
                if (el == '?')
                    regexPattern += "\\d?\\D";
                else
                    regexPattern += el;
            }
            return regexPattern;
        }
       
        // get correct files by template
        private List<string> getCorrectFiles(string[] allFiles, string pattern)
        {
            List<string> correctFiles = new List<string>();
   
            foreach (string el in allFiles)
            {
                Thread.Sleep(200);
                string fileName = Path.GetFileName(el);

                if (this.InvokeRequired)
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        workingFile.Text = "Обрабатываемый файл: " + fileName;
                        textCountFiles.Text = "Количество обаботанных файлов: " + (countFiles++);
                    }
                  ));
             
                Regex myReg = new Regex(pattern);
                if (myReg.IsMatch(fileName))
                    correctFiles.Add(el);
            }
            return correctFiles;
        }

        private List<string> GetFiles(string path, string pattern)
        {
            var files = new List<string>();
            try
            {          
                files.AddRange(getCorrectFiles(Directory.GetFiles(path), pattern));

                foreach (var directory in Directory.GetDirectories(path))
                    files.AddRange(GetFiles(directory, pattern));
            }
            catch (UnauthorizedAccessException) { }
            catch (EvaluateException)
            {
                MessageBox.Show("Указанная директория не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return files;
        }

        // choose folder
        private string ChooseFolder()
        {
            if (chooseFolder.ShowDialog() == DialogResult.OK)
            {
                return chooseFolder.SelectedPath;
            }
            return "";
        }
        private void chooseDirectory(object sender, EventArgs e)
        {           
            startDirectory.Text = ChooseFolder();          
        }
        // writing template
        private void trueChooseElem(object sender, EventArgs e)
        {
            secondTask.Visible = (startDirectory.Text == "") ? false : true;
            if (startDirectory.Text == "")
                template.Text = "";
        }
        private void chooseTemplate(object sender, EventArgs e)
        {
            specialTextGroup.Visible = (template.Text == "") ? false : true;
        }

        Thread myThread;
        private void startFinding(object sender, EventArgs e)
        {
            if (startDirectory.Text == "")
            {
                MessageBox.Show("Не указана начальная директория!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (template.Text == "")
            {
                MessageBox.Show("Не указан шаблон файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (myThread == null || !myThread.IsAlive)
            {
                ResultBox.Visible = true;
                myThread = new Thread(() => GetFiles(startDirectory.Text, getPattern(template.Text)));

                startTime = new Stopwatch();
                startTime.Start();
                myThread.Start();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myThread.ThreadState == System.Threading.ThreadState.Suspended)
                myThread.Resume();
            myThread.Abort();
        }
        private void StopWorking_Click(object sender, EventArgs e)
        {
       //     if (myThread.ThreadState != System.Threading.ThreadState.Running)
        //        return;

            myThread.Suspend();
            buttonStop.Visible = false;
            buttonReStart.Visible = true;
        }
        private void ReStart_Click(object sender, EventArgs e)
        {
            myThread.Resume();
            buttonStop.Visible = true;
            buttonReStart.Visible = false;
        }
    }
}