using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "meaningOfLife": 
    /// https://codefights.com/challenge/iuePposGo5AYBn8w9
    /// </summary>
    public class MeaningOfLife
    {
        /// <summary>
        /// Hashes an alphanumeric string into a numeric result, based on the answer to the ultimate question of life, the universe, and everything.
        /// </summary>
        /// <param name="n">A string of alphanumeric characters.</param>
        /// <returns>The hash of <paramref name="n"/>.</returns>
        public long meaningOfLife(string n)
        {
            // The answer to the ultimate question of life, the universe, and everything is 42.
            long result = 0, hashScale = 42;
            var characterHash = " 07=";
            foreach (var c in n)
            {
                result = result * hashScale + c - characterHash[c / 32];
            }
            return result;
        }
    }
}
