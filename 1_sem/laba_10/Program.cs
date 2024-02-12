using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Work_Lab
{

    class Program
    {


        public static void Main(string[] args)
        {
            string[] months = {"Junary", "Febrary", "March","April","May","June","July","August","September","October","November","December"};
            Console.Write("Set Count of symbol in words: ");
            int kol_vo = Convert.ToInt32(Console.ReadLine());

            var zapros1 = from word in months where word.Length == kol_vo select word;

            foreach (var item in zapros1)
            {
                Console.WriteLine(item);          
            }
            Console.WriteLine();
            var zapros2 = from word in months where word == "Junary" || word == "Febrary" || word == "June" || 
                          word == "July" || word == "August" || word == "December" select word;

            foreach (var item in zapros2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var zapros3 = from word in months orderby word ascending select word;

            foreach (var item in zapros3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var zapros4 = from word in months where word.Contains('u') && word.Length >= 4 select word;

            foreach (var item in zapros4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone() { name = "Aphone1", numberOfCreditCard = 1, credit = 1, debet = 1, timeOfInCitySpeak = 1, timeOfOutCitySpeak = 1 });
            phones.Add(new Phone() { name = "Cphone2", numberOfCreditCard = 2, credit = 2, debet = 2, timeOfInCitySpeak = 2, timeOfOutCitySpeak = 2 });
            phones.Add(new Phone() { name = "Nphone3", numberOfCreditCard = 3, credit = 3, debet = 3, timeOfInCitySpeak = 3, timeOfOutCitySpeak = 3 });
            phones.Add(new Phone() { name = "Bphone4", numberOfCreditCard = 4, credit = 4, debet = 4, timeOfInCitySpeak = 4, timeOfOutCitySpeak = 4 });
            phones.Add(new Phone() { name = "Dphone5", numberOfCreditCard = 5, credit = 0, debet = 1, timeOfInCitySpeak = 0, timeOfOutCitySpeak = 5 });
            phones.Add(new Phone() { name = "Fphone6", numberOfCreditCard = 6, credit = 6, debet = 0, timeOfInCitySpeak = 6, timeOfOutCitySpeak = 6 });
            phones.Add(new Phone() { name = "Sphone7", numberOfCreditCard = 7, credit = 7, debet = 7, timeOfInCitySpeak = 7, timeOfOutCitySpeak = 7 });
            phones.Add(new Phone() { name = "Aphone8", numberOfCreditCard = 0, credit = 0, debet = 0, timeOfInCitySpeak = 0, timeOfOutCitySpeak = 0 });
            phones.Add(new Phone() { name = "Lphone9", numberOfCreditCard = 9, credit = 9, debet = 9, timeOfInCitySpeak = 9, timeOfOutCitySpeak = 9 });
            phones.Add(new Phone() { name = "Pphone10", numberOfCreditCard = 10, credit = 10, debet = 10, timeOfInCitySpeak = 10, timeOfOutCitySpeak = 10 });

            Console.Write("время внутригородских разговоров: ");
            kol_vo = Convert.ToInt32(Console.ReadLine());

            var zapros5 = from phone in phones where phone.timeOfInCitySpeak > kol_vo select phone;

            foreach (var item in zapros5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var zapros6 = from phone in phones where phone.timeOfOutCitySpeak >  0 select phone;

            foreach (var item in zapros6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var zapros7 = from phone in phones where phone.debet > 0 select phone;

            Console.WriteLine(zapros7.Count()+"\n");

            var zapros8 = from phone in phones where phone.debet == 10 select phone;

            foreach (var item in zapros8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var zapros9 = from phone in phones orderby phone.name ascending select phone;

            foreach (var item in zapros9)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var zapros10 = from phone in phones where phone.credit > 0 orderby phone.name descending select phone;

            List<Class1> phones1 = new List<Class1>();
            phones1.Add(new Class1() { name = "Aphone1" });
            phones1.Add(new Class1() { name = "Aphone2" });
            phones1.Add(new Class1() { name = "Aphone3" });

            var zapros11 = from phone in phones
                           join phone1 in phones1 on phone.name equals phone1.name
            select new { name = phone.name, numberOfCreditCard = phone.numberOfCreditCard, credit = 1, debet = 1, timeOfInCitySpeak = 1, timeOfOutCitySpeak = 1};

            foreach (var item in zapros11)
            {
                Console.WriteLine(item.ToString());
            }


        }




    }
}