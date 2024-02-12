using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace laba4_5
{
    public class CustomCommand
    {
        private static RoutedUICommand pnvCommand;

        static CustomCommand()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.P, ModifierKeys.Alt, "Alt+P"));
            pnvCommand = new RoutedUICommand("PNV", "PNV", typeof(CustomCommand), inputs);

        }
        public static RoutedUICommand PnvCommand
        {
            get { return pnvCommand; }
        }

    }
}
