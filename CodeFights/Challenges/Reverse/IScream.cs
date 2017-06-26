using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "iScream": 
    /// https://codefights.com/challenge/mKe7e4ENqEF2v5QNz
    /// </summary>
    public class IScream
    {
        /// <summary>
        /// Returns the unordered number of flavor selections for an ice cream order.
        /// </summary>
        /// <param name="flavors">The number of flavors available to choose from.</param>
        /// <param name="scoops">The number of scoops being ordered.</param>
        /// <returns></returns>
        public int iScream(int flavors, int scoops)
        {
            // solved using combination with replacememnt, or k-multicombination

            // recursive algorithm
            //return scoops < 1 ? 1 : iScream(flavors + 1, scoops - 1) * flavors / scoops;

            // iterative algorithm
            decimal c = 1;
            for (; scoops > 0; flavors++, scoops--)
            {
                c = c * flavors / scoops;
            }
            return (int)Math.Round(c);
        }
    }
}