using Hotel_1.Context;
using Microsoft.EntityFrameworkCore;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Hotel_1.Entities;

namespace Hotel_1
{
    /// <summary>
    /// Interaction logic for FrontEnd.xaml
    /// </summary>
    public partial class FrontEnd : Window
    {
        payment payment ;
        LibraryContext context = new LibraryContext();
        Food_Menu menu;
        public FrontEnd()
        {
            InitializeComponent();
            menu = new Food_Menu();
            payment = new payment();
            MonthComboBox.ItemsSource = _monthNames;
            DayComboBox.ItemsSource = _day;
            GenderComboBox.ItemsSource = _gender;
            StateComboBox.ItemsSource = _state;
            guestsComboBox.ItemsSource = _guests;
            roomComboBox.ItemsSource = _roomTypes;
            floorComboBox.ItemsSource = _floor;
            numComboBox.ItemsSource = _floorNumber;
            var resvList = (from p in context.Reservations select p.Id+"-"+p.FirstName + p.LastName).ToList() ;
            SelectReservationComboBox.ItemsSource = resvList;

            
            

        }
      
            
        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public int CurrentBill;
        public int Tax=20;

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public bool taskFinder = false;
        public bool editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;


        private string[] _monthNames = new string[]
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        private string[] _day = new string[]
        {
            "1", "2", "3", "4", "5", "6",
            "7", "8", "9", "10", "11", "12","13","14","15","16","17","18","19","20","21","22"
            ,"23","24","25","26","27","28","29","30","31"
        };
        private string[] _gender = new string[]
        {
            "male","female","other"
        };
        private string[] _state = new string[]
        {
            "Alabama","Alaska","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawaii",
            "Idaho","Illinois","Indiana","lowa","Kansas","Kentucky","Louisiana","Moine","Maryland","Massachusetts",
            "Michigan","Minnesota","Mississippi",
            "Missouri","Montana Nebraska","Nevada","New Hampshire","New Jersey","New Mexico","New York","North Carolina","North Dakota",
            "Ohio","Oklahoma","Oregon","Pennsylvania Rhode","South Dakota",
            "Tennessee","Texas","Utah","Vermont","Virginia","Washington","West Virginia","Wisconsin","Wyoming"
        };

        private string[] _guests = new string[]
        {
            "1" , "2" , "3" , "4" , "5" , "6" 
        };

        private string[] _roomTypes = new string[]
        {
            "Single", "Double", "Twin", "Douplex", "Suite"
        };

        private string[] _floor = new string[]
        {
           "1" , "2" , "3" , "4" , "5"
        };

        private string[] _floorNumber = new string[]
        {
            "203" , "204" , "205" , "206" , "207" , "208" ,"209" , "300" ,
            "301" , "302" , "303" , "304" , "305" ,"400" , "401" , "402" , 
            "403" , "404" , "405" , "500" , "501" , "502" , "503" ,"504" , 
            "505" , "506" , "507" , "508" , "509" , "700"
        };

