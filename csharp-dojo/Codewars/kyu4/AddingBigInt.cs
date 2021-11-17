using System.Numerics;

namespace Codewars.kyu4
{
    public class AddingBigInt
    {

        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
