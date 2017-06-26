using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "sumOfTwo": 
    /// https://codefights.com/interview-practice/task/Hm98RnqK9Be575yoj
    /// Asked By: Google
    /// 
    /// Given two integer arrays and an integer target value, determine whether 
    /// there exists a pair of numbers from each array that add up to the 
    /// target value.
    /// </summary>
    public class SumOfTwo
    {
        /// <summary>
        /// Determines whether or not there exists a pair of numbers from each of two arrays that add up to a target value.
        /// </summary>
        /// <param name="a">An array of integers.</param>
        /// <param name="b">An array of integers.</param>
        /// <param name="v">A target value.</param>
        /// <returns><c>true</c> if there exists a pair of elements from <paramref name="a"/> and <paramref name="b"/> that add up to <paramref name="v"/>; otherwise, false.</returns>
        public bool sumOfTwo(int[] a, int[] b, int v)
        {
            return new HashSet<int>(a).Overlaps(b.Select(_ => v - _));
        }
    }
}
