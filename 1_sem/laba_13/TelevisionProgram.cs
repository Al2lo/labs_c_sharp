using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Work_lab
{
    [Serializable]
    abstract class TelevisionProgram : Director
    {
        [NonSerialized]
        int countt = 1999;

        
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
        

    }
}


