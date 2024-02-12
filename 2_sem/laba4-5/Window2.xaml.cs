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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class WindowIngidients : Window
    {
        List<Ingtidients> ingtidients = new List<Ingtidients>();
        public WindowIngidients()
        {
            InitializeComponent();
        }
        public new List<Ingtidients> ShowDialog()
        {
            base.ShowDialog();

            return ingtidients;
        }
        private void Name_Of_Ingridient_Mouse_Double_Click(object obj, EventArgs e)
        {
            Name_Of_Ingridient.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach (var item in ingtidients)
            {
                str += item.nameOfIngridient + "\n";
            }
            MessageBox.Show("ingridients:\n" + str);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ingtidients.Add(new Ingtidients(Name_Of_Ingridient.Text));
            Name_Of_Ingridient_Mouse_Double_Click(sender,e);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
