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
    /// Interaction logic for payment.xaml
    /// </summary>
    public partial class payment : Window
    {
        public payment()
        {
            InitializeComponent();
            PaymentTypeComboBox.ItemsSource = _paymentType;
            MonthComboBox.ItemsSource = _monthNumbers;
            YearComboBox.ItemsSource = _YearNumbers;
            CardTypeCombobox.ItemsSource = _CardType;
        }


        private string[] _CardType = new string[]
        {
            "Paybal", "Visa", "MasterCard","Miza"
        };





        public int totalAmountFromFrontend = 0;
        public int foodBill = 0;
        private double finalTotalFinalized = 0.0;
        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

       
        private string paymentCardNumber;

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string MM_YY_Of_Card;

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string CVC_Of_Card;

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string CardType;

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private string paymentType;

        public string paymentType1
        {
            get { return paymentType; }
            set { paymentType = value; }
        }








        private string[] _paymentType = new string[] { "Cash", "Visa" };
        private string[] _monthNumbers = new string[]
       {
            "1", "2","3","4","5","6","7","8","9","10","11","12"
       };
        private string[] _YearNumbers = new string[]
      {
            "14", "15","16","17","18","19","20","21","22","23","24","25"
      };
        private void CVCTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (CVCTextBox.Text == "")
            {
                CVCTextBox.Text = "CVC";
            }
            else if (CVCTextBox.Text == "CVC")
            {
                CVCTextBox.Text = "";
            }

        }

        private void CVCTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (CVCTextBox.Text == "")
            {
                CVCTextBox.Text = "CVC";
            }
            else if (CVCTextBox.Text == "CVC")
            {
                CVCTextBox.Text = "";
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

        private void CardNumberText_KeyDown(object sender, KeyEventArgs e)
        {
            if(CardNumberText.Text == "")
            {
                CardNumberText.Text = "9999-9999-9999-9999";
            }
            else if (CardNumberText.Text == "9999-9999-9999-9999")
            {
                CardNumberText.Text = "";
            }
        }

        private void CardNumberText_KeyUp(object sender, KeyEventArgs e)
        {
            if (CardNumberText.Text == "")
            {
                CardNumberText.Text = "9999-9999-9999-9999";
            }
            else if (CardNumberText.Text == "9999-9999-9999-9999")
            {
                CardNumberText.Text = "";
            }
        }

        private void YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YearComboBox.SelectedIndex > -1)
            {
                YearLabel.Visibility = Visibility.Hidden;

            }
            else
            {
                YearLabel.Visibility = Visibility.Visible;
            }
        }

        private void PaymentTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PaymentTypeComboBox.SelectedIndex > -1)
            {
                PaymnetTypeLabel.Visibility = Visibility.Hidden;

            }
            else
            {
                PaymnetTypeLabel.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            paymentCardNumber=CardNumberText.Text;
            MM_YY_Of_Card = MonthComboBox.Text+"/"+YearComboBox.Text;
            CVC_Of_Card1=CVCTextBox.Text;
            CardType1 = CardTypeCombobox.Text;
            paymentType1 = PaymentTypeComboBox.Text;
            this.Hide();

        }

       
    }
}
