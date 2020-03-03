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
        Class1 c1= new Class1();
        Class2 c2= new Class2();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Wynik.Text = c1.dodawanie(double.Parse(liczba1.Text),double.Parse(liczba2.Text)).ToString();
                
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
                Wynik.Text = c1.odejmowanie(double.Parse(liczba1.Text), double.Parse(liczba2.Text)).ToString();
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

                Wynik.Text = c2.mnozenie(double.Parse(liczba1.Text), double.Parse(liczba2.Text)).ToString();
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
                double b = double.Parse(liczba2.Text);
                if (b == 0)
                {
                    new DivideByZeroException();
                    Wynik.Text = "Error";
                }
                else
                {
                    Wynik.Text = c2.dzielenie(double.Parse(liczba1.Text), double.Parse(liczba2.Text)).ToString();
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
