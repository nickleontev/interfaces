namespace _2sem1lab
{
    partial class Readin_btn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readin_btn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dadname = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Group = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Faculty = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.errorProviderSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.DirectoryPath_btn = new System.Windows.Forms.Button();
            this.DirectoryPathText = new System.Windows.Forms.TextBox();
            this.FilePath_btn = new System.Windows.Forms.Button();
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Born = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DirrectoryPath = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NameOfFile = new System.Windows.Forms.Label();
            this.ScrollRec = new System.Windows.Forms.Button();
            this.errorProviderFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDadname = new System.Windows.Forms.ErrorProvider(this.components);
            this.Reading_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDadname)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Dadname);
            this.panel1.Controls.Add(this.FName);
            this.panel1.Controls.Add(this.Surname);
            this.panel1.Location = new System.Drawing.Point(28, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 173);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // Dadname
            // 
            this.Dadname.Location = new System.Drawing.Point(119, 128);
            this.Dadname.Name = "Dadname";
            this.Dadname.Size = new System.Drawing.Size(100, 20);
            this.Dadname.TabIndex = 2;
            this.Dadname.TextChanged += new System.EventHandler(this.Dadname_TextChanged);
            this.Dadname.Validated += new System.EventHandler(this.Dadname_Validated);
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(119, 80);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(100, 20);
            this.FName.TabIndex = 1;
            this.FName.Validated += new System.EventHandler(this.FName_Validated);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(119, 29);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 0;
            this.Surname.Validated += new System.EventHandler(this.Surname_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Group
            // 
            this.Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group.FormattingEnabled = true;
            this.Group.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Group.Location = new System.Drawing.Point(78, 117);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(79, 21);
            this.Group.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Курс";
            // 
            // Faculty
            // 
            this.Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Faculty.Items.AddRange(new object[] {
            "АИТ",
            "ИЭФ",
            "ТЭФ",
            "НТФ",
            "ХТФ",
            "ИТФ",
            "ЭТФ",
            "ФММТ",
            "ФПП",
            "ФГО"});
            this.Faculty.Location = new System.Drawing.Point(78, 60);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(79, 21);
            this.Faculty.TabIndex = 4;
            this.Faculty.SelectedIndexChanged += new System.EventHandler(this.Faculty_SelectedIndexChanged);
            // 
            // Course
            // 
            this.Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI"});
            this.Course.Location = new System.Drawing.Point(78, 87);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(79, 21);
            this.Course.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Факультет";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(7, 10);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(88, 10);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(169, 10);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // errorProviderSurname
            // 
            this.errorProviderSurname.ContainerControl = this;
            // 
            // DirectoryPath_btn
            // 
            this.DirectoryPath_btn.Location = new System.Drawing.Point(28, 59);
            this.DirectoryPath_btn.Name = "DirectoryPath_btn";
            this.DirectoryPath_btn.Size = new System.Drawing.Size(34, 20);
            this.DirectoryPath_btn.TabIndex = 16;
            this.DirectoryPath_btn.Text = "...";
            this.DirectoryPath_btn.UseVisualStyleBackColor = true;
            this.DirectoryPath_btn.Click += new System.EventHandler(this.DirectoryPath_btn_Click);
            // 
            // DirectoryPathText
            // 
            this.DirectoryPathText.Location = new System.Drawing.Point(68, 60);
            this.DirectoryPathText.Name = "DirectoryPathText";
            this.DirectoryPathText.Size = new System.Drawing.Size(161, 20);
            this.DirectoryPathText.TabIndex = 17;
            this.DirectoryPathText.TextChanged += new System.EventHandler(this.DirectoryPathText_TextChanged);
            // 
            // FilePath_btn
            // 
            this.FilePath_btn.Location = new System.Drawing.Point(28, 5);
            this.FilePath_btn.Name = "FilePath_btn";
            this.FilePath_btn.Size = new System.Drawing.Size(34, 20);
            this.FilePath_btn.TabIndex = 18;
            this.FilePath_btn.Text = "...";
            this.FilePath_btn.UseVisualStyleBackColor = true;
            this.FilePath_btn.Click += new System.EventHandler(this.FilePath_btn_Click);
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(68, 5);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(161, 20);
            this.FilePathText.TabIndex = 19;
            this.FilePathText.TextChanged += new System.EventHandler(this.FilePathText_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 18);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "№ записи";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CreatePrompt = true;
            // 
            // Born
            // 
            this.Born.AutoSize = true;
            this.Born.Location = new System.Drawing.Point(41, 9);
            this.Born.Name = "Born";
            this.Born.Size = new System.Drawing.Size(81, 13);
            this.Born.TabIndex = 22;
            this.Born.Text = "Год рождения:";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Save);
            this.panel2.Controls.Add(this.Clear);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Location = new System.Drawing.Point(28, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 46);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Location = new System.Drawing.Point(315, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 47);
            this.panel3.TabIndex = 24;
            // 
            // DirrectoryPath
            // 
            this.DirrectoryPath.AutoSize = true;
            this.DirrectoryPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.DirrectoryPath.Location = new System.Drawing.Point(235, 63);
            this.DirrectoryPath.Name = "DirrectoryPath";
            this.DirrectoryPath.Size = new System.Drawing.Size(149, 13);
            this.DirrectoryPath.TabIndex = 25;
            this.DirrectoryPath.Text = "Выбор каталога для записи";
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(235, 8);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(174, 13);
            this.FilePath.TabIndex = 26;
            this.FilePath.Text = "Выбор файла для чтения/записи";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(68, 86);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(161, 20);
            this.FileName.TabIndex = 27;
            this.FileName.Text = "example";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Born);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Faculty);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Course);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Group);
            this.panel4.Location = new System.Drawing.Point(336, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 152);
            this.panel4.TabIndex = 28;
            // 
            // NameOfFile
            // 
            this.NameOfFile.AutoSize = true;
            this.NameOfFile.Location = new System.Drawing.Point(235, 89);
            this.NameOfFile.Name = "NameOfFile";
            this.NameOfFile.Size = new System.Drawing.Size(156, 13);
            this.NameOfFile.TabIndex = 29;
            this.NameOfFile.Text = "Имя файла (без разширения)";
            // 
            // ScrollRec
            // 
            this.ScrollRec.Location = new System.Drawing.Point(390, 304);
            this.ScrollRec.Name = "ScrollRec";
            this.ScrollRec.Size = new System.Drawing.Size(40, 29);
            this.ScrollRec.TabIndex = 30;
            this.ScrollRec.Text = "֎";
            this.ScrollRec.UseVisualStyleBackColor = true;
            this.ScrollRec.Click += new System.EventHandler(this.ScrollRec_Click);
            // 
            // errorProviderFName
            // 
            this.errorProviderFName.ContainerControl = this;
            // 
            // errorProviderDadname
            // 
            this.errorProviderDadname.ContainerControl = this;
            // 
            // Reading_btn
            // 
            this.Reading_btn.Location = new System.Drawing.Point(176, 31);
            this.Reading_btn.Name = "Reading_btn";
            this.Reading_btn.Size = new System.Drawing.Size(53, 23);
            this.Reading_btn.TabIndex = 31;
            this.Reading_btn.Text = "Читать";
            this.Reading_btn.UseVisualStyleBackColor = true;
            this.Reading_btn.Click += new System.EventHandler(this.Reading_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(459, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // Readin_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(571, 377);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Reading_btn);
            this.Controls.Add(this.ScrollRec);
            this.Controls.Add(this.NameOfFile);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.DirrectoryPath);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FilePathText);
            this.Controls.Add(this.FilePath_btn);
            this.Controls.Add(this.DirectoryPathText);
            this.Controls.Add(this.DirectoryPath_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Readin_btn";
            this.Text = "StudentList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Readin_btn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDadname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dadname;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Faculty;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ErrorProvider errorProviderSurname;
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button FilePath_btn;
        private System.Windows.Forms.TextBox DirectoryPathText;
        private System.Windows.Forms.Button DirectoryPath_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Born;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.Label DirrectoryPath;
        private System.Windows.Forms.Label NameOfFile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button ScrollRec;
        private System.Windows.Forms.ErrorProvider errorProviderFName;
        private System.Windows.Forms.ErrorProvider errorProviderDadname;
        private System.Windows.Forms.Button Reading_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

