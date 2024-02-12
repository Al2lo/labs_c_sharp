using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    internal class ErrorData
    {
        private int[] arrProverka = { 1, 2, 3, 4, -1, -2, 2 };
        private string userName = "";

        public ErrorData(string name,int time, int year)
        {
            if (name == null || name == " ")
            {
                throw new ErrorOfName(name);

            }
            if (time <= 0)
            {
                throw new ErrorOfTime(time);

            }
            if (year > 2022)
            {
                throw new ErrorYearOfCreate(year);
            }
            this.nameOfProgram = name;
            this.yearOfCreate = year;
            this.timeOfContinue = time;
        }
        public string nameOfProgram { get; set; }
       public int yearOfCreate { get; set; }
        public int timeOfContinue { get; set; }




        public void ProverkaOfArr()
        {
            for (int i = 0; i < arrProverka.Length; i++)
            {
                if (arrProverka[i] < 0)
                {
                    throw new ErrorOfTime(arrProverka[i]);
                }
            }
        }

        public string GetUserName()
        {
            Console.Write("What is your name? ");
            string? name = Convert.ToString(Console.ReadLine());

            if (name == null || name == " ")
            {
                throw new ErrorOfName(this.userName);
            }
            else
            {
                return name;
            }
        }


    }
}
