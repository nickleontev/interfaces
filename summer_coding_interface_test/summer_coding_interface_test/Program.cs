using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer_coding_interface_test
{
    public class Program: IComparable<Program>
    {
      public  int CompareTo(Program obj)
        {
            if (this.num > obj.num) return 1;
            if (this.num < obj.num) return -1;
            else return 0;
        }
        
        public int num;
        public string name;

        static void Main(string[] args)
        {
            Program[] pr = new Program[20] ;
            int dovesok = 0;
                for (int i = 0; i < 20; i++)
                {
                pr[i] = new Program();
                dovesok++;
                if (i == 15) dovesok = 0;
                pr[i].num += dovesok;
                pr[i].name += dovesok;
                
                }

            //foreach (Program prr in pr)
            //{
            //    Console.WriteLine(String.Format("name: {0}  num: {1} "), prr.name, prr.num);
            //}
            for (int i = 0; i <pr.Length; i++)
            {
                Console.WriteLine(String.Format("name: {0}  num: {1} ", pr[i].name, pr[i].num));
            }
            Console.WriteLine("\n\n");
            Array.Sort(pr);
            for (int i = 0; i < pr.Length; i++)
            {
                Console.WriteLine(String.Format("name: {0}  num: {1} ", pr[i].name, pr[i].num));
            }

            Console.ReadKey();
        }
    }
}
