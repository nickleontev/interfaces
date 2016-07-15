namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textbox_dadname = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_show = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textbox_txt_path = new System.Windows.Forms.TextBox();
            this.textbox_bin_path = new System.Windows.Forms.TextBox();
            this.txtbrowse = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combobox_faculty = new System.Windows.Forms.ComboBox();
            this.combobox_curse = new System.Windows.Forms.ComboBox();
            this.combobox_group = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_binbrowse = new System.Windows.Forms.Button();
            this.but_datbrowse = new System.Windows.Forms.Button();
            this.textbox_dat_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.load_button = new System.Windows.Forms.Button();
            this.datradio = new System.Windows.Forms.RadioButton();
            this.binradio = new System.Windows.Forms.RadioButton();
            this.txtradio = new System.Windows.Forms.RadioButton();
            this.openFileDialog_dat = new System.Windows.Forms.OpenFileDialog();
            this.numeric_mark = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.show_num = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog_txt = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_bin = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_cnf = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_num)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_dadname
            // 
            this.textbox_dadname.Location = new System.Drawing.Point(70, 232);
            this.textbox_dadname.Name = "textbox_dadname";
            this.textbox_dadname.Size = new System.Drawing.Size(263, 20);
            this.textbox_dadname.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textbox_dadname, "Введите отчество");
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(70, 178);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(263, 20);
            this.textbox_name.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textbox_name, "Введите фамилию");
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Location = new System.Drawing.Point(70, 132);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(263, 20);
            this.textbox_lastname.TabIndex = 0;
            this.textbox_lastname.TabStop = false;
            this.toolTip1.SetToolTip(this.textbox_lastname, "Введите имя");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // but_show
            // 
            this.but_show.Location = new System.Drawing.Point(366, 292);
            this.but_show.Name = "but_show";
            this.but_show.Size = new System.Drawing.Size(75, 23);
            this.but_show.TabIndex = 8;
            this.but_show.Text = "Перейти к";
            this.but_show.UseVisualStyleBackColor = true;
            this.but_show.Click += new System.EventHandler(this.show_but);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 321);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(466, 172);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // textbox_txt_path
            // 
            this.textbox_txt_path.Location = new System.Drawing.Point(44, 15);
            this.textbox_txt_path.Name = "textbox_txt_path";
            this.textbox_txt_path.Size = new System.Drawing.Size(311, 20);
            this.textbox_txt_path.TabIndex = 9;
            // 
            // textbox_bin_path
            // 
            this.textbox_bin_path.Location = new System.Drawing.Point(44, 45);
            this.textbox_bin_path.Name = "textbox_bin_path";
            this.textbox_bin_path.Size = new System.Drawing.Size(311, 20);
            this.textbox_bin_path.TabIndex = 10;
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(8, 12);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(30, 23);
            this.txtbrowse.TabIndex = 10;
            this.txtbrowse.Text = "txt";
            this.txtbrowse.UseVisualStyleBackColor = true;
            this.txtbrowse.Click += new System.EventHandler(this.txtbrowse_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // combobox_faculty
            // 
            this.combobox_faculty.FormattingEnabled = true;
            this.combobox_faculty.Items.AddRange(new object[] {
            "ИЭФ",
            "ХТФ",
            "АИТ",
            "ТЭФ",
            "ЭТФ",
            "ФММТ",
            "НТФ",
            "ИТФ",
            "ФПП",
            "ИЭФ",
            "ФГО"});
            this.combobox_faculty.Location = new System.Drawing.Point(360, 185);
            this.combobox_faculty.Name = "combobox_faculty";
            this.combobox_faculty.Size = new System.Drawing.Size(121, 21);
            this.combobox_faculty.TabIndex = 5;
            this.combobox_faculty.Text = "Факультет";
            // 
            // combobox_curse
            // 
            this.combobox_curse.FormattingEnabled = true;
            this.combobox_curse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.combobox_curse.Location = new System.Drawing.Point(360, 158);
            this.combobox_curse.Name = "combobox_curse";
            this.combobox_curse.Size = new System.Drawing.Size(121, 21);
            this.combobox_curse.TabIndex = 4;
            this.combobox_curse.Text = "Курс";
            // 
            // combobox_group
            // 
            this.combobox_group.FormattingEnabled = true;
            this.combobox_group.Items.AddRange(new object[] {
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
            this.combobox_group.Location = new System.Drawing.Point(360, 211);
            this.combobox_group.Name = "combobox_group";
            this.combobox_group.Size = new System.Drawing.Size(121, 21);
            this.combobox_group.TabIndex = 6;
            this.combobox_group.Text = "Группа";
            // 
            // num
            // 
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num.Enabled = false;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num.ForeColor = System.Drawing.SystemColors.InfoText;
            this.num.InterceptArrowKeys = false;
            this.num.Location = new System.Drawing.Point(52, 289);
            this.num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Size = new System.Drawing.Size(43, 27);
            this.num.TabIndex = 11;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(120, 289);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 27);
            this.but_delete.TabIndex = 12;
            this.but_delete.Text = "Удалить";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.delButton_Click);
            // 
            // but_binbrowse
            // 
            this.but_binbrowse.Location = new System.Drawing.Point(8, 48);
            this.but_binbrowse.Name = "but_binbrowse";
            this.but_binbrowse.Size = new System.Drawing.Size(30, 23);
            this.but_binbrowse.TabIndex = 13;
            this.but_binbrowse.Text = "bin";
            this.but_binbrowse.UseVisualStyleBackColor = true;
            this.but_binbrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_datbrowse
            // 
            this.but_datbrowse.Location = new System.Drawing.Point(8, 72);
            this.but_datbrowse.Name = "but_datbrowse";
            this.but_datbrowse.Size = new System.Drawing.Size(30, 23);
            this.but_datbrowse.TabIndex = 14;
            this.but_datbrowse.Text = "dat";
            this.but_datbrowse.UseVisualStyleBackColor = true;
            this.but_datbrowse.Click += new System.EventHandler(this.but_datbrowse_Click);
            // 
            // textbox_dat_path
            // 
            this.textbox_dat_path.Location = new System.Drawing.Point(44, 75);
            this.textbox_dat_path.Name = "textbox_dat_path";
            this.textbox_dat_path.Size = new System.Drawing.Size(311, 20);
            this.textbox_dat_path.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.load_button);
            this.groupBox1.Controls.Add(this.datradio);
            this.groupBox1.Controls.Add(this.binradio);
            this.groupBox1.Controls.Add(this.txtradio);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 83);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузить из:";
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(45, 33);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(76, 23);
            this.load_button.TabIndex = 17;
            this.load_button.Text = "Загрузить";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // datradio
            // 
            this.datradio.AutoSize = true;
            this.datradio.Enabled = false;
            this.datradio.Location = new System.Drawing.Point(6, 59);
            this.datradio.Name = "datradio";
            this.datradio.Size = new System.Drawing.Size(40, 17);
            this.datradio.TabIndex = 2;
            this.datradio.Text = "dat";
            this.datradio.UseVisualStyleBackColor = true;
            // 
            // binradio
            // 
            this.binradio.AutoSize = true;
            this.binradio.Enabled = false;
            this.binradio.Location = new System.Drawing.Point(6, 36);
            this.binradio.Name = "binradio";
            this.binradio.Size = new System.Drawing.Size(39, 17);
            this.binradio.TabIndex = 1;
            this.binradio.Text = "bin";
            this.binradio.UseVisualStyleBackColor = true;
            // 
            // txtradio
            // 
            this.txtradio.AutoSize = true;
            this.txtradio.Checked = true;
            this.txtradio.Enabled = false;
            this.txtradio.Location = new System.Drawing.Point(6, 13);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(36, 17);
            this.txtradio.TabIndex = 0;
            this.txtradio.TabStop = true;
            this.txtradio.Text = "txt";
            this.txtradio.UseVisualStyleBackColor = true;
            this.txtradio.CheckedChanged += new System.EventHandler(this.txtradio_CheckedChanged);
            // 
            // openFileDialog_dat
            // 
            this.openFileDialog_dat.CheckFileExists = false;
            this.openFileDialog_dat.CheckPathExists = false;
            this.openFileDialog_dat.DefaultExt = "dat";
            this.openFileDialog_dat.FileName = "datfile";
            this.openFileDialog_dat.Filter = "dat файл (*.dat)|*.dat";
            // 
            // numeric_mark
            // 
            this.numeric_mark.Location = new System.Drawing.Point(455, 238);
            this.numeric_mark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_mark.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_mark.Name = "numeric_mark";
            this.numeric_mark.Size = new System.Drawing.Size(28, 20);
            this.numeric_mark.TabIndex = 17;
            this.numeric_mark.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Оценка";
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(12, 289);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(34, 27);
            this.button_left.TabIndex = 19;
            this.button_left.Text = "<<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(80, 289);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(34, 27);
            this.button_right.TabIndex = 20;
            this.button_right.Text = ">>";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // show_num
            // 
            this.show_num.Location = new System.Drawing.Point(449, 292);
            this.show_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.show_num.Name = "show_num";
            this.show_num.Size = new System.Drawing.Size(34, 20);
            this.show_num.TabIndex = 21;
            this.show_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog_txt
            // 
            this.openFileDialog_txt.CheckFileExists = false;
            this.openFileDialog_txt.DefaultExt = "txt";
            this.openFileDialog_txt.FileName = "txtfile";
            this.openFileDialog_txt.Filter = "txt файл (*.txt)|*.txt";
            // 
            // openFileDialog_bin
            // 
            this.openFileDialog_bin.CheckFileExists = false;
            this.openFileDialog_bin.DefaultExt = "bin";
            this.openFileDialog_bin.FileName = "binfile";
            this.openFileDialog_bin.Filter = "bin файл (*.bin)|*.bin";
            // 
            // saveFileDialog_cnf
            // 
            this.saveFileDialog_cnf.DefaultExt = "txt";
            this.saveFileDialog_cnf.FileName = "conf";
            this.saveFileDialog_cnf.Filter = "txt файл (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 515);
            this.Controls.Add(this.show_num);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeric_mark);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textbox_dat_path);
            this.Controls.Add(this.but_datbrowse);
            this.Controls.Add(this.but_binbrowse);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.num);
            this.Controls.Add(this.combobox_group);
            this.Controls.Add(this.combobox_curse);
            this.Controls.Add(this.combobox_faculty);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbrowse);
            this.Controls.Add(this.textbox_bin_path);
            this.Controls.Add(this.textbox_txt_path);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.but_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.textbox_dadname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Приложение 1.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_dadname;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_show;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textbox_txt_path;
        private System.Windows.Forms.TextBox textbox_bin_path;
        private System.Windows.Forms.Button txtbrowse;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combobox_faculty;
        private System.Windows.Forms.ComboBox combobox_curse;
        private System.Windows.Forms.ComboBox combobox_group;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_datbrowse;
        private System.Windows.Forms.TextBox textbox_dat_path;
        public System.Windows.Forms.Button but_binbrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton datradio;
        private System.Windows.Forms.RadioButton binradio;
        private System.Windows.Forms.RadioButton txtradio;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.NumericUpDown numeric_mark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.NumericUpDown show_num;
        public System.Windows.Forms.OpenFileDialog openFileDialog_txt;
        public System.Windows.Forms.OpenFileDialog openFileDialog_bin;
        public System.Windows.Forms.SaveFileDialog saveFileDialog_cnf;
        public System.Windows.Forms.OpenFileDialog openFileDialog_dat;
    }
}

