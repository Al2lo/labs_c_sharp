using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    public class MainWorker: Worker
    {
        public override event Grade? Turn_on;
        public override event Grade? Upgrade;
        public override event Message? message;
        public MainWorker()
        {
            //this.Turn_on += LevelDown;
            //this.Upgrade += LevelUp;
            //this.message += DisplayMessage;
            money = 1000;
            type = "MainWorekr";
        
        }
        sealed public override Boss LevelUp()
        {
            message("LevelUp:\n");

            Boss boss = new Boss() { nameOfWorker = this.nameOfWorker };
            message($"now YOU:\nType is: {boss.type}\nnName is: {boss.nameOfWorker}\nMoney: {boss.money}\n");

            return boss;

        }

        public override Worker LevelDown()
        {
            message("LevelDown\n");

            Worker worker = new Worker() { nameOfWorker = this.nameOfWorker };

            message($"now YOU:\nType is: {worker.type}\nnName is: {worker.nameOfWorker}\nMoney: {worker.money}\n");

            return worker;

        }
        public override MainWorker Work(Holop newWorker)
        {
 
            money += 100;
            message($"{nameOfWorker} Руководит охраной Босса\n{nameOfWorker} заработал 100р\n");
            if (money >= 400)
            {
                return (MainWorker)Upgrade();

            }
            
            return (Boss)newWorker;
            
        }
        public override Worker Buy(Holop newWorker)
        {
            money -= 500;
            message("Вы потратили 500");
            if (money < 0)
            {
                return (Worker)Turn_on();
            }

            return (MainWorker)newWorker;

        }

    }
}
