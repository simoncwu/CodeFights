using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "magicSquare3by3": 
    /// https://codefights.com/challenge/DACX76NXCaJmAQta3
    /// 
    /// Given an array of 9 integers, determine whether or not they can be used 
    /// to populate a magic square of order 3. Duplicate and non-consecutive 
    /// values are allowed in the magic square.
    /// </summary>
    public class MagicSquare3by3
    {
        /// <summary>
        /// Indicates whether or not an array of integers can form a magic square of order 3 (duplicate and non-consecutive values allowed).
        /// </summary>
        /// <param name="numbers">An array of 9 integers.</param>
        /// <returns><c>true</c> if a magic square can be made from <paramref name="numbers"/>; otherwise, <c>false</c>.</returns>
        public bool magicSquare3by3(int[] numbers)
        {
            Array.Sort(numbers);
            int i = 0;
            return 
                // the number differences from the median should be mirrored about the median
                "    ".All(_ => numbers[8 - i] + numbers[i++] == 2 * numbers[4]) && 
                // test that two triplets across all three thirds add up to the same magic number (we could do all three triplets, but any two will suffice)
                numbers[0] + numbers[4] + numbers[8] == numbers[1] + numbers[5] + numbers[6];
        }

    }
}
