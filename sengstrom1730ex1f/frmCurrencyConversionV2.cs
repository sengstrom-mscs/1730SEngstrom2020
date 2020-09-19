using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sengstrom1730ex1f
{
    public partial class frmCurrencyConversionV2 : Form
    {
        public frmCurrencyConversionV2()
        {
            InitializeComponent();
        }

        private void frmCurrencyConversionV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutandim.Image;
            btnCostaRica.BackgroundImage = picCostaRicadim.Image;
            btnEuro.BackgroundImage = picEurodim.Image;
            txtRate.Text = "0.727989";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtUSD.Text = "0.00";
            txttotal.Text = "0.00";
            txtCurrency.Focus();

        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutandim.Image;
            btnCostaRica.BackgroundImage = picCostaRicadim.Image;
            btnEuro.BackgroundImage = picEurodim.Image;
            txtRate.Text = "0.727989";
            lblCurrency.Text = btnAustralia.Text + ":";
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliadim.Image;
            btnCostaRica.BackgroundImage = picCostaRicadim.Image;
            btnEuro.BackgroundImage = picEurodim.Image;
            txtRate.Text = "0.0136093";
            lblCurrency.Text = btnBhutan.Text + ":";
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnBhutan.BackgroundImage = picBhutandim.Image;
            btnAustralia.BackgroundImage = picAustraliadim.Image;
            btnEuro.BackgroundImage = picEurodim.Image;
            txtRate.Text = "0.00167569";
            lblCurrency.Text = btnCostaRica.Text + ":";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnBhutan.BackgroundImage = picBhutandim.Image;
            btnAustralia.BackgroundImage = picAustraliadim.Image;
            btnCostaRica.BackgroundImage = picCostaRicadim.Image;
            txtRate.Text = "1.8352";
            lblCurrency.Text = btnEuro.Text + ":";
        }

        private void calcusd(object sender, EventArgs e)
        {
            txtUSD.Text = (
            Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txttotal.Text = (
                Convert.ToDecimal(txtUSD.Text) + Convert.ToDecimal(txttotal.Text)).ToString("0.00");
            lblEqualtion.Text = lblEqualtion.Text + "+" + txttotal.Text;

         }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            btnAustralia.BackgroundImage = picAustralia.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtUSD.Text = "0.00";
            txttotal.Text = "0.00";
            lblEqualtion.Text = "0.00";
              txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
