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

namespace WpfApp2
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

     

        private void submit(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "Ok":
                    var result = MessageBox.Show($"You have entered : \n" +
                        $"Name = {fname.Text} {lname.Text} \n" +
                        $"Gender = {gen.Text} \n" +
                         $"Address = {add.Text} \n" +
                          $"Job Title = {jo.Text} \n" +
                          $"Phone = {ph.Text}  \n"+
                          $"Mobile = {mo.Text}  \n" +
                          $"Email = {em.Text}  \n" 
                        , "Personal Info",MessageBoxButton.OKCancel,MessageBoxImage.Information);
                
                    if(result == MessageBoxResult.OK)
                    {
                        MessageBox.Show("Data saves successfully", "Saving", MessageBoxButton.OK);
                    }
                    else {
                        fname.Clear();
                        lname.Clear();
                        gen.Clear();
                        add.Clear();
                        mo.Clear();
                        ph.Clear();
                        em.Clear();
                        jo.Clear();
                    }
                   

                    break;
                case "Cancel":
                    fname.Clear();
                    lname.Clear();
                    gen.Clear();
                    add.Clear();
                    mo.Clear();
                    ph.Clear();
                    em.Clear();
                    jo.Clear(); 
                    break;
            }
    

        }
    }
}
