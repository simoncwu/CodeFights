using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "firstDuplicate": 
    /// https://codefights.com/interview-practice/task/pMvymcahZ8dY4g75q
    /// Asked By: Google
    /// 
    /// Given an array a that contains only numbers in the range from 1 to the 
    /// length of the array, find the first duplicate instance of any number in 
    /// the array. If there are no duplicates, return -1.
    /// 
    /// The solution should have O(n) time complexity and O(1) additional space 
    /// complexity.
    /// </summary>
    public class FirstDuplicate
    {
        /// <summary>
        /// Returns the first duplicate instance of a number in an array.
        /// </summary>
        /// <param name="a">An array of positive integers up to the length of the array, inclusive.</param>
        /// <returns>The first number in <paramref name="a"/> that is a duplicate, if one exists; otherwise, <c>-1</c>.</returns>
        public int firstDuplicate(int[] a)
        {
            int i = 0, j;
            
            // loop through until the value at the index indicated by the current value is negative
            for (; i < a.Length && a[j = Math.Abs(a[i]) - 1] > 0; i++)
            {
                // mark current value as visited by negating the value at the index indicated by it
                a[j] = -a[j];
            }

            // i marks the position of the duplicate value if it is within the bounds of the array
            return i < a.Length ? Math.Abs(a[i]) : -1;
        }
    }
}
