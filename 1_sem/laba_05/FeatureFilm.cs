using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    internal class FeatureFilm: Film
    {
        public override void GetInfo(TelevisionProgram program)
        {
            Console.WriteLine("Это Худ. Фильм");
            base.ToString();
        }
    }
}
