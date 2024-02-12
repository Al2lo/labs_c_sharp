using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Work_Lab
{

    public class Program
    {





        static void Main(string[] args)
        {
            Furniture<string> stringProverka = new Furniture<string> {name = "TV" };
            Furniture<int> intProverka = new Furniture<int> { name =1};

            Console.WriteLine("String");

            ((IList<string>)stringProverka).Add("Table");
            ((IList<string>)stringProverka).Add("Bed");
            ((IList<string>)stringProverka).Add("Sofa");


            ((IList<string>)stringProverka).GetInfo();

            ((IList<string>)stringProverka).Remove("Bed");


            ((IList<string>)stringProverka).GetInfo();



            ((IList<string>)stringProverka).Search("Sofa");

            Console.WriteLine("Int");

            ((IList<int>)intProverka).Add(1);
            ((IList<int>)intProverka).Add(2);
            ((IList<int>)intProverka).Add(3);


            ((IList<int>)intProverka).GetInfo();

            ((IList<int>)intProverka).Remove(1);


            ((IList<int>)intProverka).GetInfo();



            ((IList<int>)intProverka).Search(2);

            List<int> list = new List<int>();

            foreach (int item in intProverka.arrayList)
            {
                list.Add(item);
            }

            Console.WriteLine("new collection");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSet value of list");
            int value = Convert.ToInt32(Console.ReadLine());

            if (list.Contains(value))
            {
                Console.WriteLine($"Элемент {value} найден");
            }
            else
            {
                Console.WriteLine("Error");
            }


            ObservableCollection<Furniture<int>> observableCollection = new ObservableCollection<Furniture<int>>();
            observableCollection.CollectionChanged += wasChange;
            observableCollection.Add(intProverka);
            observableCollection.Remove(intProverka);


            static void wasChange(Object? sendr, NotifyCollectionChangedEventArgs e)
            {
                Console.WriteLine("Was Change");
            }
        }

    }


}