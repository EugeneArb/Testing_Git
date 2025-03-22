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

        // �������� ���
        [Fact]
        public void GCDCalculatesCorect()
        {
            int result = _calculator.GCD(48, 180);
            Assert.Equal(12, result);
        }

        // ���������� �����
        [Fact]
        public void ReduceFractionCorrect()
        {
            int numerator = 10;
            int denominator = 20;
            _calculator.ReduceFraction(ref numerator, ref denominator);
            Assert.Equal("1/2", $"{numerator}/{denominator}");
        }

        // ��������� �����
        [Fact]
        public void AddFractionsCorrect()
        {
            string result = _calculator.AddFractions(1, 2, 1, 3);
            Assert.Equal("5/6", result);
        }

        // ³������� �����
        [Fact]
        public void SubtractFractionsCorrect()
        {
            string result = _calculator.SubtractFractions(3, 4, 1, 4);
            Assert.Equal("1/2", result);
        }

        // �������� �����
        [Fact]
        public void MultiplyFractionsCorrect()
        {
            string result = _calculator.MultiplyFractions(2, 3, 3, 4);
            Assert.Equal("1/2", result);
        }

        // ĳ����� �����
        [Fact]
        public void DivideFractionsCorrect()
        {
            string result = _calculator.DivideFractions(2, 3, 4, 5);
            Assert.Equal("5/6", result);
        }

        // ĳ����� �� ����
        [Fact]
        public void DividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.DivideFractions(2, 3, 0, 4));
        }

        // �������� �����
        [Fact]
        public void AddNegativeFractionsCorrect()
        {
            string result = _calculator.AddFractions(-1, 2, 1, 3);
            Assert.Equal("1/6", result);
        }

        // ������ ��������
        [Fact]
        public void AddFractionsWithEmptyValues()
        {
            Assert.Throws<ArgumentException>(() => _calculator.AddFractions(0, 0, 0, 0));
        }
    }
}