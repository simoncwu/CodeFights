using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "longest_increasing_subsequence": 
    /// https://codefights.com/challenge/dGd57tGyHDa6dK5AF
    /// 
    /// Given an array of integers, find the longest increasing subsequence in 
    /// it. If there are multiple sequences of the maximum length, return the 
    /// lexicographically smallest one.
    /// </summary>
    public class LongestIncreasingSubsequence
    {
        /// <summary>
        /// Returns the longest increasing subsequence in an array of integers.
        /// </summary>
        /// <param name="input_array">An array of integers.</param>
        /// <returns>The longest increasing subsequence in <paramref name="input_array"/>.</returns>
        public int[] longest_increasing_subsequence(int[] input_array)
        {
            // index of previous element in sequence ending at array[n]
            var previousInSequenceIndices = new int[input_array.Length];
            // index of last element in longest subsequence of length n
            var lastSequenceElementIndices = new int[input_array.Length + 1];

            int maxLen = 0;
            // for each index in array
            for (int i = 0; i < input_array.Length; i++)
            {
                // find length of longest known sequence that can end in array[i]
                int newLen = maxLen + 1;
                while (newLen > 1 && input_array[lastSequenceElementIndices[newLen - 1]] >= input_array[i])
                {
                    newLen--;
                }

                // update/set current value as last element in sequence of found length
                previousInSequenceIndices[lastSequenceElementIndices[newLen] = i] = lastSequenceElementIndices[newLen - 1];

                // update max length if longer length found
                if (newLen > maxLen)
                    maxLen++;
            }

            // starting from last element in longest sequence, fill in sequence by walking backwards through p
            var s = new int[maxLen];
            for (int k = lastSequenceElementIndices[maxLen]; maxLen > 0; k = previousInSequenceIndices[k])
            {
                s[--maxLen] = input_array[k];
            }
            return s;
        }
    }
}
