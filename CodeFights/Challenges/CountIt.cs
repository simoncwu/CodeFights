using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "countIt": 
    /// https://codefights.com/challenge/v5Zg8trjoun3PTxrZ
    /// </summary>
    public class CountIt
    {
        /// <summary>
        /// Counts the number of loops in the written form of a number.
        /// </summary>
        /// <param name="n">The number to analyze.</param>
        /// <returns>The number of loops in the written form of <paramref name="n"/>.</returns>
        public int countIt(int n)
        {
            return (n + "").Sum(_ => _ == '8' ? 2 : "069".Contains(_) ? 1 : 0);
        }

    }
}
