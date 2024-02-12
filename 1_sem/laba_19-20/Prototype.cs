﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Work_lab.Driver;

namespace Work_lab
{
    public abstract class Prototype
    {

        public Car car;
        public abstract string name { get; set; }
        public abstract bool free { get; set; }
        public abstract int id { get; set; }

        int countt = 0;
        public Driver[] drivers = new Driver[10];

        public Prototype(string typeOfCar, int maxWeight, (int, int) size)
        {
            if (typeOfCar == "Грузовая")
            {
                this.car = new HeavytCar(maxWeight, size);
            }
            if (typeOfCar == "Легковая")
            {
                this.car = new LowWeighttCar(maxWeight, size);
            }
            if (typeOfCar == "MiniVen")
            {
                this.car = new MiniVenCar(maxWeight, size);
            }
        }
        public Prototype(string typeOfCar, int maxWeight, (int, int) size, int id, string nam)
        {
            if (typeOfCar == "Грузовая")
            {
                this.car = new HeavytCar(maxWeight, size);
            }
            if (typeOfCar == "Легковая")
            {
                this.car = new LowWeighttCar(maxWeight, size);
            }
            if (typeOfCar == "MiniVen")
            {
                this.car = new MiniVenCar(maxWeight, size);
            }
            if (typeOfCar == "MiniVen with pricep")
            {
                this.car = new PricepCar(new MiniVenCar(maxWeight, size));
            }
            if (typeOfCar == "Грузовая with pricep")
            {
                this.car = new PricepCar(new HeavytCar(maxWeight, size));
            }
            if (typeOfCar == "Легковая with pricep")
            {
                this.car = new PricepCar(new LowWeighttCar(maxWeight, size));
            }
            this.name = nam;
            this.id = id;
            add(typeOfCar, maxWeight, size, id, nam);
            Dispatcher dispatcher = Dispatcher.GetInstance();
            dispatcher.GetFreeDrivers(drivers[countt]);
        }
        private void add(string typeOfCar, int maxWeight, (int, int) size, int id, string nam)
        {
            drivers[countt] = new Driver(typeOfCar, maxWeight, size);
            drivers[countt].name = nam;
            drivers[countt].free = true;   
            drivers[countt].id = id;
            drivers[countt].car = this.car;
        }


        public abstract  Prototype Clone();


    }
}
