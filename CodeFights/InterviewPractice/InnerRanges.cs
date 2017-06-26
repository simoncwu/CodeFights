using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution to CodeFights interview practice "innerRanges": 
    /// https://codefights.com/interview/sSpmKahzuxJQe9gSu
    /// 
    /// Given a sorted integer array in which the range of elements is in the 
    /// inclusive range [l, r], return its missing inner ranges as an array of 
    /// range strings, with each range in the form "n" if the range covers a 
    /// single number, or "start->end" if it covers a range of numbers.
    /// </summary>
    public class InnerRanges
    {
        /// <summary>
        /// Returns the inner ranges not covered by an array of integers for a specific range of values.
        /// </summary>
        /// <param name="nums">A sorted array of integers within a range of values.</param>
        /// <param name="l">The lower bound of the range, inclusive.</param>
        /// <param name="r">The upper bound of the range, inclusive.</param>
        /// <returns>An array of strings representing the inner ranges of the range from <paramref name="l"/> to <paramref name="r"/> not covered by the values in <paramref name="nums"/>.</returns>
        public string[] innerRanges(int[] nums, int l, int r)
        {
            var ranges = new List<string>();
            foreach (var n in nums)
            {
                // l represents the next number expected
                if (l < n)
                {
                    // add the missing range from l to n - 1
                    ranges.Add(l + (l < n - 1 ? "->" + (n - 1) : ""));
                    // update l to n + 1, adjusting for possible 32-bit integer overflow
                    l = Math.Max(n, n + 1);
                }
                else if (l == n)
                {
                    // expected number was specified, so increment to next in sequence, adjusting for possible 32-bit integer overflow
                    l = Math.Max(l, l + 1);
                }
            }

            // check for missing values between end of array and upper bound
            if (!nums.Any() || l > nums.Last() && l <= r)
                ranges.Add(l + (l < r ? "->" + r : ""));

            return ranges.ToArray();
        }
    }
}
