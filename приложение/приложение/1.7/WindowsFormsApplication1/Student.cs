using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Student
    {
        public Student(string LASTNAME, string NAME, string DADNAME, string BIRTH, int COURSE, string FACULT, int GROUP)
        {
            lastname = LASTNAME;
            name = NAME;
            dadname = DADNAME;
            birth = BIRTH;
            course = COURSE;
            facult = FACULT;
            group = GROUP;
            dlina = lastname.Length + name.Length + dadname.Length + birth.Length + facult.Length + 32;
        }
        public string passport()
        {
            return lastname + "/" + name + "/" + dadname + "/" + birth + "/" + course.ToString() + "/" + facult + "/" + group.ToString();
        }
        public int GetDlina()
        {
            return dlina;
        }
        public string GetLastName()
        {
            return lastname;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDadName()
        {
            return dadname;
        }
        public string GetBirth()
        {
            return birth;
        }
        public int GetCourse()
        {
            return course;
        }
        public string GetFacult()
        {
            return facult;
        }
        public int GetGroup()
        {
            return group;
        }
        int dlina;
        string lastname;
        string name;
        string dadname;
        string birth;
        int course;
        string facult;
        int group;
    }
}
