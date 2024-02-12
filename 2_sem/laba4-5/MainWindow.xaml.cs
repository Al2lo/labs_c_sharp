using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace laba4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string str = "";
        string str1 = "";
        Admin ad;
        private int numberStyle = 0;
        public int numberOfRedact;
        public int numberOfInfoItem;
        public int numberOfDeleteItem;
        ICommand _command;
        public Memento mementoUndo = new Memento();
        public  Memento mementoRedo = new Memento();
        public int index = 0;
        public List<Bluds> bluds = new List<Bluds>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin(this);
            mementoUndo.history.Push(bluds);
            _command = new CommnadCreateBlud(admin);
            _command.Execute();
            
        }

        private void Search_Double_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";
            userControl1.MouseDoubleClick += UserControl1_Loaded;
            userControl2.MouseDoubleClick += UserControl1_Loaded;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin(this);
            _command = new CommandFilter(admin);
            _command.Execute();
        }
        internal void MouseOverOnGrid(object sender, MouseEventArgs e)
        {
            Grid grid = new Grid();
            grid = (Grid)sender;
            grid.Children[1].Visibility = Visibility.Visible;
        }
        internal void MouseLeaveOnGrid(object sender, MouseEventArgs e)
        {
            Grid grid = new Grid();
            grid = (Grid)sender;
            grid.Children[1].Visibility = Visibility.Hidden;
        }
        internal void MouseDownOnGrid(object sender, MouseButtonEventArgs e)
        {
            Admin admin = new Admin(this);
            if (numberOfDeleteItem == -2)
            {
                numberOfDeleteItem = WrapPanel.Children.IndexOf((Grid)sender);
                _command = new CommandDeleteItem(admin);
                _command.Execute();
            }
            else if(numberOfRedact == -1)
            {
                numberOfDeleteItem = WrapPanel.Children.IndexOf((Grid)sender);
                _command = new CommandRedact(admin);
                _command.Execute();
            }
            else
            {
                numberOfInfoItem = WrapPanel.Children.IndexOf((Grid)sender);
                _command = new CommandInfo(admin);
                _command.Execute();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin(this);
            _command = new CommandSearch(admin);
            _command.Execute();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin(this);
            _command = new CommandCategory(admin);
            _command.Execute();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin(this);
            _command = new CommandCoast(admin);
            _command.Execute();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ad = new Admin(this);
            if (numberOfDeleteItem != -2)
            {
                numberOfDeleteItem = -2;
                DeleteButton.Style = this.TryFindResource("ButtonStyleDown") as Style;
            }
            else
            {
                numberOfDeleteItem = 0;
                DeleteButton.Style = this.TryFindResource("ButtonStyle") as Style;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ad = new Admin(this);
            if (numberOfRedact != -1)
            {
                numberOfRedact = -1;
                RedactButtotn.Style = this.TryFindResource("ButtonStyleDown") as Style;
            }
            else
            {
                numberOfRedact = 0;
                RedactButtotn.Style = (Style)this.TryFindResource("ButtonStyle");
            }

        }

        private void Button_click_ChengeStyle(object sender, RoutedEventArgs e)
        {
            if (numberStyle == 0)
            {
                var uri = new Uri("Dictionary1.xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                // очищаем коллекцию ресурсов приложения
                Application.Current.Resources.Clear();
                // добавляем загруженный словарь ресурсов
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                numberStyle = 1;
            }
            else
            {
                var uri = new Uri("Dictionary2.xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                // очищаем коллекцию ресурсов приложения
                Application.Current.Resources.Clear();
                // добавляем загруженный словарь ресурсов
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                numberStyle = 0;
            }
        }

        private void UndoButtonClick(object sender, RoutedEventArgs e)
        {
            ad = new Admin(this);
            mementoRedo.history.Push(bluds);
            ad.deleteOnWrapPanel();
            if (mementoUndo.history.Count == 1 || mementoUndo.history.Count == 0)
            {
                bluds = new List<Bluds>();
                return;
            }

            mementoUndo.history.Pop();
            bluds = mementoUndo.history.Pop();
            ad = new Admin(this);
            foreach (var item in bluds)
            {
                ad.vyvodOnWrapPanel(item);
            }
        }
        private void RedoButtonCLick(object sender, RoutedEventArgs e)
        {
            ad = new Admin(this);
            ad.deleteOnWrapPanel();
            if (mementoRedo.history.Count == 0)
            {
                bluds = new List<Bluds>();
                return;
            }
            bluds = mementoRedo.history.Pop();
            mementoUndo.history.Push(bluds);

            foreach (var item in bluds)
            {
                ad.vyvodOnWrapPanel(item);
            }
        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(userControl1.Background.ToString());
        }

        private void UserControl1_Loaded_1(object sender, RoutedEventArgs e)
        {
        }

        private void userControl1_Loaded_2(object sender, RoutedEventArgs e)
        {

        }
        private void ClickOv(object sender, MouseButtonEventArgs e)
        {
            Grid grid = (Grid)sender;
            str += sender.ToString() + grid.Name + "\n";
            if (grid.Name == "grid2")
            {
                MessageBox.Show(str);
                str = "";
            }
        }
        private void tynnel(object sender, MouseButtonEventArgs e)
        {

            str1 += sender.ToString() + "\n";
            if (sender.ToString() == but.ToString())
            {
                MessageBox.Show(str1);
                str1 = "";
            }
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("new command");
        }
    }

}
    
