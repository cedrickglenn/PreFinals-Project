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

namespace Final_Project
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

        private void LoanButton_Click(object sender, RoutedEventArgs e)
        {
            TransactionWindow addTransaction = new TransactionWindow();
            addTransaction.Show();
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            TransactionList addTransactionList = new TransactionList();
            addTransactionList.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow addSettings = new SettingsWindow();
            addSettings.Show();
        }
    }
    public static class DataStorage
    {
        public static decimal[] prices = new decimal[3];
        public static List<string> customers = new List<string>();
        public static List<string> jewelryType = new List<string>();
        public static List<string> jewelryQuality = new List<string>();
        public static List<string> address = new List<string>();
        public static List<string> contactNumber = new List<string>();
        public static List<string> otherDetails = new List<string>();
        public static List<DateTime> transactionDate = new List<DateTime>();
        public static List<decimal> discount = new List<decimal>();
        public static List<decimal> actualValue = new List<decimal>();
        public static List<decimal> loanAmount = new List<decimal>();
        public static List<decimal> balance = new List<decimal>();
        public static List<decimal> paidAmount = new List<decimal>();
        public static List<decimal> accumulatedAmount = new List<decimal>();
        public static List<decimal> interest = new List<decimal>();
        public static List<decimal> weight = new List<decimal>();
        public static List<int> receiptNumberList = new List<int>();
        public static List<int> selectionIndices = new List<int>();

    }

}
