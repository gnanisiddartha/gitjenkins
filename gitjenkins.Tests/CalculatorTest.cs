using System;
using NUnit.Framework;
using gitjenkins.Models;

namespace gitjenkins.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calc = new Calculator();

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(4, calc.sum(1, 2));
        }
    }
}
