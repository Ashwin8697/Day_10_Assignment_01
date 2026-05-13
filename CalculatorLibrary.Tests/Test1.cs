using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calc = new Calculator();

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(15, calc.Add(10, 5));
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(5, calc.Subtract(10, 5));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(50, calc.Multiply(10, 5));
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(2, calc.Divide(10, 5));
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            try
            {
                calc.Divide(10, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}