using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "thatsOdd": 
    /// https://codefights.com/challenge/fZDobaa2BQncF7NXA
    /// </summary>
    public class ThatsOdd
    {
        /// <summary>
        /// Indicates whether or not a string has an odd ASCII character sum.
        /// </summary>
        /// <param name="str">A string of characters.</param>
        /// <returns><c>true</c> if the sum of the ASCII characters in <paramref name="str"/> is odd; otherwise, <c>false</c>.</returns>
        public bool thatsOdd(string str)
        {
            return str.Sum(_ => _) % 2 > 0;
        }
    }
}
