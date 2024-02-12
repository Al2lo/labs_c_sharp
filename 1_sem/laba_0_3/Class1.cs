using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_0_3
{
    internal class Set<T>
    {
        internal class Production
        {
            const string id = "BSTU";

        }
        

        internal class Developer
        {
            const string Name = "Aleksandr";
            public int id = 1;
            const string department = "POIT";
        }

        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));

            }

            if (!_items.Contains(item))
            {
                _items.Add(item);

            }

        }

        public void get()
        {
            if (_items == null)
            {
                Console.WriteLine("Нет значений");
            }
            else
            {
                foreach (T item in _items)
                {
                    Console.WriteLine(item);
                }
            }
        }

            public int CountElem()
            {
            int count = 0;

            foreach (T item in this._items)
            {
                count++;

            }

            return count;  
            }

        public static bool operator >(T item1, Set<T> item2)
        {
            if (item1 == null)
            {
                Console.WriteLine("пУСТОЕ МНОЖЕСТВО");

            }
            if (item2._items.Contains(item1))
            {
                return true;

            }
            else
            {
                return false;

            }

        }
        public static bool operator <(T item1, Set<T> item2)
        {
            if (item1 == null)
            {
                Console.WriteLine("пУСТОЕ МНОЖЕСТВО");

            }
            if (item2._items.Contains(item1))
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        public static bool operator >(Set<T> item1, Set<T> item2)
        {
            int countQual = 0;
            int count = 0;
            if (item1 == null)
            {
                Console.WriteLine("пУСТОЕ МНОЖЕСТВО");

            }
            foreach (T variable in item1._items)
            {
                count++;
                if (item2._items.Contains(variable))
                {
                    countQual++;
                }
            }
            if (countQual == count)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public static bool operator <(Set<T> item1, Set<T> item2)
        {
            int countQual = 0;
            int count = 0;
            if (item1 == null)
            {
                Console.WriteLine("пУСТОЕ МНОЖЕСТВО");


            }
            foreach (T variable in item2._items)
            {
                count++;
                if (item2._items.Contains(variable))
                {
                    countQual++;

                }
            }
            if (countQual == count)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        public static Set<T> operator *(Set<T> item1, Set<T> item2)
        {
            Set<T> result = new Set<T>();

            foreach (T item in item1._items)
            {
                if (item2._items.Contains(item))
                {
                    result.Add(item);

                }

            }

            return result;
        }


        public string GetNumber(Set<string> item2)
        {
            string result = "";

            foreach (string item in item2._items)
            {

                foreach(char variable in item)
                {
                    if (Char.IsDigit(variable))
                    {
                        result += " "+variable;
                        break;

                    }

                }

            }

            return result;

        }
        public void vyvod()
        {
            Console.WriteLine("Вывод элементов множества: ");

            foreach (T item in this._items)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Конец вывода");
        }

        public void Delete(Set<int> item2)
        {

            foreach (int item in item2._items)
            {

                if (item >= 0)
                {
                    item2._items.Remove(item);
                }
            }
        }
    }
}
