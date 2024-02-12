using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_04
{
    internal class ErrorYearOfCreate: Exception
    {
        private int _year;
        protected ErrorYearOfCreate() : base()
        {

        }

        public ErrorYearOfCreate(int value) : base($"Год не может быть больше 2022 {value}")
        {
            _year = value;
        }

        public int Yeat
        {
            get => _year;
        }



    }
}

