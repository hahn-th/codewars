using Codewars.kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodewarsTests.kyu5;

[TestClass]
public class MovingZerosToTheEndTests
{
    [TestMethod]
    public void Test()
    {
        CollectionAssert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MovingZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
    }

    private static Random rnd = new Random();

    private static int[] solution(int[] arr) => arr.Where(v => v != 0).Concat(arr.Where(v => v == 0)).ToArray();

    [TestMethod, Description("Random Tests")]
    public void RandomTest()
    {
        const int Tests = 100;

        for (int i = 0; i < Tests; ++i)
        {
            int[] test = new int[rnd.Next(4, 100)].Select(_ => rnd.Next(0, 6)).ToArray();

            int[] expected = solution(test);
            int[] actual = MovingZerosToTheEnd.MoveZeroes(test);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}