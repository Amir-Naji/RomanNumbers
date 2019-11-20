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
    }
}
