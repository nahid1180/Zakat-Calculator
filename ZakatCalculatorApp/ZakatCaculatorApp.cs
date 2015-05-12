using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakatCalculatorApp
{
    public partial class ZakatCaculatorApp : Form
    {
        private Calculator aCalculator;

        public ZakatCaculatorApp()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            aCalculator.GoldPrice = Convert.ToDouble(goldPriceTextBox.Text);
            aCalculator.SilverPrice = Convert.ToDouble(silverPriceTextBox.Text);
            aCalculator.NaturallyCropsPrice = Convert.ToDouble(naturallyCropsTextBox.Text);
            aCalculator.IrrigatedWaterCropsPrice = Convert.ToDouble(irrigatedCropsTextBox.Text);
            aCalculator.LiabilitiesDebts = Convert.ToDouble(liabilitiesTextBox.Text);
            aCalculator.LoanCash = Convert.ToDouble(loansTextBox.Text);
            aCalculator.PriceOfLand = Convert.ToDouble(landPriceTextBox.Text);
            aCalculator.SaleableStock = Convert.ToDouble(stockTextBox.Text);
            aCalculator.SharesProfit = Convert.ToDouble(profitTextBox.Text);
            aCalculator.CashOnHand = Convert.ToDouble(bankCashTextBox.Text);

            double Zakat = aCalculator.All()/2.5;

            MessageBox.Show("Your total balance is :"+aCalculator.All().ToString()+Environment.NewLine+"Your given zakat amount is :"+Zakat);
            Clear();
        }

        private void Clear()
        {
            aCalculator = new Calculator();
            goldPriceTextBox.Text = "";
            silverPriceTextBox.Text = "";
            naturallyCropsTextBox.Text = "";
            irrigatedCropsTextBox.Text = "";
            liabilitiesTextBox.Text = "";
            loansTextBox.Text = "";
            landPriceTextBox.Text = "";
            stockTextBox.Text = "";
            profitTextBox.Text = "";
            bankCashTextBox.Text = "";
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
    }
}
