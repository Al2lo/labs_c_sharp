using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba_8
{
    internal class Commander
    {
        MainWindow mainWindow;

        public Commander(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void Sort()
        {
            WorkWithBD.Sort(mainWindow.SortText.Text, mainWindow.Container);
            
        }

        public void Insert()
        {
            Window1 window1 = new Window1(-1);
            Airplane newAirplane = window1.ShowDialog();
            WorkWithBD.Insert(newAirplane);
            WorkWithBD.GetAll(mainWindow.Container);
        }

        public void Delete()
        {
            Window1 window = new Window1(-2);
            Airplane newAirplane = window.ShowDialog();
            WorkWithBD.Delete(newAirplane.id);
            WorkWithBD.GetAll(mainWindow.Container);
        }

        public void Update()
        {
            Window1 window = new Window1(mainWindow.Container.SelectedIndex);
            Airplane newAirplane = window.ShowDialog();
            WorkWithBD.Update(newAirplane);
            WorkWithBD.GetAll(mainWindow.Container);
        }

        public void GetZapros()
        {
            Window1 window1 = new Window1(-3);
            string zapros = window1.Show();
            WorkWithBD.GetZapros(zapros, mainWindow.Container);
        }
    }
}
