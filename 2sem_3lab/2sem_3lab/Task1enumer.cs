using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2sem_3lab
{
    class Task1enumer : IEnumerable, IEnumerator
    {
        int[] arr = { 3, 2, 1, 4, 5, 829 };
        int index = -1;

        //возвращает Объект IEnumerator, 
        //который может использоваться для перебора коллекции.
        //Итерация в программировании — организация обработки данных, при которой действия повторяются многократно,
        //не приводя при этом к вызовам самих себя (в отличие от рекурсии)[1].
        // Реализуем интерфейс IEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        

        //Перемещает перечислитель к следующему элементу коллекции.
        //public bool MoveNext()
        //{
        //    if (index < arr.Length - 1)
        //    {
        //        index = index + 1;

        //        return true;
        //    }
        //    else
        //    {
        //        Reset();
        //        return false;
        //    }
        //}

        //Устанавливает перечислитель в его начальное положение, 
        //т. е. перед первым элементом коллекции
        public void Reset()
        {
            index = -1;
        }

        //Получает текущий элемент в коллекции.
        object IEnumerator.Current
        {
            get
            {
                return arr[index];
            }
        }
    }
}
