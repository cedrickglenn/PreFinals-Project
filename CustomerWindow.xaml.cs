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
using Final_Project.Properties;

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {


        public CustomerWindow()
        {
            InitializeComponent();
        }

       
        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            
            PersonClass customer = new PersonClass(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text);
            bool exist = false;
            if (!exist)
                DataStorage.customers.Add(customer.GetFullName());
            DataStorage.address.Add(txtAddress.Text);
            DataStorage.contactNumber.Add(txtContactNumber.Text);
            DataStorage.jewelryType.Add("");
            DataStorage.jewelryQuality.Add("");
            DataStorage.weight.Add(0);
            DataStorage.discount.Add(0);
            DataStorage.actualValue.Add(0);
            DataStorage.loanAmount.Add(0);
            DataStorage.transactionDate.Add(Convert.ToDateTime("01/01/00"));
            DataStorage.interest.Add(0);
            DataStorage.otherDetails.Add("");
            this.Hide();
        }
    }
}
