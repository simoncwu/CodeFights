using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 4":
    /// https://codefights.com/arcade/intro/level-4
    /// </summary>
    class Level4
    {
        /// <summary>
        /// Several people are standing in a row are divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on. You are given an array of positive integers - the weights of the people. Return an array of the total weights of each team.
        /// </summary>
        /// <param name="a">An array of the people weights.</param>
        /// <returns>An array of the weights of each team.</returns>
        int[] alternatingSums(int[] a)
        {
            var sums = new int[2];
            a.Select((_, i) => sums[i % 2] += _).Count();
            return sums;
        }

        /// <summary>
        /// Given a rectangular matrix of characters, add a border of asterisks(*) to it.
        /// </summary>
        /// <param name="picture">A non-empty array of non-empty equal-length strings.</param>
        /// <returns>The same matrix of characters, framed with a border of asterisks of width 1.</returns>
        string[] addBorder(string[] picture)
        {
            var bordered = new string[picture.Length + 2];
            for (int i = 0; i < picture.Length;)
            {
                bordered[i + 1] = '*' + picture[i++] + '*';
            }
            bordered[0] = bordered[bordered.Length - 1] = new string('*', bordered[1].Length);
            return bordered;
        }

        /// <summary>
        /// Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements. Given two arrays, check whether they are similar.
        /// </summary>
        /// <param name="A">Array of integers.</param>
        /// <param name="B">Array of integers of the same length as <paramref name="A"/>.</param>
        /// <returns><c>true</c> if <paramref name="A"/> and <paramref name="B"/> are similar, <c>false</c> otherwise.</returns>
        bool areSimilar(int[] A, int[] B)
        {
            var diffs = A.Select((_, i) => i).Where(_ => A[_] != B[_]).ToArray();
            return diffs.Length == 0 || diffs.Length == 2 && A[diffs[0]] == B[diffs[1]] && B[diffs[0]] == A[diffs[1]];
        }

        /// <summary>
        /// You are given an array of integers. On each move you are allowed to increase exactly one of its element by one. Find the minimal number of moves required to obtain a strictly increasing sequence from the input.
        /// </summary>
        /// <param name="inputArray">An array of integers.</param>
        /// <returns>The minimal number of moves needed to obtain a strictly increasing sequence from <paramref name="inputArray"/>.</returns>
        int arrayChange(int[] inputArray)
        {
            int last = inputArray[0] - 1;
            return inputArray.Sum(_ => (last = Math.Max(last + 1, _)) - _);
        }

        /// <summary>
        /// Given a string, find out if its characters can be rearranged to form a palindrome.
        /// </summary>
        /// <param name="inputString">A string consisting of lowercase English letters.</param>
        /// <returns><c>true</c> if the characters of the inputString can be rearranged to form a palindrome, <c>false</c> otherwise.</returns>
        bool palindromeRearranging(string inputString)
        {
            var counts = new int[26];
            foreach (var c in inputString)
            {
                counts[c - 'a']++;
            }
            return counts.Count(_ => _ % 2 > 0) < 2;

            // one-line LINQ version, slightly less performant
            return inputString.Distinct().Count(_ => inputString.Count(c => c == _) % 2 > 0) < 2;
        }
    }
}
