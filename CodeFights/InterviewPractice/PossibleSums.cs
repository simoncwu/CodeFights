using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "possibleSums": 
    /// https://codefights.com/interview-practice/task/rMe9ypPJkXgk3MHhZ
    /// Asked By: Google
    /// 
    /// Given the values of a collection of coins and the quantities of each 
    /// denomination, find the number of distinct, positive sums that can be 
    /// made using all possible groupings of the coins.
    /// </summary>
    public class PossibleSums
    {
        /// <summary>
        /// Counts the number of distinct positive total amounts that can be made using a collection of coins.
        /// </summary>
        /// <param name="coins">An array containing various (not necessarily unique) denominations of coin values in the collection.</param>
        /// <param name="quantity">An array containing the quantities on hand of each respective coin denomination in <paramref name="coins"/>.</param>
        /// <returns>The number of distinct possible positive sums that can be created with the coin collection.</returns>
        public int possibleSums(int[] coins, int[] quantity)
        {
            var sums = new HashSet<int>(); // since we're counting distinct, use hashset
            sums.Add(0); // base default sum of nothing
            for (int i = 0; i < coins.Length; i++)
            {
                foreach (var s in sums.ToArray())
                {
                    // for each increment of each coin denomination, sum with sums previously achieved
                    var c = s + coins[i];
                    for (int j = 0; j < quantity[i]; j++, c += coins[i])
                    {
                        sums.Add(c);
                    }
                }
            }

            // subtact 1 from count for implicit sum of 0
            return sums.Count - 1;
        }
    }
}
