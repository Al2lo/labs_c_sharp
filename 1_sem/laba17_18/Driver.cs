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

        internal void Dostavka()
        {
            Console.WriteLine($"{this.name} dostavil posilky!");
            GetInfoAboutDrivera(this);
        }
        internal void GetInfoAboutDrivera(Driver driver)
        {
            Console.WriteLine("name: " + driver.name + "\nid: " + driver.id + "\ntypeCar: " + driver.car.typeOfCar + "\nFree: " + driver.free);
        }

        public override Driver Clone()
        {
            return new Driver(this.car.typeOfCar,this.car.maxWeight, (this.car.size.Item1, this.car.size.Item2),this.id,this.name);    
        }

    }
}
