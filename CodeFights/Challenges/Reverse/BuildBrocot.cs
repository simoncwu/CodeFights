using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "buildBrocot": 
    /// https://codefights.com/challenge/BWcHvXN8B9oSKDRoc
    /// </summary>
    public class BuildBrocot
    {
        /// <summary>
        /// Returns the path from the root of a Stern-Brocot tree to a specified node.
        /// </summary>
        /// <param name="s">The value of the target Stern-Brocot tree node.</param>
        /// <returns>The path from the root to the node whos value is <paramref name="s"/> as a series of "L" and "R" path choices.</returns>
        public string buildBrocot(string s)
        {
            var mn = Array.ConvertAll((s + "/1").Split('/'), decimal.Parse);
            decimal c = 1, C = 1, l = 0, L = 1, r = 1, R = 0;
            var sb = new StringBuilder();
            while (mn[0] != c | mn[1] != C)
            {
                if (mn[0] / mn[1] < c / C)
                {
                    // left path
                    r = c;
                    R = C;
                    c += l;
                    C += L;
                    sb.Append("L");
                }
                else
                {
                    // right path
                    l = c;
                    L = C;
                    c += r;
                    C += R;
                    sb.Append("R");
                }
            }
            return sb.ToString();
        }
    }
}
