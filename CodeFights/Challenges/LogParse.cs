using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "logParse": 
    /// https://codefights.com/challenge/tJkNfRGxq9txcrqCB
    /// 
    /// Analyze a set of product sales analytics log entries, each formatted as 
    /// <period_start>,<period_end>,<users_visited>,<profit_made>, and find the 
    /// entry with the lowest per capita profit, i.e., with the lowest 
    /// <profit_made> / <users_visited> / <period_length> value. Return the 
    /// answer as an array of the Unix timestamps for the entry's period start 
    /// and end values. The answer is guaranteed to be unique. If there are no 
    /// logs, return an empty array instead.
    /// </summary>
    public class LogParse
    {
        /// <summary>
        /// Returns the period start and end timestamps of the log entry with the lowest per capita profit.
        /// </summary>
        /// <param name="logs">An array of log entries.</param>
        /// <returns>The period start and end timestamps of the entry in <paramref name="logs"/> with the lowest per capita profit.</returns>
        public int[] logParse(string[] logs) =>
            logs.Any() ? (from l in logs
                          let logComponents = l.Split(',')
                          let periodStartTimestamp = DateTimeToTimestamp(logComponents[0])
                          let periodEndTimestamp = DateTimeToTimestamp(logComponents[1])
                          orderby int.Parse(logComponents[3]) / (periodStartTimestamp - periodEndTimestamp) / int.Parse(logComponents[2])
                          select new[] { (int)periodStartTimestamp, (int)periodEndTimestamp }).Last().ToArray() : new int[0];

        /// <summary>
        /// Converts a date/time value to a Unix timestamp.
        /// </summary>
        /// <param name="s">A date/time value in any standard date/time format.</param>
        /// <returns>The Unix timestamp equivalent of <paramref name="s"/>.</returns>
        double DateTimeToTimestamp(string s) => DateTime.Parse(s).Ticks / 1e7 - 62135596800;
    }
}
