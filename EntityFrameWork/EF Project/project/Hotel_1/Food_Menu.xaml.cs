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
    /// Interaction logic for Food_Menu.xaml
    /// </summary>
   
    public partial class Food_Menu : Window
    {
        public Food_Menu()
        {
            InitializeComponent();
        }


        private int lunchQ = 0;

        public int LunchQ
        {
            get { return lunchQ; }
            set { lunchQ = value; }
        }
        private int breakfastQ = 0;

        public int BreakfastQ
        {
            get { return breakfastQ; }
            set { breakfastQ = value; }
        }
        private int dinnerQ = 0;

        public int DinnerQ
        {
            get { return dinnerQ; }
            set { dinnerQ = value; }
        }

        private bool cleaning=false;

        public bool Cleaning
        {
            get { return cleaning; }
            set { cleaning = value; }
        }
        private bool towel=false;

        public bool Towel 
        {
            get { return towel; }
            set { towel = value; }
        }

        private bool surprise = false;

        public bool Surprise
        {
            get { return surprise; }
            set { surprise = value; }
        }

        private void BreakFastNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (BreakFastNum.Text == "")
            {
                BreakFastNum.Text = "Quantity?";
            }
            else if (BreakFastNum.Text == "Quantity?")
            {
                BreakFastNum.Text = "";
            }
        }

        private void BreakFastNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (BreakFastNum.Text == "")
            {
                BreakFastNum.Text = "Quantity?";
            }
            else if (BreakFastNum.Text == "Quantity?")
            {
                BreakFastNum.Text = "";
            }
        }

        private void DinnerNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (DinnerNum.Text == "")
            {
                DinnerNum.Text = "Quantity?";
            }
            else if (DinnerNum.Text == "Quantity?")
            {
                DinnerNum.Text = "";
            }
        }

        private void DinnerNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (DinnerNum.Text == "")
            {
                DinnerNum.Text = "Quantity?";
            }
            else if (DinnerNum.Text == "Quantity?")
            {
                DinnerNum.Text = "";
            }
        }

        private void LunchNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (LunchNum.Text == "")
            {
                LunchNum.Text = "Quantity?";
            }
            else if (LunchNum.Text == "Quantity?")
            {
                LunchNum.Text = "";
            }
        }

        private void LunchNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (LunchNum.Text == "")
            {
                LunchNum.Text = "Quantity?";
            }
            else if (LunchNum.Text == "Quantity?")
            {
                LunchNum.Text = "";
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (BreakFastCheck.IsChecked==true)
            {
                BreakfastQ = Convert.ToInt32(BreakFastNum.Text)*7;
            }
            if (LunchCheck.IsChecked == true)
            {
                LunchQ = Convert.ToInt32(LunchNum.Text)*15;
            }
            if (DinnerCheck.IsChecked == true)
            {
                DinnerQ = Convert.ToInt32(DinnerNum.Text)*15;
            }
            if (CleaningCheck.IsChecked==true)
            {
                Cleaning = true;
            }
            if (TowelsCheck.IsChecked==true)
            {
                Towel = true;
            }
            if (SurpriseCheck.IsChecked==true)
            {
                Surprise = true;
            }

            this.Hide();
        }
    }
}
