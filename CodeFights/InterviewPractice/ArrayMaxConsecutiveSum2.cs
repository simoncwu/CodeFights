using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution to CodeFights interview practice "arrayMaxConsecutiveSum2": 
    /// https://codefights.com/interview-practice/task/dQD4TCunke2JQ98rj
    /// 
    /// Given an array of integers, find the maximum possible sum of a 
    /// contiguous subarray with at lesat 1 element.
    /// </summary>
    public class ArrayMaxConsecutiveSum2
    {
        /// <summary>
        /// Returns the maximum possible sum of any contiguous non-empty subsequence of an array.
        /// </summary>
        /// <param name="inputArray">An array of integers.</param>
        /// <returns>The maximum possible sum of any non-empty subarray of <paramref name="inputArray"/>.</returns>
        public int arrayMaxConsecutiveSum2(int[] inputArray)
        {
            int sum = -1;
            // aggregate values into sum so long as it stays nonnegative. 
            // once the sum is negative, reset sum to current value (drop all previous values)
            return inputArray.Max(_ => sum = sum < 0 ? _ : _ + sum);
        }
    }
}
