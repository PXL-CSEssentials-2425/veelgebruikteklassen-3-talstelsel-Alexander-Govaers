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

namespace WpfApp_talstelsel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            int userInput = Convert.ToInt32(hexaTextBox.Text,16);
            decimalTextBox.Text = $"{userInput:N}";
        }

        private void retryButton_Click(object sender, RoutedEventArgs e)
        {
            hexaTextBox.Clear();
            decimalTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void hexaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.A && e.Key <= Key.F || e.Key == Key.Back)
            {
                e.Handled = false;
                return;
            }
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                e.Handled = false;
                return;
            }
            else e.Handled = true;
        }
    }
}
