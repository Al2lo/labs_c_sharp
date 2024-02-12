using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    internal class Client:AbstractZakaz
    {
        Dispatcher dispatcher = Dispatcher.GetInstance();
        public string name { get; set; }

        public override void GiveZakaz((string, int, int, int) needCar)
        {
            dispatcher.GiveZakaz(needCar);
        }

    }
}
