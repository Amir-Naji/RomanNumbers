using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program p = new Program();
        private readonly IDivision div = new Division();

        [TestMethod]
        public void GetAllNumbersTest()
        {
            var v = div.GetAllNumbers(2, 1);
            CollectionAssert.AreEqual(new List<int>() { 2 }, v);

            v = div.GetAllNumbers(22, 1);
            CollectionAssert.AreEqual(new List<int>() { 20, 2 }, v);

            v = div.GetAllNumbers(222, 1);
            CollectionAssert.AreEqual(new List<int>() { 200, 20, 2 }, v);

            v = div.GetAllNumbers(2222, 1);
            CollectionAssert.AreEqual(new List<int>() { 2000, 200, 20, 2 }, v);

            v = div.GetAllNumbers(1234567, 1);
            CollectionAssert.AreEqual(new List<int>() { 1000000, 200000, 30000, 4000, 500, 60, 7 }, v);
        }

        [TestMethod]
        public void ConvertToRomanNumberSimpleTest()
        {
            p.Factory();

            var romanNumber = p.ConvertToRomanNumber(1);
            Assert.AreEqual("I", romanNumber);

            romanNumber = p.ConvertToRomanNumber(5);
            Assert.AreEqual("V", romanNumber);

            romanNumber = p.ConvertToRomanNumber(10);
            Assert.AreEqual("X", romanNumber);

            romanNumber = p.ConvertToRomanNumber(50);
            Assert.AreEqual("L", romanNumber);

            romanNumber = p.ConvertToRomanNumber(100);
            Assert.AreEqual("C", romanNumber);

            romanNumber = p.ConvertToRomanNumber(500);
            Assert.AreEqual("D", romanNumber);

            romanNumber = p.ConvertToRomanNumber(1000);
            Assert.AreEqual("M", romanNumber);
        }

        [TestMethod]
        public void CasesNumbersTest()
        {
            p.Factory();

            var romanNumber = p.ConvertToRomanNumber(4);
            Assert.AreEqual("IV", romanNumber);

            romanNumber = p.ConvertToRomanNumber(9);
            Assert.AreEqual("IX", romanNumber);

            romanNumber = p.ConvertToRomanNumber(40);
            Assert.AreEqual("XL", romanNumber);

            romanNumber = p.ConvertToRomanNumber(90);
            Assert.AreEqual("XC", romanNumber);

            romanNumber = p.ConvertToRomanNumber(400);
            Assert.AreEqual("CD", romanNumber);

            romanNumber = p.ConvertToRomanNumber(900);
            Assert.AreEqual("CM", romanNumber);
        }
    }
}
