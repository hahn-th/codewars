using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars.kyu3;

namespace CodewarsTests.kyu3
{
    [TestClass]
    public class RailFenceCipherTests
    {

        [TestMethod]
        public void EncodeSampleTests()
        {
            string[][] encodes =
                {
                    new[] { "WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN" },  // 3 rails
                    new[] { "Hello, World!", "Hoo!el,Wrdl l" },    // 3 rails
                    new[] { "Hello, World!", "H !e,Wdloollr" },    // 4 rails
                    new[] { "", "" }                               // 3 rails (even if...)
                };
            int[] rails = { 3, 3, 4, 3 };
            for (int i = 0; i < encodes.Length; i++)
            {
                Assert.AreEqual(encodes[i][1], RailFenceCipher.Encode(encodes[i][0], rails[i]));
            }
        }

        [TestMethod]
        public void DecodeSampleTests()
        {
            string[][] decodes =
            {
                new[] { "WECRLTEERDSOEEFEAOCAIVDEN", "WEAREDISCOVEREDFLEEATONCE" },    // 3 rails
                new[] { "H !e,Wdloollr", "Hello, World!" },    // 4 rails
                new[] { "", "" }                               // 3 rails (even if...)
            };
            int[] rails = { 3, 4, 3 };
            for (int i = 0; i < decodes.Length; i++)
            {
                Assert.AreEqual(decodes[i][1], RailFenceCipher.Decode(decodes[i][0], rails[i]));
            }
        }
    }
}
