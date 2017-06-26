using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "sumInRange": 
    /// https://codefights.com/interview-practice/task/4MoqQLaw22nrzXbgs
    /// Asked By: Palantir Technologies
    /// 
    /// For each query in an array of queries and an array of integers, find 
    /// the sum of the elements in the array from index query[0] to query[1], 
    /// inclusive. Return the sum of all query results, modulo 10^9 + 7.
    /// </summary>
    public class SumInRange
    {
        /// <summary>
        /// Returns the sum of the sums of several ranges of values in an array of integers.
        /// </summary>
        /// <param name="nums">An array of integers.</param>
        /// <param name="queries">An array of ranges to sum, each as an array of the form [start index, end index].</param>
        /// <returns>The sum of the sums of each range in <paramref name="queries"/>, modulo 10^9 + 7.</returns>
        public int sumInRange(int[] nums, int[][] queries)
        {
            // sumFromZero[i] represents the sum of all values from index 0 to index i - 1, i.e., [0, i - 1]
            var sumFromZero = new int[nums.Length + 1];
            int m = 1000000007, sum = 0;

            // populate sumFromZero array
            for (int i = 0; i < nums.Length;)
            {
                sumFromZero[++i] = sumFromZero[i - 1] + nums[i - 1];
            }

            // process queries
            foreach (var q in queries)
            {
                // range [x, y] = [0, y + 1] - [0, x]
                sum = (sum + sumFromZero[q[1] + 1] - sumFromZero[q[0]]) % m;

                // to reproduce python's modulo behavior (as opposed to remainder), add modulus to value if it is negative
                if (sum < 0)
                    sum += m;
            }
            return sum;
        }
    }
}
