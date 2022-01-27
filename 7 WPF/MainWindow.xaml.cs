using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace _7_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*Задание 3*/
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fonSize = ((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                double fontSize1 = Convert.ToDouble(fonSize);
                textBox.FontSize = fontSize1;
            }
        }
        private void ButtonWeight_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else
                textBox.FontWeight = FontWeights.Normal;
        }

        private void ButtonItalic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
                textBox.FontStyle = FontStyles.Normal;

        }

        private void ButtonUnderline_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
                textBox.TextDecorations = null;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }
        /*Задание 5*/
        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Текстовый файлы (*.txt)|*.txt|Все файлы (*.*)|(*.*)";
        //    if (openFileDialog.ShowDialog() == true)
        //    {
        //        textBox.Text = File.ReadAllText(openFileDialog.FileName);
        //    }
        //}
        //private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Текстовый файлы (*.txt)|*.txt|Все файлы (*.*)|(*.*)";
        //    if (saveFileDialog.ShowDialog() == true)
        //    {
        //        File.WriteAllText(saveFileDialog.FileName, textBox.Text);
        //    }
        //}

        //private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        /*Задание 7*/

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файлы (*.txt)|*.txt|Все файлы (*.*)|(*.*)";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файлы (*.txt)|*.txt|Все файлы (*.*)|(*.*)";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /*Задание 0*/

        //private void styleBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    int styleIndex = styleBox.SelectedIndex;
        //    Uri uri = new Uri("Light.xaml", UriKind.Relative);
        //    if (styleIndex == 1)
        //    {
        //        uri = new Uri("Dark.xaml", UriKind.Relative);
        //    }
        //    ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
        //    Application.Current.Resources.Clear();
        //    Application.Current.Resources.MergedDictionaries.Add(resource);
        //}

        private void styleBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Uri theme = new Uri(styleBox.SelectedIndex == 0 ? "Light.xaml" : "Dark.xaml",UriKind.Relative);
            ResourceDictionary themeDict = Application.LoadComponent(theme) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(themeDict);

        }
    }
}
