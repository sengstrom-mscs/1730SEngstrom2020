using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sengstrom1730ex2G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' command with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1aTextBox.Text);

            //1b) 'If" command with no default
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1aTextBox.Text);

            //1c) if else-if
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1aTextBox.Text);

            //1d) Nested if
            resultNestedIf01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1aTextBox.Text);

            //1E) Switch with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1aTextBox.Text);

            //1F) If with default
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(input1aTextBox.Text);

            //1G Else-if with default
            resultElseIFDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1aTextBox.Text);

            //1H) Nested Else-if with default
            resultNestedifDefaulTextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1aTextBox.Text);

            //2A) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input2aTextBox.Text);

            //2B) Separate 'if' statements   
            resultIf02TextBox.Text = Ex2gCalculations.If02(input2aTextBox.Text);

            //2c) if elseif
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(input2aTextBox.Text);

            //2D) Nested if-else
            resultNestedIf02TextBox.Text = Ex2gCalculations.NestedIfElse02(input2aTextBox.Text);
        }
    }
}
