using System;
using System.Globalization;
using System.Windows.Forms;
using CalculateMinLOb.OneArgumentFolder;
using CalculateMinLOb.TwoArgumentsFolder;

namespace CalculateMinLOb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoArgumentsButtonClick(object sender, EventArgs e)
        {
            string firstValueText = input1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = input.Text;
            double secondValue = Convert.ToDouble(secondValueText);

            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue, secondValue);

            output.Text = result.ToString();
        }

        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            string firstValueText = input1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue);

            output.Text = result.ToString(CultureInfo.CurrentCulture);
        }
    }

}

