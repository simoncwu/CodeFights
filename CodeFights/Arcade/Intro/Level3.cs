using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 3":
    /// https://codefights.com/arcade/intro/level-3
    /// </summary>
    class Level3
    {
        /// <summary>
        /// Given an array of strings, return another array containing all of its longest strings.
        /// </summary>
        /// <param name="inputArray">A non-empty array.</param>
        /// <returns>Array of the longest strings, stored in the same order as in the inputArray.</returns>
        string[] allLongestStrings(string[] inputArray)
        {
            int len = inputArray.Max(_ => _.Length);
            return inputArray.Where(_ => _.Length == len).ToArray();
        }

        /// <summary>
        /// Given two strings, find the number of common characters between them.
        /// </summary>
        /// <param name="s1">A string consisting of lowercase latin letters a-z.</param>
        /// <param name="s2">A string consisting of lowercase latin letters a-z.</param>
        /// <returns>The number of common characters between <paramref name="s1"/> and <paramref name="s2"/>.</returns>
        int commonCharacterCount(string s1, string s2)
        {
            return s1.Distinct().Sum(_ => Math.Min(s1.Count(l => l == _), s2.Count(l => l == _)));
        }

        /// <summary>
        /// Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half. Given a ticket number n, determine if it's lucky or not.
        /// </summary>
        /// <param name="n">A ticket number represented as a positive integer with an even number of digits.</param>
        /// <returns><c>true</c> if n is a lucky ticket number, <c>false</c> otherwise.</returns>
        bool isLucky(int n)
        {
            var N = n.ToString();
            n = N.Length / 2;
            return N.Substring(n).Sum(_ => _ - '0') == N.Remove(n).Sum(_ => _ - '0');
        }

        /// <summary>
        /// Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task is to rearrange the people by their heights in a non-descending order without moving the trees.
        /// </summary>
        /// <param name="a">An array of trees (represented by -1) and person heights, by position.</param>
        /// <returns>Sorted array <paramref name="a"/> with all the trees untouched.</returns>
        int[] sortByHeight(int[] a)
        {
            int i = 0;
            foreach (var h in a.Where(_ => _ != -1).OrderBy(_ => _))
            {
                for (; a[i] == -1; i++) ;
                a[i++] = h;
            }
            return a;
        }

        /// <summary>
        /// You are given an array of integers. On each turn you are allowed to merge any two equal numbers or split a single even number into two halves. What is the maximal integer you can get via an arbitrary number of the these operations?
        /// </summary>
        /// <param name="inputArray">Array of positive integers.</param>
        /// <returns>The maximum value that can be obtained.</returns>
        int obtainMaxNumber(int[] inputArray)
        {
            Loop:
            for (int i = 0; i < inputArray.Length; i++)
            {
                int v = inputArray[i];
                if (v == 0)
                    continue;
                int j = Array.IndexOf(inputArray, v, i + 1);
                if (j != -1)
                {
                    inputArray[i] *= 2;
                    inputArray[j] = 0;
                    goto Loop;
                }
            }
            return inputArray.Max();
        }
    }
}
