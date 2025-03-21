using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFractions
{
    public class Calculator
    {
        // Функція для обчислення найбільшого спільного дільника (НСД)
        public int GCD(int a, int b)
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
        public void ReduceFraction(ref int numerator, ref int denominator)
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

        // Операція додавання дробів
        public string AddFractions(int num1, int denom1, int num2, int denom2)
        {
            int resultNumerator = (num1 * denom2) + (num2 * denom1);
            int resultDenominator = denom1 * denom2;
            ReduceFraction(ref resultNumerator, ref resultDenominator);
            return $"{resultNumerator}/{resultDenominator}";
        }

        // Операція віднімання дробів
        public string SubtractFractions(int num1, int denom1, int num2, int denom2)
        {
            int resultNumerator = (num1 * denom2) - (num2 * denom1);
            int resultDenominator = denom1 * denom2;
            ReduceFraction(ref resultNumerator, ref resultDenominator);
            return $"{resultNumerator}/{resultDenominator}";
        }

        // Операція множення дробів
        public string MultiplyFractions(int num1, int denom1, int num2, int denom2)
        {
            int resultNumerator = num1 * num2;
            int resultDenominator = denom1 * denom2;
            ReduceFraction(ref resultNumerator, ref resultDenominator);
            return $"{resultNumerator}/{resultDenominator}";
        }

        // Операція ділення дробів
        public string DivideFractions(int num1, int denom1, int num2, int denom2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Ділення на нуль неможливе!");
            }

            int resultNumerator = num1 * denom2;
            int resultDenominator = denom1 * num2;
            ReduceFraction(ref resultNumerator, ref resultDenominator);
            return $"{resultNumerator}/{resultDenominator}";
        }
    }
}

