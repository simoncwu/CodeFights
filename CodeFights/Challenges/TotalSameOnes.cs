using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "totalSameOnes": 
    /// https://codefights.com/challenge/dBrLcRdRDSPKeHzd5
    /// 
    /// Given a positive integer k, count how many numbers there are in the 
    /// range from 1 to k (inclusive) that have the same number of set bits in 
    /// their binary representations as k.
    /// </summary>
    public class TotalSameOnes
    {
        /// <summary>
        /// Counts the number of positive integers up to and including a specified number that have the same number of set binary bits as the specified number.
        /// </summary>
        /// <param name="k">A positive integer.</param>
        /// <returns>The number of positive integers up to and including <paramref name="k"/> that have the same number of set binary bits as <paramref name="k"/>.</returns>
        public int totalSameOnes(int k)
        {
            return totalSameOnesCombinatorial(k);
        }

        /// <summary>
        /// Counts the number of positive integers up to and including a specified number that have the same number of set binary bits as the specified number, using a combinatorial algorithm.
        /// </summary>
        /// <param name="k">A positive integer.</param>
        /// <returns>The number of positive integers up to and including <paramref name="k"/> that have the same number of set binary bits as <paramref name="k"/>.</returns>
        int totalSameOnesCombinatorial(int k)
        {
            int setBits = k % 2, places = 0, count = 1, combinations = 1;
            while (k > 0)
            {
                combinations = ++places > setBits ? combinations * places / (places - setBits) : 1;
                k >>= 1;
                if (k % 2 > 0)
                    count += combinations = combinations * (places - setBits++) / setBits;
            }
            return count;
        }

        int totalSameOnesGospers(int k)
        {
            return 0;
        }
    }
}
