using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    partial class Phone
    {

        public readonly int id;
        public const string family = "ivanov";
        public string name { get; set; }
        public static string patronymic { get;}
        public string adress { get; set; }
        public int numberOfCreditCard { get; set; }
        public int debet { get; set; }
        public int credit { get; set; }
        public int timeOfInCitySpeak { get; set; }
        public int timeOfOutCitySpeak { get; set; }

        static int kol_voOject = 0;
        public Phone()
        {
            id = 1;
            name = "petr";
            adress = "angarskaya";
            numberOfCreditCard = 1;
            debet = 1;
            credit = 1;
            timeOfInCitySpeak = 1;
            timeOfOutCitySpeak = 1;
            kol_voOject++;
        }
        public Phone(string name, int id)
        {
            this.id = id;
            this.name = name;
            adress = "baykalskaya";
            numberOfCreditCard = 2;
            debet = 2;
            credit = 2;
            timeOfInCitySpeak = 2;
            timeOfOutCitySpeak = 2;
            kol_voOject++;
        }
        public Phone(string name, string adress = "tomskaya")
        {
            id = 3;
            this.name = name;
            this.adress = adress;
            numberOfCreditCard = 3;
            debet = 3;
            credit = 3;
            timeOfInCitySpeak = 0;
            timeOfOutCitySpeak = 1;
            kol_voOject++;
        }
        static Phone()
        {
            patronymic = "alekseevich";
        }

        private Phone(int a,string b)
        {
            id =a;
            name =b;
        }

        static void vyvod(Phone phone)
        {
            Console.WriteLine(phone.name);
            Console.WriteLine(phone.id);
            Console.WriteLine(Phone.family);
            Console.WriteLine(Phone.patronymic);
            Console.WriteLine(phone.adress);
            Console.WriteLine(phone.debet);
            Console.WriteLine(phone.credit);
            Console.WriteLine(phone.numberOfCreditCard);
            Console.WriteLine(phone.timeOfInCitySpeak);
            Console.WriteLine(phone.timeOfOutCitySpeak);
            Console.WriteLine(Phone.kol_voOject);
        }
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[3];


            Phone petr = new Phone();
            Phone ivan = new Phone("inan",2);
            Phone alex = new Phone("alex");
            Phone phone = new Phone(4,"kelvin");

            phones[0] = petr;
            phones[1] = ivan;
            phones[2]= alex;


            
        }
    }
}
