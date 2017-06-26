using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "isCryptSolution": 
    /// https://codefights.com/interview-practice/task/yM4uWYeQTHzYewW9H
    /// Asked By: Palantir Technologies
    /// 
    /// A cryptarithm is a mathematical puzzle where letters are mapped to 
    /// digits such that an arithmetic equation consisting of letters 
    /// is valid when the letters are converted to digits.
    /// 
    /// Given an array of three non-empty strings representing a cryptarithm 
    /// and an array distinctly mapping letters to numeric digits, convert the 
    /// letters in each string to digits and determine if both of the following 
    /// hold true:
    /// 1. [string/number 1] + [string/number 2] = [string/number 3], and
    /// 2. none of the converted numbers containing leading zeros.
    /// </summary>
    public class IsCryptSolution
    {
        /// <summary>
        /// Indicates whether or not a letters-to-digits mapping is a valid solution to a cryptarithm without resulting in leading zeros.
        /// </summary>
        /// <param name="crypt">An array of three non-empty strings representing the cryptarithm [string 1] + [string 2] = [string 3].</param>
        /// <param name="solution">An array of two-element character arrays representing a proposed mapping between letters and numbers, in the format [letter, digit].</param>
        /// <returns><c>true</c> if <paramref name="solution"/> is a valid solution for <paramref name="crypt"/>; otherwise, <c>false</c>.</returns>
        public bool isCryptSolution(string[] crypt, char[][] solution)
        {
            // create mapping of letters to numbers
            var map = solution.ToDictionary(_ => _[0], _ => _[1] - '0');

            // function for decoding a string into an integer
            Func<string, int> Decode = s => s.Aggregate(0, (r, v) => r * 10 + map[v]);

            return
                // check that all strings are either less than 2 digits long or doesn't lead with a 0
                crypt.All(_ => _.Length < 2 || map[_[0]] > 0) &&
                // evaluate equation
                Decode(crypt[0]) + Decode(crypt[1]) == Decode(crypt[2]);
        }
    }
}
