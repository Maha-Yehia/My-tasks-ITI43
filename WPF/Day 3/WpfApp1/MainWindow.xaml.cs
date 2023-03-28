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
        List<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();
            employees = new List<Employee>() {
            new Employee() { id= 1 ,name="Mickey",salary=1000,image="Images/download (1).jfif"},
            new Employee() { id = 2, name = "Pooh", salary = 1000, image = "Images/download (2).jfif" },
            new Employee() { id = 3, name = "Patrick", salary = 1000, image = "Images/download (3).jfif" },
            new Employee() { id = 4, name = "Tweety", salary = 1000, image = "Images/download.jfif" },
            new Employee() { id = 5, name = "SpongeBob", salary = 1000, image = "Images/download.png" },
            new Employee() { id = 6, name = "Timmy", salary = 1000, image = "Images/images (1).jfif" },
            new Employee() { id = 7, name = "Timon", salary = 1000, image = "Images/images (1).png" },
            new Employee() { id = 8, name = "Bomba", salary = 1000, image = "Images/images.png" },
            new Employee() { id = 9, name = "Jerry", salary = 1000, image = "Images/images.jfif" },
            new Employee() { id = 10, name = "Tom", salary = 1000, image = "Images/tom.png" },
            new Employee() { id =11, name = "Dory", salary = 1000, image = "Images/images (2).jfif" },
            new Employee() { id = 12, name = "Nemo", salary = 1000, image = "Images/unnamed.png" },




        };
            lst.ItemsSource = employees;
        }
    }
}
