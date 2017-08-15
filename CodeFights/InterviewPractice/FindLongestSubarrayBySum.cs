using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights challenge "findLongestSubarrayBySum": 
    /// https://codefights.com/interview-practice/task/izLStwkDr5sMS9CEm
    /// Asked By: Palantir Technologies, Facebook
    /// 
    /// Given an array of non-negative integers and a number s, find a longest 
    /// contiguous subarray with a sum equal to s and return its inclusive 
    /// bounds as an array in the format [start index, end index] (1-based). If 
    /// there are multiple such subarrays, return the one with the lowest lower 
    /// bound. If there are no answers, return [-1].
    /// </summary>
    public class FindLongestSubarrayBySum
    {
        /// <summary>
        /// Finds the bounds of the longest contiguous subarray of an array with a target total sum.
        /// </summary>
        /// <param name="s">The target sum of the subarray to find.</param>
        /// <param name="arr">An array of nonnegative integers.</param>
        /// <returns>An array of the lower and upper bounds (1-based, inclusive) of the longest, leftmost contiguous subarray of <paramref name="arr"/> with a sum of <paramref name="s"/>.</returns>
        public int[] findLongestSubarrayBySum(int s, int[] arr)
        {
            int start = 0, end = 0, sum = 0, length = 0;
            var bounds = new[] { -1 }; // default, if no matches are found

            // progressively advance right pointer from left to right
            for (; end < arr.Length; end++)
            {
                // aggregate next number
                sum += arr[end];

                // if sum exceeds target, advance left pointer and subtract values from sum until sum no longer exceeds target
                while (sum > s && start < end)
                {
                    sum -= arr[start++];
                }

                // test if subarray sum matches target and length for current pointers exceeds previous subarray length
                int curLength = end - start + 1;
                if (sum == s && curLength > length)
                {
                    // update longest subarray bounds and length
                    bounds = new[] { start + 1, end + 1 };
                    length = curLength;
                }
            }
            return bounds;
        }
    }
}
