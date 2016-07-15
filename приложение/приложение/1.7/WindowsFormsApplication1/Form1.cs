using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public void txtfilldict()
        {
            StreamReader read = new StreamReader(openFileDialog_txt.FileName);
            string stroka;
            int i = 0;
            while (true)
            {
                stroka = read.ReadLine();
                if (stroka == null) break;
                else binlist.Add(stroka.ToCharArray());
                i++; 
            }
            read.Close();
        }
        public void txtwrite()
        {
            StreamWriter mywriter = new StreamWriter(textbox_txt_path.Text, false);
            {
                for (int i = 0; i < binlist.Count;i++)
                    mywriter.WriteLine(binlist[i]);
                mywriter.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void show_but(object sender, EventArgs e)
        {
            show(ref list, (int)show_num.Value - 1);
            num.Value = show_num.Value;
        }

        //СЧИТЫВАЕМ ИЗ .bin
        //richTextBox1.ResetText();
        //BinaryReader br = new BinaryReader(File.OpenRead(saveFileDialog_bin.FileName));
        //try
        //{
        //    while (true)
        //    {
        //        string s = br.ReadString() + "\n";
        //        richTextBox1.Text += s;
        //    }
        //}
        //catch (EndOfStreamException)
        //{ }
        //br.Dispose();
        //br.Close();



        //binfilldict();

        //try
        //{
        //    richTextBox1.Text = list[(int)num.Value];
        //}
        //catch (KeyNotFoundException)
        //{
        //    richTextBox1.Text = "Заданная ячейка пуста";
        //    return; 
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("D:\\myconf.txt"))
            {
                StreamReader confread = new StreamReader(File.OpenRead("D:\\myconf.txt"));
                textbox_lastname.Text = confread.ReadLine();
                textbox_name.Text = confread.ReadLine();
                textbox_dadname.Text = confread.ReadLine();
                dateTimePicker1.Text = confread.ReadLine();
                combobox_curse.Text = confread.ReadLine();
                combobox_faculty.Text = confread.ReadLine();
                combobox_group.Text = confread.ReadLine();
                confread.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txtbrowse_Click(object sender, EventArgs e) //button txt browse
        {
            if (openFileDialog_txt.ShowDialog() == DialogResult.OK)
            {
                FileInfo myfile = new FileInfo(openFileDialog_txt.FileName);
                FileStream str = new FileStream(openFileDialog_txt.FileName, FileMode.OpenOrCreate);
                if (myfile.Exists == true) txtradio.Enabled = true;
                str.Close();
                textbox_txt_path.Text = openFileDialog_txt.FileName;
            }
        }
        
        private void savebutton_Click(object sender, EventArgs e)
        {
            // try
            {
                //[num.Value] = num.Value + ". " + textbox_lastname.Text + "/" + textbox_name.Text + "/" + textbox_dadname.Text + "/" + dateTimePicker1.Text + "/" + combobox_curse.Text + "/" + combobox_faculty.Text + "/" + combobox_group.Text;
            }
            //catch (ArgumentException)
            //{
            //    list[num.Value] = textbox_lastname.Text + "/" + textbox_name.Text + "/" + textbox_dadname.Text + "/" + dateTimePicker1.Text + "/" + combobox_curse.Text + "/" + combobox_faculty.Text + "/" + combobox_group.Text;

            //    return;
            //}
            binwrite();
            txtwrite();
            datwrite();
            num.Value++;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void clear()
        {
            textbox_dadname.Clear();
            textbox_name.Clear();
            textbox_lastname.Clear();
            dateTimePicker1.ResetText();
            combobox_curse.Text = "Курс";
            combobox_faculty.Text= "Факультет";
            combobox_group.Text="Группа";
        } 
        private void clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void curse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Хотите ли вы сохранить текущую конфигурацию?", "Опасность", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (saveFileDialog_cnf.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter my = new StreamWriter(saveFileDialog_cnf.FileName, false);
                    string sss = textbox_lastname.Text + '/' + textbox_name.Text + '/' + textbox_dadname.Text + '/' + dateTimePicker1.Text + '/' + combobox_curse.Text + '/' + combobox_faculty.Text + '/' + combobox_group.Text;
                    char[] ch = { '/' };
                    string[] conf = sss.Split(ch);
                    for (int i = 0; i < conf.Length; i++) my.WriteLine(conf[i]);
                    my.Close();
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
         void delete (ref List<Student> list) // если поставлю здесь public, то появится ошибка! Почему?
        {
            if (num.Value == num.Maximum) MessageBox.Show("Ты что хочешь-то, я не понимаю?!");
            else
            {
                list.RemoveAt((int)num.Value - 1);
                num.Maximum--;
                bin b = new bin();
                b.rewrite(list, openFileDialog_bin.FileName);
            }
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            delete(ref list);
            show_num.Maximum--;
            show(ref list, (int)num.Value - 1);
        }
        void show(ref List<Student> stud, int index)
        {
            try
            {
                textbox_lastname.Text = stud[index].GetLastName();
                textbox_name.Text = stud[index].GetName();
                textbox_dadname.Text = stud[index].GetDadName();
                dateTimePicker1.Text = stud[index].GetBirth();
                combobox_curse.Text = stud[index].GetCourse().ToString();
                combobox_faculty.Text = stud[index].GetFacult();
                combobox_group.Text = stud[index].GetGroup().ToString();
            }
            catch { clear(); }
        }
        public void button2_Click(object sender, EventArgs e)  //кнопка bin browse
        {
            if (openFileDialog_bin.ShowDialog() == DialogResult.OK)
            {
                textbox_bin_path.Text = openFileDialog_bin.FileName;
                FileInfo myfile = new FileInfo(openFileDialog_bin.FileName);
                if (myfile.Exists) binradio.Enabled = true;
                FileStream ff = myfile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                ff.Close();ff.Dispose();
                binfill(ref list);
                num.Maximum = list.Count+1;
                show_num.Maximum = list.Count + 1;
                if (list.Count != 0) show(ref list, 0);
            }

        }
        BinaryWriter bw;
        SortedDictionary<decimal, long> strokeLength = new SortedDictionary<decimal, long>();
        string[] strmas = new string[8];
        List<string[]> mas = new List<string[]>();
        List<char[]> binlist = new List<char[]>();
        public void rebinwrite()
        {
            FileStream fi = new FileStream(openFileDialog_bin.FileName, FileMode.Create, FileAccess.Write);

            bw = new BinaryWriter
                              (fi, Encoding.Default);
            bw.BaseStream.Position = 0;
            //foreach (char[] vals in binlist.Values)
            //{
            //    bw.Write(vals.Length);
            //    bw.Write(vals);
            //}
            for (int i = 0; i < binlist.Count; i++)
            {
                {
                    bw.Write(binlist[i].Length);
                    bw.Write(binlist[i]);
                }
            }
            bw.Close();
            fi.Close();
        }
        public void binwrite()
        {
            //int i = 0;
            char[] ArrLastname;
            char[] ArrName;
            char[] ArrDadname;
            char[] Arrfacult;
            char[] ArrBirth;
            string Lastname;
            string Name;
            string Dadname;
            string facult;
            string Birth;
           // string Fullstroke;
            int course;
            int group;
            int mark;
            int dlina;
            FileStream fi = new FileStream(openFileDialog_bin.FileName, FileMode.Append,FileAccess.Write);
            
           bw = new BinaryWriter
                             (fi, Encoding.Default);

            Lastname = textbox_lastname.Text;
            Name = textbox_name.Text;
            Dadname = textbox_dadname.Text;
            Birth = dateTimePicker1.Text;
            facult = combobox_faculty.Text;
            group = Convert.ToInt32(combobox_group.Text);
            course = Convert.ToInt32(combobox_curse.Text);
            mark = (int)numeric_mark.Value;
            ArrLastname = Lastname.ToCharArray();
            ArrName = Name.ToCharArray();
            ArrDadname = Dadname.ToCharArray();
            Arrfacult = facult.ToCharArray();
            ArrBirth = Birth.ToCharArray();
            dlina = Lastname.Length + Name.Length + Dadname.Length + Birth.Length + facult.Length + 4 + 4 + 4 + 20;
            //string[] strmas = new string[8];
            //if (mas.Count >= num.Value)
            //{
            //    mas[0][new]
            //    mas[(int)num.Value][0] = Convert.ToString(dlina);
            //    mas[(int)num.Value][1] = Lastname;
            //    mas[(int)num.Value][2] = Name;
            //    mas[(int)num.Value][3] = Dadname;
            //    mas[(int)num.Value][4] = Birth;
            //    mas[(int)num.Value][5] = Convert.ToString(course);
            //    mas[(int)num.Value][6] = facult;
            //    mas[(int)num.Value][7] = Convert.ToString(group);
            //}
            //else
            //{
            //    mas[(int)num.Value].Add(;
            //}
            bw.Write(dlina);
            bw.Write(ArrLastname.Length);
            bw.Write(ArrLastname);
            bw.Write(ArrName.Length);
            bw.Write(ArrName);
            bw.Write(ArrDadname.Length);
            bw.Write(ArrDadname);
            bw.Write(ArrBirth.Length);
            bw.Write(ArrBirth);
            bw.Write(course);
            bw.Write(Arrfacult.Length);
            bw.Write(Arrfacult);
            bw.Write(group);
            bw.Close();
        }
        
         void binfill(ref List<Student> list)
        {
            bin b = new bin();
            list = b.read(openFileDialog_bin.FileName);
        }
        public void binread()
        {
            BinaryReader br = new BinaryReader(
                    File.Open(openFileDialog_bin.FileName, FileMode.Open), Encoding.Default);
            br.BaseStream.Position = 0;
            int k;
                for (decimal i = 1; i < num.Value; i++)
                {
                    k = br.ReadInt32();
                    br.BaseStream.Seek(k - 4, SeekOrigin.Current);
                }
            k = br.ReadInt32();
            string str = new string(br.ReadChars(br.ReadInt32()));
            textbox_lastname.Text = str;
            str = new string(br.ReadChars(br.ReadInt32()));
            textbox_name.Text = str;
            str = new string(br.ReadChars(br.ReadInt32()));
            textbox_dadname.Text = str;
            str = new string(br.ReadChars(br.ReadInt32()));
            dateTimePicker1.Text = str;
            combobox_curse.Text = Convert.ToString(br.ReadInt32());
            combobox_faculty.Text = new string(br.ReadChars(br.ReadInt32()));
            combobox_group.Text = Convert.ToString(br.ReadInt32());
            br.Close();
        }

        class bin
        {
            public void write(Student what, string where)
            {
                FileStream fi = new FileStream(where, FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter
                                  (fi, Encoding.Default);
                int dlina = what.GetDlina();
                char[] lastname = what.GetLastName().ToCharArray();
                char[] name = what.GetName().ToCharArray();
                char[] dadname = what.GetDadName().ToCharArray();
                char[] birth = what.GetBirth().ToCharArray();
                int course = what.GetCourse();
                char[] facult = what.GetFacult().ToCharArray();
                int group = what.GetGroup();

                bw.Write(dlina);
                bw.Write(lastname.Length);
                bw.Write(lastname);
                bw.Write(name.Length);
                bw.Write(name);
                bw.Write(dadname.Length);
                bw.Write(dadname);
                bw.Write(birth.Length);
                bw.Write(birth);
                bw.Write(course);
                bw.Write(facult.Length);
                bw.Write(facult);
                bw.Write(group);
                bw.Close();fi.Close();
            }
            public void rewrite(List<Student> list, string where)
            {
                FileStream fs = new FileStream(where, FileMode.Create);
                fs.Close();
                bin b = new bin();
                for (int i = 0; i < list.Count; i++)
                    b.write(list[i], where);
            }
            public Student read(string path, int position)
            {
                BinaryReader br = new BinaryReader(
                        File.Open(path, FileMode.Open), Encoding.Default);
                br.BaseStream.Position = 0;
                int k;
                for (decimal i = 1; i < position; i++)
                {
                    k = br.ReadInt32();
                    br.BaseStream.Seek(k - 4, SeekOrigin.Current);
                }
                int dlina = br.ReadInt32();
                string lastname = new string(br.ReadChars(br.ReadInt32()));
                string name = new string(br.ReadChars(br.ReadInt32()));
                string dadname = new string(br.ReadChars(br.ReadInt32()));
                string birth = new string(br.ReadChars(br.ReadInt32()));
                int course = br.ReadInt32();
                string facult = new string(br.ReadChars(br.ReadInt32()));
                int group = br.ReadInt32();
                br.Close();
                return new Student(lastname, name, dadname, birth, course, facult, group);
            }
            public List<Student> read (string path)
            {
                BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open), Encoding.Default);
                List<Student> stud = new List<Student>();
                try
                {
                    while (true)
                    {
                        int dlina = br.ReadInt32();
                        string lastname = new string(br.ReadChars(br.ReadInt32()));
                        string name = new string(br.ReadChars(br.ReadInt32()));
                        string dadname = new string(br.ReadChars(br.ReadInt32()));
                        string birth = new string(br.ReadChars(br.ReadInt32()));
                        int course = br.ReadInt32();
                        string facult = new string(br.ReadChars(br.ReadInt32()));
                        int group = br.ReadInt32();
                        stud.Add(new Student(lastname, name, dadname, birth, course, facult, group));
                    }
                }
                catch (EndOfStreamException)
                {
                    br.Close();
                    return stud;
                }
            }

        }

        private void txtradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            txt_class t = new txt_class();
            bin b = new bin();
            dat d = new dat();
            if (binradio.Checked)
            {
                list = b.read(openFileDialog_bin.FileName);
                show(ref list, 0);
                t.write(list, openFileDialog_txt.FileName);
                d.rewrite(list, openFileDialog_dat.FileName);
            }
            else if (datradio.Checked)
            {
                list = d.read(openFileDialog_dat.FileName);
                show(ref list, 0);
                t.write(list, openFileDialog_txt.FileName);
                b.rewrite(list, openFileDialog_bin.FileName);
            }
            else
            {
                list = t.read(openFileDialog_txt.FileName);
                show(ref list, 0);
                b.rewrite(list, openFileDialog_bin.FileName);
                d.rewrite(list, openFileDialog_dat.FileName);
            }
        }

        private void cnf_button_Click(object sender, EventArgs e)
        {

        }

        private void but_datbrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog_dat.ShowDialog() == DialogResult.OK)
            {
                textbox_dat_path.Text = openFileDialog_dat.FileName;
                FileInfo myfile = new FileInfo(openFileDialog_dat.FileName);
                if (myfile.Exists) datradio.Enabled = true;
                FileStream ff = myfile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                ff.Close();
            }
        }

        public void datwrite()
        {
            FileStream dat = new FileStream(openFileDialog_dat.FileName, FileMode.Create);
            for (int i = 0; i < binlist.Count; i++)
            {
                byte[] arr = Encoding.Default.GetBytes(binlist[i]);
                byte[] bytelength = BitConverter.GetBytes(binlist[i].Length);
                dat.Write(bytelength, 0, bytelength.Length);
                dat.Write(arr, 0, arr.Length);
            }
            dat.Close();
        }
        public void datfilldict()
        {
            FileStream dat = new FileStream(openFileDialog_dat.FileName, FileMode.Open);
            int n = 1;
            while (n != 0)
            { 
                byte[] bytelength = new byte[4];
                n = dat.Read(bytelength, 0, 4);
                if (n == 0) break;
                int lng = BitConverter.ToInt32(bytelength, 0);
                byte[] arr = new byte[lng];
                dat.Read(arr, 0, lng);
                char[] ch = Encoding.Default.GetChars(arr);
                binlist.Add(ch);
            }
        }
        public List<Student> list = new List<Student>();
        public int status()
        {
            if (textbox_dadname.Text == "" && textbox_name.Text == "" && textbox_lastname.Text == "" && combobox_curse.Text == "Курс" && combobox_faculty.Text == "Факультет" && combobox_group.Text == "Группа") return 0;
            if (textbox_dadname.Text != "" && textbox_name.Text != "" && textbox_lastname.Text != "" && combobox_curse.Text != "Курс" && combobox_faculty.Text != "Факультет" && combobox_group.Text != "Группа") return 2;
            else return 1;
        }
        private void button_right_Click(object sender, EventArgs e)
        {
            int k = status();
            if (k == 0 && num.Value == num.Maximum)
            {
                num.Value = 1;
                show(ref list, 0);
            }
            if (k == 2)
            {
                fill(ref list, (int)num.Value);
                num.Maximum = list.Count + 1;
                show_num.Maximum = list.Count + 1;
                num.Value++;
                show(ref list, (int)num.Value - 1);
            }
            if (k == 1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
            }
        }
        void fill(ref List<Student> list, int num)
        {
            Student stud = new Student(textbox_lastname.Text, textbox_name.Text, textbox_dadname.Text, dateTimePicker1.Text, Convert.ToInt32(combobox_curse.Text), combobox_faculty.Text, Convert.ToInt32(combobox_group.Text));
            bin b = new bin();
            dat d = new dat();
            txt_class t = new txt_class();
            try
            {
                list[num - 1] = stud;
            }
            catch (ArgumentOutOfRangeException)
            {
                list.Add(stud);
            }
            b.rewrite(list, openFileDialog_bin.FileName);
            t.write(list, openFileDialog_txt.FileName);
            d.rewrite(list, openFileDialog_dat.FileName);
        }
        private void button_left_Click(object sender, EventArgs e)
        {
            int k = status();

            if (textbox_txt_path.Text != openFileDialog_txt.FileName || textbox_dat_path.Text != openFileDialog_dat.FileName || textbox_bin_path.Text != openFileDialog_bin.FileName) MessageBox.Show("Пожалуйста, выберите все три файла");

            if (num.Value == num.Minimum)
            {
                if (k == 2)
                {
                    fill(ref list, (int)num.Value);
                    num.Value = list.Count + 1;
                    show(ref list, list.Count + 1);
                }
                if (k == 1)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                }
            }
            else
            {
                if (k == 0)
                {
                    num.Value--;
                    show(ref list, (int)num.Value - 1);
                }
                if (k == 2)
                {
                    fill(ref list, (int)num.Value);
                    num.Value--;
                    show(ref list, (int)num.Value - 1);
                }
                if (k == 1)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                }
            }
        }
    }
}