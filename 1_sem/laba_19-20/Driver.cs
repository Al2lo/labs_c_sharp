using laba_19_20;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    public class Driver: Prototype
    {
        public override string name { get; set; }
        public override bool free { get; set; }
        public override int id { get; set; }

        public Driver(string typeOfCar, int maxWeight, (int, int) size) : base(typeOfCar, maxWeight,size)
        { }
        public Driver(string typeOfCar,int maxWeight,(int,int) size, int id, string nam) : base(typeOfCar,maxWeight,size,id,nam)
        {
        }
        public Driver(Car car, int id, string nam) : base(car.typeOfCar, car.maxWeight, car.size, id, nam)
        {
        }
        
        public void Dostavka(IDostavka dostavka)
        {
            dostavka.Dostavka();
        }
        public void GetInfoAboutDrivera(Driver driver)
        {
            Console.Write("name: " + driver.name + "\nid: " + driver.id + "\ntypeCar: " + driver.car.typeOfCar + "\nFree: " + driver.free + "\nmoveable: ");
            driver.car.Movable.Move();
        }
        public override Driver Clone()
        {
            return new Driver(this.car.typeOfCar,this.car.maxWeight, (this.car.size.Item1, this.car.size.Item2),this.id,this.name);    
        }

        public DriverMemento SaveState()
        {
            return new DriverMemento(this.name, this.id, this.free);
        }
        public void RestoreState(DriverMemento driverMemento)
        {
            this.free = driverMemento.free;
            this.name = driverMemento.name;
            this.id = driverMemento.id;
        }
    }

    public class DriverMemento
    {
        public string name { get; set; }
        public int id { get; set; }
        public bool free { get; set; }

        public DriverMemento(string name, int id, bool free)
        {
            this.name = name;
            this.id = id;
            this.free = free;
        }
    }

    public class DriverHistory
    {
        public Stack<DriverMemento> driverHistory { get; private set; }

        public DriverHistory()
        {
            driverHistory = new Stack<DriverMemento>();
        }
    }
}
