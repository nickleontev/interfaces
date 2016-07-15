using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2sem1lab
{
    class FileProcesses
    {
        public void WriteToBin(Dictionary<decimal,Student> list, string FilePath)// переписать через рефлексию
                                                                //или спросить у Забержинскаго
        {
            FileStream FS = new FileStream(FilePath, FileMode.Create, FileAccess.Write);

            BinaryWriter BW = new BinaryWriter(FS, Encoding.Default);
            foreach (KeyValuePair<decimal, Student> student in list)
            {
                // обдумать что-куда сохранять

                //FieldInfo[] a =  student.GetType().GetFields();


                int dlina = student.Value.surname.Length + 4 + student.Value.name.Length + 4 + student.Value.dadname.Length + 4 + student.Value.course.Length + 4 + student.Value.faculty.Length + 4 + student.Value.group.Length + 4 + student.Value.date.Length + 20;
                BW.Write(dlina);
                //фамилия
                BW.Write(student.Value.surname.ToCharArray().Length);
                BW.Write(student.Value.surname.ToCharArray());



                //имя
                BW.Write(student.Value.name.ToCharArray().Length);
                BW.Write(student.Value.name.ToCharArray());


                //отчество
                BW.Write(student.Value.dadname.ToCharArray().Length);
                BW.Write(student.Value.dadname.ToCharArray());


                //курс
                BW.Write(student.Value.course.ToCharArray().Length);
                BW.Write(student.Value.course.ToCharArray());

                //факультет
                BW.Write(student.Value.faculty.ToCharArray().Length);
                BW.Write(student.Value.faculty.ToCharArray());

                //группа
                BW.Write(student.Value.group.ToCharArray().Length);
                BW.Write(student.Value.group.ToCharArray());

                //дата рождения
                BW.Write(student.Value.date.ToCharArray().Length);
                BW.Write(student.Value.date.ToCharArray());

            }
            //закрываем поток
            BW.Close();
            FS.Close();

        }

        public void WriteToDat(Dictionary<decimal, Student> list, string FilePath)
        {
            //BinaryFormatter BF = new BinaryFormatter();

            //using (Stream fStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    BF.Serialize(fStream, obj);
            //}
            FileStream FS = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            foreach (KeyValuePair<decimal, Student> student in list)
            {
                
                byte[] Name;
                byte[] NameLength;

                byte[] Surname;
                byte[] SurnameLength;

                byte[] Dadname;
                byte[] DadnameLength;

                byte[] Course;
                byte[] CourseLength;

                byte[] Faculty;
                byte[] FacultyLength;

                byte[] Group;
                byte[] GroupLength;

                byte[] Date;
                byte[] DateLength;

                int ByteCount;
                byte[] ArrByteCount;

                //имя
                Name = Encoding.Default.GetBytes(student.Value.name.ToCharArray());
                NameLength = BitConverter.GetBytes(Name.Length);
                //фамилия
                Surname = Encoding.Default.GetBytes(student.Value.surname.ToCharArray());
                SurnameLength = BitConverter.GetBytes(Surname.Length);
                //отчество
                Dadname = Encoding.Default.GetBytes(student.Value.dadname.ToCharArray());
                DadnameLength = BitConverter.GetBytes(Dadname.Length);
                //курс
                Course = Encoding.Default.GetBytes(student.Value.course.ToCharArray());
                CourseLength = BitConverter.GetBytes(Course.Length);
                //факультет
                Faculty = Encoding.Default.GetBytes(student.Value.faculty.ToCharArray());
                FacultyLength = BitConverter.GetBytes(Faculty.Length);
                //группа
                Group = Encoding.Default.GetBytes(student.Value.group.ToCharArray());
                GroupLength = BitConverter.GetBytes(Group.Length);
                //дата
                Date = Encoding.Default.GetBytes(student.Value.date.ToCharArray());
                DateLength = BitConverter.GetBytes(Date.Length);

                //длина
                ByteCount = Name.Length + Surname.Length + Dadname.Length + Course.Length + Faculty.Length + Group.Length + Date.Length + 7 * 4;
                ArrByteCount = BitConverter.GetBytes(ByteCount);

                //ЗАПИСЬ

                FS.Write(ArrByteCount, 0, ArrByteCount.Length);
                //имя
                FS.Write(NameLength,0,NameLength.Length);
                FS.Write(Name, 0, Name.Length);
                
                //фамилия
                FS.Write(SurnameLength, 0, SurnameLength.Length);
                FS.Write(Surname, 0, Surname.Length);
                
                //отчество
                FS.Write(DadnameLength, 0, DadnameLength.Length);
                FS.Write(Dadname, 0, Dadname.Length);
               
                //курс
                FS.Write(CourseLength, 0, CourseLength.Length);
                FS.Write(Course, 0, Course.Length);
               
                //факультет
                FS.Write(FacultyLength, 0, FacultyLength.Length);
                FS.Write(Faculty, 0, Faculty.Length);
                
                //группа
                FS.Write(GroupLength, 0, GroupLength.Length);
                FS.Write(Group, 0, Group.Length);
                
                //дата
                FS.Write(DateLength, 0, DateLength.Length);
                FS.Write(Date, 0, Date.Length);

             
            }
            FS.Close();
        }

        public Dictionary<decimal, Student> ReadFromBin(string Path)
        {
            BinaryReader br = new BinaryReader(File.Open(Path, FileMode.Open), Encoding.Default);
            Dictionary<decimal, Student> list = new Dictionary<decimal, Student>();
            try
            {
                decimal i = 1;
                while (true)
                {
                    try
                    {

                        int dlina = br.ReadInt32();
                        string name = new string(br.ReadChars(br.ReadInt32()));

                        string surname = new string(br.ReadChars(br.ReadInt32()));
                        string dadname = new string(br.ReadChars(br.ReadInt32()));
                        string course = new string(br.ReadChars(br.ReadInt32()));
                        string faculty = new string(br.ReadChars(br.ReadInt32()));
                        string group = new string(br.ReadChars(br.ReadInt32()));
                        string date = new string(br.ReadChars(br.ReadInt32()));
                        list.Add(i++, new Student(name, surname, dadname, course, faculty, group, date));
                        
                    }
                    catch (OutOfMemoryException e)
                    {
                        FileStream FS = new FileStream(@"C: \Users\sv\Desktop\!.txt", FileMode.Create);
                        using (StreamWriter SW = new StreamWriter(FS))
                        {
                            SW.WriteLine(e.ToString());

                            
                        }
                    }
                    
                }
            }
            catch (EndOfStreamException)
            {
                br.Close();
                return list;
            }
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
            string name = new string(br.ReadChars(br.ReadInt32()));
            string surname = new string(br.ReadChars(br.ReadInt32()));
            string dadname = new string(br.ReadChars(br.ReadInt32()));
            string course = new string(br.ReadChars(br.ReadInt32()));
            string faculty = new string(br.ReadChars(br.ReadInt32()));
            string group = new string(br.ReadChars(br.ReadInt32()));
            string date = new string(br.ReadChars(br.ReadInt32()));
            br.Close();
            return new Student(name, surname, dadname, course, faculty, group, date);
        }
        public Dictionary<decimal, Student> ReadFromDat(string Path)
        {
            Dictionary<decimal, Student> list = new Dictionary<decimal, Student>();
            FileStream FS = new FileStream(Path, FileMode.Open);
            //using (FileStream FS = new FileStream(Path, FileMode.Open))
            //{
            //    BinaryFormatter BF = new BinaryFormatter();
            //    return list = (Dictionary<decimal, Student>)BF.Deserialize(FS);
            //}
            //Читаем длину
            byte[] Name;
            byte[] NameLength = new byte[4];

            byte[] Surname;
            byte[] SurnameLength = new byte[4];

            byte[] Dadname;
            byte[] DadnameLength = new byte[4];

            byte[] Course;
            byte[] CourseLength = new byte[4];

            byte[] Faculty;
            byte[] FacultyLength = new byte[4];

            byte[] Group;
            byte[] GroupLength = new byte[4];

            byte[] Date;
            byte[] DateLength = new byte[4];







            decimal i = 1;
            byte[] byte_int = new byte[4];
            int n = 1;
            while (n != 0)
            {


                n = FS.Read(byte_int, 0, 4);
                if (n == 0) break;
                //длина


                //имя
                FS.Read(NameLength, 0, NameLength.Length);
                    Name = new byte [BitConverter.ToInt32(NameLength, 0)];
                    FS.Read(Name, 0, Name.Length);

                    //фамилия
                    FS.Read(SurnameLength, 0, SurnameLength.Length);
                    Surname = new byte[BitConverter.ToInt32(SurnameLength, 0)];
                    FS.Read(Surname, 0, Surname.Length);

                    //отчество
                    FS.Read(DadnameLength, 0, DadnameLength.Length);
                    Dadname = new byte[BitConverter.ToInt32(DadnameLength, 0)];
                    FS.Read(Dadname, 0, Dadname.Length);

                    //курс
                    FS.Read(CourseLength, 0, CourseLength.Length);
                    Course = new byte[BitConverter.ToInt32(CourseLength, 0)];
                    FS.Read(Course, 0, Course.Length);

                    //факультет
                    FS.Read(FacultyLength, 0, FacultyLength.Length);
                    Faculty = new byte[BitConverter.ToInt32(FacultyLength, 0)];
                    FS.Read(Faculty, 0, Faculty.Length);

                    //группа
                    FS.Read(GroupLength, 0, GroupLength.Length);
                    Group = new byte[BitConverter.ToInt32(GroupLength, 0)];
                    FS.Read(Group, 0, Group.Length);

                    //дата
                    FS.Read(DateLength, 0, DateLength.Length);
                    Date = new byte[BitConverter.ToInt32(DateLength, 0)];
                    FS.Read(Date, 0, Date.Length);

                    string surname = Encoding.Default.GetString(Surname);
                    string name = Encoding.Default.GetString(Name);
                    string dadname = Encoding.Default.GetString(Dadname);
                    string course = Encoding.Default.GetString(Course);
                    string faculty = Encoding.Default.GetString(Faculty);
                    string group = Encoding.Default.GetString(Group);
                    string date = Encoding.Default.GetString(Date);

                    list.Add(i++, new Student(name, surname, dadname, course, faculty, group, date));
                }

            FS.Close();
            return list;
        }
    }
}

