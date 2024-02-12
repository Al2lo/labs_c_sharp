using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    public abstract class AbstractZakaz
    {
        public abstract void GiveZakaz((string, int, int, int) needCar);
    }
}
