using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.kyu5
{
    public class ProductOfConsecutiveFibNumbers
    {

        public static ulong[] productFib(ulong prod)
        {
            ulong n=1, n1=0, next;
            while (true)
            {
                if ((n * n1) >= prod)
                {
                    return new ulong[3] { n1, n, ((n * n1) == prod) ? (ulong)1 : (ulong)0 };
                }
                else
                {
                    next = n + n1;
                    n1 = n;
                    n = next;
                }
            }
        }

    }
}
