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
using System.Windows.Shapes;

namespace laba4_5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WorkWithBludsWindow : Window
    {
        ICommand _command;
        public string pathToImage;


        public new Bluds ShowDialog()
        {
            base.ShowDialog();

            if (Coast.Text == "")
            {
                return new Bluds(TypeBlock.Text, FullName.Text, CommentBlock.Text, NameBlock.Text, 0, ingtidients, pathToImage);
            }
            return new Bluds(TypeBlock.Text, FullName.Text, CommentBlock.Text, NameBlock.Text, Int32.Parse(Coast.Text), ingtidients, pathToImage);
        }

        List<Ingtidients> ingtidients;
        public WorkWithBludsWindow(string name, string fullname, string type, int coast, string comment)
        {
            InitializeComponent();
            NameBlock.Text = name;
            FullName.Text = fullname;
            Coast.Text = coast.ToString();
            TypeBlock.Text = type;
            CommentBlock.Text = comment;
        }
        public WorkWithBludsWindow()
        {
            InitializeComponent();
        }

        private void Name_Double_Click(object obj, RoutedEventArgs e)
        {
            NameBlock.Text = "";
        }
        private void FullName_Double_Click(object obj, RoutedEventArgs e)
        {
            FullName.Text = "";
        }
        private void Type_Double_Click(object obj, RoutedEventArgs e)
        {
            TypeBlock.Text = "";
        }
        private void Coast_Double_Click(object obj, RoutedEventArgs e)
        {
            Coast.Text = "";
        }
        private void Comment_Double_Click(object obj, RoutedEventArgs e)
        {
            CommentBlock.Text = "";
        }

        private void Click_Add_Ingridient(object obj,RoutedEventArgs e)
        {
            WindowIngidients windowIngidients = new WindowIngidients();
            ingtidients = windowIngidients.ShowDialog();

        }
        private void Click_Close_Create_Bludo(object obj, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Click_Add_Photo(object obj, RoutedEventArgs e)
        {
            Admin admin = new Admin(this);
            _command = new CommnadCreatPhoto(admin);
            _command.Execute();
        }
    }
    
}
