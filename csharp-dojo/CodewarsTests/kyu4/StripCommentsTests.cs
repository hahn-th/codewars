using Codewars.kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests.kyu4
{
    [TestClass]
    public class StripCommentsTests
    {
        [TestMethod]
        public void StripComments()
        {
            Assert.AreEqual(
                    "apples, pears\ngrapes\nbananas",
                    StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

            Assert.AreEqual("\n\nFB\n\nA\n\nD\n\nFF", StripCommentsSolution.StripComments("--\n\nFB\n\nA\n\nD\n\nFF-B", new string[] { "#", "$", "!", "-" }));
            Assert.AreEqual("a\n b\nc", StripCommentsSolution.StripComments("a \n b \nc ", new string[] { "#", "$" }));
        }

        [TestMethod]
        public void StripComments2()
        {
            Assert.AreEqual("a\n b\nc", StripCommentsSolution.StripComments("a \n b \nc ", new string[] { "#", "$" }));
            Assert.AreEqual(String.Empty, StripCommentsSolution.StripComments("a", new string[] { "a" }));
        }

        [TestMethod]
        public void StripComments3()
        {
            Assert.AreEqual("\n\nAB\nd", StripCommentsSolution.StripComments("\n\nAB-\nd", new string[] { "-" }));
        }
    }
}
