using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    internal class News : TelevisionProgram
    {
        public override string nameOfProgram { get; set; }
        public override int yearOfCreate { get; set; }
        public override int timeOfContinue { get; set; }
        public override void GetInfo(TelevisionProgram program)
        {
            Console.WriteLine("Это новости");
            base.ToString();
        }
    }
}
