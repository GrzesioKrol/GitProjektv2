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

namespace WpfApp1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(liczba1.Text);
            int b = int.Parse(liczba2.Text);
            Wynik.Text = (a + b).ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(liczba1.Text);
            int b = int.Parse(liczba2.Text);
            Wynik.Text = (a - b).ToString();
        }

        private void Razy_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(liczba1.Text);
            int b = int.Parse(liczba2.Text);
            Wynik.Text = (a * b).ToString();
        }

        private void Podzielic_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(liczba1.Text);
            int b = int.Parse(liczba2.Text);
            Wynik.Text = (a / b).ToString();
        }
    }
}
