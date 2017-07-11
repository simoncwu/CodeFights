using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution to CodeFights reverse challenge "oneLeft": 
    /// https://codefights.com/challenge/Y7RAnE4xmuyb4KkcB
    /// </summary>
    public class OneLeft
    {
        /// <summary>
        /// Shifts each letter in a string one key to the left on a QWERTY keyboard (round-robin).
        /// </summary>
        /// <param name="s">A string of lowercase English letters.</param>
        /// <returns>The value of <paramref name="s"/> with each letter shifted one key to the left on a keyboard.</returns>
        public string oneLeft(string s) => s.Aggregate("", (r, v) => r + "lvxswdfguhjknbiopearycqztm"[v - 97]);
    }
}
