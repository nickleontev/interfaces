using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Введите наименование факультета");
                    string facult = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите номер группы");
                    int group = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ФИО");
                    string FIO = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите оценку");
                    int mark = Convert.ToInt32(Console.ReadLine());


                    Task3Write task3 = new Task3Write(group, mark, facult, FIO);
                    task3.WriteTo();
                    task3.ReadFile();
                    string exit = Convert.ToString(Console.ReadLine());
                    if (exit == "exit" || exit == "учше" )
                    {
                        break;
                    }

                }
                catch
                {
                    Console.WriteLine("Непредвиденная ошибка. Проверьте правильность ввода");
                }
            }














            //task3.ConversionToFormat(FIO);
            //string FIO;
            //string facult;
            //byte[] ArrFIO;
            //byte[] Arrfacult;
            //byte[] ArrFIOLength;
            //byte[] ArrfacultLength;
            //int group;
            //int mark;
            //int bytecount;
            //byte[] Arrgroup;
            //byte[] Arrmark;
            //byte[] Arrbytecount;
            //FileStream bw = new FileStream
            //(@"C:\\test.bin", FileMode.Create);
            //FIO = "Иванов Ivan иванович";
            //facult = "ФАIT";
            //group = 3;
            //mark = 2;
            //ArrFIO = Encoding.Unicode.GetBytes(FIO.ToCharArray());
            //ArrFIOLength = BitConverter.GetBytes(ArrFIO.Length);

            //Arrfacult = Encoding.Unicode.GetBytes(facult.ToCharArray());
            //ArrfacultLength = BitConverter.GetBytes(Arrfacult.Length);

            ////ArrFIOLength = BitConverter.GetBytes(ArrFIO.Length);

            ////ArrfacultLength = BitConverter.GetBytes(Arrfacult.Length);

            //Arrgroup = BitConverter.GetBytes(group);

            //Arrmark = BitConverter.GetBytes(mark);

            //bytecount = ArrFIO.Length + Arrfacult.Length + 20;

            //Arrbytecount = BitConverter.GetBytes(bytecount);



            //bw.Write(Arrbytecount, 0, Arrbytecount.Length);
            //bw.Write(ArrFIOLength, 0, ArrFIOLength.Length);
            //bw.Write(ArrFIO, 0, ArrFIO.Length);
            //bw.Write(ArrfacultLength, 0, ArrfacultLength.Length);
            //bw.Write(Arrfacult, 0, Arrfacult.Length);
            //bw.Write(Arrgroup, 0, Arrgroup.Length);
            //bw.Write(Arrmark, 0, Arrmark.Length);

            //class Task3Interface
            //{
            //    public void CreateWriteFile()
            //    {
            //        //создание файла
            //        FileStream file_1 = File.Create("KAV_LAB3.bin");
            //        //запись в файл
            //        StreamWriter writeinfile = new StreamWriter(file_1);
            //        writeinfile.WriteLine(Convert.ToString(Console.ReadLine()));
            //        writeinfile.Close();
            //        file_1.Close();
            //    }

            //    public void ReadFile()
            //    {
            //        FileStream readfile = File.Open("KAV_LAB3.bin", FileMode.Open);
            //        StreamReader readerfile = new StreamReader(readfile);
            //        while (readerfile.Peek() != -1)
            //        {
            //            Console.WriteLine(readerfile.ReadLine());
            //        }

            //    }
        }
    }
}
