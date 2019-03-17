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

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for TransactionList.xaml
    /// </summary>
    public partial class TransactionList : Window
    {
        public TransactionList()
        {
            InitializeComponent();
            Calculations calculate = new Calculations();
            List<Customers> items = new List<Customers>();

            for (int counter = 0; counter < DataStorage.customers.Count ; counter++)
            {
                
                DataStorage.accumulatedAmount[counter] = calculate.GetAccumulatedAmount(DataStorage.loanAmount[counter], DataStorage.interest[counter], DataStorage.transactionDate[counter]) + DataStorage.loanAmount[counter];
                
                DataStorage.balance[counter] = DataStorage.accumulatedAmount[counter] - DataStorage.paidAmount[counter];

                items.Add(new Customers() { Name = DataStorage.customers[counter], Address = DataStorage.address[counter],
                    ContactNumber = DataStorage.contactNumber[counter], ReceiptNumber = DataStorage.receiptNumberList[counter],
                    LoanAmount = DataStorage.loanAmount[counter], AccumulatedAmount = DataStorage.accumulatedAmount[counter],
                    Balance = DataStorage.balance[counter], TransactionDate = DataStorage.transactionDate[counter] }); 
                
            }

            TransactionsList.ItemsSource = items;
        }
        private void TransactionsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            if (DataStorage.balance[TransactionsList.SelectedIndex] == 0 )
            {
                MessageBox.Show("Total Balance in this transaction is fully paid!");
            }
            else
            {
                PaymentWindow addPayment = new PaymentWindow();
                DataStorage.selectionIndices.Add(TransactionsList.SelectedIndex);
                addPayment.Show();
                this.Close();
            }
            
        }
    }

    public class Customers
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int ReceiptNumber { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal AccumulatedAmount { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransactionDate { get; set; }

    }

    


}
