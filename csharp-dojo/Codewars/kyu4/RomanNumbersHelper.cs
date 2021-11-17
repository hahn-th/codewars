namespace Codewars.kyu4
{

    /*  Create a RomanNumerals class that can convert a roman numeral to and from an integer value. It should follow the API demonstrated in the examples below. Multiple roman numeral values will be tested for each helper method.
        Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

        Input range : 1 <= n < 4000

        In this kata 4 should be represented as IV, NOT as IIII (the "watchmaker's four").
        Examples

        RomanNumerals.toRoman(1000); // should return 'M'
        RomanNumerals.fromRoman('M'); // should return 1000

        Help
        Symbol 	Value
        I 	1
        IV 	4
        V 	5
        X 	10
        L 	50
        C 	100
        D 	500
        M 	1000
    */
    public class RomanNumbersHelper
    {
        public string toRoman(int value)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>() { 
                {1000,"M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };
            string result = "";

            foreach(var keyValue in pairs)
            {
                double res = value / keyValue.Key;
                for (int i = 0; i < Math.Floor(res); i++)
                {
                    result += keyValue.Value;
                    value -= keyValue.Key;
                }
                if (value == 0) break;
            }

            return result;
        }

        public int fromRoman(string romanNumber)
        {
            int lastVal = 0;

            Stack<int> stack = new Stack<int>();

            char[] romans = romanNumber.ToCharArray();
            for (int i = 0; i < romans.Length; i++)
            {
                int curVal = 0;
                switch (romans[i].ToString())
                {
                    case "I": curVal = 1;break;
                    case "V": curVal = 5; break;
                    case "X": curVal = 10; break;
                    case "L": curVal = 50; break;
                    case "C": curVal = 100; break;
                    case "D": curVal = 500; break;
                    case "M": curVal = 1000; break;
                }
                
                if (lastVal < curVal && stack.Count > 0)
                {
                    // Search backwards
                    // followed by bigger -> pop from stack, substract from current value and push to stack
                    stack.Push(curVal - stack.Pop());
                }
                else
                {
                    // Apply sum to result
                    stack.Push(curVal);
                }
                lastVal = curVal;
            }

            int result = 0;
            while (stack.Count() > 0)
            {
                result += stack.Pop();
            }
            return result;
        }
    }
}
