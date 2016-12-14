using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "majorIndex": 
    /// https://codefights.com/challenge/CN6zAWnaZYjcQTRyf
    /// 
    /// Given a non-negative number, calculate the sum of the 0-based positions from the right of all "01"s in its binary representation.
    /// </summary>
    public class MajorIndex
    {
        /// <summary>
        /// Returns the sum of the positions of all "01"s in a number's binary representation.
        /// </summary>
        /// <param name="number">A number from 0 to 2^53.</param>
        /// <returns>The sum of the positions of all "01"s in <paramref name="number"/>.</returns>
        public int majorIndex(string number)
        {
            return majorIndexByBitwiseShift(number);
        }

        /// <summary>
        /// Returns the sum of the positions of all "01"s in a number's binary representation by using bitwise shift detection.
        /// </summary>
        /// <param name="number">A number from 0 to 2^53.</param>
        /// <returns>The sum of the positions of all "01"s in <paramref name="number"/>.</returns>
        int majorIndexByBitwiseShift(string number)
        {
            int sum = 0;
            int p = 0;
            long n = long.Parse(number);
            while (n > 4)
            {
                p++;
                if (n % 4 == 1) // detect trailing 01 pattern
                    sum += p;
                n >>= 1;
            }
            return sum;
        }

        /// <summary>
        /// Returns the sum of the positions of all "01"s in a number's binary representation by indexing its binary representation string.
        /// </summary>
        /// <param name="number">A number from 0 to 2^53.</param>
        /// <returns>The sum of the positions of all "01"s in <paramref name="number"/>.</returns>
        int majorIndexByBinaryString(string number)
        {
            int sum = 0;
            number = Convert.ToString(long.Parse(number), 2);
            for (int i = number.Length - 1; i > 0; i--)
            {
                if (number[i] == '1' && number[i - 1] == '0')
                    sum += number.Length - i;
            }
            return sum;
        }
    }
}
