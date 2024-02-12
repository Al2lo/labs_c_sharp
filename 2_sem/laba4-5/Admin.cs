using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace laba4_5
{
    public class Admin
    {
        MainWindow windowMain;
        WorkWithBludsWindow windoSecond;
        public Admin(MainWindow window)
        {
            this.windowMain = window;
        }
        public Admin(WorkWithBludsWindow window)
        {
            this.windoSecond = window;
        }

        public void CreateBlud()
        {
            WorkWithBludsWindow workWithBludsWindow;
            if (windowMain.numberOfRedact != -1)
            {
                 workWithBludsWindow = new WorkWithBludsWindow();
            }
            else
            {
                workWithBludsWindow = new WorkWithBludsWindow(windowMain.bluds[windowMain.numberOfDeleteItem].name, windowMain.bluds[windowMain.numberOfDeleteItem].fullName, windowMain.bluds[windowMain.numberOfDeleteItem].type, windowMain.bluds[windowMain.numberOfDeleteItem].coast, windowMain.bluds[windowMain.numberOfDeleteItem].comment);

            }
            Bluds newBlud = workWithBludsWindow.ShowDialog();
            if (newBlud.coast == 0)
            {
                return;
            }
            windowMain.bluds.Add(newBlud);
            windowMain.index++;
            newBlud.index = windowMain.index;
            using (StreamWriter writer = new StreamWriter("writer.json"))
            {
               string ser =  JsonConvert.SerializeObject(newBlud);
                writer.WriteLine(ser);
            }
            vyvodOnWrapPanel(newBlud);
           
        }
        public void DeleteItem()
        {
            deleteOnWrapPanel();
            windowMain.bluds.Remove(windowMain.bluds[windowMain.numberOfDeleteItem]);
            if (windowMain.numberOfRedact == -1)
            {
                windowMain.RedactButtotn.Style = windowMain.TryFindResource("ButtonStyle") as Style;
            }
            else
            {
                windowMain.DeleteButton.Style = windowMain.TryFindResource("ButtonStyle") as Style;
            }
            foreach(var item in windowMain.bluds)
            {
                vyvodOnWrapPanel(item);
            }
            windowMain.numberOfDeleteItem = 0;
        }
        public void vyvodOnWrapPanel(Bluds blud)
        {
            Grid grid = new Grid();
            grid.Background = new SolidColorBrush(Color.FromRgb(194,194,196));
            grid.Background.Opacity = 0.5;
            Border border = new Border();
            border.BorderThickness = new Thickness(2);
            border.BorderBrush = Brushes.Black;
            Grid newGrid = new Grid();
            Image image = new Image();
            image.Stretch = Stretch.UniformToFill;
            if (blud.pathToImage == null)
            {
                blud.pathToImage = "D:\\ООП\\2_sem\\laba4-5\\defaultImage.png";
            }
            image.Source = new BitmapImage(new Uri(blud.pathToImage));
            newGrid.Children.Add(image);
            newGrid.Children.Add(grid);
            newGrid.Children.Add(border);
            newGrid.Children[1].Visibility = Visibility.Hidden;
            image.VerticalAlignment = VerticalAlignment.Top;

            newGrid.Margin = new Thickness(4, 4, 4, 4);
            newGrid.MouseDown += windowMain.MouseDownOnGrid;
            newGrid.MouseMove += windowMain.MouseOverOnGrid;
            newGrid.MouseLeave += windowMain.MouseLeaveOnGrid;
            windowMain.WrapPanel.Children.Add(newGrid);
        }
        public void RedactBlud()
        {

            this.CreateBlud();
            this.DeleteItem();
            windowMain.numberOfRedact = 0;
        }
        public void VisiblItem()
        {

        }
        public void Search()
        {
                deleteOnWrapPanel();
                foreach (var item in windowMain.bluds)
                {
                    if (windowMain.SearchBox.Text == "all")
                    {
                        vyvodOnWrapPanel(item);
                    }
                    if (item.fullName == windowMain.SearchBox.Text)
                    {
                        vyvodOnWrapPanel(item);
                    }
                }
        }
        public void Category()
        {
            deleteOnWrapPanel();
            foreach (var item in windowMain.bluds)
            {
                if (windowMain.SearchBox.Text == "all")
                {
                    vyvodOnWrapPanel(item);
                }
                if (item.type == windowMain.SearchBox.Text)
                {
                    vyvodOnWrapPanel(item);
                }
            }
        }
        public void Coast()
        {
            deleteOnWrapPanel();
            foreach (var item in windowMain.bluds)
            {
                if (windowMain.SearchBox.Text == "all")
                {
                    vyvodOnWrapPanel(item);
                }
                if (item.coast ==Int32.Parse(windowMain.SearchBox.Text))
                {
                    vyvodOnWrapPanel(item);
                }
            }
        }
        public void GetInfoAboutBlud()
        {
            string agrid = "";
            if (windowMain.bluds[windowMain.numberOfInfoItem].ingtidients != null)
            {
                foreach (var item in windowMain.bluds[windowMain.numberOfInfoItem].ingtidients)
                {
                    agrid += item.nameOfIngridient + ",\n";
                }
            }
            MessageBox.Show("name: " + windowMain.bluds[windowMain.numberOfInfoItem].name + "\nfullname: " + windowMain.bluds[windowMain.numberOfInfoItem].fullName + "\ncoast: " + windowMain.bluds[windowMain.numberOfInfoItem].coast + "\ningridients: " + agrid);
        }
        public void deleteOnWrapPanel()
        {
            windowMain.WrapPanel.Children.Clear();
        }
        public void DeleteBlud()
        {
            var newList = from item in windowMain.bluds where item.index != windowMain.numberOfDeleteItem select item;
            windowMain.bluds = (List<Bluds>)newList;
        }
        public void AddPhoto()
        {
            try
            {
                Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog();
                bool? resoponse = fileDialog.ShowDialog();

                if (resoponse is true)
                {
                    windoSecond.pathToImage = fileDialog.FileName;
                    windoSecond.ImageBox.Source = new BitmapImage(new Uri(fileDialog.FileName));
                    windoSecond.ImageBox.Stretch = Stretch.UniformToFill;
                    windoSecond.ImageBox.HorizontalAlignment = HorizontalAlignment.Center;
                    windoSecond.ImageBox.VerticalAlignment = VerticalAlignment.Center;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Filter()
        {
            deleteOnWrapPanel();
            foreach (var item in windowMain.bluds)
            {
                if (windowMain.SearchBox.Text == "all")
                {
                    vyvodOnWrapPanel(item);
                }
                if (item.name == windowMain.SearchBox.Text)
                {
                    vyvodOnWrapPanel(item);
                }
            }
        }

        //public void SaveState()
        //{
        //    MainWindow.mementoUndo.history.Push(windowMain.bluds);
        //}
        //public void UndoState()
        //{
        //    MainWindow.mementoRedo.history.Push(windowMain.bluds);
        //    if (MainWindow.mementoUndo.history.Count == 1)
        //    {
        //        windowMain.bluds = null;
        //        return;
        //    }

        //    MainWindow.mementoUndo.history.Pop();
        //    windowMain.bluds = MainWindow.mementoUndo.history.Pop();
        //}
        //public void RedoState()
        //{
        //    if (MainWindow.mementoRedo.history.Count == 0)
        //    {
        //        windowMain.bluds = null;
        //        return;
        //    }
        //    MainWindow.mementoUndo.history.Push(windowMain.bluds);
        //    windowMain.bluds = MainWindow.mementoRedo.history.Pop();

        //}
    }
}
