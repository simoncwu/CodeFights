using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "reverseChallenge": 
    /// https://codefights.com/challenge/jzs6k2FedHaDfCWtv
    /// </summary>
    public class ReverseChallenge
    {
        /// <summary>
        /// Encodes a message using a reverse alphabet and in reverse letter order.
        /// </summary>
        /// <param name="s">A string to encrypt.</param>
        /// <returns>The encrypted version of <paramref name="s"/>.</returns>
        public string reverseChallenge(string s)
        {
            var sb = new StringBuilder();
            var r = s.Replace(" ", "");
            int i = r.Length;
            foreach (var c in s)
            {
                sb.Append(c == ' ' ? c : (char)(219 - r[--i]));
            }
            return sb.ToString();
        }
    }
}