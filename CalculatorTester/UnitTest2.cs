using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest2
    {
        
           
        [TestMethod]
        public void TestMethod1()
        {
           
        }
        [TestMethod]
        public void ThVoNgiem()
        {
            /*
             *input: 0 1
             *output : VN
             */
            SimpleEquation s = new SimpleEquation(0, 1);
            Assert.AreEqual("VN", s.SingleEquation());
        }
        [TestMethod]
        public void ThVoSoNgiem()
        {
            /*
             *input: 0 0
             *output : VSN
             */
            SimpleEquation s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());
        }
        [TestMethod]
        public void ThMotNgiem()
        {
            /*
             *input: 2 1
             *output :-0.5
             */
            SimpleEquation s = new SimpleEquation(2, 1);
            Assert.AreEqual("-0.5", s.SingleEquation());
        }
    }
}
