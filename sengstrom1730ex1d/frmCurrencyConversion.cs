using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sengstrom1730ex1d
{
    public partial class semgstrom1730ex1d : Form
    {
        public semgstrom1730ex1d()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void semgstrom1730ex1d_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.727989";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0136093";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00167569";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.8352";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmountAustralia_TextChanged(object sender, EventArgs e)
        {

        }

        private void australiaTextChange(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

           
        private void bhutanTextChange(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
                ).ToString("0.00");

        }

        private void costaricaTextChange(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
               Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
               ).ToString("0.00");

        }

        private void euroTextChange(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
               Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
               ).ToString("0.00");
        }

        private void usdTextChange(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutan.Text) + Convert.ToDecimal(txtUSDCostaRica.Text) +
                Convert.ToDecimal(txtUSDEuro.Text)

                ).ToString("0.00");
        }
    }
}