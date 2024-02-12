using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_04
{
    internal class ErrorOfTime: Exception
    {
        int _time;
        protected ErrorOfTime() : base()
        {

        }

        public ErrorOfTime(int value) : base($"Время не может быть отрицательным {value}")
        {
            _time = value;
        }

        public int Name
        {
            get => _time;
        }



    }
}

