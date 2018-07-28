using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTrain
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void add_two_positive_int()
        {
            var calculator = new Calculator();
            var first = 1;
            var second = 2;
            var result =calculator.Add(first, second);
            Assert.AreEqual(3, result);
        }

        public class Calculator

        {
            public int Add(int first, int second)
            {
                return first + second;
            }
        }
    }
}
