using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.kyu6
{
    public class FindTheOddInt
    {

        /// <summary>
        /// Kata: 54da5a58ea159efa38000836
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int find_it(int[] seq)
        {
            var result = seq.GroupBy(x => x)
                .Select(group => new
                {
                    key = group.Key,
                    cnt = group.Count()
                })
                .Where(x => x.cnt % 2 == 1).First();

            return result.key;
        }
    }
}
