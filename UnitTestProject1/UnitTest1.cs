using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arifmetica;

namespace testArifmetica
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void MinAVG_ReturnsCorrectRoundedAverage()
        {
            string[] marks = { "2", "4", "3", "4", "5" };
            double expected = 3.6;
            double actual = Calculator.MinAVG(marks);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinAVG_ReturnsCorrectRoundedAveragea()
        {
            string[] marks = { "2", "2", "3", "4", "4" };
            double expected = 3;
            double actual = Calculator.MinAVG(marks);
            Assert.AreEqual(expected, actual);
        }
    }
}