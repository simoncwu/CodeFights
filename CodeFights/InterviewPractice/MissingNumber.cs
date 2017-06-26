using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "missingNumber": 
    /// https://codefights.com/interview-practice/task/PLCrGrJmBxQdj8QKX
    /// Asked By: Microsoft, Twitter
    /// 
    /// Given an unsorted array of integers starting from 0 that is nearly 
    /// consecutive save for a single missing number, find the missing number.
    /// </summary>
    public class MissingNumber
    {
        /// <summary>
        /// Returns the number that is missing from an unsorted array of nearly-consecutive integers.
        /// </summary>
        /// <param name="arr">An array of nearly-consecutive integers except for one missing number.</param>
        /// <returns>The number that is missing from <paramref name="arr"/>.</returns>
        public int missingNumber(int[] arr)
        {
            int n = arr.Length;
            // the sum of numbers from 1 to n is n * (n - 1) / 2, so subtracting from that the sum of all numbers will yield the missing element
            return n * ++n / 2 - arr.Sum();
        }

    }
}
