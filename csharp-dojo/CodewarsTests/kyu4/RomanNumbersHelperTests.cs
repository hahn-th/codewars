using Codewars.kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.kyu4;

[TestClass]
public class RomanNumbersHelperTests
{
    [TestMethod]
    public void TestFromRoman()
    {
        RomanNumbersHelper helper = new RomanNumbersHelper();
        Assert.AreEqual(1, helper.fromRoman("I"));
        Assert.AreEqual(3, helper.fromRoman("III"));
        Assert.AreEqual(4, helper.fromRoman("IV"));
        Assert.AreEqual(6, helper.fromRoman("VI"));
        Assert.AreEqual(9, helper.fromRoman("IX"));
        Assert.AreEqual(13, helper.fromRoman("XIII"));
        Assert.AreEqual(997, helper.fromRoman("CMXCVII"));
        Assert.AreEqual(782, helper.fromRoman("DCCLXXXII"));
        Assert.AreEqual(3755, helper.fromRoman("MMMDCCLV"));
    }

    [TestMethod]
    public void TestToRoman()
    {
        RomanNumbersHelper helper = new RomanNumbersHelper();
        Assert.AreEqual("I", helper.toRoman(1));
        Assert.AreEqual("V", helper.toRoman(5));
        Assert.AreEqual("IX", helper.toRoman(9));
        Assert.AreEqual("XIX", helper.toRoman(19));
        Assert.AreEqual("XCIX", helper.toRoman(99));
        Assert.AreEqual("MDCCCXCIX", helper.toRoman(1899));
        Assert.AreEqual("MCML", helper.toRoman(1950));
    }


}
