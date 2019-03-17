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
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {

        public TransactionWindow()
        {
            InitializeComponent();
            if (DataStorage.prices[0] > 0)
                cmbJewelryQuality.Items.Add("10k");
            if (DataStorage.prices[1] > 0)
                cmbJewelryQuality.Items.Add("18k");
            if (DataStorage.prices[2] > 0)
                cmbJewelryQuality.Items.Add("21k");
        }

        private void BtnAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            int customerIndex = 0;

            foreach (string name in DataStorage.customers)
            {
                if (cmbCustomer.Text == name)
                {
                    customerIndex = DataStorage.customers.IndexOf(name);
                    break;
                }
            }
            Calculations calculations = new Calculations();

            DataStorage.jewelryType.Insert(customerIndex, cmbJewelryType.Text);
            DataStorage.jewelryQuality.Insert(customerIndex, cmbJewelryQuality.Text);
            DataStorage.weight.Insert(customerIndex, Convert.ToInt32(txtWeight.Text));
            DataStorage.discount.Insert(customerIndex, Convert.ToDecimal(txtDiscount.Text));
            DataStorage.actualValue.Insert(customerIndex, Convert.ToDecimal(txtActualValue.Text));
            DataStorage.loanAmount.Insert(customerIndex, Convert.ToDecimal(txtLoanAmount.Text));
            DataStorage.transactionDate.Insert(customerIndex, Convert.ToDateTime(transDate.Text));
            DataStorage.interest.Insert(customerIndex, Convert.ToDecimal(txtInterest.Text));
            DataStorage.otherDetails.Insert(customerIndex, txtOtherDetails.Text);
            DataStorage.balance.Insert(customerIndex, Convert.ToDecimal(txtLoanAmount.Text));
            DataStorage.accumulatedAmount.Insert(customerIndex, Convert.ToDecimal(txtLoanAmount.Text));
            DataStorage.paidAmount.Insert(customerIndex, 0);
            calculations.GetReceiptNumber();
            
            

            MessageBox.Show("Customer Name: " + cmbCustomer.Text + "\n" 
                + "Jewelry Type; " + cmbJewelryType.Text + "\n" + "Jewelry Quality : " 
                + cmbJewelryQuality.Text + "\n" + "Weight: " + txtWeight.Text + "\n" + "Discount: " + txtDiscount.Text
                + "\n" + "Actual Value: " + txtActualValue.Text + "\n" + "Loan Amount: " + txtLoanAmount.Text + "\n" 
                + "Transaction Date: " + transDate.Text + "\n" + "Receipt Number: " + DataStorage.receiptNumberList[0] ) ; 
            this.Hide();
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow addCustomer = new CustomerWindow();
            addCustomer.ShowDialog();
            cmbCustomer.Items.Clear();

            foreach (string customer in DataStorage.customers)
                cmbCustomer.Items.Add(customer);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void TxtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculations calculate = new Calculations();
            string jewelryDiscount = "0";
            string jewelryWeight = "0";

            if (txtDiscount.Text != "")
                jewelryDiscount = txtDiscount.Text;

            if (txtWeight.Text != "")
                switch (cmbJewelryQuality.Text)
                {
                    case "10k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[0], Convert.ToDecimal(jewelryDiscount), Convert.ToInt32(txtWeight.Text)));
                        break;
                    case "18k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[1], Convert.ToDecimal(jewelryDiscount), Convert.ToInt32(txtWeight.Text)));
                        break;
                    case "21k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[2], Convert.ToDecimal(jewelryDiscount), Convert.ToInt32(txtWeight.Text)));
                        break;
                    default:
                        break;
                }
            else
                switch (cmbJewelryQuality.Text)
                {
                    case "10k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[0], Convert.ToDecimal(jewelryDiscount), Convert.ToInt32(jewelryWeight)));
                        break;
                    case "18k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[1], Convert.ToDecimal(jewelryDiscount), Convert.ToInt32(jewelryWeight)));
                        break;
                    case "21k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[2], Convert.ToDecimal(jewelryDiscount), Convert.ToInt32(jewelryWeight)));
                        break;
                    default:
                        break;
                }


        }
        private void TxtDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculations calculate = new Calculations();
            decimal jewelryDiscount = 0;
            int weight = 0;

            if (txtWeight.Text == "")
                weight = 0;
            else
                weight = Convert.ToInt32(txtWeight.Text);

            if (txtDiscount.Text == "" || txtDiscount.Text == "0")
                switch (cmbJewelryQuality.Text)
                {
                    case "10k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[0], jewelryDiscount, weight));
                        break;
                    case "18k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[1], jewelryDiscount, weight));
                        break;
                    case "21k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[2], jewelryDiscount, weight));
                        break;
                    default:
                        txtActualValue.Text = "0";
                        break;
                }
            else
                if (Convert.ToDecimal(txtDiscount.Text) >= 100)
                {
                    txtActualValue.Text = "0";
                }
            else
                switch (cmbJewelryQuality.Text)
                {
                    case "10k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[0], Convert.ToDecimal(txtDiscount.Text), weight));
                        break;
                    case "18k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[1], Convert.ToDecimal(txtDiscount.Text), weight));
                        break;
                    case "21k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[2], Convert.ToDecimal(txtDiscount.Text), weight));
                        break;
                    default:
                        txtActualValue.Text = "0";
                        break;
                }





        }

        private void CmbJewelryQuality_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calculations calculate = new Calculations();
            decimal jewelryDiscount = 0;
            int weight = 0;
            if (txtWeight.Text == "")
                weight = 0;
            else
                weight = Convert.ToInt32(txtWeight.Text);
            if (txtDiscount.Text == "" || txtDiscount.Text == "0")
                switch (cmbJewelryQuality.Text)
                {
                    case "10k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[0],jewelryDiscount, weight));
                        break;
                    case "18k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[1], jewelryDiscount, weight));
                        break;
                    case "21k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[2], jewelryDiscount, weight));
                        break;
                    default:
                        txtActualValue.Text = "0";
                        break;
                }
            else
                if (Convert.ToDecimal(txtDiscount.Text) >= 100)
                {
                    txtActualValue.Text = "0";
                }
            else
                switch (cmbJewelryQuality.Text)
                {
                    case "10k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[0], Convert.ToDecimal(txtDiscount.Text), weight));
                        break;
                    case "18k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[1], Convert.ToDecimal(txtDiscount.Text), weight));
                        break;
                    case "21k":
                        txtActualValue.Text = Convert.ToString(calculate.GetPrice(DataStorage.prices[2], Convert.ToDecimal(txtDiscount.Text), weight));
                        break;
                    default:
                        txtActualValue.Text = "0";
                        break;
                }
        }
    }
    }

