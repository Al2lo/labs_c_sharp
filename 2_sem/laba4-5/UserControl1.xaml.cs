using Newtonsoft.Json.Linq;
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

namespace laba4_5
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static readonly RoutedEvent clickEvent;
        public static FrameworkPropertyMetadata metadata;
        public static DependencyProperty dependencyProperty;
        static UserControl1()
        {
            clickEvent = EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserControl2));
            metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(correct);
;            dependencyProperty = DependencyProperty.RegisterAttached("Background", typeof(string), typeof(UserControl1),metadata);
        }
        public UserControl1()
        {
            InitializeComponent();
        }

 
        private static string correct(DependencyObject obj, object value)
        {
            try
            {
                int a = Int32.Parse((string)value);
                MessageBox.Show("error is not correct");
                return "";
            }
            catch
            {
                return (string)value;
            }
        }
        public new string Background

        {
            get
            {
                return (string)GetValue(dependencyProperty);
            }
            set
            {
                SetValue(dependencyProperty, value);
            }
        }
        

        public event RoutedEventHandler Clickov
        {
            add
            {
                base.AddHandler(UserControl1.clickEvent, value);
            }
            remove
            {
                base.RemoveHandler(UserControl1.clickEvent, value);
            }
        }
    }


}
