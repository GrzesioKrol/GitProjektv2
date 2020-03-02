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
            try
            {
                double a = double.Parse(liczba1.Text);
                double b = double.Parse(liczba2.Text);
                Wynik.Text = (a + b).ToString();
            }
            catch (FormatException)
            {                
                Wynik.Text = "Error";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(liczba1.Text);
                double b = double.Parse(liczba2.Text);
                Wynik.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                Wynik.Text = "Error";
            }
        }

        private void Razy_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double a = double.Parse(liczba1.Text);
                double b = double.Parse(liczba2.Text);
                Wynik.Text = (a * b).ToString();
            }

            catch (FormatException)
            {
                Wynik.Text = "Error";
            }
        }


        private void Podzielic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(liczba1.Text);
                double b = double.Parse(liczba2.Text);
                if (b == 0)
                {
                    new DivideByZeroException();
                    Wynik.Text = "Error";
                }
                else
                {
                    Wynik.Text = Math.Round((a / b),2).ToString() ;
                }
            }            
            catch (FormatException)
            {
                Wynik.Text = "Error";
            }
   
        }

        private void liczba1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
