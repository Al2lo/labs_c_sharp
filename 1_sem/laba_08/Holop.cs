using Lab_Work;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{

    public class Holop: IMainFunctionForWorkers
    {
        public delegate void Message(string message);
        public delegate Holop Grade();
        public delegate void Func(string oldSring);

        public virtual event Grade? Turn_on;
        public virtual event Message? message;
        public virtual event Grade? Upgrade;
        public string type { get; set; }
        public string? nameOfWorker { get; set; }
        public int money { get; set; }

        public Holop()
        {

            this.Turn_on += LevelDown;
            this.Upgrade += LevelUp;
            this.message += DisplayMessage;
            type = "Holop";
            money = 0;
        }
        public virtual Worker LevelUp()
        {
            if (message != null)
            {
                message($"Level Up {nameOfWorker}");
            }

            Worker worker = new Worker() { nameOfWorker = this.nameOfWorker };
            message($"now YOU:\nType is: {worker.type}\nnName is: {worker.nameOfWorker}\nMoney: {worker.money}\n");
            return worker;
        }
        public virtual Holop LevelDown()
        {
            if (message != null)
            {
                message($"LevelDown {nameOfWorker}");
            }

            Holop holop = new Holop() {nameOfWorker = this.nameOfWorker };
            return holop;
        }

        public virtual Holop Work(Holop newWorker) 
        {
            money += 5;
            message($"{nameOfWorker} подметает двор\n{nameOfWorker} заработал 5р\n");
            if (money>=20)
            {
                 return Upgrade();
            }
            return newWorker;

        }
        public virtual Holop Buy(Holop newWorker)
        {
            money -= 10;
            message("Вы потратили 10");
            if (money <0)
            {
                return Turn_on();
            }

            return newWorker;

        }

        public void GetInfo() => message($"Type is: {type}\nName is: {nameOfWorker}\nMoney: {money}\n");

        public void DisplayMessage(string message) => Console.WriteLine(message);
    }
}
