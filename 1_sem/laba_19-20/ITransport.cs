using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_lab;

namespace laba_19_20
{
    public interface IDostavka
    {
        void Dostavka();
    }
    public class Auto: IDostavka
    {
        public void Dostavka()
        {
            Console.WriteLine("dostavil posilky!");
        }
    }
}
