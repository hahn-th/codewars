using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars.kyu5;

namespace CodewarsTests.kyu5
{

    [TestClass]
    public class ProductOfConsecutiveFibNumbersTests
    {
        [TestMethod]
        public void Test1()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            CollectionAssert.AreEqual(r, ProductOfConsecutiveFibNumbers.productFib(4895));
        }
    }
}
