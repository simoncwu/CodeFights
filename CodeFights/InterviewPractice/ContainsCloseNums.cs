using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution to CodeFights interview practice "containsCloseNums": 
    /// https://codefights.com/interview-practice/task/njfXsvjRthFKmMwLC
    /// Asked By: Palantir Technologies
    /// 
    /// Given an array of integers and an integer k, determine if there exists 
    /// any pair of duplicate values in the array that are no more than k 
    /// positions apart.
    /// </summary>
    public class ContainsCloseNums
    {
        /// <summary>
        /// Indicates whether or not an array contains any pair of duplicate values that are no more than a given number of positions apart.
        /// </summary>
        /// <param name="nums">An array of integers.</param>
        /// <param name="k">The maximum number of positions apart that a pair of duplicates can be.</param>
        /// <returns><c>true</c> if <paramref name="nums"/> contains any pair of duplicates that are no more than <paramref name="k"/> positions apart.</returns>
        public bool containsCloseNums(int[] nums, int k)
        {
            // track the index of the last time each value was encountered
            var lastIndex = new Dictionary<int, int>();
            int i = 0;
            foreach (var n in nums)
            {
                // check if the last instance of the current value was seen at most k positions prior
                if (lastIndex.ContainsKey(n) && i - lastIndex[n] <= k)
                    return true;
                // update last seen instance of the current value
                lastIndex[n] = i++;
            }
            return false;
        }

    }
}
