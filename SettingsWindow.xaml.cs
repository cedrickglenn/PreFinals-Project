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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            switch (cmbCarat.Text)
            {
                case "10k":
                    DataStorage.prices[0] = Convert.ToDecimal(txtPricePerCarat.Text);
                    break;
                case "18k":
                    DataStorage.prices[1] = Convert.ToDecimal(txtPricePerCarat.Text);
                    break;
                case "21k":
                    DataStorage.prices[2] = Convert.ToDecimal(txtPricePerCarat.Text);
                    break;
                default:
                    break;
            }
 
            this.Hide();
        }
    }
}
