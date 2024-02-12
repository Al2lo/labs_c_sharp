using laba_19_20;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    public class Dispatcher : AbstractZakaz
    {
        private static readonly object locker = new object(); 
        private static Dispatcher _instance;

        private Dispatcher()
        {
        }

        public static Dispatcher GetInstance()
        {
            if (_instance == null)
            {
                lock(locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Dispatcher();
                    }
                }
            }
            return _instance;
        }

        public string name = "dispatcher";
       Driver []freeDrivers = new Driver[10];
        private static int countt = 0;

        public void GetFreeDrivers(Driver driver)
        {

                if (driver.free)
                {
                    freeDrivers[countt] = driver;
                    countt++;
                }
            
        }

        public override void GiveZakaz((string, int, int, int) needCar)
        {
            foreach (var driver in freeDrivers)
            {
                int i  = 0;
                i++;
                if (driver == null)
                {
                    throw new Exception("We dont have cars");
                }
                if ((driver.car.size.Item1 >= needCar.Item3 && driver.car.size.Item2 >= needCar.Item4) && driver.car.typeOfCar == needCar.Item1 && driver.car.maxWeight >= needCar.Item2)
                {
                    Console.WriteLine("zakaz priniat");
                    Auto auto = new Auto();
                    driver.Dostavka(auto);
                    driver.GetInfoAboutDrivera(driver);
                    break;
                }
                else if (i == 10)
                {
                    Console.WriteLine("Dont free cars");
                }
            }
           
        }
    }
}
