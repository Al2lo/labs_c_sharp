using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    internal interface IMainFunctionForWorkers
    {
        public Worker LevelUp();
        public Holop LevelDown();
        public Holop Work(Holop newWorker);

        public void GetInfo();
    }
}
