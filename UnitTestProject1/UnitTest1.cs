using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program p = new Program();

        [TestMethod]
        public void GetAllNumbersTest()
        {
            var v = p.GetAllNumbers(2, 1);
            CollectionAssert.AreEqual(new List<int>() { 2 }, v);

            v = p.GetAllNumbers(22, 1);
            CollectionAssert.AreEqual(new List<int>() { 20, 2 }, v);

            v = p.GetAllNumbers(222, 1);
            CollectionAssert.AreEqual(new List<int>() { 200, 20, 2 }, v);

            v = p.GetAllNumbers(2222, 1);
            CollectionAssert.AreEqual(new List<int>() { 2000, 200, 20, 2 }, v);

            v = p.GetAllNumbers(1234567, 1);
            CollectionAssert.AreEqual(new List<int>() { 1000000, 200000, 30000, 4000, 500, 60, 7 }, v);
        }

        [TestMethod]
        public void ConvertToRomanNumberSimpleTest()
        {
            var romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(1, 1));
            Assert.AreEqual("I", romanNumber);

            romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(5, 1));
            Assert.AreEqual("V", romanNumber);

            romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(10, 1));
            Assert.AreEqual("X", romanNumber);

            romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(50, 1));
            Assert.AreEqual("L", romanNumber);

            romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(100, 1));
            Assert.AreEqual("C", romanNumber);

            romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(500, 1));
            Assert.AreEqual("D", romanNumber);

            romanNumber = p.ConvertToRomanNumber(p.GetAllNumbers(1000, 1));
            Assert.AreEqual("M", romanNumber);
        }
    }
}
