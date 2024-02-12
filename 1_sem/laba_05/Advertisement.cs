using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    internal sealed class Advertisement: TelevisionProgram, IInfo
    {
        public override string nameOfProgram { get; set; }
        public override sealed int yearOfCreate { get; set; }
        public override sealed int timeOfContinue { get; set; }

        public override void GetInfo(TelevisionProgram program)
        {
            Console.WriteLine("Это Реклама");
            base.ToString();
        }

        public void GetInfo(int item)
        {
            Console.WriteLine("Это Реклама");
        }
    }
}
