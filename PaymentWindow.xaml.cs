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
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private static int count = 0;

        private void BtnPay_Click(object sender, RoutedEventArgs e)
        {
            int index = DataStorage.selectionIndices[count];
            decimal currentPayAmount = Convert.ToDecimal(txtPayAmount.Text);

            if ((DataStorage.paidAmount[index] + currentPayAmount) > DataStorage.accumulatedAmount[index])
            {
                MessageBox.Show("Cannot pay more than the total balance! Please try again.");
            }
            else
            {
                DataStorage.paidAmount[index] = DataStorage.paidAmount[index] + currentPayAmount;
                count++;
                TransactionList transaction = new TransactionList();
                transaction.Show();
                this.Close();
            }
            
             
            
        }
    }
}
