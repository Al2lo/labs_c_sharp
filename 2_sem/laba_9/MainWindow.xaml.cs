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

namespace laba_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserRepositoriy repositoty;
        public MainWindow()
        {
            InitializeComponent();
            UserContext context = new UserContext();
            repositoty = new UserRepositoriy(context);
        }

        private void Loadedd(object sender,RoutedEventArgs e)
        {
            Container.ItemsSource = repositoty.GetAll().ToList<User>();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Clean(object sender, RoutedEventArgs e)
        {
            textSearchOrFilter.Text = "";
        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }
        private void Change_Item(object sender, RoutedEventArgs e)
        {
            User user = Container.SelectedItem as User;
            if (Container.SelectedItem == null)
            {
                this.Text_id.Text ="";
                this.Text_Name.Text = "";
                this.Text_Age.Text = "";
                return;
            }
            this.Text_id.Text = user.Id.ToString();
            this.Text_Name.Text = user.Name.ToString();
            this.Text_Age.Text = user.Age.ToString();
            //if (user.Work.Id == null)
            //{

            //}
            //this.Text_Work_id.Text = user.Work.Id.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            repositoty.Insert();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            repositoty.Delete();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            repositoty.Update();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            repositoty.Search();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            repositoty.Filter();
        }
    }
}
