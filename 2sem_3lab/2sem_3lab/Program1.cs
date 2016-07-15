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


            ////Random r = new System.Random();
            ////int[] arr = new int[12];
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    int s = r.Next(0, 30);
            ////    arr[i] = s;
            ////}
            ////Console.Write("Массив до сортировки: ");
            ////foreach (var item in arr)
            ////{

            ////    Console.Write(item + " ");
            ////}


            ////Task2ArrayElement tas = new Task2ArrayElement();
            ////tas.Sort(arr);


            //////ArrayList arr = new ArrayList();
            //////// Initialize random number generator.
            //////Random r = new Random();

            //////// Generate 10 temperatures between 0 and 100 randomly.
            //////for (int ctr = 1; ctr <= 10; ctr++)
            //////{
            //////    int degrees = r.Next(0, 100);
            //////    Task2ArrayElement temp = new Task2ArrayElement();
            //////    //temp.Fahrenheit = degrees;
            //////    arr.Add(temp);
            //////}

            List<Task2ArrayElement> com = new List<Task2ArrayElement>();
            com.Add(new Task2ArrayElement(180));
            com.Add(new Task2ArrayElement(160));
            com.Add(new Task2ArrayElement(140));
            com.Add(new Task2ArrayElement(360));
            com.Add(new Task2ArrayElement(220));
            com.Add(new Task2ArrayElement(360));

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






            Console.ReadLine();
        }

    }
}
