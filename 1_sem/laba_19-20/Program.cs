using laba_19_20;
using System;

namespace Work_lab
{
    public class Program
    {
        interface ICommand
    {
        public abstract void Execute((string, int, int, int) needCar);
        public abstract void Undo();
    }

    class ConcreteCommand : ICommand
    {
        Client client;
        public ConcreteCommand(Client r)
        {
            this.client = r;
        }

        public void Execute((string, int, int, int) needCar)
        {
            client.GiveZakaz(needCar);
        }
        public void Undo()
        {
            Action action = () => { Console.WriteLine("zakaz otmenen"); };
        }
    }

        public static void Main(string[] argv)
        {
            try
            {
                Car car = new HeavytCar(18, (5, 5));
                Driver driver = new Driver(car, 1, "kfd");
                Client client = new Client();
                ConcreteCommand concrete = new ConcreteCommand(client) ;
                concrete.Execute(("Грузовая", 12, 3, 4));
                DriverHistory history = new DriverHistory();
                history.driverHistory.Push(driver.SaveState());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}