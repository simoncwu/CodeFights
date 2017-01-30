using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "holidayBreak": 
    /// https://codefights.com/challenge/yBwcdkwQm5tAG2MJo
    /// 
    /// If winter break each school year starts no later than December 23 and 
    /// ends no earlier than January 1; and a school week must have at least 3 
    /// school days; and January 2 is also a holiday if January 1 falls on a 
    /// Sunday; determine the length, in days, of the winter break that starts 
    /// in a given school year.
    /// </summary>
    public class HolidayBreak
    {
        /// <summary>
        /// Returns the length, in days, of the winter break for a specific school year.
        /// </summary>
        /// <param name="year">The year in which the winter break begins.</param>
        /// <returns>The length of the winter break for year <paramref name="year"/>, in days.</returns>
        public int holidayBreak(int year)
        {
            var start = new DateTime(year, 12, 23);
            // adjust start for a proper school week
            if (start.DayOfWeek < DayOfWeek.Thursday)
                start = start.AddDays(-1 - (int)start.DayOfWeek);

            var end = new DateTime(year + 1, 1, 2);
            // adjust end for 1/1 falling on Sunday
            if (end.DayOfWeek == DayOfWeek.Monday)
                end = end.AddDays(1);
            // adjust end for a proper school week.
            if (((int)end.DayOfWeek + 6) % 7 > 2)
                end = end.AddDays((8 - (int)end.DayOfWeek) % 7);

            return (end - start).Days;
        }
    }
}