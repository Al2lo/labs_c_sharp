using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace Work_lab
{
    internal class Set<T>: IMethodsForCollection<T>
    {


        private List<T> _items = new List<T>();


        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (_items.Contains(item))
            {
                Console.WriteLine($"Данный элемент: ({item}) у нас уже есть!");

            }
            else
            {
                _items.Add(item);

            }

        }

        public void Delete(T item)
        {

            if (_items.Contains(item))
            {
                _items.Remove(item);

            }
            else
            {
                Console.WriteLine("We don't have this item");

            }
        }


        public void GetInfo()
        {
            Console.WriteLine("Start GetInfo: ");

            foreach (var item in _items)
            {
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }

                Console.WriteLine(item.ToString());

            }

            Console.WriteLine("End GetInfo.\n");

        }

        public void ReadFile(Set<string> set)
        {
            using (StreamReader file = new StreamReader("reader.txt", true))
            {
                string[] dataFile = new string[50];
                dataFile = file.ReadToEnd().Split(" ");


                for (int i = 0; i < dataFile.Length; i++)
                {
                 
                    set._items.Add(dataFile[i]);
           
                }

               file.Close();

            }
        }

        public void WriteFile()
        {
            using (StreamWriter file = new StreamWriter("writer.txt",true))
            {
                foreach (var item in this._items)
                {
                    if (this._items is Film)
                    {
                        file.WriteLine(this.ToString()+"\n");
                    }
                    else
                    {
                        file.Write(item + ",");

                    }

                }

                file.Close();
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



    }
}
