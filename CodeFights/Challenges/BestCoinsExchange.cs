using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "bestCoinsExchange": 
    /// https://codefights.com/challenge/vFup7mXP4Sdfpx6TY
    /// 
    /// Given a set of distinct, arbitrary coin denominations, find a 
    /// combination using the least number of coins possible that adds up to 
    /// the target change amount. In case of a tie, choose the combination with 
    /// the highest value coin denomination.
    /// 
    /// Return the combination as an array of coin denominations where each 
    /// denomination is an array in the format [denomination, # coins], sorted 
    /// by descending denomination value.
    /// </summary>
    public class BestCoinsExchange
    {
        /// <summary>
        /// Returns the optimal combination of coins that add up to a specified amount of change.
        /// </summary>
        /// <param name="coins">An array of distinct, positive coin denomination values, in ascending order.</param>
        /// <param name="change">The desired amount of change to obtain.</param>
        /// <returns></returns>
        public int[][] bestCoinsExchange(int[] coins, int change)
        {
            // track computed "best" combinations
            var given = new int[change + 1][];
            given[0] = new int[coins.Length];
            // for each denomination
            for (int i = 0; i < coins.Length; i++)
            {
                // for all amounts <= change
                for (int j = coins[i]; j <= change; j++)
                {
                    // compare [current combination] with [current denomination + combination for [current amount - current denomination]]
                    given[j] = BestCombination(given[j], AddCoin(given[j - coins[i]], i));
                }
            }
            return given.Last().Select((_, i) => new[] { coins[i], _ }).Where(_ => _[1] > 0).Reverse().ToArray();
        }

        /// <summary>
        /// Returns the best option between two coin combinations.
        /// </summary>
        /// <param name="a">The first coin combination to compare.</param>
        /// <param name="b">The second coin combination to compare.</param>
        /// <returns>The best combination between coin combinations <paramref name="a"/> and <paramref name="b"/>.</returns>
        int[] BestCombination(int[] a, int[] b)
        {
            // potentially handles ties for same # of coins condition implicitly because most # of highest coin values will be invoked as param b last
            return a == null || b == null ? a ?? b : a.Sum() < b.Sum() ? a : b;

            // version that explicitly handles ties for same # of coins
            //if (a == null || b == null)
            //    return a ?? b;
            //int sa = a.Sum(), sb = b.Sum();
            //return sa < sb ? a : sb < sa ? b : Array.FindLastIndex(a, _ => _ > 0) > Array.FindLastIndex(b, _ => _ > 0) ? a : b;
        }

        /// <summary>
        /// Increments the count for a single denomination in a coin combination and returns it as a new coin combination instance.
        /// </summary>
        /// <param name="a">The original coin combination to augment.</param>
        /// <param name="index">The array index of the coin denomination to increment in <paramref name="a"/>.</param>
        /// <returns>An augmented coin combination based on <paramref name="a"/> where the denomination at index <paramref name="index"/> has been incremented by 1.</returns>
        int[] AddCoin(int[] a, int index)
        {
            if (a != null)
            {
                a = (int[])a.Clone();
                a[index]++;
            }
            return a;
        }
    }
}
