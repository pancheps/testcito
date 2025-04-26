using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiNetFrameworkTest.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Sum_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = Program.Sum(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Sum_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            int result = Program.Sum(a, b);

            // Assert
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Sum_PositiveAndNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = -3;

            // Act
            int result = Program.Sum(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Sum_ZeroAndNumber_ReturnsCorrectResult()
        {
            // Arrange
            int a = 0;
            int b = 7;

            // Act
            int result = Program.Sum(a, b);

            // Assert
            Assert.AreEqual(7, result);
        }
    }
}
