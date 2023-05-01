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
using System.Windows.Shapes;

namespace Hotel_1
{
    /// <summary>
    /// Interaction logic for KitchenWindow.xaml
    /// </summary>
    public partial class KitchenWindow : Window
    {
        LibraryContext context = new LibraryContext();
        Kitchen_Food menu;

        public KitchenWindow()
        {
            InitializeComponent();
            var resvList = (from p in context.Reservations where p.SupplyStatus == false select p.Id + "-" + p.FirstName +" " + p.LastName).ToList();
            RoomServiceList.ItemsSource = resvList;

            menu = new Kitchen_Food();
        }

        private void RoomServiceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoomServiceList.SelectedItem != null)
            {

                var a = RoomServiceList.SelectedItem.ToString().Split("-");
                var resv = context.Reservations.Find(int.Parse(a[0]));
                FIrstTextBox.Text = resv.FirstName;
                LastTextBox.Text = resv.LastName;

                PhoneTextBox.Text = resv.PhoneNumber;

                RoomTypeText.Text = resv.RoomType;

                FloorNumTextBox.Text = resv.RoomFloor;

                RoomNumText.Text = resv.RoomNumber;

                BreakFastText.Text = resv.BreakFast.ToString();

                LunchText.Text = resv.Lunch.ToString();

                DinnerText.Text = resv.Dinner.ToString();

                CleaningCheck.IsEnabled = true;
                CleaningCheck.IsChecked = resv.Cleaning;

                TowelsCheck.IsEnabled = true;
                TowelsCheck.IsChecked = resv.Towel;

                SurpriseCheck.IsEnabled = true;
                SurpriseCheck.IsChecked = resv.SSurprise;

                FoodSupplyCheck.IsEnabled = true;
                FoodSupplyCheck.IsChecked = resv.SupplyStatus;
            }
            else
            {
                //RoomServiceList.SelectedItem = "";
            }
        }

        int dinner;
        int lunch;
        int breakfast;
        //change food selection
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menu.Show();
        }

        //update
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            breakfast = menu.BreakfastQ /7;
            BreakFastText.Text = breakfast.ToString();

            lunch = menu.LunchQ /15; 
            LunchText.Text = lunch.ToString();

            dinner = menu.DinnerQ /15;
            DinnerText.Text = dinner.ToString();

            var x = RoomServiceList.SelectedValue.ToString().Split("-");
            var id = int.Parse(x[0]);
            var obj = context.Reservations.Find(id);

            obj.Lunch = lunch;
            obj.BreakFast = breakfast;
            obj.Dinner = dinner;

            obj.FoodBill = menu.BreakfastQ + menu.LunchQ + menu.DinnerQ;

            obj.Cleaning = (bool)CleaningCheck.IsChecked;
            obj.SSurprise = (bool)SurpriseCheck.IsChecked;
            obj.Towel = (bool)TowelsCheck.IsChecked;
            obj.SupplyStatus = (bool)FoodSupplyCheck.IsChecked;

            context.SaveChanges();

            var resvList = (from p in context.Reservations where p.SupplyStatus == false select p.Id + "-" + p.FirstName + " " + p.LastName).ToList();
            RoomServiceList.ItemsSource = resvList;
        }

        private void Overview_Click(object sender, RoutedEventArgs e)
        {
            overview.Visibility = Visibility.Visible;
            ToDo.Visibility = Visibility.Hidden;

            overGrid.ItemsSource = context.Reservations.Select(o => new { Id = o.Id, FirstName = o.FirstName , LastName = o.LastName , PhoneNumber = o.PhoneNumber, RoomType = o.RoomType , RoomFloor = o.RoomFloor , RoomNumber = o.RoomNumber , BreakFast = o.BreakFast , Lunch = o.Lunch , Dinner = o.Dinner , Cleaning = o.Cleaning , Towel = o.Towel , SSurprise = o.SSurprise , SupplyStatus = o.SupplyStatus , FoodBill = o.FoodBill}).Where(o => o.SupplyStatus == false).ToList();
        }

        private void TODO_Click(object sender, RoutedEventArgs e)
        {
            overview.Visibility = Visibility.Hidden;
            ToDo.Visibility = Visibility.Visible;
        }
    }
}
