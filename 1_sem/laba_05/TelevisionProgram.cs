using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Runtime.Remoting;


namespace laba_04
{
    abstract class TelevisionProgram : Director
    {
 
        TelevisionProgram[] program = new TelevisionProgram[5];
        public abstract string nameOfProgram { get; set; }
        public abstract int yearOfCreate { get; set; }
        public abstract int timeOfContinue { get; set; }
        public abstract void GetInfo(TelevisionProgram program);
        public override string ToString()
        {
            Console.WriteLine($"Название программы {nameOfProgram} Длительность: {timeOfContinue} Год создагия: {yearOfCreate}");
            return base.ToString();
        }


        public TelevisionProgram[] WorkProgram
        {
            get => program;
            set => program = value;
        }

        public void Add(TelevisionProgram element, ref int counter)
        {
           program[counter] = element;
            counter++;
        }

      public void Remove(TelevisionProgram element)
        {
           program =program.Except(new TelevisionProgram[] { element }).ToArray();
        }

        public void GetInfoSpisok()
        {
            Console.WriteLine("Вывод элементов программы:");
            foreach (var item in program)
            { 
                if (item ==null)
                {
                    break;
                }
                Console.WriteLine(item.nameOfProgram);

            }
            Console.WriteLine("End");
        }

        public void SearchOneYearFilm(int year, TelevisionProgram programs)
        {
            Console.WriteLine("все фильмы, снятые в определенный год");
            foreach (var item in program)
            {
                if ((item is Film) && (item.yearOfCreate == year))
                {
                    item.ToString();
                }
            }
            Console.WriteLine("End");
        }

        public int GetTimeOfProgram()
        {
            int time = 0;

            foreach (var item in program)
            {
                if (item == null)
                {
                    break;
                }
                time += item.timeOfContinue;
            }

            return time;
        }

        public int GetAdvertisment()
        {
            int count = 0;

            foreach (var item in program)
            {
                if (item == null)
                {
                    break;
                }
                if (item is Advertisement)
                {
                    count++;
                }
            }

            return count;
        }



        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader("info.txt", true))
            {

                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] names = str.Split(' ');
                    this.nameOfProgram = names[0];
                    
                }

            }

        }


        //async public void ReadJsonFile()
        //{
        //    using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        //    {
        //        TelevisionProgram restoredPerson = await JsonSerializer.DeserializeAsync<TelevisionProgram>(fs);
        //        Console.WriteLine($"Name: {this.nameOfProgram = Name}  create year: {this.yearOfCreate = Year}");
        //    }
        //}


        }
    }


