using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "northPoleTrafficClock": 
    /// https://codefights.com/challenge/SR6zZZEzfEwpyCC8f
    /// 
    /// You are given an array of several strings depicting the countdown 
    /// states of a seven-segment digital timer with two digits. Each state is 
    /// a six character representation of the lower three segments of both 
    /// digits. The first string represents the timer's start value, and each 
    /// string that follows represents the next value in the countdown. The 
    /// array does not necessarily contain the entire countdown sequence to 
    /// zero. Digit segments are represented by '|' for vertical segments, '_' 
    /// for horizontal segments, and '*' for empty segments.
    /// 
    /// Given a sequence of countdown states, return an array of all possible 
    /// timer start values in descending order.
    /// </summary>
    public class NorthPoleTrafficClock
    {
        /// <summary>
        /// Finds all possible start values for a timer with a damaged display based upon a series of countdown sequence readings.
        /// </summary>
        /// <param name="countdown">A series of countdown sequence readings.</param>
        /// <returns>An array of all possible timer start values, in descending order.</returns>
        public int[] northPoleTrafficClock(string[] countdown)
        {
            var digits = new[] { "|_|", "**|", "|_*", "*_|", "**|", "*_|", "|_|", "**|", "|_|", "**|" };
            var starts = new int[100].Select((_, i) => i).ToArray();
            // generate all possible display values
            var display = starts.Select(_ => digits[_ / 10] + digits[_ % 10]).ToArray();
            for (int i = 0; i < countdown.Length; i++)
            {
                // filter candidates to only those whose i-th countdown value matches the corresponding display value
                starts = starts.Where(_ => countdown[i].Remove(3) == "***" ? _ - i < 10 && _ >= i && display[_ - i] == "|_|" + countdown[i].Substring(3) : _ >= i && display[_ - i] == countdown[i]).ToArray();
            }
            return starts.Reverse().ToArray();
        }
    }
}
