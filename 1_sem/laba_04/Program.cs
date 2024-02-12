using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    partial class Printer
    {


        public void ProverkaIs(TelevisionProgram program)
        {
            if (program is Film film)
            {
                Console.WriteLine("Is Film");
            }
        }

        public void ProverkaAs(TelevisionProgram program)
        {
            News news = program as News;
            if (news !=null)
            {
                Console.WriteLine("Is News");
            }
        }
        static void Main(string[] args)
        {
            int counter = 0;

            News news = new News() {yearOfCreate = 2003,nameOfProgram ="News", timeOfContinue=30 };
            Film film = new Film() {yearOfCreate = 2013, nameOfProgram = "Gods", timeOfContinue = 130 };
            FeatureFilm featureFilm = new FeatureFilm() { yearOfCreate = 2023, nameOfProgram = "Hypertoniya", timeOfContinue = 170 };
            Cartoon cartoon = new Cartoon() {yearOfCreate = 1993, nameOfProgram = "HY POGODI", timeOfContinue = 20 };
            Advertisement advertisement1 = new Advertisement() {yearOfCreate = 2022, nameOfProgram = "Colgate", timeOfContinue = 1 };
            Advertisement advertisement2 = new Advertisement() {yearOfCreate = 2022, nameOfProgram = "SuperGEl", timeOfContinue = 1 };

            TelevisionProgram spisok = film;
            spisok.Add(news,ref counter);
            spisok.GetInfoSpisok();
            spisok.Add(film,ref counter);
            spisok.GetInfoSpisok();
            spisok.Add(advertisement1, ref counter);
            spisok.GetInfoSpisok();
            

            TelevisionProgram spisokFilms = film;
            spisokFilms.SearchOneYearFilm(2013, spisok);
            spisokFilms.GetInfoSpisok();

            int time = spisok.GetTimeOfProgram();

            int countOfAdvertisment = spisok.GetAdvertisment();

            Console.WriteLine("");
            Console.WriteLine("Delete");
            spisok.Remove(film);
            spisok.GetInfoSpisok();


            Console.WriteLine("");
            Console.WriteLine($"Время длиельности в программы {time} min");
            Console.WriteLine($"Кол-во рекламных роликов {countOfAdvertisment}");

            Film film1 = new Film();
            film1.ReadFile();

            film1.ToString();

            TelevisionProgram film3 = film;
            film3.ReadJsonFile();
            film3.GetInfoSpisok();

        }
    }
}

