using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "toms_wagons": 
    /// https://codefights.com/challenge/X8dWNNGxbAAnMkBaB
    /// 
    /// Tom goes to a train station every afternoon to watch a train on its 
    /// daily run. This train starts each month with only 1 wagon, and then 
    /// grows in length by 2 wagons each day throughout the month. Starting on 
    /// a specific day of the year, Tom will be away for a certain number of 
    /// days, during which time he will miss the wagons on this daily train. 
    /// Given the day, month, and number of days away, calculate the total 
    /// number of wagons Tom will miss whilst away. Ignore leap year 
    /// conditions in your calculations.
    /// </summary>
    public class TomsWagons
    {
        /// <summary>
        /// Returns the total number of wagons Tom will miss whilst away.
        /// </summary>
        /// <param name="month">The 1-based number of the month when Tom starts his leave.</param>
        /// <param name="day">The 1-based day of the month when Tom starts his leave.</param>
        /// <param name="n">The number of days Tom will be away.</param>
        /// <returns>The total number of wagons Tom will miss whilst away.</returns>
        public int toms_wagons(int month, int day, int n)
        {
            // first month
            int days = Math.Min(Days(--month) - --day, n), w = Wagons(day, day + days);

            // subsequent months
            while ((n -= days) > 0)
            {
                days = Math.Min(Days(++month % 12), n);
                w += Wagons(0, days);
            }
            return w;
        }

        /// <summary>
        /// Returns the number of days in a month.
        /// </summary>
        /// <param name="month">The 0-based index of the month.</param>
        /// <returns>The number of days in month <paramref name="month"/>.</returns>
        int Days(int month)
        {
            return month % 7 % 2 < 1 ? 31 : month < 2 ? 28 : 30;
        }

        /// <summary>
        /// Returns the total number of wagons that will run within a specific timeframe during a single month.
        /// </summary>
        /// <param name="start">The 0-based starting day of the timeframe, inclusive.</param>
        /// <param name="end">The 0-based ending day of the timeframe, exclusive.</param>
        /// <returns>The total number of wagons from day <paramref name="start"/> until <paramref name="end"/>, exclusive.</returns>
        int Wagons(int start, int end)
        {
            return (start + end) * (end - start);
        }
    }
}
