using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem1lab
{
    [Serializable]
    public class Student
    {
        public string name;
        public string surname;
        public string dadname;
        public string course;
        public string faculty;
        public string group;
        public string date;

        public Student(string name, string surname, string dadname, string course, string faculty, string group, string date)
        {
            this.name = name;
            this.surname = surname;
            this.dadname = dadname;
            this.course = course;
            this.faculty = faculty;
            this.group = group;
            this.date = date;// метод IsDate
        }
        public override string ToString()
        {

            string s = "Имя: " + this.name + "\nФамилия: "+this.surname+"\nОтчество: "+this.dadname+"\nГруппа: "+this.course+"-"+this.faculty+"-"+this.group+"\nДата рождения: "+ this.date;
            return s;
        }
    }
}
