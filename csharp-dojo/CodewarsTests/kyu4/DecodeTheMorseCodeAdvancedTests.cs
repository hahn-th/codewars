using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTests.kyu4
{
    [TestClass]
    public class DecodeTheMorseCodeAdvancedTests
    {

        [TestMethod]
        public void TestFromDescription()
        {
            Assert.AreEqual("HEY JUDE", DecodeTheMorseCodeAdvanced.DecodeMorse(DecodeTheMorseCodeAdvanced.DecodeBits("1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011")));
        }
    }
}
