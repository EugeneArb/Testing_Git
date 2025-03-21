using CalculatorFractions;

namespace TestingCalculator
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        // Перевірка НСД
        [Fact]
        public void GCDCalculatesCorect()
        {
            int result = _calculator.GCD(48, 180);
            Assert.Equal(12, result);
        }

        // Скорочення дробу
        [Fact]
        public void ReduceFractionCorrect()
        {
            int numerator = 10;
            int denominator = 20;
            _calculator.ReduceFraction(ref numerator, ref denominator);
            Assert.Equal("1/2", $"{numerator}/{denominator}");
        }

        // Додавання дробів
        [Fact]
        public void AddFractionsCorrect()
        {
            string result = _calculator.AddFractions(1, 2, 1, 3);
            Assert.Equal("5/6", result);
        }

        // Віднімання дробів
        [Fact]
        public void SubtractFractionsCorrect()
        {
            string result = _calculator.SubtractFractions(3, 4, 1, 4);
            Assert.Equal("1/2", result);
        }

        // Множення дробів
        [Fact]
        public void MultiplyFractionsCorrect()
        {
            string result = _calculator.MultiplyFractions(2, 3, 3, 4);
            Assert.Equal("1/2", result);
        }

        // Ділення дробів
        [Fact]
        public void DivideFractionsCorrect()
        {
            string result = _calculator.DivideFractions(2, 3, 4, 5);
            Assert.Equal("5/6", result);
        }

        // Ділення на нуль
        [Fact]
        public void DividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.DivideFractions(2, 3, 0, 4));
        }

        // Негативні дроби
        [Fact]
        public void AddNegativeFractionsCorrect()
        {
            string result = _calculator.AddFractions(-1, 2, 1, 3);
            Assert.Equal("1/6", result);
        }

        // Порожні значення
        [Fact]
        public void AddFractionsWithEmptyValues()
        {
            Assert.Throws<ArgumentException>(() => _calculator.AddFractions(0, 0, 0, 0));
        }
    }
}