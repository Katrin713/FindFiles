using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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

        private List<string> GetFiles(string path, string pattern)
        {
            var files = new List<string>();
            try
            {
                files.AddRange(Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly));

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

        private void button1_Click(object sender, EventArgs e)
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
            string sourceDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
           
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
    }
}
