using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Set<int> set1 = new Set<int>();
                set1.Add(1);
                set1.Add(2);
                set1.Add(3);
                set1.GetInfo();
                set1.Delete(3);
                set1.GetInfo();
                set1.Add(1);


                Set<string> set2= new Set<string>();
                set2.Add("Hello");
                set2.Add("Hey");
                set2.Add("Hey yoyy");
                set2.GetInfo();
                set2.Delete("Hello");
                set2.GetInfo();



                Set<Film> setFilm = new Set<Film>();
                setFilm.Add(new Film { nameOfProgram = "foodTrak", timeOfContinue = 120 , yearOfCreate = 2022}); ;
                setFilm.GetInfo();

                
                set1.WriteFile();
                setFilm.WriteFile();
                Set<string> setReader = new Set<string>();
                setReader.ReadFile(setReader);
                setReader.GetInfo();
            
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("It's end!!!");
            }
        }
    }
}