using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "rotateArrayFromIndex": 
    /// https://codefights.com/challenge/zgsSAjAL2vstp35ce
    /// 
    /// Build a function that rotates a number in an array to another location 
    /// in the array, both specified by index. If the index is out of the 
    /// bounds of the array, use the nearest valid index. Both indices are 
    /// guaranteed to be nonnegative.
    /// </summary>
    public class RotateArrayFromIndex
    {
        /// <summary>
        /// Rotates a number in an array to another location in the array.
        /// </summary>
        /// <param name="values">An array of integers.</param>
        /// <param name="start">The index of the number to rotate.</param>
        /// <param name="end">The rotation destination index.</param>
        /// <returns>The <paramref name="values"/> array after rotating the number at index <paramref name="start"/> to index <paramref name="end"/>.</returns>
        /// <remarks>If either index parameter is outside the bounds of the <paramref name="values"/> array, the nearest valid index is used instead.</remarks>
        public int[] rotateArrayFromIndex(int[] values, int start, int end)
        {
            // greatest valid index
            int n = values.Length - 1;

            // correct indices that are past the end of the array.
            end = end > n ? n : end;
            start = start > n ? n : start;

            // swap values from start position to end
            for (n = values[start]; start != end; values[start] = n)
            {
                // advance start pointer in the direction of end index
                values[start] = values[start += start < end ? 1 : -1];
            }
            return values;
        }

    }
}
