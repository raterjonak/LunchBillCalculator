using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchBillCalculatorUI
{
    public partial class LunchBillCalculatorUI : Form
    {
        private double riceUnit, fishUnit, meatUnit;
        double totalGross;


     
        public LunchBillCalculatorUI()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void showTotalButton_Click(object sender, EventArgs e)
        {
            

            riceUnit = Convert.ToDouble(riceTextBox.Text);
            fishUnit = Convert.ToDouble(fishTextBox.Text);
            meatUnit = Convert.ToDouble(meatTextBox.Text);

            totalGross = riceUnit * 20 + fishUnit * 80 + meatUnit * 100;

            totalGrossTextBox.Text = Convert.ToString(totalGross);
            riceTextBox.Text = "";
            fishTextBox.Text = "";
            meatTextBox.Text = "";
        }

        private void showNetBillButton_Click(object sender, EventArgs e)
        {
            
            double netBill,vat=.05, discount;
            discount = Convert.ToDouble(discountTextBox.Text);
            discount = discount*0.01*totalGross;
            vat = vat*totalGross;

            netBill = (totalGross-discount)+vat;

            MessageBox.Show("Your Net Bill is :" + netBill+"Tk");
            
        }
    }
}
