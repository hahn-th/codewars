using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codewars.kyu4
{
    /*
     * 
     * https://www.codewars.com/kata/51c8e37cee245da6b40000bd
     * 
     * 
     * Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.

        Example:

        Given an input string of:

        apples, pears # and bananas
        grapes
        bananas !apples

        The output expected would be:

        apples, pears
        grapes
        bananas

        The code would be called like so:

        string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new [] { "#", "!" })
        // result should == "apples, pears\ngrapes\nbananas"

    */
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            Regex r = new Regex(@"([ ]?[" + string.Join("", commentSymbols) + @"].*|[ ]+)$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            return r.Replace(text, "");
        }
    }
}
