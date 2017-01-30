using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "extractPinCode": 
    /// https://codefights.com/challenge/jopxFifZN3GPjG856
    /// 
    /// Given a set of real-world coordinates representing touch positions on a 
    /// 2D keypad in pairs of alternating y- and x-coordinate values for each 
    /// touch, extract and return the four-digit PIN code that was entered. The 
    /// keypad has a memory capacity of only the last four entered digits, and 
    /// is laid out as a grid as follows:
    ///   x →
    /// y 1 2 3
    /// ↓ 4 5 6
    ///   7 8 9
    ///   * 0 #
    /// where * is the submit button and # erases the last digit entered. The 
    /// horizontal and vertical length of each button and each space between 
    /// buttons is 1.0.
    /// </summary>
    public class ExtractPinCode
    {
        /// <summary>
        /// Extracts a four-digit PIN code from a sequence of keypad touch positions.
        /// </summary>
        /// <param name="coordinateSequence">The sequence of real-world coordinates that correspond to touch positions on a keypad.</param>
        /// <returns>The four-digit PIN code that was entered during <paramref name="coordinateSequence"/>.</returns>
        public int[] extractPinCode(double[] coordinateSequence)
        {
            var code = new int[4];
            int i = coordinateSequence.Length - 3,
                c = 3,
                erasures = 0;

            // final touch position is submit key, so use that to anchor all other touch positions
            double offsetX = coordinateSequence[i + 2], offsetY = coordinateSequence[i + 1] - 6;

            // extract digits in reverse sequence order
            while (c >= 0)
            {
                var d = ToDigit(coordinateSequence[i--] - offsetX, coordinateSequence[i--] - offsetY);
                // only extract digit if an erasure is not pending
                if (d > 11)
                    erasures++;
                else if (erasures > 0)
                    erasures--;
                else
                    code[c--] = d % 10;
            }
            return code;
        }

        /// <summary>
        /// Converts a keypad touch position to its corresponding digit.
        /// </summary>
        /// <param name="x">The x-coordinate of the touch position.</param>
        /// <param name="y">The y-coordinate of the touch position.</param>
        /// <returns>The keypad digit that corresponds to the specified touch position.</returns>
        /// <remarks>The coordinate system is such that (0,0) represents the upper-left corner of the [1] key and (5,7) represents the bottom-right corner of the erase key.</remarks>
        int ToDigit(double x, double y)
        {
            return (int)(x + 3) / 2 + 3 * (int)(++y / 2);
        }
    }
}
