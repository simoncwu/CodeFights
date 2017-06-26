using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "snowmen": 
    /// https://codefights.com/challenge/G3NpJorpYBwC3Nviz
    /// 
    /// Building a snowman requires three snowballs of different radii. Given 
    /// an array of radii for various spherical snowballs, calculate the 
    /// minimum possible amount of snow that will be left over after building 
    /// as many snowmen as possible. Express this as the sum of the volumes of 
    /// the remaining snowballs.
    /// </summary>
    public class Snowmen
    {
        /// <summary>
        /// Returns the minimum amount of snow that is left over after building as many snowmen as possible from snowballs.
        /// </summary>
        /// <param name="snowballs">An array of the radii of the snowballs available.</param>
        /// <returns>The minimal volume of unused snow.</returns>
        public double snowmen(int[] snowballs)
        {
            return BuildSnowmen(snowballs).Sum(_ => _ * _ * _) * Math.PI * 4 / 3;
        }

        /// <summary>
        /// Returns the snowballs that is left over after building as many snowmen as possible from snowballs.
        /// </summary>
        /// <param name="snowballs">An array of the radii of the snowballs available.</param>
        /// <returns>The radii of the smallest unused snowballs possible.</returns>
        int[] BuildSnowmen(int[] snowballs)
        {
            Array.Sort(snowballs, (a, b) => b - a);
            var unused = new List<int>();
            int snowmenCount = snowballs.Length / 3, snowman = snowmenCount;

            // represents tiers of snowmen parts
            var parts = new[] {
                // start with largest parts
                snowballs.Take(snowmenCount).ToArray(),
                new int[snowmenCount],
                new int[snowmenCount]
            };

            // fill 2nd, 3rd tiers from largest to smallest
            foreach (var s in snowballs.Skip(snowmenCount))
            {
                int tier = snowman / snowmenCount;
                // if smaller than previous tier, use snowball
                if (snowman < 3 * snowmenCount && parts[tier - 1][snowman % snowmenCount] > s)
                    parts[tier][snowman++ % snowmenCount] = s;
                // else we can't use it at all
                else
                    unused.Add(s);
            }

            // add smallest of incomplete snowmen parts
            if (snowman < 3 * snowmenCount)
                unused.AddRange(BuildMaximalSnowmen(parts.SelectMany(_ => _).ToArray()).Where(_ => _ > 0));

            return unused.ToArray();
        }

        /// <summary>
        /// Returns the snowballs that are left over after building maximal-size snowmen from snowballs.
        /// </summary>
        /// <param name="snowballs">An array of the radii of the snowballs available.</param>
        /// <returns>The radii of the snowballs left over.</returns>
        int[] BuildMaximalSnowmen(int[] snowballs)
        {
            int smallest;
            // minimize leftover snowballs by repeatedly creating maximal size snowmen until no more can be made
            do
            {
                smallest = -1;
                // try to find largest snowball
                int largest = Array.FindIndex(snowballs, _ => _ > 0);
                if (largest >= 0)
                {
                    // try to find largest snowball < largest
                    int middle = Array.FindIndex(snowballs, _ => _ < snowballs[largest] && _ > 0);
                    if (middle > 0)
                    {
                        // try to find largest snowball < middle
                        smallest = Array.FindIndex(snowballs, _ => _ < snowballs[middle] && _ > 0);
                        if (smallest > 0)
                        {
                            // found maximal snowman combination, so use/erase it
                            snowballs[largest] = snowballs[middle] = snowballs[smallest] = 0;
                        }
                    }
                }
            } while (smallest >= 0);
            return snowballs;
        }
    }
}
