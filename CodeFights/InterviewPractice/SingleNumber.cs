using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "singleNumber": 
    /// https://codefights.com/interview-practice/task/APDXraJZYfPSYqQMJ/solutions
    /// Aksed By: Palantir Technologies
    /// 
    /// You are given an array of integers in which every element appears 
    /// twice, except one. Find this element using an algorithm with linear 
    /// runtime complexity (O(n)) without allocating extra memory.
    /// </summary>
    public class SingleNumber
    {
        /// <summary>
        /// Returns the value of the number that appears only once in an array.
        /// </summary>
        /// <param name="nums">An array containing unique integers in pairs, except for one that appears only once.</param>
        /// <returns>The value of the number that appears only once in <paramref name="nums"/>.</returns>
        public int singleNumber(int[] nums)
        {
            int res = 0;
            foreach (int num in nums)
            {
                // any # XOR-ed with itself cancels out to 0, 
                // so by cumulatively XOR-ing all the values, 
                // the only value that remains at the end is the one that hasn't been cancelled -- 
                // the one that appears only once (or odd # of times)
                res ^= num;
            }
            return res;
        }
    }
}
