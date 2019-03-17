using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineClassDemo.Helper; 

namespace OnlineClassDemo.Test
{
    [TestClass]
    public class CalculatorTest
    {     
        [TestMethod]
        public void Add_Test()
        {
            int actual = Calculator.Add(2, 3);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Subtract_Test()
        {
            int actual = Calculator.Subtract(5, 4);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Multiply_Test()
        {
            int actual = Calculator.Multiply(2, 3);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Divide_Test()
        {
            int actual = Calculator.Divide(10, 2); 
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void AddHelper_Test()
        {
            int actual = CalculatorHelper.AddHelper(10, 2);
            Assert.AreEqual(12, actual);
        }
    }
}
