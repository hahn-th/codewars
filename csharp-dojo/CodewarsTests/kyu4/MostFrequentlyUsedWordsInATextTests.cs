using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Codewars.kyu4;

namespace CodewarsTests.kyu4;

[TestClass]
public class MostFrequentlyUsedWordsInATextTests
{
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_1()
    {
        CollectionAssert.AreEqual(new List<string> { "e", "d", "a" }, MostFrequentlyUsedWordsInAText.Top3("a a a  b  c c  d d d d  e e e e e"), "1");
    }

    [TestMethod]
    public void MostFrequentlyUsedWordsTests_2()
    {
        CollectionAssert.AreEqual(new List<string> { "e", "ddd", "aa" }, MostFrequentlyUsedWordsInAText.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"), "2");
    }
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_3()
    {
        CollectionAssert.AreEqual(new List<string> { "won't", "wont" }, MostFrequentlyUsedWordsInAText.Top3("  //wont won't won't "), "3");
    }
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_4()
    {
        CollectionAssert.AreEqual(new List<string> { "e" }, MostFrequentlyUsedWordsInAText.Top3("  , e   .. "), "4");
    }
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_5()
    {
        CollectionAssert.AreEqual(new List<string> { }, MostFrequentlyUsedWordsInAText.Top3("  ...  "), "5");
    }
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_6()
    {
        CollectionAssert.AreEqual(new List<string> { }, MostFrequentlyUsedWordsInAText.Top3("  '  "), "6");
    }
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_7()
    {
        CollectionAssert.AreEqual(new List<string> { }, MostFrequentlyUsedWordsInAText.Top3("  '''  "), "7");
    }
    [TestMethod]
    public void MostFrequentlyUsedWordsTests_8()
    {
        CollectionAssert.AreEqual(new List<string> { "a", "of", "on" }, MostFrequentlyUsedWordsInAText.Top3(
            string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                    "mind, there lived not long since one of those gentlemen that keep a lance",
                    "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                    "coursing. An olla of rather more beef than mutton, a salad on most",
                    "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                    "on Sundays, made away with three-quarters of his income." })), "8");

    }
}

//[TestClass]
//public class MostFrequentlyUsedWordsInATextTests
//{

//    [TestMethod]
//    public void MostFrequentlyUsedWordsTests()
//    {
//        Assert.AreEqual(true, true);
//    }

//    [TestMethod]
//    public void SampleTests()
//    {
//        Assert.AreEqual(true, true);
//        //List<String> equal = new List<string> { "e", "d", "a" };
//        //List<String> actual = MostFrequentlyUsedWordsInAText.Top3("a a a  b  c c  d d d d  e e e e e");
//        //CollectionAssert.AreEqual(equal, actual);

//        //Assert.AreEqual(new List<string> { "e", "ddd", "aa" }, MostFrequentlyUsedWordsInAText.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
//        //Assert.AreEqual(new List<string> { "won't", "wont" }, MostFrequentlyUsedWordsInAText.Top3("  //wont won't won't "));
//        //Assert.AreEqual(new List<string> { "e" }, MostFrequentlyUsedWordsInAText.Top3("  , e   .. "));
//        //Assert.AreEqual(new List<string> { }, MostFrequentlyUsedWordsInAText.Top3("  ...  "));
//        //Assert.AreEqual(new List<string> { }, MostFrequentlyUsedWordsInAText.Top3("  '  "));
//        //Assert.AreEqual(new List<string> { }, MostFrequentlyUsedWordsInAText.Top3("  '''  "));
//        //Assert.AreEqual(new List<string> { "a", "of", "on" }, MostFrequentlyUsedWordsInAText.Top3(
//        //    string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
//        //            "mind, there lived not long since one of those gentlemen that keep a lance",
//        //            "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
//        //            "coursing. An olla of rather more beef than mutton, a salad on most",
//        //            "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
//        //            "on Sundays, made away with three-quarters of his income." })));
//    }
//}