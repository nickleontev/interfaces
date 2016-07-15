using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public class dat
    {
        public void write (Student what, string where)
        {
            byte[] dlina = BitConverter.GetBytes(what.GetDlina());
            byte[] lastname = Encoding.Default.GetBytes(what.GetLastName().ToCharArray());
            byte[] lastname_length = BitConverter.GetBytes(lastname.Length);
            byte[] name = Encoding.Default.GetBytes(what.GetName().ToCharArray());
            byte[] name_length = BitConverter.GetBytes(name.Length);
            byte[] dadname = Encoding.Default.GetBytes(what.GetDadName().ToCharArray());
            byte[] dadname_length = BitConverter.GetBytes(dadname.Length);
            byte[] birth = Encoding.Default.GetBytes(what.GetBirth().ToCharArray());
            byte[] birth_length = BitConverter.GetBytes(birth.Length);
            byte[] course = BitConverter.GetBytes(what.GetCourse());
            byte[] facult = Encoding.Default.GetBytes(what.GetFacult().ToCharArray());
            byte[] facult_length = BitConverter.GetBytes(facult.Length);
            byte[] group = BitConverter.GetBytes(what.GetGroup());
            FileStream dw = new FileStream(where, FileMode.Append);
            dw.Write(dlina, 0, dlina.Length);
            dw.Write(lastname_length, 0, lastname_length.Length);
            dw.Write(lastname, 0, lastname.Length);
            dw.Write(name_length, 0,name_length.Length);
            dw.Write(name, 0, name.Length);
            dw.Write(dadname_length, 0, dadname_length.Length);
            dw.Write(dadname, 0, dadname.Length);
            dw.Write(birth_length, 0, birth_length.Length);
            dw.Write(birth, 0, birth.Length);
            dw.Write(course, 0, course.Length);
            dw.Write(facult_length, 0, facult_length.Length);
            dw.Write(facult, 0, facult.Length);
            dw.Write(group, 0, group.Length);
            dw.Close();
        }
        public void rewrite(List<Student> list, string where)
        {
            FileStream fs = new FileStream(where, FileMode.Create);
            fs.Close();
            dat d = new dat();
            for (int i = 0; i < list.Count; i++)
                d.write(list[i], where);
        }
        public List<Student> read(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            List<Student> stud = new List<Student>();
            byte[] byte_int = new byte[4];
            byte[] byte_char;
            int i = 0;
                int n = 1;
                while (n != 0)
                {
                    n = fs.Read(byte_int, 0, 4);
                    if (n == 0) break;
                    int dlina = BitConverter.ToInt32(byte_int, 0);
                    fs.Read(byte_int, 0, 4);
                    int lastname_length = BitConverter.ToInt32(byte_int, 0);
                    byte_char = new byte[lastname_length];
                    fs.Read(byte_char, 0, lastname_length);
                    char[] lastname = Encoding.Default.GetChars(byte_char);
                    /////
                    fs.Read(byte_int, 0, 4);
                    int name_length = BitConverter.ToInt32(byte_int, 0);
                    byte_char = new byte[name_length];
                    fs.Read(byte_char, 0, byte_char.Length);
                    char[] name = Encoding.Default.GetChars(byte_char);
                    /////
                    fs.Read(byte_int, 0, 4);
                    int dadname_length = BitConverter.ToInt32(byte_int, 0);
                    byte_char = new byte[dadname_length];
                    fs.Read(byte_char, 0, byte_char.Length);
                    char[] dadname = Encoding.Default.GetChars(byte_char);
                    /////
                    fs.Read(byte_int, 0, 4);
                    int birth_length = BitConverter.ToInt32(byte_int, 0);
                    byte_char = new byte[birth_length];
                    fs.Read(byte_char, 0, byte_char.Length);
                    char[] birth = Encoding.Default.GetChars(byte_char);
                    /////
                    fs.Read(byte_int, 0, 4);
                    int course = BitConverter.ToInt32(byte_int, 0);
                    //////
                    fs.Read(byte_int, 0, 4);
                    int facult_length = BitConverter.ToInt32(byte_int, 0);
                    byte_char = new byte[facult_length];
                    fs.Read(byte_char, 0, byte_char.Length);
                    char[] facult = Encoding.Default.GetChars(byte_char);
                    //////
                    fs.Read(byte_int, 0, 4);
                    int group = BitConverter.ToInt32(byte_int, 0);
                ///////
                string lastname_str = new string(lastname);
                string name_str = new string(name);
                string dadname_str = new string(dadname);
                string birth_str = new string(birth);
                string facult_str = new string(facult);
                //////
                stud.Add(new Student(lastname_str, name_str, dadname_str, birth_str, course, facult_str, group));
                ////
                i++;
                }
            fs.Close();
            return stud;
        }

    }
}
