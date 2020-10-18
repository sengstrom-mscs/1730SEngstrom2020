using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sengstrom1730ex2B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = 0.727989m;
            decimal usdAutralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAutralia.ToString("0.00");


            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = 0.0136093m;
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");

            decimal amountCostaRica = Convert.ToDecimal(txtAmountCostaRica.Text);
            decimal rateCostaRica = 0.00167569m;
            decimal usdCostaRica = amountCostaRica * rateCostaRica;
            txtUSDCostaRica.Text = usdCostaRica.ToString("0.0");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = 1.8352m;
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            Decimal usdTotal = usdAutralia + usdBhutan + usdCostaRica + usdEuro;
            txtTotalUSD.Text = usdTotal.ToString("0.00");



        }

        private void btnReset_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
