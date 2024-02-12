using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    internal interface ICommand
    {
        void Execute();
    }


    internal class CommandInsert:ICommand
    {
        Commander _commander;

        public CommandInsert(Commander commander)
        {
            _commander = commander;
        }
        public void Execute()
        {
            _commander.Insert();
        }
    }

    internal class CommandSort : ICommand
    {
        Commander _commander;

        public CommandSort(Commander commander)
        {
            _commander = commander;
        }
        public void Execute()
        {
            _commander.Sort();
        }
    }

    internal class CommandDelete : ICommand
    {
        Commander _commander;

        public CommandDelete(Commander commander)
        {
            _commander = commander;
        }
        public void Execute()
        {
            _commander.Delete();
        }
    }

    internal class CommandUpdate : ICommand
    {
        Commander _commander;

        public CommandUpdate(Commander commander)
        {
            _commander = commander;
        }
        public void Execute()
        {
            _commander.Update();
        }
    }

    internal class CommandZapros : ICommand
    {
        Commander _commander;

        public CommandZapros(Commander commander)
        {
            _commander = commander;
        }
        public void Execute()
        {
            _commander.GetZapros();
        }
    }


}
