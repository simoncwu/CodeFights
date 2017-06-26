using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "studentsAge": 
    /// https://codefights.com/challenge/95w2q3BNpMT5M2yfs
    /// 
    /// You are given an unsorted array of the ages of a classroom's students, 
    /// calculate the number of pairings of students such that one is younger 
    /// than the other by exactly 1 and also precedes the older one in the 
    /// array.
    /// </summary>
    public class StudentsAge
    {
        /// <summary>
        /// Counts the number of pairings of students in an array where a student precedes another student who is older by exactly 1.
        /// </summary>
        /// <param name="students">An unsorted array of students' ages.</param>
        /// <returns>The number of pairings of younger students that precede a student who is older by 1.</returns>
        public int studentsAge(int[] students)
        {
            // counts[i] represents # of students of age i + 1 (due to 0-based indexing)
            var counts = new int[100002];
            int total = 0;
            foreach (var age in students)
            {
                // increment age count
                counts[age + 1]++;
                // pair with # of students of age (age = i + 1) - 1
                total += counts[age];
            }
            return total;
        }
    }
}
