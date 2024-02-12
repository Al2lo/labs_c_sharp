using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace laba_8
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICommand command;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Loaded_Window(object sender, RoutedEventArgs e)
        {
            WorkWithBD.GetAll(Container);
        }

        private void Click_Insert(object sender, RoutedEventArgs e)
        {
            Commander commander = new Commander(this);
            command = new CommandInsert(commander);
            command.Execute();
        }

        private void Click_Delete(object sender, RoutedEventArgs e)
        {
            Commander commander = new Commander(this);
            command = new CommandDelete(commander);
            command.Execute();
        }

        private void Click_Update(object sender, RoutedEventArgs e)
        {
            Commander commander = new Commander(this);
            command = new CommandUpdate(commander);
            command.Execute();
        }

        private void ZaprosButtonClick(object sender, RoutedEventArgs e)
        {
            Commander commander = new Commander(this);
            command = new CommandZapros(commander);
            command.Execute();
        }
        private void TextChangeFilter(object sender, TextChangedEventArgs e)
        {

        }
        private void SorttextClear(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }
        private void GoSort(object sender, RoutedEventArgs e)
        {
            Commander commander = new Commander(this);
            command = new CommandSort(commander);
            command.Execute();
        }

    }
}
