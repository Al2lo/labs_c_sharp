using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laaba_2
{
    partial class Phone
    {
        static void Bar(ref int timeOfInCitySpeak, out int timeOfOutCitySpeak)
        {
            timeOfInCitySpeak++;
            timeOfOutCitySpeak = 5;
        }
    }
}
