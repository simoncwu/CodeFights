using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "product": 
    /// https://codefights.com/challenge/MAKAXvQK7v95B3j9R
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Returns the square of the floor of half the length of a string.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <returns></returns>
        public int product(string s)
        {
            int n = s.Length / 2;
            return n * n;
        }
    }
}
