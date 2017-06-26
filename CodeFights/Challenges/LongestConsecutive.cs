using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "longestConsecutive": 
    /// https://codefights.com/challenge/J9z6mzQQziyZuwPQJ
    /// 
    /// Given an array of non-negative integers, return the position of the 
    /// first number in the array with the most consecutive set bits in its 
    /// binary representation out of all numbers in the array.
    /// </summary>
    public class LongestConsecutive
    {
        /// <summary>
        /// Returns the position of the first number in an array with the most consecutive set bits in its binary representation.
        /// </summary>
        /// <param name="arr">An array of non-negative integers.</param>
        /// <returns>The 0-based position of the first number</returns>
        public int longestConsecutive(int[] arr)
        {
            int index = 0, max = 0, i = 0;
            for (; i < arr.Length; i++)
            {
                int count = 0, n = arr[i];

                // count max # of consecutive bits: each & with shift unsets the last 1 in each group of 1s
                for (; n > 0; count++)
                {
                    n &= n << 1;
                }

                // update index and max if greater # of bits found
                if (count > max)
                {
                    index = i;
                    max = count;
                }
            }
            return index;
        }
    }
}
