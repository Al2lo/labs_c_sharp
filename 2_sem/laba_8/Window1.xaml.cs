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

namespace laba_8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int type;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(int i)
        {
            InitializeComponent();
            type = i;
            this.uniformGrid.Width = 200;
            this.uniformGrid.Height = 360;
            if (i == -1)
            {
                this.uniformGrid.Rows = 8;
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter id" , FontSize = 18, Margin = new Thickness(0,10,0,0)});
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter type", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter model", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter free place", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter data create", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter max weight", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter last osmotr", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() {Text = "Enter image", FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.Title.Text = "OPERATION INSERT";
            }
            if (i == -2)
            {
                this.Height = 400;
                uniformGrid.Children.Add((new TextBox() { Text = "Enter id", FontSize = 18,Height = 50}));
                this.Title.Text = "OPERATION DELETE";
            }
            if(i == -3)
            {
                this.uniformGrid.Children.Add(new TextBox() { Text = "Enter id", FontSize = 18, Height = 50 });
                this.Title.Text = "OPERATION ZAPROS";
            }
            if (i >= 0)
            {
                this.uniformGrid.Rows = 8;
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].id.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].type.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].model.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].freePlace.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].dataCreate.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].maxWeight.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].dateLastOsm.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.uniformGrid.Children.Add(new TextBox() { Text = WorkWithBD.airplanes[i].img.ToString(), FontSize = 18, Margin = new Thickness(0, 10, 0, 0) });
                this.Title.Text = "OPERATION INSERT";
            }
        }

        public new Airplane ShowDialog()
        {
            
            base.ShowDialog();
            TextBox id = (TextBox)uniformGrid.Children[0];
            if (type >= -1 )
            {
                TextBox type = (TextBox)uniformGrid.Children[1];
                TextBox model = (TextBox)uniformGrid.Children[2];
                TextBox freePlace = (TextBox)uniformGrid.Children[3];
                TextBox dataCreate = (TextBox)uniformGrid.Children[4];
                TextBox maxweight = (TextBox)uniformGrid.Children[5];
                TextBox dataLastOsm = (TextBox)uniformGrid.Children[6];
                TextBox image = (TextBox)uniformGrid.Children[7];
                return new Airplane(Int32.Parse(id.Text), type.Text, model.Text, Int32.Parse(freePlace.Text), dataCreate.Text, Int32.Parse(maxweight.Text), dataLastOsm.Text, image.Text);
            }
            if (type == -2)
            {
                return new Airplane(Int32.Parse(id.Text));
            }
            return null;

        }
        public new string Show()
        {
            base.ShowDialog();
            TextBox text = (TextBox)uniformGrid.Children[0];
            return text.Text;
        }

        private void Click_GO(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
