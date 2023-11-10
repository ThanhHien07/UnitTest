using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation Cal;
        [TestInitialize]
        [TestMethod]

        
        public void Setup()
        {
             Cal = new Calculation(10, 5);
        }
        public void TestAddOperator()
        {
            // testcase:
            // input: 10,5
            // Output:15
            Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(15, cal.Execute("+"));
        }
        public void TestSubOperator()
        {
            // testcase:
            // input: 10,5
            // Output:15
            Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(5, cal.Execute("-"));
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(Cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(Cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    }
}
