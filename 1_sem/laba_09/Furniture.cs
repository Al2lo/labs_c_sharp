using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Lab
{

    interface IList<T>
    {
        void Add(T item);
        void Remove(T item);
        void Search(T item);
        void GetInfo();

    }
    internal class Furniture<T> : IList<T>
    {
        public T name { get; set; }
        public ArrayList arrayList = new ArrayList();
        public int count { get; set; } = 0;

        void IList<T>.Add(T item)
        {
            arrayList.Add(item);
            count++;
        }

        void IList<T>.Remove(T item)
        {
            if (arrayList.Contains(item))
            {
                arrayList.Remove(item);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        void IList<T>.Search(T item)
        {
            if (arrayList.Contains(item))
            {
                Console.WriteLine($"{item } Есть в списке");
            }
            else
            {
                Console.WriteLine("Элемент не найден! ");
            }
        }

        void IList<T>.GetInfo()
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
        }


    }
}
