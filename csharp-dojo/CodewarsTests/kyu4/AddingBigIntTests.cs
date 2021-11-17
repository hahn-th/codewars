using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars.kyu4;

namespace CodewarsTests.kyu4
{
    [TestClass]
    public class AddingBigIntTests
    {

        [TestMethod]
        public  void AddTests()
        {
            Assert.AreEqual("110", AddingBigInt.Add("91", "19"));
            Assert.AreEqual("1111111111", AddingBigInt.Add("123456789", "987654322"));
            Assert.AreEqual("1000000000", AddingBigInt.Add("999999999", "1"));
        }
    }
}
