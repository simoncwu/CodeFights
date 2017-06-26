using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "containsDuplicates": 
    /// https://codefights.com/interview-practice/task/CfknJzPmdbstXhsoJ
    /// Asked By: Palantir Technologies
    /// 
    /// Determine whether an array of integers contains any duplicates.
    /// </summary>
    public class ContainsDuplicates
    {
        /// <summary>
        /// Indicates whether or not an array of integers contains any duplicates.
        /// </summary>
        /// <param name="a">An array of integers.</param>
        /// <returns><c>true</c> if <paramref name="a"/> contains any duplicates; otherwise, <c>false</c>.</returns>
        public bool containsDuplicates(int[] a)
        {
            // complexity bounded by internal implementation of LINQ Distinct() method, probably around O(n):
            return a.Distinct().Count() < a.Length;

            // or same as above, with worse worst-case additional O(n) comparisons but better best-case:
            return !a.SequenceEqual(a.Distinct());

            // or single-pass with O(n) memory:
            var distinct = new HashSet<int>();
            foreach (var n in a)
            {
                if (distinct.Contains(n))
                    return true;
                distinct.Add(n);
            }
            return false;

            // or complexity bounded by array sort:
            Array.Sort(a);
            for (int i = 0; ++i < a.Length;)
            {
                if (a[i] == a[i - 1])
                    return true;
            }
            return false;
        }
    }
}
