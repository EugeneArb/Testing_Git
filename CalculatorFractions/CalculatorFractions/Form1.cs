using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Calculator _calculator = new Calculator();
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (tbFirstDenumerator.Text.Trim().Length > 0 && tbFirstNumerator.Text.Trim().Length > 0 &&
                tbSecondDenumerator.Text.Trim().Length > 0 && tbSecondNumerator.Text.Trim().Length > 0)
            {
                int firstNumerator = int.Parse(tbFirstNumerator.Text);
                int firstDenominator = int.Parse(tbFirstDenumerator.Text);
                int secondNumerator = int.Parse(tbSecondNumerator.Text);
                int secondDenominator = int.Parse(tbSecondDenumerator.Text);

                if (firstDenominator == 0 || secondDenominator == 0)
                {
                    MessageBox.Show("Знаменник не може бути нулем!", "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (cbSign.Text)
                {
                    case "+":
                        tbResult.Text = _calculator.AddFractions(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
                        break;

                    case "-":
                        tbResult.Text = _calculator.SubtractFractions(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
                        break;

                    case "*":
                        tbResult.Text = _calculator.MultiplyFractions(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
                        break;

                    case "/":
                        try
                        {
                            tbResult.Text = _calculator.DivideFractions(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Ділення на нуль неможливе!", "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    default:
                        MessageBox.Show("Оберіть правильну операцію!", "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Всі поля повинні бути заповнені.", "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstDenumerator.Text = string.Empty;
            tbFirstNumerator.Text = string.Empty;
            tbSecondDenumerator.Text = string.Empty;
            tbSecondNumerator.Text = string.Empty;
            tbResult.Text = string.Empty;
        }
    }
}
