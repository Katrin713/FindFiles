using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkingWithFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        static void AsyncCompleted(IAsyncResult resObj, string fileName)
        {
            
        }
        static int countFiles;
        private List<string> getCorrectFiles(string[] allFiles, string pattern)
        {
            List<string> correctFiles = new List<string>();

            foreach (string el in allFiles)
            {
                Thread.Sleep(200);

                string z = Path.GetFileName(el);
                BeginInvoke(new MethodInvoker(() => workingFile.Text = "Обрабатываемый файл: " + z));
                Regex myReg = new Regex(pattern);
                if (myReg.IsMatch(z))
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
            myThread = new Thread(() => GetFiles(startDirectory.Text, getPattern(template.Text)));
            myThread.Start();
            
            // var temp = GetFiles(startDirectory.Text, getPattern(template.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myThread.Suspend();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myThread.Resume();
        }
    }
}
