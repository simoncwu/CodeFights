using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "alpha5": 
    /// https://codefights.com/challenge/KQqMrjTTZ3o8tASdP
    /// </summary>
    public class Alpha5
    {
        /// <summary>
        /// Returns an uppercase letter of the alphabet using the indices of the a string's letters as an index.
        /// </summary>
        /// <param name="s">The string to be used as an index.</param>
        /// <returns>An uppercase letter </returns>
        public char alpha5(string s)
        {
            return (char)(65 + s.Sum(_ => _ - 97) % 26);
        }
    }
}
