using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    public class Worker: Holop
    {

        public override event Grade? Turn_on;
        public override event Message? message;
        public override event Grade? Upgrade;
        public Worker()
        {
            //this.Turn_on += LevelDown;
            //this.Upgrade += LevelUp;
            //this.message += DisplayMessage;
            money = 100;
            type = "Worker";
        }

        public override MainWorker LevelUp()
        {

            message("LevelUp\n");

            MainWorker worker = new MainWorker() {nameOfWorker = this.nameOfWorker };

            message($"now YOU:\nType is: {worker.type}\nnName is: {worker.nameOfWorker}\nMoney: {worker.money}\n");
            
            return worker;

        }
        public override Holop LevelDown()
        {
            message("LevelDown\n");

            Holop holop = new Holop() { nameOfWorker = this.nameOfWorker };

            message($"now YOU:\nType is: {holop.type}\nnName is: {holop.nameOfWorker}\nMoney: {holop.money}\n");

            return holop;

        }

        public override Worker Work(Holop newWorker)
        {
            money += 50;
            message($"{nameOfWorker} Охраняет Босса\n{nameOfWorker} заработал 50р\n");
            if (money >=200)
            {
                 return (Worker)Upgrade();

            }

            return (Worker)newWorker;

        }
        public override Holop Buy(Holop newWorker)
        {
            money -= 50;
            message("Вы потратили 50");
            if (money <= 50)
            {
                return Turn_on();
            }

            return (Worker)newWorker;

        }

    }
}

