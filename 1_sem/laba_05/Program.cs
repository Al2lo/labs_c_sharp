using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    class Printer
    {
        void IAmPrinting(TelevisionProgram program)
        {
            program.ToString();
        }


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

            TelevisionProgram spisokFilms = film;
            spisokFilms.SearchOneYearFilm(2013, spisok);
            spisokFilms.GetInfoSpisok();

            int time = spisok.GetTimeOfProgram();

            int countOfAdvertisment = spisok.GetAdvertisment();

            Console.WriteLine($"Время длиельности в программы {time} min");
            Console.WriteLine($"Кол-во рекламных роликов {countOfAdvertisment}");

            Film film1 = new Film();
            film1.ReadFile();
            film1.ToString();


            Debugger.Break();


            int zero = 1;
            Debug.Assert(zero == 1, "Zero != 1");

            Logger logger = new Logger();
            try
            {

                Console.WriteLine(5 / zero);


                //int[] arrP = {1,2,3};
                //Console.WriteLine(arrP[zero]);
                ErrorData errorData1 = new ErrorData("Adolf",111,1941);
                //ErrorData errorData2 = new ErrorData(" ", 120, 1111);
                ErrorData errorData3 = new ErrorData("AMerica", 0, 2020);
                //ErrorData errorData4 = new ErrorData("Lycia", 120, 2023);
                errorData1.ProverkaOfArr();
                //errorData1.GetUserName();

            }
            catch (ErrorOfName e)
            {
                logger.LoggerFile(e);
                logger.LoggerConsole(e);
                throw;
            }
            catch (ErrorYearOfCreate e)
            {
                logger.LoggerFile(e);
                logger.LoggerConsole(e);
            }
            catch (ErrorOfTime e)
            {
                StackTrace stack = new StackTrace(e);
                foreach (StackFrame frame in stack.GetFrames())
                {
                    Console.WriteLine(frame.GetMethod());

                }
                logger.LoggerFile(e);
                logger.LoggerConsole(e);

            }
            catch (DivideByZeroException e)
            {
                logger.LoggerFile(e);
                logger.LoggerConsole(e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                logger.LoggerFile(e);
                logger.LoggerConsole(e);
            }
            finally
            {
                Console.WriteLine("\nEnd");
            }





        }
    }
}

