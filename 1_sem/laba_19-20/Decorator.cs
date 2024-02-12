using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    public interface IMoveable
    {
        void Move();
    }
    class PetrolMove : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }

    public abstract class Car
    {
        public  string typeOfCar { get; set; }
        public int maxWeight { get; set; }
        public (int, int) size { get; set; }
        public Car(string typeOfCar, int maxWeight, (int, int) size,IMoveable moveable)
        {
            this.typeOfCar = typeOfCar;
            this.maxWeight = maxWeight;
            this.size = size;
            Movable = moveable;
            
        }
        public IMoveable Movable { get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }

    class HeavytCar : Car
    {
        public HeavytCar(int maxWeight, (int, int) size) : base("Грузовая", maxWeight, size, new PetrolMove())
        {}
    }
    class LowWeighttCar : Car
    {
        public LowWeighttCar(int maxWeight, (int, int) size) : base("Легковая", maxWeight, size, new PetrolMove())
        { }
    }
    class MiniVenCar : Car
    {
        public MiniVenCar(int maxWeight, (int, int) size) : base("MiniVen", maxWeight, size, new PetrolMove())
        { }
    }
    public abstract class CarDecorator: Car
    {
        protected Car car;
        public CarDecorator(string typeOfCar, int maxWeight, (int, int) size, Car car) : base(typeOfCar, maxWeight, size, new PetrolMove())
        {
            this.car = car;
        }
    }

    public class PricepCar : CarDecorator
    {
        public PricepCar(Car car) : base(car.typeOfCar + " with pricep", car.maxWeight, car.size, car)
        { }
    }

}
