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

        // Функція для обчислення найбільшого спільного дільника (НСД)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Функція для скорочення дробу
        private void ReduceFraction(ref int numerator, ref int denominator)
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }
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
                        int addNumerator = (firstNumerator * secondDenominator) + (secondNumerator * firstDenominator);
                        int addDenominator = firstDenominator * secondDenominator;
                        ReduceFraction(ref addNumerator, ref addDenominator);
                        tbResult.Text = $"{addNumerator}/{addDenominator}";
                        break;

                    case "-":
                        int subtractNumerator = (firstNumerator * secondDenominator) - (secondNumerator * firstDenominator);
                        int subtractDenominator = firstDenominator * secondDenominator;
                        ReduceFraction(ref subtractNumerator, ref subtractDenominator);
                        tbResult.Text = $"{subtractNumerator}/{subtractDenominator}";
                        break;

                    case "*":
                        int multiplyNumerator = firstNumerator * secondNumerator;
                        int multiplyDenominator = firstDenominator * secondDenominator;
                        ReduceFraction(ref multiplyNumerator, ref multiplyDenominator);
                        tbResult.Text = $"{multiplyNumerator}/{multiplyDenominator}";
                        break;

                    case "/":
                        if (secondNumerator == 0)
                        {
                            MessageBox.Show("Ділення на нуль неможливе!", "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        int divideNumerator = firstNumerator * secondDenominator;
                        int divideDenominator = firstDenominator * secondNumerator;
                        ReduceFraction(ref divideNumerator, ref divideDenominator);
                        tbResult.Text = $"{divideNumerator}/{divideDenominator}";
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
