using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2sem1lab
{
    public partial class Readin_btn : Form
    {
        public Readin_btn()
        {
            InitializeComponent();
        }
        bool tf_numeric = true;
        string filename_txt = "";
        string filename_dat = "";
        string filename_bin = "";
        // string readfilename_txt;
        //save
        
            


        Dictionary<decimal, Student> list = new Dictionary<decimal,Student>();



        private void Save_Click(object sender, EventArgs e)
        {
           

                if (Surname.Text == "" || FName.Text == "" || Dadname.Text == "" || Course.Text == "" || Group.Text == "" || Faculty.Text == "")
                {
                    MessageBox.Show("Не заполнено одно или несколько обязательных полей.", "Ошибка сохранения");
                    return;
                }
                else
                {
                    list[numericUpDown1.Value] = new Student(FName.Text, Surname.Text, Dadname.Text, Course.Text, Faculty.Text, Group.Text, dateTimePicker1.Text);
                    //FileProcesses FP = new FileProcesses();
                    //FP.WriteToDat(list, FilePathText.Text);
                    //foreach (KeyValuePair<decimal, Student> student in list)
                    //{
                    //    FP.WriteToBin(student.Value,  FilePathText.Text); // обдумать что-куда сохранять

                    //}

                    if (list.Count != 0 && String.IsNullOrWhiteSpace(DirectoryPathText.Text))
                    {
                        if (FilePathText.Text != "") //если файл открыт на чтение и перезаписывается
                        {

                            string FileName = FilePathText.Text;
                            FileName = FileName.Substring(0, FileName.Length - 3);
                            FileProcesses FP = new FileProcesses();
                            //перезапись в .dat
                            FP.WriteToDat(list, FileName + "dat");

                            //перезапись в .bin
                            
                                FP.WriteToBin(list, FileName + "bin"); // обдумать что-куда сохранять
                            
                        }
                        else
                        {

                        }
                    }

                    else //когда выбрана дирректория для сохранения
                    {
                        filename_txt = DirectoryPathText.Text + "\\" + FileName.Text + ".txt";
                        filename_bin = DirectoryPathText.Text + "\\" + FileName.Text + ".bin";
                        filename_dat = DirectoryPathText.Text + "\\" + FileName.Text + ".dat";

                        FileProcesses FP = new FileProcesses();
                        //перезапись в .dat
                        FP.WriteToDat(list, filename_dat);

                        //перезапись в .bin
                        
                      
                            FP.WriteToBin(list, filename_bin); // обдумать что-куда сохранять
                        

                    }



                }

            numericUpDown1.Maximum = list.Count + 1;


        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryPathText.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //output


        //public string DictionaryDecode(Dictionary<decimal, string> dic)
        //{

        //    string[] sdic = dic[(int)numericUpDown1.Value].Split('/');
        //    try
        //    {
        //        string number = sdic[0];
        //        string surname = sdic[1];
        //        string name = sdic[2];
        //        string dadname = sdic[3];
        //        string date = sdic[4];
        //        string group = sdic[5];

        //        string s = "№" + number + "\nФИО: " + surname + " " + name + " " + dadname + "\nГруппа: " + group + "\nГод рождения: " + date;
        //        return s;
        //    }
        //    catch (IndexOutOfRangeException e)
        //    {
        //        return richTextBox1.Text = e.Message;
        //    }
        //}


        private void ClearForms()
        {
            Surname.Clear();
            FName.Clear();
            Dadname.Clear();
            dateTimePicker1.ResetText();
            Group.ResetText();
            Course.ResetText();
            Faculty.ResetText();
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            ClearForms();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            list.Remove(numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (tf_numeric == false)
            { if (numericUpDown1.Value > list.Count) numericUpDown1.Value = 1; }
            try
            {
               
                try
                {
                    Surname.Text = list[numericUpDown1.Value].surname;
                    FName.Text = list[numericUpDown1.Value].name;
                    Dadname.Text = list[numericUpDown1.Value].dadname;
                    dateTimePicker1.Text = list[numericUpDown1.Value].date;
                    Course.Text = list[numericUpDown1.Value].course;
                    Faculty.Text = list[numericUpDown1.Value].faculty;
                    Group.Text = list[numericUpDown1.Value].group;
                }
                catch (IndexOutOfRangeException)
                {
                    return;
                }
            }
            catch (KeyNotFoundException)
            {
                ClearForms();
            }
        }



        private void ScrollRec_Click(object sender, EventArgs e)
        {
            if (ScrollRec.BackColor == Color.Gray)
            {
                ScrollRec.BackColor = DefaultBackColor;
                numericUpDown1.Maximum = 100;
                tf_numeric = true;
            }
            else
            {
                ScrollRec.BackColor = Color.Gray;
                numericUpDown1.Maximum = list.Count + 1;
                if (numericUpDown1.Value == list.Count + 1) numericUpDown1.Value = list.Count;
                tf_numeric = false;

            }
        }

        private void Surname_Validated(object sender, EventArgs e)
        {

        }

        private void FName_Validated(object sender, EventArgs e)
        {

        }

        private void Dadname_Validated(object sender, EventArgs e)
        {
        }

        //отлов пустых текстбоксов
        private void EmptyField(TextBox field, ErrorProvider error)
        {
            if (field.Text == " ")
                error.SetError(field, "Заполните поле!");
            else
                error.SetError(field, string.Empty);
        }

        //СLOSING
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (list.Count != 0 && String.IsNullOrWhiteSpace(DirectoryPathText.Text))
            {
                if (FilePathText.Text != "") //если файл открыт на чтение и перезаписывается
                {

                    string FileName = FilePathText.Text;
                    FileName = FileName.Substring(0, FileName.Length - 3);

                    StreamWriter SW = new StreamWriter(FileName+".txt", false);
                    foreach (KeyValuePair<decimal, Student> student in list)
                    {
                       SW.WriteLine(student.Value.ToString());
                    }

                        SW.Close();

                }
                else
                {

                }
            }
            else //когда выбрана дирректория для сохранения
            {
                if (list.Count != 0)
                {
                    filename_txt = DirectoryPathText.Text + "\\" + FileName.Text + ".txt";
                    StreamWriter SW = new StreamWriter(filename_txt, false);
                    foreach (KeyValuePair<decimal, Student> student in list)
                    {
                        SW.WriteLine(student.Value.ToString());
                    }
                    SW.Close();
                }
                else
                {

                }
            }

            var result = MessageBox.Show("Хотите ли вы сохранить текущую конфигурацию?", "Опасность", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (list.Count != 0 && String.IsNullOrWhiteSpace(DirectoryPathText.Text))
                {
                    if (FilePathText.Text != "") //если файл открыт на чтение и перезаписывается
                    {

                        string FileName = FilePathText.Text;
                        FileName = FileName.Substring(0, FileName.Length - 3);

                        StreamWriter SW = new StreamWriter(FileName+"config.txt", false);

                        string s = Surname.Text + '/' + FName.Text + '/' + Dadname.Text + '/' + dateTimePicker1.Text + '/' + Faculty.Text + '/' + Course.Text + '/' + Group.Text;
                        char[] ch = { '/' };
                        string[] conf = s.Split(ch);
                        for (int i = 0; i < conf.Length; i++)
                            SW.WriteLine(conf[i]);
                        SW.Close();

                    }
                    else
                    {

                    }
                }

                else //когда выбрана дирректория для сохранения
                {
                    if (DirectoryPathText.Text != "")
                    {
                        filename_txt = DirectoryPathText.Text + "\\" + "config" + ".txt";
                        StreamWriter SW = new StreamWriter(filename_txt, false);
                        string s = Surname.Text + '/' + FName.Text + '/' + Dadname.Text + '/' + dateTimePicker1.Text + '/' + Faculty.Text + '/' + Course.Text + '/' + Group.Text;
                        char[] ch = { '/' };
                        string[] conf = s.Split(ch);
                        for (int i = 0; i < conf.Length; i++)
                            SW.WriteLine(conf[i]);
                        SW.Close();
                    }
                    else
                    {
                        StreamWriter SW = new StreamWriter(@"C:\Users\sv\Desktop\config.txt", false);
                        string s = Surname.Text + '/' + FName.Text + '/' + Dadname.Text + '/' + dateTimePicker1.Text + '/' + Faculty.Text + '/' + Course.Text + '/' + Group.Text;
                        char[] ch = { '/' };
                        string[] conf = s.Split(ch);
                        for (int i = 0; i < conf.Length; i++)
                            SW.WriteLine(conf[i]);
                        SW.Close();
                    }

                }



            }

            
          


          //File.Delete("D:\\myconf.txt");
            //if (list.Count != 0 && String.IsNullOrWhiteSpace(DirectoryPathText.Text))
            //{
            //    if (FilePathText.Text != null)
            //    {

            //        string FileName = FilePathText.Text;
            //        FileName = FileName.Substring(0, FileName.Length - 3);
            //        string str_for_dat = "";
            //        FileStream FS = new FileStream(FileName+"txt", FileMode.Create);
            //        using (StreamWriter SW = new StreamWriter(FS))
            //        {
            //            foreach (string val in list.Values)
            //            {
            //                SW.WriteLine(val.Substring(0, val.Length - 1));
            //                str_for_dat += val;
            //            }
            //            SW.Close();
            //        }

            //        byte[] byte_str = Encoding.Default.GetBytes(str_for_dat);

            //        try
            //        {

            //            FileStream FSs = new FileStream(FileName+"dat", FileMode.Create);
            //            FSs.Write(byte_str, 0, byte_str.Length);

            //        }
            //        catch { return; }

            //        try
            //        {
            //            FileStream FSs = new FileStream(FileName+"bin", FileMode.Create);
            //            using (BinaryWriter BW = new BinaryWriter(FSs))
            //            {
            //                BW.Write(byte_str);
            //            }
            //        }
            //        catch (Exception d)
            //        {
            //            richTextBox1.Text = d.ToString();
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        if (MessageBox.Show("Данные будут утеряны. Вы уверены, что все равно хотите выйти из программы?", "Не указан путь к каталогу", MessageBoxButtons.YesNo) == DialogResult.No)
            //        {
            //            e.Cancel = true;

            //        }
            //        else e.Cancel = false;
            //    }
            //}

            //else
            //{
            //    filename_txt = DirectoryPathText.Text + "\\" + FileName.Text + ".txt";
            //    filename_bin = DirectoryPathText.Text + "\\" + FileName.Text + ".bin";
            //    filename_dat = DirectoryPathText.Text + "\\" + FileName.Text + ".dat";
            //    string str_for_dat = "";
            //    try
            //    {
            //        FileStream FS = new FileStream(filename_txt, FileMode.Create);
            //        using (StreamWriter SW = new StreamWriter(FS))
            //        {
            //            foreach (string val in list.Values)
            //            {
            //                SW.WriteLine( val.Substring(0, val.Length-1));
            //                str_for_dat += val;
            //            }
            //            SW.Close();
            //        }
            //    }
            //    catch { return; }

            //    byte[] byte_str = Encoding.Default.GetBytes(str_for_dat);

            //    try
            //    {

            //        FileStream FS = new FileStream(filename_dat, FileMode.Create);
            //        FS.Write(byte_str, 0, byte_str.Length);

            //    }
            //    catch { return; }

            //    try
            //    {
            //        FileStream FS = new FileStream(filename_bin, FileMode.Create);
            //        using (BinaryWriter BW = new BinaryWriter(FS))
            //        {
            //            BW.Write(byte_str);
            //        }
            //    }
            //    catch (Exception d) { richTextBox1.Text = d.ToString();
            //        return;
            //    }
            //}
        }
        //DIRECTORYDIALOG
        private void DirectoryPath_btn_Click(object sender, EventArgs e)
        {
            
            if (DirectoryPathText.Enabled == false) { DirectoryPathText.Enabled = true; FileName.Enabled = true; FileName.Text = "exemple";
                FilePathText.Clear(); }
            FilePathText.Enabled = false;
            Reading_btn.Enabled = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryPathText.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }

        //FILEDIALOG
        private void FilePath_btn_Click(object sender, EventArgs e)
        {
            if (FilePathText.Enabled == false) { FilePathText.Enabled = true; Reading_btn.Enabled = true; DirectoryPathText.Clear(); }
            DirectoryPathText.Enabled = false; FileName.Clear();
            FileName.Enabled = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePathText.Text = openFileDialog1.FileName;
            }
        }

        //READING
        byte[] readingData = new byte[100];
        private void Reading_btn_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(FilePathText.Text) == ".dat" || Path.GetExtension(FilePathText.Text) == ".bin")
            {
                if (Path.GetExtension(FilePathText.Text) == ".dat")
                {
                    FileProcesses FP = new FileProcesses();
                    list = new Dictionary<decimal, Student>();
                    list = FP.ReadFromDat(FilePathText.Text);
                }

                if (Path.GetExtension(FilePathText.Text) == ".bin")
                {
                    FileProcesses FP = new FileProcesses();
                    list = new Dictionary<decimal, Student>();
                    list = FP.ReadFromBin(FilePathText.Text);

                }
            }
            else
            {
                MessageBox.Show("Неподдерживаемый формат.", "Невозможно прочитать файл", MessageBoxButtons.OK);
            }
            numericUpDown1.Maximum = list.Count + 1;



            //if (FilePathText.Text != "")
            //{
            //    list = new Dictionary<decimal, string>(); ;
            //    string s;
            //    // readfilename_txt = FilePathText.Text;

            //    if (Path.GetExtension(@FilePathText.Text) == ".txt")
            //    {
            //        FileStream FS = new FileStream(FilePathText.Text, FileMode.Open);
            //        using (StreamReader SR = new StreamReader(FS))
            //        {
            //            int i = 1;
            //            while ((s = SR.ReadLine()) != null)
            //            {
            //                list.Add((decimal)i++, s + "\n");
            //                richTextBox1.Text += s;
            //            }
            //            SR.Close();
            //        }
            //    }

            //    if (Path.GetExtension(@FilePathText.Text) == ".dat")
            //    {
            //        FileStream FS = new FileStream(FilePathText.Text, FileMode.Open);

            //        FS.Read(readingData, 0, readingData.Length);
            //        string str = Encoding.Default.GetString(readingData);
            //        string[] arraystring = str.Split('\n');
            //        richTextBox1.Text = str;
            //        int i = 1;
            //        foreach (string strin in arraystring)
            //        {
            //            list.Add((decimal)i++, strin);
            //        }
            //        FS.Close();

            //    }

            //    if (Path.GetExtension(@FilePathText.Text) == ".bin")
            //    {
            //        FileStream FS = new FileStream(FilePathText.Text, FileMode.Open);

            //        BinaryReader BR = new BinaryReader(FS);
            //        BR.Read(readingData, 0, readingData.Length);
            //        BR.Close();
            //        string str = Encoding.Default.GetString(readingData);
            //        string[] arraystring = str.Split('\n');
            //        richTextBox1.Text = str;
            //        int i = 1;
            //        foreach (string strin in arraystring)
            //        {
            //            list.Add((decimal)i++, strin);
            //        }
            //        FS.Close();

            //    }
                /////////БООООМС
                //////if (Path.GetExtension(@FilePathText.Text) == ".bin")
                //////{
                //////    FileStream FS = new FileStream(FilePathText.Text, FileMode.Open);

                //////    FS.Read(readingData, 0, readingData.Length);
                //////    string str = Encoding.Default.GetString(readingData);
                //////    string[] arraystring = str.Split('\n');
                //////    richTextBox1.Text = str;
                //////    int i = 1;
                //////    foreach (string strin in arraystring)
                //////    {
                //////        list.Add((decimal)i++, strin);
                //////    }


                //////    FS.Close();

                //////}



                ////// this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
                numericUpDown1.Minimum = 0;
                numericUpDown1.Value = 0;
                numericUpDown1.Value = 1;
                numericUpDown1.Minimum = 1;
            }

        
       

        private void FilePathText_TextChanged(object sender, EventArgs e)
        {
            Save.Enabled = DirectoryPathText.Text.Length != 0 || FilePathText.Text.Length != 0;
            if (FilePathText.Text.Length != 0) DirectoryPathText.Enabled = false;
            else { DirectoryPathText.Enabled = true; }
        }

        private void Dadname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Readin_btn_Load(object sender, EventArgs e)
        {
            
                Save.Enabled = false;
           
        }

        private void DirectoryPathText_TextChanged(object sender, EventArgs e)
        {
            Save.Enabled = FilePathText.Text.Length != 0 || DirectoryPathText.Text.Length != 0;
            if (DirectoryPathText.Text.Length != 0) FilePathText.Enabled = false;
            else { FilePathText.Enabled = true; }
        }
    }
    }
