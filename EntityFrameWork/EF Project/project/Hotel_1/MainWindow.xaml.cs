using Hotel_1.Context;
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

namespace Hotel_1
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
        LibraryContext context=new LibraryContext();
        private void myTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                myPlaceHolder1.Visibility = Visibility.Visible;
            }
            else
            {
                myPlaceHolder1.Visibility = Visibility.Hidden;
            }
        }

        private void myTextBox2_TextChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Password))
            {
                myPlaceHolder2.Visibility = Visibility.Visible;
            }
            else
            {
                myPlaceHolder2.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrontEnd front = new FrontEnd();
            KitchenWindow kitchen = new KitchenWindow();
            var user1 = (from p in context.FrontDisk select p).ToList(); 
            foreach (var item in user1)
            {
                if(item.UserName==Username.Text&&item.Password==Password.Password)
                {
                    this.Visibility = Visibility.Hidden;
                    front.Show();
                }
            }
            var user2=(from p in context.Kitchens select p).ToList();
            foreach (var item in user2)
            {
                if (item.Username == Username.Text && item.Password == Password.Password)
                {
                    this.Visibility = Visibility.Hidden;
                    kitchen.Show();
                }
            }
            if (front.IsActive == false && kitchen.IsActive == false) { MessageBox.Show("please enter a valid username or password"); }
        }
    }
}
