using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(20.3, 3.7, 24)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        [InlineData(-309, -101, -410)]
        [InlineData(9,-9,0)]
        public void ShouldAddTwoNumbers(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(20.3, 3.7, 16.6)]
        [InlineData(double.MaxValue, double.MaxValue, 0)]
        [InlineData(-309, -101, -208)]
        [InlineData(-9, -9, 0)]
        public void ShouldSubtractTwoNumbers(double x, double y, double expected)
        {
            double actual = Calculator.Subtract(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(20.3, 3.7, 75.11)]
        [InlineData(-309, -101, 31209)]
        [InlineData(9, -9, -81)]
        [InlineData(0,3,0)]
        public void ShouldMultiplyTwoNumbers(double x, double y, double expected)
        {
            double actual = Calculator.Multiply(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(20.3, 0, 0)]
        [InlineData(-300, -100, 3)]
        [InlineData(9, -9, -1)]
        [InlineData(0,3,0)]
        public void ShouldDivideTwoNumbers(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
