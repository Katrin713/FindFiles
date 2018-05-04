namespace WorkingWithFiles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.template = new System.Windows.Forms.TextBox();
            this.workingFile = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.textCountFiles = new System.Windows.Forms.Label();
            this.chooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.startDirectory = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.secondTask = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.specialTextGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.secondTask.SuspendLayout();
            this.specialTextGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стартовая директория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шаблон имени файла: ";
            // 
            // template
            // 
            this.template.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.template.Location = new System.Drawing.Point(369, 20);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(824, 44);
            this.template.TabIndex = 4;
            // 
            // workingFile
            // 
            this.workingFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workingFile.Location = new System.Drawing.Point(-6, 9);
            this.workingFile.Name = "workingFile";
            this.workingFile.Size = new System.Drawing.Size(1178, 44);
            this.workingFile.TabIndex = 3;
            this.workingFile.Text = "Обрабатываемый файл:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textCountFiles);
            this.groupBox1.Controls.Add(this.workingFile);
            this.groupBox1.Location = new System.Drawing.Point(18, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1460, 665);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(791, 9);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(663, 642);
            this.treeView1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 43);
            this.label6.TabIndex = 9;
            this.label6.Text = "Прошедшее время: ";
            // 
            // textCountFiles
            // 
            this.textCountFiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCountFiles.Location = new System.Drawing.Point(-6, 72);
            this.textCountFiles.Name = "textCountFiles";
            this.textCountFiles.Size = new System.Drawing.Size(1184, 45);
            this.textCountFiles.TabIndex = 8;
            this.textCountFiles.Text = "Количество обаботанных файлов: ";
            // 
            // startDirectory
            // 
            this.startDirectory.Enabled = false;
            this.startDirectory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDirectory.Location = new System.Drawing.Point(372, 35);
            this.startDirectory.Name = "startDirectory";
            this.startDirectory.Size = new System.Drawing.Size(824, 44);
            this.startDirectory.TabIndex = 3;
            this.startDirectory.Click += new System.EventHandler(this.chooseDirectory);
            this.startDirectory.TextChanged += new System.EventHandler(this.trueChooseElem);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1215, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.chooseDirectory);
            // 
            // secondTask
            // 
            this.secondTask.Controls.Add(this.button3);
            this.secondTask.Controls.Add(this.template);
            this.secondTask.Controls.Add(this.label2);
            this.secondTask.Location = new System.Drawing.Point(3, 99);
            this.secondTask.Name = "secondTask";
            this.secondTask.Size = new System.Drawing.Size(1475, 85);
            this.secondTask.TabIndex = 11;
            this.secondTask.TabStop = false;
            this.secondTask.Visible = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1211, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.chooseTemplate);
            // 
            // specialTextGroup
            // 
            this.specialTextGroup.Controls.Add(this.button1);
            this.specialTextGroup.Controls.Add(this.textBox1);
            this.specialTextGroup.Controls.Add(this.label3);
            this.specialTextGroup.Location = new System.Drawing.Point(18, 190);
            this.specialTextGroup.Name = "specialTextGroup";
            this.specialTextGroup.Size = new System.Drawing.Size(1460, 228);
            this.specialTextGroup.TabIndex = 12;
            this.specialTextGroup.TabStop = false;
            this.specialTextGroup.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1196, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.startFinding);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(354, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(824, 206);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 83);
            this.label3.TabIndex = 2;
            this.label3.Text = "Текст, содежащийся в файле: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 89);
            this.button4.TabIndex = 11;
            this.button4.Text = "Остановить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(302, 106);
            this.button5.TabIndex = 12;
            this.button5.Text = "Возобновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1490, 1210);
            this.Controls.Add(this.specialTextGroup);
            this.Controls.Add(this.secondTask);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startDirectory);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1516, 1281);
            this.MinimumSize = new System.Drawing.Size(1516, 1281);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Прогамма для поиска файлов по заданным критериям";
            this.groupBox1.ResumeLayout(false);
            this.secondTask.ResumeLayout(false);
            this.secondTask.PerformLayout();
            this.specialTextGroup.ResumeLayout(false);
            this.specialTextGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.TextBox template;
        private System.Windows.Forms.Label workingFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label textCountFiles;
        public System.Windows.Forms.FolderBrowserDialog chooseFolder;
        private System.Windows.Forms.TextBox startDirectory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox secondTask;
    
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox specialTextGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

