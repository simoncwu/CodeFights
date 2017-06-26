using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "worthyDiceSet": 
    /// https://codefights.com/challenge/5vrZzsJ6L8Y5CXdKm
    /// 
    /// A "worthy" dice set is a set of rolled regular 6 side dice where the 
    /// sum and product of the face values are equal in a given modulo. Given 
    /// the number of dice and the modulo, count the ordered sets of rolled 
    /// dice results that are "worthy".
    /// </summary>
    public class WorthyDiceSet
    {
        /// <summary>
        /// Counts the number of permutations of rolling a given number of dice that result in "worthy" sets per a given modulo.
        /// </summary>
        /// <param name="n">A positive number of dice.</param>
        /// <param name="mod">A positive modulo operator.</param>
        /// <returns>The number of permutations of rolling <paramref name="n"/> dice that result in "worthy" sets.</returns>
        public int worthyDiceSet(int n, int mod)
        {
            // base empty set
            var combinations = new bool[1].Select(_ => new
            {
                sum = 0,
                product = 1
            });

            // generate dice face values
            var numbers = Enumerable.Range(1, 6);

            // loop per die
            while (n-- > 0)
            {
                // add each die face value to all possible permutations generated thus far
                combinations = combinations.SelectMany(c => numbers.Select(i => new
                {
                    sum = c.sum + i,
                    product = c.product * i
                }));
            }
            return combinations.Count(c => c.sum % mod == c.product % mod);
        }
    }
}
