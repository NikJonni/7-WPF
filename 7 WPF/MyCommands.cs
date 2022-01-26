using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _7_WPF
{
    internal class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }// команда-свойство этоого класса типа RoutedCommand
        static MyCommands()//конструктор самый простой
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Exit","Exit", typeof(MyCommands),inputs);
        }
    }
}
