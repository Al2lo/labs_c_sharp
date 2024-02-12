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
        public static string patronymic { get; }
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

        public override bool Equals(object? obj)
        {

            Phone phone = obj as Phone;

            if (this.name == phone.name)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        public override int GetHashCode()
        {
            return id*3;

        }

        public override string ToString()
        {
            return $"{name}:{family}:{patronymic}";

        }


        static void vyvod(Phone phone)
        {
            Console.WriteLine("id пользователя " + phone.id);
            Console.WriteLine("Имя пользователя " + (phone.name));
            Console.WriteLine("фамилия пользователя " + Phone.family);
            Console.WriteLine("Отчество пользователя " + Phone.patronymic);
            Console.WriteLine("адрес пользователя " + phone.adress);
            Console.WriteLine("Дебет пользователя " + phone.debet);
            Console.WriteLine("Кредиты пользователя " + phone.credit);
            Console.WriteLine("Номер кредита пользователя " + phone.numberOfCreditCard);
            Console.WriteLine("Городские звонки пользователя " + phone.timeOfInCitySpeak);
            Console.WriteLine("Межгородские звонки мользователя пользователя " + phone.timeOfOutCitySpeak);
            Console.WriteLine("количество объектов " + Phone.kol_voOject);
        }
        private Phone(int a, string b)
        {

            id = a;
            name = b;
        }

        static void Main(string[] args)
        {

            Phone[] phonees = new Phone[3];


            Phone petr = new Phone();
            Phone ivan = new Phone("inan", 2);
            Phone alex = new Phone("alex");
            Phone phone = new Phone(4, "kelvin");

            phonees[0] = petr;
            phonees[1] = ivan;
            phonees[2] = alex;

            Type objectType = typeof(Phone);
            Console.WriteLine("Тип созданного объекта - " + objectType);

            Console.WriteLine("Имена первого и второго телефона одинаковы:"+petr.Equals(ivan));

            Console.WriteLine(alex.ToString());
            Console.WriteLine(alex.GetHashCode());

            Console.Write("Введите время внутригородских разговоров: ");
            int maxMin = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < phonees.Length; i++)
            {
                phonees[i].getInfo1(maxMin, ref counter);
                Console.WriteLine();
            }

            if (counter >=3)
            {
                Console.WriteLine("Нет таких");
            }

            counter = 0;
            Console.WriteLine();
            Console.WriteLine("сведения об абонентах, которые пользовались междугородной связью; ");

            for (int i = 0; i < phonees.Length; i++)
            {
                phonees[i].getInfo2(ref counter);
                Console.WriteLine();

            }

            if (counter >= 3)
            {
                Console.WriteLine("Нет таких");

            }

            var user = new { Name = "Tom", Age = 34 };
            Console.WriteLine(user.GetType().Name);

        }

        public void getInfo1( int maxMin, ref int counter)
        { 
            if (this.timeOfInCitySpeak > maxMin)
            {
                vyvod(this);

            }
            else
            {
                counter++;

            }
        }

        public void getInfo2(ref int counter)
        {
            if (this.timeOfOutCitySpeak > 0)
            {
                vyvod(this);

            }
            else
            {
                counter++;

            }
        }
    }
}
