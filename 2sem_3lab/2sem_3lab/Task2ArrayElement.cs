using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_3lab
{
    public class Task2ArrayElement : IComparable<Task2ArrayElement>
    {
        //свойства
        //public string Name
        //{
        //    get;
        //    set;
        //}
        public int Number1
        {
            get;
            set;
        }
        //public int Number2
        //{
        //    get;
        //    set;
        //}

        //конструктор
        public Task2ArrayElement( int Number1)
        {
            this.Number1 = Number1;
            //this.Number2 = Number2;
        }

        //public int CompareTo(ArrayElement obj)
        //{
        //    if (this.Number2 < obj.Number2)
        //        return 1;
        //    if (this.Number2 > obj.Number2)
        //        return -1;
        //    else
        //        return 0;
        //}//по убыванию

        public int CompareTo(Task2ArrayElement obj)
        {
            if (this.Number1 > obj.Number1)
                return 1;
            if (this.Number1 < obj.Number1)
                return -1;
            else
                return 0;
        }//по возрастанию

        public override string ToString()
        {
            return String.Format(" {0}\t ", this.Number1);
        }
    }
}
