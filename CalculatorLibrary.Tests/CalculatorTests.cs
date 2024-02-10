using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            decimal a = 5;
            decimal b = 7;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            decimal a = 10;
            decimal b = -5;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            decimal a = -3;
            decimal b = -2;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Add_NumberWithZero_ReturnsSameNumber()
        {
            // Arrange
            decimal a = 0;
            decimal b = 5;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_TwoZeros_ReturnsZero()
        {
            // Arrange
            decimal a = 0;
            decimal b = 0;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
