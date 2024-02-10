using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        // For Add logic
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

        // For Substract Logic

        [TestMethod]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            decimal a = 10;
            decimal b = 5;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_LargerNumberFromSmaller_ReturnsNegativeResult()
        {
            // This test assumes your logic allows for negative results
            // Arrange
            decimal a = 5;
            decimal b = 10;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Subtract_NumberFromItself_ReturnsZero()
        {
            // Arrange
            decimal a = 5;

            // Act
            var result = _calculator.Subtract(a, a);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            decimal a = -5;
            decimal b = -3;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Subtract_FromZero_ReturnsNegativeNumber()
        {
            // Arrange
            decimal a = 0;
            decimal b = 5;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        //For Multiply Logic

        [TestMethod]
        public void Multiply_TwoPositiveNumbers_ReturnsPositiveProduct()
        {
            // Arrange
            decimal a = 5;
            decimal b = 6;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Multiply_PositiveAndNegativeNumber_ReturnsNegativeProduct()
        {
            // Arrange
            decimal a = -5;
            decimal b = 6;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(-30, result);
        }

        [TestMethod]
        public void Multiply_TwoNegativeNumbers_ReturnsPositiveProduct()
        {
            // Arrange
            decimal a = -5;
            decimal b = -6;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Multiply_NumberByZero_ReturnsZero()
        {
            // Arrange
            decimal a = 0;
            decimal b = 5;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_TwoZeros_ReturnsZero()
        {
            // Arrange
            decimal a = 0;
            decimal b = 0;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }


        //For Divide Logic

        [TestMethod]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            decimal a = 10;
            decimal b = 2;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_PositiveAndNegativeNumber_ReturnsNegativeQuotient()
        {
            // Arrange
            decimal a = 10;
            decimal b = -2;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Divide_TwoNegativeNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            decimal a = -10;
            decimal b = -2;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_NumberByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            decimal a = 10;
            decimal b = 0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [TestMethod]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            decimal a = 0;
            decimal b = 5;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }

    }
}
