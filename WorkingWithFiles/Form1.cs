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
        TreeNode parentNode, currNode;

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
                {  
                    string neededFile = el.Substring(startDirectory.Text.Length + 1) + "\\";
                    
                    if (this.InvokeRequired)
                        BeginInvoke(new MethodInvoker(() =>
                        {
                            currNode = parentNode;
                            string specialName = FindNodeByName(neededFile);
                            getStartTree(specialName);
                        }
                      ));
                    correctFiles.Add(neededFile);
                }
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

        private void getStartTree(string temp)
        {
            if (currNode == null)
            {
                currNode = treeView1.Nodes.Add(temp.Substring(0, temp.IndexOf('\\')));
                temp = temp.Substring(temp.IndexOf('\\') + 1);
            }
            while (temp != "")
            {
                
                int index = temp.IndexOf('\\');
                if (index > 0)
                    currNode = currNode.Nodes.Add(temp.Substring(0, index));
                temp = temp.Substring(temp.IndexOf('\\') + 1);
            }
        }

        string FindNodeByName(string name)
        {

            for (int i = -1; i < currNode.Nodes.Count - 1; )
            {
                i++;
                if (currNode.Nodes[i].Text == name.Substring(0, name.IndexOf('\\')))
                {
                    currNode = currNode.Nodes[i];
                    name = name.Substring(name.IndexOf('\\') + 1);
                    i = -1;
                }
            }
            return name;
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
                treeView1.Nodes.Clear();
                currNode = null;
                getStartTree(startDirectory.Text + "\\");
                parentNode = currNode;
                timer.Start();
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
            myThread.Suspend();
            buttonStop.Visible = false;
            buttonReStart.Visible = true;
            timer.Stop();
        }
        private void ReStart_Click(object sender, EventArgs e)
        {
            myThread.Resume();
            buttonStop.Visible = true;
            timer.Start();
            buttonReStart.Visible = false;
        }
        int h, min, sec;
        private void timer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                h++;
            }
            textTime.Text = string.Format("Прошедшее время: {0} ч. {1} мин. {2} сек.", h, min, sec);
            if (myThread.IsAlive == false)
                timer.Stop();
        }
    }
}