using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    public class Logger
    {
        public void LoggerConsole(Exception e)
        {
            Console.WriteLine($"{DateTime.Now}, INFO: {e.Message}");

        }

        public void LoggerFile(Exception e)
        {
            using (StreamWriter stream = new StreamWriter("Logger.txt",true))
            {
                stream.WriteLine($"{DateTime.Now}, INFO: {e.Message}");
            }
        }

    }
}
