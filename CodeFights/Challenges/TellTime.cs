using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "tellTime": 
    /// https://codefights.com/challenge/ud7b7W8QiEQQsyTvx
    /// 
    /// Express the time shown on a digital clock as a string of English words, 
    /// rounded to the nearest 5 minutes.
    /// </summary>
    public class TellTime
    {
        /// <summary>
        /// Returns a string representing a digital clock time in English as words, rounded to the nearest 5 minutes.
        /// </summary>
        /// <param name="time_str">A valid time in hh:mm format.</param>
        /// <returns>The value of <paramref name="time_str"/> in English words.</returns>
        public string tellTime(string time_str)
        {
            int hours = time_str[0] % 12 * 10 + time_str[1] % 12,
                minutes = ((time_str[3] % 12 * 10 + time_str[4] % 12) * 2 + 5) / 10 * 5;
            time_str = " past ";
            // if time is past the half hour, adjust to be relative to next hour
            if (minutes > 30)
            {
                minutes = 60 - minutes;
                hours = hours % 12 + 1;
                time_str = " to ";
            }
            else if (minutes == 0)
            {
                time_str = "";
            }
            return
                "It's " +
                // minutes
                ".....five.....ten.....quarter.....twenty.....twenty five.....half".Split('.')[minutes] +
                // "past"/"to"
                time_str +
                // hour
                " one two three four five six seven eight nine ten eleven twelve".Split()[hours] +
                // "o'clock" if start of the hour
                (minutes == 0 ? " o'clock" : "");
        }
    }
}
