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

namespace MortgageCalculatos
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
        // Variables
       static public double amountBorrowed { get; set; }
       static public double interestRate { get; set; }
       static public int mortgagePeriod { get; set; }
        private void Btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Get & Parse values
            amountBorrowed = (double)Int32.Parse(txt_Ammount.Text);

            // Get Interest rate
            decimal result;
            if (Decimal.TryParse(txt_Interest.Text, out result))
                interestRate = (double)result;
            // Get mortgage period
            mortgagePeriod = Int32.Parse(txt_Period.Text);

            // Calculate mortgage
            txt_MontlyPayments.Text =
                CalcMortgage(amountBorrowed, interestRate,
                mortgagePeriod);

        }

        private string CalcMortgage(double amountBorrowed, 
                                double interestRate, 
                                int mortgagePeriod)
        {
            double p = amountBorrowed;
            double r = ConvertToMontlyInterest(interestRate);
            double n = YearsToMonths(mortgagePeriod);

            var c = (decimal)(((r * p) * Math.Pow((1 + r), n)) /
                (Math.Pow((1 + r), n) - 1));

            return ($"${Math.Round(c, MidpointRounding.AwayFromZero)}");
            //throw new NotImplementedException();
        }

        private double ConvertToMontlyInterest(double percent)
        {
            return (percent / 12) / 100;
            //throw new NotImplementedException();
        }

        private double YearsToMonths(int years)
        {
            return (12 * years);
            //throw new NotImplementedException();
        }
    }
}
