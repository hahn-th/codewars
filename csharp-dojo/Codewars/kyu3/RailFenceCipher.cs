using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.kyu3
{

    /*
     * Create two functions to encode and then decode a string using the Rail Fence Cipher. This cipher is used to encode a string by placing each character successively in a diagonal along a set of "rails". First start off moving diagonally and down. When you reach the bottom, reverse direction and move diagonally and up until you reach the top rail. Continue until you reach the end of the string. Each "rail" is then read left to right to derive the encoded string.

For example, the string "WEAREDISCOVEREDFLEEATONCE" could be represented in a three rail system as follows:

W       E       C       R       L       T       E
  E   R   D   S   O   E   E   F   E   A   O   C  
    A       I       V       D       E       N    

The encoded string would be:

WECRLTEERDSOEEFEAOCAIVDEN

Write a function/method that takes 2 arguments, a string and the number of rails, and returns the ENCODED string.

Write a second function/method that takes 2 arguments, an encoded string and the number of rails, and returns the DECODED string.

For both encoding and decoding, assume number of rails >= 2 and that passing an empty string will return an empty string.

Note that the example above excludes the punctuation and spaces just for simplicity. There are, however, tests that include punctuation. Don't filter out punctuation as they are a part of the string.
    */

    public class RailFenceCipher
    {

        public static string Encode(string s, int n)
        {
            string[] rails = new string[n];
            for (int i = 0; i < n; i++)
                rails[i] = "";

            int targetRail = 0;
            int direction = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (targetRail == 0)
                    direction = 1;
                else if (targetRail == (n - 1))
                    direction = -1;

                rails[targetRail] += s.Substring(i, 1);
                targetRail += direction;
            }

            return String.Join("", rails);
        }

        public static string Decode(string s, int n)
        {
            Console.WriteLine("> " + s);
            string[] decoded = new string[s.Length];
            int len = n * 2 - 1;
            int curRow = 0;
            int decodedIndex = 0;
            for(int i=0;i<s.Length;i++)
            {
                decoded[decodedIndex] = s.Substring(i, 1);
                decodedIndex += len-1;

                if(decodedIndex >= s.Length)
                {
                    curRow += 1;
                    decodedIndex = curRow;
                    if (curRow < (n-1))
                        len = (n - curRow) * 2 - 1;
                    else
                        len = n * 2 - 1;
                }
            }

            Console.WriteLine("< " + string.Join("", decoded));
            return string.Join("", decoded);
        }
    }
}