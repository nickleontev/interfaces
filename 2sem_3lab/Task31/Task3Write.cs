using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task31
{
    class Task3Write : IWrite, IRead
    {
        //Саня привет
        public int group;
        public int mark;
        public string FIO;
        public string facult;
        public char[] ArrFIO; 
        public char[] Arrfacult;
        public string roman;

        public Task3Write( int group, int mark, string FIO, string facult)
        {
            //    this.ArrFIO = FIO.ToCharArray();
            //    this.Arrfacult = facult.ToCharArray();
            this.group= group;
            this.mark= mark;
            
            this.FIO= FIO;
            this.facult= facult;
        }
        

        public void WriteTo()
        {
            ArrFIO = FIO.ToCharArray();
            Arrfacult = facult.ToCharArray();
            BinaryWriter bw = new BinaryWriter(File.Create(@"C: \Users\Александр\OneDrive\Документы\Программирование\Программирование 2 семестр\Лабы от OKE\Lab.bin"), Encoding.Unicode);
            bw.Write(ArrFIO.Length * 2 + Arrfacult.Length * 2 + 20);
            bw.Write(ArrFIO.Length);
            bw.Write(ArrFIO);
            bw.Write(group);
            bw.Write(Arrfacult.Length);
            bw.Write(Arrfacult);
            bw.Write(mark);


            ////2
            //FIO = "Сидоров Сидор Петрович";
            //facult = "Пивоваренное производство";
            //group = 123;
            //mark = 5;
            //ArrFIO = FIO.ToCharArray();
            //Arrfacult = facult.ToCharArray();
            //bw.Write(ArrFIO.Length * 2 + Arrfacult.Length * 2 + 20);
            //bw.Write(ArrFIO.Length);
            //bw.Write(ArrFIO);
            //bw.Write(group);
            //bw.Write(Arrfacult.Length);
            //bw.Write(Arrfacult);
            //bw.Write(mark);
            ////3
            //FIO = "Лопухин Лопух Лошарович";
            //facult = "Дебилов";
            //group = 666;
            //mark = -2;
            //ArrFIO = FIO.ToCharArray();
            //Arrfacult = facult.ToCharArray();
            //bw.Write(ArrFIO.Length * 2 + Arrfacult.Length * 2 + 20);
            //bw.Write(ArrFIO.Length);
            //bw.Write(ArrFIO);
            //bw.Write(group);
            //bw.Write(Arrfacult.Length);
            //bw.Write(Arrfacult);
            //bw.Write(mark);
            bw.Close();
        }
        public void ReadFile()
        {
            BinaryReader br = new BinaryReader(File.Open(@"C: \Users\Александр\OneDrive\Документы\Программирование\Программирование 2 семестр\Лабы от OKE\Lab.bin", FileMode.Open), Encoding.Unicode);
            Console.WriteLine("1 запись");
            Console.WriteLine("Длина записи {0}", br.ReadInt32());
            ArrFIO = br.ReadChars(br.ReadInt32());
            Console.WriteLine(ArrFIO);
            Console.WriteLine(br.ReadInt32());
            Arrfacult = br.ReadChars(br.ReadInt32());
            Console.WriteLine(Arrfacult);
            Console.WriteLine(br.ReadInt32());
            ////==
            //Console.WriteLine("N Запись (3)");
            //br.BaseStream.Position = 0;
            //int k;
            //for (int i = 1; i < 3; i++)
            //{
            //    k = br.ReadInt32();
            //    br.BaseStream.Seek(k - 4, SeekOrigin.Current);
            //}
            //Console.WriteLine("Длина записи {0}", br.ReadInt32());
            //ArrFIO = br.ReadChars(br.ReadInt32());
            //Console.WriteLine(ArrFIO);
            //Console.WriteLine(br.ReadInt32());
            //Arrfacult = br.ReadChars(br.ReadInt32());
            //Console.WriteLine(Arrfacult);
            //Console.WriteLine(br.ReadInt32());
            br.Close();
        }
        
        //public void WriteToBin(Dictionary<decimal, Task3Write> list, string FilePath)
        //{
        //    FileStream FS = new FileStream(FilePath, FileMode.Create, FileAccess.Write);

        //    BinaryWriter BW = new BinaryWriter(FS, Encoding.Default);
        //    foreach (KeyValuePair<decimal, Task3Write> student in list)
        //    {
        //        // обдумать что-куда сохранять

        //        //FieldInfo[] a =  student.GetType().GetFields();


        //        int dlina = student.Value.group.Length + 4 + student.Value.mark.Length + 4 + student.Value.bytecount.Length + 4 + student.Value.FIO.Length + 4 + student.Value.facult.Length  + 20;
        //        BW.Write(dlina);
        //        //фамилия
        //        BW.Write(student.Value.surname.ToCharArray().Length);
        //        BW.Write(student.Value.surname.ToCharArray());



        //        //имя
        //        BW.Write(student.Value.name.ToCharArray().Length);
        //        BW.Write(student.Value.name.ToCharArray());


        //        //отчество
        //        BW.Write(student.Value.dadname.ToCharArray().Length);
        //        BW.Write(student.Value.dadname.ToCharArray());


        //        //курс
        //        BW.Write(student.Value.course.ToCharArray().Length);
        //        BW.Write(student.Value.course.ToCharArray());

        //        //факультет
        //        BW.Write(student.Value.faculty.ToCharArray().Length);
        //        BW.Write(student.Value.faculty.ToCharArray());

        //        //группа
        //        BW.Write(student.Value.group.ToCharArray().Length);
        //        BW.Write(student.Value.group.ToCharArray());

        //        //дата рождения
        //        BW.Write(student.Value.date.ToCharArray().Length);
        //        BW.Write(student.Value.date.ToCharArray());

        //    }
        //    //закрываем поток
        //    BW.Close();
        //    FS.Close();

        //}
    
        //public void CreateWriteFile()
        //{
        //    File.Create(@"C:\\test.bin")

        //}
        //public char[] ConversionToFormat(string Str)
        //{
        //    char[] StrArr;
        //    StrArr = Str.ToCharArray();
        //    return StrArr;
        //}
        //public void WriteTo()
        //{
        //    BinaryWriter bw = new BinaryWriter(File.Create(@"C:\\test.bin"), Encoding.Unicode);
        //    bw.Write(ArrFIO.Length * 2 + Arrfacult.Length * 2 + 20);
        //    bw.Write(ArrFIO.Length);
        //    bw.Write(ArrFIO);
        //    bw.Write(group);
        //    bw.Write(Arrfacult.Length);
        //    bw.Write(Arrfacult);
        //    bw.Write(mark);
        //}
    }
}
