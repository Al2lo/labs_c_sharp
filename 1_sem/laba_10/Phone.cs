using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Lab
{
    class Phone
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
            return id * 3;

        }

        public override string ToString()
        {
            return $"{name}:{family}:{patronymic}";

        }
    }
}
