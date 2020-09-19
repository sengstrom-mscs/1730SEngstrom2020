using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engstrom1730ex1e
{
    public partial class frmAverageTestScore : Form
    {
        public frmAverageTestScore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            txtaverage.Text =
                ((Convert.ToDecimal(txttest1.Text) + Convert.ToDecimal(txttest2.Text) + Convert.ToDecimal(txttest3.Text)) /3).ToString("0.00");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttest1.Text = "0";
            txttest2.Text = "0";
            txttest3.Text = "0";
            txtaverage.Text = "0";
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
