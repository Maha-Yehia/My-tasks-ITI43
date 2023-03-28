using System;
using System.Collections.Generic;
using System.DirectoryServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double first;
        double second;
        string op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            txt.Text += ((Button)sender).Content.ToString();
            second = double.Parse(txt.Text);

        }

        private void btnDiv(object sender, RoutedEventArgs e)
        {
            first = double.Parse(txt.Text);
            op = "/";
            txt.Clear();


        }
        private void btnMul(object sender, RoutedEventArgs e)
        {
            first = double.Parse(txt.Text);
            op = "*";
            txt.Clear();
        }
        private void btnMinus(object sender, RoutedEventArgs e)
        {
            first = double.Parse(txt.Text);
            op = "-";
            txt.Clear();
        }
        private void btnSum(object sender, RoutedEventArgs e)
        {
            first = double.Parse(txt.Text);
            op = "+";
            txt.Clear();
        }

        private void btnEqual(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch (op)
            {
                case "/":
                    if (second == 0)
                    {
                        result = 0; 
                    }
                   else  result = first / second;
                    txt.Text = result.ToString();
                    break;
                case "+":
                    result = first + second;
                    txt.Text = result.ToString();
                    break;
                case "*":
                    result = first * second;
                    txt.Text = result.ToString();
                    break;
                case "-":
                    result = first - second;
                    txt.Text = result.ToString();
                    break;
            }
        }

    }
}
