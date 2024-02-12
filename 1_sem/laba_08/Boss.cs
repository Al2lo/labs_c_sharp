using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    public class Boss: MainWorker
    {
        public override event Grade? Turn_on;
        public override event Grade? Upgrade;
        public override event Message? message;
        public Boss()
        {
            //this.Turn_on += LevelDown;
            //this.Upgrade += LevelUp;
            //this.message += DisplayMessage;
            money = 100000;
            type = "BOSS";

        }
        public override MainWorker LevelDown()
        {
            if (message != null)
            {
                message($"LevelDown {nameOfWorker}");
            }

            MainWorker mainWorker = new MainWorker() { nameOfWorker = this.nameOfWorker };

            message($"now YOU:\nType is: {mainWorker.type}\nnName is: {mainWorker.nameOfWorker}\nMoney: {mainWorker.money}\n");

            return mainWorker;
        }

        sealed public override Boss Work(Holop newWorker)
        {
            money += 10000;
            Console.WriteLine("Ваши сотрудники отжали завод\nВаш кошелек увеличился на 10000");
            return (Boss)newWorker;
        }
        public override MainWorker Buy(Holop newWorker)
        {
            money -= 500000;
            message("Вы потратили 50000");
            if (money < 0)
            {
                return (MainWorker)Turn_on();
            }

            return (Boss)newWorker;

        }
    }
}
