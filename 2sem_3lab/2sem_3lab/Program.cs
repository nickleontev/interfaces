using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace _2sem_3lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Задание 1 \n");

            Task1enumer cls = new Task1enumer();
            foreach (int el in cls)
            {
                Console.Write(el + "\t");
            }

            //yield
            Console.Write("\n\nЧерез yield :  ");
            foreach (var item in Task1Yield.Power())
            {
                Console.WriteLine(item + "\n");
            }

            //задание 2
            Console.WriteLine("Задание 2 \n");
            List<Task2ArrayElement> com = new List<Task2ArrayElement>();

            com.Add(new Task2ArrayElement(180, 300000));
            com.Add(new Task2ArrayElement(160, 220000));
            com.Add(new Task2ArrayElement(140, 260000));
            com.Add(new Task2ArrayElement(360, 4200000));
            com.Add(new Task2ArrayElement(220, 400000));
            com.Add(new Task2ArrayElement(360, 4200000));

            Console.WriteLine("До сортировки \n");
            foreach (var item in com)
            {
                Console.WriteLine(item);
            }

            com.Sort();
            Console.WriteLine("\nПосле сортировки \n");
            foreach (var item in com)
            {
                Console.WriteLine(item);
            }

            //Задание 3
            Console.WriteLine("Задание 3 ");
            Task3 tas = new Task3();
            Console.Write("Ввод в файл :  ");
            tas.CreateWriteFile();
            Console.Write("В файл записанно :  ");
            tas.ReadFile();
            





            Console.ReadLine();
        }

    }
}
