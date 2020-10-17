using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample1_DataTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotDogsSubtotal.Text = (
            //               4.0m * Convert.ToDecimal(txtHotDogs.Text)
            //           ).ToString("0.00");
            int HotDogs = Convert.ToInt32(txtHotDogs.Text);
            Decimal HotDogPrice = 4.0m;
            Decimal HotDogSubtotal = HotDogs * HotDogPrice;
            txtHotDogsSubtotal.Text = HotDogSubtotal.ToString("0.00");

            //txtHamburgersSubtotal.Text = (
            //       5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //   ).ToString("0.00");
            int Hamburgers = Convert.ToInt32(txtHamburgers.Text);
            Decimal HamburgerPrice = 5.0m;
            Decimal HamburgerSubtotal = Hamburgers * HamburgerPrice;
            txtHamburgersSubtotal.Text = HamburgerSubtotal.ToString("0.00");

            //txtPretaxTotal.Text = (
            //   //    Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //   //).ToString("0.00");
            Decimal pretaxTotal = HotDogSubtotal + HamburgerSubtotal;
            txtPretaxTotal.Text = pretaxTotal.ToString("0.00");

            //txtTax.Text = (
            //       Convert.ToDecimal(txtPretaxTotal.Text) * 0.06875m
            //   ).ToString("0.00");
            Decimal tax = 6.875m * pretaxTotal / 100;
            txtTax.Text = tax.ToString("0.00");

            //txtTotal.Text = (
            //      Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //  ).ToString("0.00");
            Decimal total = pretaxTotal + tax;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHamburgersSubtotal.Text = "0";
            txtHotDogsSubtotal.Text = "0";
            txtPretaxTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";


            txtHotDogs.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
