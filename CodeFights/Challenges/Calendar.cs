using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "calendar": 
    /// https://codefights.com/challenge/uHyZ9Cg96B3JY2DNa
    /// 
    /// Given a specific month of a specific year, return a rectangular array 
    /// matrix representing the calendar for that month. The calendar should 
    /// contain 6 rows representing weeks, each containing 7 elements 
    /// representing weekdays, with Sunday as the first day of the week. Empty 
    /// cells should contain zeros, and the first day of the month should 
    /// appear within the first row.
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Returns a 6 x 7 matrix representing the calendar for a specific month.
        /// </summary>
        /// <param name="month">The number of a month.</param>
        /// <param name="year">The number of a year.</param>
        /// <returns>A 6 x 7 matrix representing the calendar for month <paramref name="month"/> of year <paramref name="year"/>.</returns>
        public int[][] calendar(int month, int year)
        {
            // offset the numbering by the # of the weekday that is the 1st of the month
            int i = -(int)new DateTime(year, month, 1).DayOfWeek, max = DateTime.DaysInMonth(year, month);

            // increment the counter across all cells and assign the number if it is within the bounds of the min and max day #s of the month
            return new int[6].Select(_ => new int[7].Select(o => ++i < 0 | i > max ? 0 : i).ToArray()).ToArray();
        }
    }
}
