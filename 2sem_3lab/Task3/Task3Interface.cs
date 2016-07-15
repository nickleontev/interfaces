using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2sem_3lab
{
    public interface IRead
    {
        void ReadFile();
    }
    public interface IWrite
    {
        void CreateWriteFile();
    }
    class Task3 : IRead, IWrite
    {
        public void CreateWriteFile()
        {
            //создание файла
            FileStream file_1 = File.Create("KAV_LAB3.bin");
            //запись в файл
            StreamWriter writeinfile = new StreamWriter(file_1);
            writeinfile.WriteLine(Convert.ToString(Console.ReadLine()));
            writeinfile.Close();
            file_1.Close();
        }
        
        public void ReadFile()
        {
            FileStream readfile = File.Open("KAV_LAB3.bin", FileMode.Open);
            StreamReader readerfile = new StreamReader(readfile);
            while (readerfile.Peek() != -1)
            {
                Console.WriteLine(readerfile.ReadLine());
            }

        }

        
    }
}
