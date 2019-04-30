using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorWithTests.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(-5, -2, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(null, 5, 0)]
        public void Add(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }//Add

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-5, -2, -3)]
        [InlineData(0, 0, 0)]
        [InlineData(null, 5, 0)]
        public void Subtract(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }//Subtract

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(-5, -2, 10)]
        [InlineData(-2, 5, -10)]
        [InlineData(null, 5, 0)]
        public void Multiply(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }//Multiply

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(-5, -2, -3)]
        [InlineData(0, 0, null)]
        [InlineData(null, 5, 0)]
        public void Divide(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }//Divide

        [Theory]
        [InlineData(1, 0)]
        [InlineData(-5, null)]
        [InlineData(0, 0)]
        [InlineData(null, 0)]
        public void Factorial(int number, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Factorial(number);

            // Assert
            Assert.Equal(expected, actual);
        }//Factorial


    }//CalculatorTests
}//CalculatorWithTests.Tests
