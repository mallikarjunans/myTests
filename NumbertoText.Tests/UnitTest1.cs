using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbertoText.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void isEmpty()
        {
            String num;
            num = String.Empty;
            String rsult = String.Empty;
            Assert.AreEqual(num, rsult);
        }

        [TestMethod]
        public void isValidNumber()
        {
            int number;
            number = -11;

            // NumberToText nt = new NumberToText();
            string result = NumberToText.NumberToTexts(number, false);
            string actualResult = "Invalid Number";

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void isNumber()
        {
            string num;

            num = "A";
            int rsult = 1;
            Assert.AreEqual(num,rsult);
            
        }
    }
}
