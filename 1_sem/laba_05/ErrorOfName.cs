using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    internal class ErrorOfName : Exception
    {
        string? _name;

        protected ErrorOfName() : base()
        {

        }

        public ErrorOfName(string? value) : base($"What is it.Why is not correct {value}")
        {
            _name = value;
        }

        public string? Name
        {
            get => _name;
        }



    }
}
