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
    /// Interaction logic for Kitchen_Food.xaml
    /// </summary>
    public partial class Kitchen_Food : Window
    {
        public Kitchen_Food()
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

            if (BreakFastCheck.IsChecked == true)
            {
                BreakfastQ = Convert.ToInt32(BreakFastNum.Text) * 7;
            }
            if (LunchCheck.IsChecked == true)
            {
                LunchQ = Convert.ToInt32(LunchNum.Text) * 15;
            }
            if (DinnerCheck.IsChecked == true)
            {
                DinnerQ = Convert.ToInt32(DinnerNum.Text) * 15;
            }
            

            this.Hide();
        }
    }
}