        private void myTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(myTextBox3.Text))
            {
                myPlaceHolder3.Visibility = Visibility.Visible;
            }
            else
            {
                myPlaceHolder3.Visibility = Visibility.Hidden;
            }
        }
        private void myTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(myTextBox4.Text))
            {
                myPlaceHolder4.Visibility = Visibility.Visible;
            }
            else
            {
                myPlaceHolder4.Visibility = Visibility.Hidden;
            }
        }

        private void YearTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(YearTextBox.Text))
            {
                YearLabel.Visibility = Visibility.Visible;
            }
            else
            {
                YearLabel.Visibility = Visibility.Hidden;
            }
        }

        private void MonthComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MonthComboBox.SelectedIndex > -1)
            {
                MonthLabel.Visibility = Visibility.Hidden;

            }
            else
            {
                MonthLabel.Visibility = Visibility.Visible;
            }
        }

        private void DayComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DayComboBox.SelectedIndex > -1)
            {
                DayLabel.Visibility = Visibility.Hidden;

            }
            else
            {
                DayLabel.Visibility = Visibility.Visible;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GenderComboBox.SelectedIndex > -1)
            {
                GenderLabel.Visibility = Visibility.Hidden;

            }
            else
            {
                GenderLabel.Visibility = Visibility.Visible;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                phoneLabel.Visibility = Visibility.Visible;
            }
            else
            {
                phoneLabel.Visibility = Visibility.Hidden;
            }

        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                EmailLabel1.Visibility = Visibility.Visible;
            }
            else
            {
                EmailLabel1.Visibility = Visibility.Hidden;
            }
        }

        private void StrreetNametxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(StrreetNametxtBox.Text))
            {
                StreetLabel.Visibility = Visibility.Visible;
            }
            else
            {
                StreetLabel.Visibility = Visibility.Hidden;
            }
        }

        private void Apt_SuiteTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Apt_SuiteTextbox.Text))
            {
                Apt_SuiteLabel.Visibility = Visibility.Visible;
            }
            else
            {
                Apt_SuiteLabel.Visibility = Visibility.Hidden;
            }
        }

        private void StateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(StateComboBox.SelectedItem.ToString()))
            {
                StateLabel.Visibility = Visibility.Visible;
            }
            else
            {
                StateLabel.Visibility = Visibility.Hidden;
            }
        }

        private void CityTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(CityTextBox.Text))
            {
                CityLabel.Visibility = Visibility.Visible;
            }
            else
            {
                CityLabel.Visibility = Visibility.Hidden;
            }
        }

        private void ZipCodeTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(ZipCodeTextBox.Text))
            {
                ZipCodeLabel.Visibility = Visibility.Visible;
            }
            else
            {
                ZipCodeLabel.Visibility = Visibility.Hidden;
            }
        }

        private void guestsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(guestsComboBox.SelectedItem.ToString()))
            {
                guestsLabel.Visibility = Visibility.Visible;
            }
            else
            {
                guestsLabel.Visibility = Visibility.Hidden;
            }
        }

        private void roomComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(roomComboBox.SelectedItem.ToString()))
            {
                roomLabel.Visibility = Visibility.Visible;
            }
            else
            {
                roomLabel.Visibility = Visibility.Hidden;
            }
        }

        private void floorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(floorComboBox.SelectedItem.ToString()))
            {
                floorLabel.Visibility = Visibility.Visible;
            }
            else
            {
                floorLabel.Visibility = Visibility.Hidden;
            }
        }

        private void numComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(numComboBox.SelectedItem.ToString()))
            {
                numLabel.Visibility = Visibility.Visible;
            }
            else
            {
                numLabel.Visibility = Visibility.Hidden;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            reservation.Visibility = Visibility.Visible;
            universal.Visibility = Visibility.Hidden;
            search.Visibility = Visibility.Hidden;
            ReservationAdv.Visibility = Visibility.Hidden;
            RoomAvailability.Visibility = Visibility.Hidden;


            item1.BorderBrush = Brushes.Green;
            item1.BorderThickness = new Thickness(0, 0 , 0, 3);

            item2.BorderBrush = null;

            item3.BorderBrush = null;

            item4.BorderBrush = null;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            universal.Visibility = Visibility.Visible;
            reservation.Visibility = Visibility.Hidden;
            search.Visibility = Visibility.Hidden;
            ReservationAdv.Visibility = Visibility.Hidden;
            RoomAvailability.Visibility = Visibility.Hidden;


            item2.BorderBrush = Brushes.Green;
            item2.BorderThickness = new Thickness(0, 0, 0, 3);

            item1.BorderBrush = null;

            item3.BorderBrush = null;

            item4.BorderBrush = null;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            search.Visibility = Visibility.Hidden;
            reservation.Visibility = Visibility.Hidden;
            universal.Visibility = Visibility.Hidden;
            RoomAvailability.Visibility = Visibility.Hidden;


            context.Reservations.Load();
            var a = (from p in context.Reservations
                     select p).ToList();
            ReservationAdv.ItemsSource= a;

            ReservationAdv.Visibility = Visibility.Visible;

            item3.BorderBrush = Brushes.Green;
            item3.BorderThickness = new Thickness(0, 0, 0, 3);

            item2.BorderBrush = null;

            item1.BorderBrush = null;

            item4.BorderBrush = null;

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            search.Visibility = Visibility.Hidden;
            reservation.Visibility = Visibility.Hidden;
            ReservationAdv.Visibility= Visibility.Hidden;
            RoomAvailability.Visibility = Visibility.Visible;
            item4.BorderBrush = Brushes.Green;
            item4.BorderThickness = new Thickness(0, 0, 0, 3);

            item2.BorderBrush = null;

            item3.BorderBrush = null;

            item1.BorderBrush = null;
            context.Reservations.Load();
            var occupied= (from p in context.Reservations.Where(p=>p.CheckIn==false) select new {p.RoomNumber,p.RoomType,p.Id,p.FirstName,p.LastName,p.PhoneNumber}).ToList();   
            OccupiedList.ItemsSource= occupied;
            var Reserved = (from p in context.Reservations.Where(p => p.CheckIn == true) select new { p.RoomNumber, p.RoomType, p.Id, p.FirstName, p.LastName, p.PhoneNumber,p.ArrivalTime,p.LeavingTime }).ToList();
            ReservedList.ItemsSource = Reserved;



        }

        private void imgMouseDown(object sender, MouseButtonEventArgs e)
        {
            //search
            universal.Visibility = Visibility.Hidden;
            search.Visibility = Visibility.Visible;
           //string  searchText= searchTextBox2.Text;
           //var list=context.Reservations.Where(p=>p.FirstName==searchText).ToList();
           // searchDataGrid.ItemsSource= list;
           var reservations=context.Reservations.ToList();
            string searchText = searchTextBox2.Text;
            List<Entities.Reservation> searchedReservation = new List<Entities.Reservation>();
            //foreach(var reservation in reservations)
            //{
            //    string word = "";
            //    word=reservation.FirstName+" "+reservation.LastName;
            //   if(word.Any(w => w.ToString() == searchText))
            //    {
            //        searchedReservation.Add(reservation);
            //    }
            //}


           
            
           var list = context.Reservations.Where(p=>(p.FirstName+p.LastName+p.Id+p.EmailAddress+p.City+p.CardCvc+p.ArrivalTime+p.FoodBill+p.State+p.ZipCode+p.TotalBill+p.CardNumber).Contains(searchText)).ToList();
            
            searchDataGrid.ItemsSource= list;
            


        }

        private void searchTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(searchTextBox.Text == "")
            {
                searchTextBox.Text = "Search";
            }
            else if(searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
            }
        }
        private void searchTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Search";
            }
            else if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
            }
        }

        private void searchTextBoxKeyDown2(object sender, KeyEventArgs e)
        {
         if (searchTextBox2.Text == "")
            {
                searchTextBox2.Text = "Search";
            }
            else if (searchTextBox2.Text == "Search")
            {
                searchTextBox2.Text = "";
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
            Reservation resv= new Reservation();
            resv.FirstName= myTextBox3.Text;
            resv.LastName = myTextBox4.Text  ;

            resv.BirthDay = (Array.IndexOf(_monthNames, MonthComboBox.SelectedValue.ToString())+1) +"/"+
                DayComboBox.SelectedValue.ToString()+"/"+YearTextBox.Text;

            resv.Gender = GenderComboBox.SelectedValue.ToString();

            resv.PhoneNumber = PhoneTextBox.Text  ;

           resv.EmailAddress =EmailTextBox.Text ;

            resv.NumberGuest = int.Parse( guestsComboBox.SelectedValue.ToString())  ;
            resv.StreetAddress = StrreetNametxtBox.Text;
            resv.AptSuite = Apt_SuiteTextbox.Text;
            resv.City = CityTextBox.Text;

            resv.State = StateComboBox.SelectedValue.ToString()  ;
            resv.ZipCode = ZipCodeTextBox.Text ;
            resv.RoomFloor = floorComboBox.SelectedValue.ToString();
            resv.RoomNumber= numComboBox.SelectedValue.ToString();
            resv.RoomType = roomComboBox.SelectedValue.ToString() ;

            resv.ArrivalTime= DateTime.Parse(EntryDate.Text);
            resv.LeavingTime = DateTime.Parse(DepartureDate.Text);
            resv.CheckIn = (bool)CheckIn.IsChecked;
            resv.SupplyStatus = (bool)FoodSupplyStat.IsChecked;

            resv.CardExpiry = payment.MM_YY_Of_Card1;
            resv.TotalBill=(float)payment.FinalTotalFinalized;
            resv.PaymentType = payment.paymentType1;
            resv.CardType=payment.CardType1;
            resv.CardNumber = payment.PaymentCardNumber;
            resv.Towel = menu.Towel;
            resv.Cleaning = menu.Cleaning;
            resv.SSurprise = menu.Surprise;
            resv.FoodBill = payment.foodBill;
            resv.CardCvc = payment.CVC_Of_Card1;
            resv.BreakFast = menu.BreakfastQ;
            resv.Dinner = menu.DinnerQ;
            resv.Lunch = menu.LunchQ;

            context.Reservations.Add(resv);
            int num=context.SaveChanges();
            if (num > 0)
            
                MessageBox.Show("the reservation has been entered successfully");

            var resvList = (from p in context.Reservations select p.Id + "-" + p.FirstName + p.LastName).ToList();
            SelectReservationComboBox.ItemsSource = resvList;

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
           var x= SelectReservationComboBox.SelectedValue.ToString().Split("-");
           var id = int.Parse(x[0]);
            var obj = context.Reservations.Find(id);
            context.Reservations.Remove(obj);

            int num= context.SaveChanges();
            if (num > 0) { MessageBox.Show("reservation has been Deleted successfully"); }

            var resvList = (from p in context.Reservations select p.Id + "-" + p.FirstName + p.LastName).ToList();
            SelectReservationComboBox.ItemsSource = resvList;

            SelectReservationComboBox.SelectedIndex = 0;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var x = SelectReservationComboBox.SelectedValue.ToString().Split("-");
            var id = int.Parse(x[0]);
            var obj = context.Reservations.Find(id);

            obj.FirstName = myTextBox3.Text;
            obj.LastName = myTextBox4.Text;

            obj.BirthDay = (Array.IndexOf(_monthNames, MonthComboBox.SelectedValue.ToString()) + 1) + "/" +
                DayComboBox.SelectedValue.ToString() + "/" + YearTextBox.Text;

            obj.Gender = GenderComboBox.SelectedValue.ToString();

            obj.PhoneNumber = PhoneTextBox.Text;

            obj.EmailAddress = EmailTextBox.Text;

            obj.NumberGuest = int.Parse(guestsComboBox.SelectedValue.ToString());
            obj.StreetAddress = StrreetNametxtBox.Text;
            obj.AptSuite = Apt_SuiteTextbox.Text;
            obj.City = CityTextBox.Text;

            obj.State = StateComboBox.SelectedValue.ToString();
            obj.ZipCode = ZipCodeTextBox.Text;
            obj.RoomFloor = floorComboBox.SelectedValue.ToString();
            obj.RoomNumber = numComboBox.SelectedValue.ToString();
            obj.RoomType = roomComboBox.SelectedValue.ToString();

            obj.ArrivalTime = DateTime.Parse(EntryDate.Text);
            obj.LeavingTime = DateTime.Parse(DepartureDate.Text);
            obj.CheckIn = (bool)CheckIn.IsChecked;
            obj.SupplyStatus = (bool)FoodSupplyStat.IsChecked;

            obj.CardExpiry = payment.MM_YY_Of_Card1;
            obj.TotalBill = (float)payment.FinalTotalFinalized;
            obj.PaymentType = payment.paymentType1;
            obj.CardType = payment.CardType1;
            obj.CardNumber = payment.PaymentCardNumber;
            obj.Towel = menu.Towel;
            obj.Cleaning = menu.Cleaning;
            obj.SSurprise = menu.Surprise;
            obj.FoodBill = payment.foodBill;
            obj.CardCvc = payment.CVC_Of_Card1;
            obj.BreakFast = menu.BreakfastQ;
            obj.Dinner = menu.DinnerQ;
            obj.Lunch = menu.LunchQ;

            //context.Reservations.Add(obj);


            int num = context.SaveChanges();
            if (num > 0) { MessageBox.Show("reservation has been Updated successfully"); }

            //var resvList = (from p in context.Reservations select p.Id + "-" + p.FirstName + p.LastName).ToList();
            //SelectReservationComboBox.ItemsSource = resvList;

            //SelectReservationComboBox.SelectedIndex = 0;
        }

        private void searchTextBoxKeyUp2(object sender, KeyEventArgs e)
        {
            if (searchTextBox2.Text == "")
            {
                searchTextBox2.Text = "Search";
            }
            else if (searchTextBox2.Text == "Search")
            {
                searchTextBox2.Text = "";
            }
        }

        private void btnFood_Click(object sender, RoutedEventArgs e)
        {
          
            menu.Show();

        }

        private void btnBill_Click(object sender, RoutedEventArgs e)
        {
           
            if (menu.BreakFastCheck.IsChecked == true)
            {
                foodBill += menu.BreakfastQ;

            }
            if (menu.DinnerCheck.IsChecked == true)
            {
                foodBill += menu.DinnerQ;
            }
            if (menu.LunchCheck.IsChecked == true)
            {
                foodBill += menu.LunchQ;
            }
            if(roomComboBox.SelectedValue=="Single")
            { CurrentBill = 20; }
            else if (roomComboBox.SelectedValue == "Double")
            { CurrentBill = 30; }
            else if(roomComboBox.SelectedValue== "Twin")
            { CurrentBill = 40; }
            else if (roomComboBox.SelectedValue == "Doublex")
            { CurrentBill = 50; }
            else if (roomComboBox.SelectedValue == "Suite")
            { CurrentBill = 60; }
            totalAmount = CurrentBill + foodBill+Tax;

            payment.Show();
            payment.FoodBillLabel.Content = foodBill;
            payment.CurrentBillLabel.Content = CurrentBill;
            payment.TaxLabel.Content = Tax;
            payment.TotalLabel.Content = totalAmount;
            Submit.Visibility= Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpDelGrid.Visibility= Visibility.Visible;
           
        }

        private void SelectReservationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(SelectReservationComboBox.SelectedItem != null)
            {

               var a=  SelectReservationComboBox.SelectedItem.ToString().Split("-");
                var resv = context.Reservations.Find(int.Parse(a[0]));
                myTextBox3.Text = resv.FirstName;
                myTextBox4.Text=resv.LastName;
            
                string[] birthday = resv.BirthDay.Split('/');
                string year, month, day;
                day=birthday[0];
                month=birthday[1];
                year = birthday[2];

                //MonthComboBox.SelectedValue = _monthNames[int.Parse(month) - 1];
                MonthComboBox.SelectedIndex = int.Parse(month) - 1;
                DayComboBox.SelectedValue = day;
                YearTextBox.Text = year;
                GenderComboBox.SelectedValue=resv.Gender.ToString();
                PhoneTextBox.Text = resv.PhoneNumber;
                EmailTextBox.Text = resv.EmailAddress;
                StrreetNametxtBox.Text = resv.StreetAddress;
                Apt_SuiteTextbox.Text = resv.AptSuite;
                CityTextBox.Text = resv.City;
                StateComboBox.SelectedValue= resv.State;
                ZipCodeTextBox.Text= resv.ZipCode;
                guestsComboBox.SelectedValue = resv.NumberGuest.ToString();
                floorComboBox.SelectedValue = resv.RoomFloor.ToString();
                numComboBox.SelectedValue = resv.RoomNumber.ToString();
                roomComboBox.SelectedValue = resv.RoomType.ToString();
            
                EntryDate.Text=resv.ArrivalTime.ToString();
                DepartureDate.Text = resv.LeavingTime.ToString();
                CheckIn.IsChecked=resv.CheckIn;
                FoodSupplyStat.IsChecked = resv.SupplyStatus;
            }
            else
            {
                SelectReservationComboBox.SelectedItem = "";
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpDelGrid.Visibility= Visibility.Hidden;
        }
    }
}
