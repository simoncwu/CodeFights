using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "chickenNuggetNumber": 
    /// https://codefights.com/challenge/3vvqhbQbvghe3yGTB
    /// 
    /// Given three distinct denominations of chicken nuggets per box that one 
    /// can buy, determine the maximum number of nuggets that cannot be 
    /// obtained using only these sizes.
    /// </summary>
    public class ChickenNuggetNumber
    {
        /// <summary>
        /// Calculates the maximum number of chicken nuggets that cannot be obtained using only a given set of box sizes.
        /// </summary>
        /// <param name="sizes">A sorted array of chicken nugget box sizes.</param>
        /// <returns>The maximum number of nuggets that cannot be obtained using boxes of sizes <paramref name="sizes"/>.</returns>
        public int chickenNuggetNumber(int[] sizes)
        {
            int max = 0;

            // seed possible quantities as 0, and each box size
            var possibleQuantities = new HashSet<int>(sizes);
            possibleQuantities.Add(0);

            // exit condition is when a full contiguous partition of the smallest size is possible, => all subsequent values are possible by building upon the full partition
            for (int i = 0; i <= max + sizes[0]; i++)
            {
                // if any previous quantity that differs by one of the box sizes was possible, then current quantity is also possible
                if (sizes.Any(_ => possibleQuantities.Contains(i - _)))
                {
                    possibleQuantities.Add(i);
                }
                else
                {
                    max = i; // update latest impossible quanitty found
                }
            }
            return max;
        }
    }
}
