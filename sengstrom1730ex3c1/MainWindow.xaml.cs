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

namespace sengstrom1730ex3c1
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            // 0)
            try
            {

                int index = int.Parse(this.inputTextBox0a.Text);
                string days = Ex3cCalculations.Calc0(index);
                resultTextBox0.Text = days;


            }
            catch
            {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
            }
            // 1)
            try
            {
                int index = int.Parse(this.inputTextBox1a.Text);
                string search = "";
                resultTextBox1.Text = Ex3cCalculations.Calc1(search);
            }
            catch
            {
                resultTextBox1.Text = "";
            }

            // 2)
            int[] numbers2 = { 11, 22, 23, 34, 10 };
            resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();

            //3) 
            double[] numbers3 = { 11.1, 22.2, 23.3, 34.4, 9.0 };
            try
            {
                resultTextBox3.Text = Ex3cCalculations.Calc2(numbers2).ToString();

            }
            catch
            {
                MessageBox.Show("Testing");
            }

            // 4)

            double[] numbers4 = new double[inputListBox4a.Items.Count];

            numbers4[0] = Double.Parse(inputListBox4a.Items[0].ToString());

            // 5)

            double[] numbers5 = new double[inputListBox5a.Items.Count];
            for (int i = 0; i < inputListBox5a.Items.Count; i++)
            {
                numbers5 = double.Parse(inputListBox5a.Items.GetItemAt(i).ToString());
            }

            resultTextBox5.Text = Ex3cCalculations.Calc5(numbers5).ToString();

            // 6)
            double[] numbers6 = new double[inputListBox6a.Items.Count];
            for (int i = 0; i < inputListBox5a.Items.Count; i++)
            {
                numbers6 = double.Parse(inputListBox6a.Items.GetItemAt(i).ToString());
            }

            resultTextBox5.Text = Ex3cCalculations.Calc5(numbers5).ToString();

        }
        
        

        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double input = double.Parse(this.inputTextBox4a.Text);
                this.inputListBox4a.Items.Add(input.ToString("n1"));
                this.resultTextBox4.Text = "";
                this.inputListBox4a.ScrollIntoView(inputListBox4a.Items[inputListBox4a.Items.Count - 1]);
            }
            catch
            {
                MessageBox.Show("Invalid input: " + inputTextBox4a.Text);
                this.inputTextBox4a.Focus();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");

            inputTextBox0a.Focus();
        }

        private void inputTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
           ((TextBox)sender).SelectAll();
        }
    }
}
