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
            double result;
            string firstValueText = input1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = input.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            switch (((Button)sender).Name)
            {
                case "add":
                    result = secondValue + firstValue;
                    break;
                case "minus":
                    result = firstValue - secondValue;
                    break;
                case "mult":
                    result = firstValue * secondValue;
                    break;
                case "div":
                    result = firstValue / secondValue;

                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            output.Text = result.ToString();
        }
    }

}

