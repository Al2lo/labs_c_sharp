using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4_5
{
    interface ICommand
    {
        void Execute();
        void Undo();

    }
    internal class CommnadCreateBlud : ICommand
    {
        Admin admin;
        public CommnadCreateBlud(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.CreateBlud();
        }
        public void Undo()
        {

        }
    }
    internal class CommandVisibilityElem : ICommand
    {
        Admin admin;
        public CommandVisibilityElem(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.CreateBlud();
        }
        public void Undo()
        {

        }
    }
    internal class CommnadCreatPhoto : ICommand
    {
        Admin admin;
        public CommnadCreatPhoto(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.AddPhoto();
        }
        public void Undo()
        {

        }
    }
    internal class CommandFilter : ICommand
    {
        Admin admin;
        public CommandFilter(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.Filter();
        }
        public void Undo()
        {

        }
    }
    internal class CommandDeleteItem : ICommand
    {
        Admin admin;
        public CommandDeleteItem(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.DeleteItem();
        }
        public void Undo()
        {

        }
    }
    internal class CommandRedact : ICommand
    {
        Admin admin;
        public CommandRedact(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.RedactBlud();
        }
        public void Undo()
        {

        }
    }


    internal class CommandInfo : ICommand
    {
        Admin admin;
        public CommandInfo(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.GetInfoAboutBlud();
        }
        public void Undo()
        {

        }
    }
    internal class CommandSearch : ICommand
    {
        Admin admin;
        public CommandSearch(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.Search();
        }
        public void Undo()
        {

        }
    }
    internal class CommandCategory : ICommand
    {
        Admin admin;
        public CommandCategory(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.Category();
        }
        public void Undo()
        {

        }
    }
    internal class CommandCoast : ICommand
    {
        Admin admin;
        public CommandCoast(Admin admin)
        {
            this.admin = admin;
        }

        public void Execute()
        {
            admin.Coast();
        }
        public void Undo()
        {

        }
    }
}
