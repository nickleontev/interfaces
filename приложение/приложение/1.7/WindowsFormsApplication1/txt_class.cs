using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class txt_class
    {
        public void write(List<Student> what, string where)
        {
            StreamWriter tw = new StreamWriter(where, false);
            for (int i = 0; i < what.Count; i++)
            {
                tw.WriteLine(what[i].passport());
            }
            tw.Close();
        }
        public List<Student> read(string from)
        {
            StreamReader tr = new StreamReader(from);
            List<Student> list = new List<Student>();
            int k;
            string stroka;
            while (true)
            {
                string lastname = null;
                string name = null;
                string dadname = null;
                string birth = null;
                string course = null;
                string facult = null;
                string group = null;

                k = 0;
                stroka = tr.ReadLine();
                if (stroka == null) break;
                while (stroka[k] != '/')
                {
                    lastname += stroka[k];
                    k++;
                }
                k++;
                while (stroka[k] != '/')
                {
                    name += stroka[k];
                    k++;
                }
                k++;
                while (stroka[k] != '/')
                {
                    dadname += stroka[k];
                    k++;
                }
                k++;
                while (stroka[k] != '/')
                {
                    birth += stroka[k];
                    k++;
                }
                k++;
                while (stroka[k] != '/')
                {
                    course += stroka[k];
                    k++;
                }
                k++;
                while (stroka[k] != '/')
                {
                    facult += stroka[k];
                    k++;
                }
                k++;
                while (k < stroka.Length)
                {
                    group += stroka[k];
                    k++;
                }
                Student stud = new Student(lastname, name, dadname, birth, Convert.ToInt32(course), facult, Convert.ToInt32(group));
                list.Add(stud);
            }
            tr.Close();
            return list;
        }
    }
}
