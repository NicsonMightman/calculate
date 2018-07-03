using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateMinLOb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Click(object sender, EventArgs e)
        {
          
            string firstValueText = input1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = input.Text;
            double secondValue = Convert.ToDouble(secondValueText);

            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue, secondValue);
            
            

            output.Text = result.ToString();
        }
    }

}

