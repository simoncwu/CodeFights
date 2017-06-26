using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "getTemperatureInfo": 
    /// https://codefights.com/challenge/uJgCw8pfLQoLhTyMM
    /// 
    /// Given a list of temperature measurements spanning a period of several 
    /// days, return the average temperature to date for each day. Round odd 
    /// numbered results up and even numbered results down.
    /// </summary>
    public class GetTemperatureInfo
    {
        /// <summary>
        /// Returns the average temperature to date for a series of daily temperature measurements.
        /// </summary>
        /// <param name="measurements">An array of daily temperature measurements.</param>
        /// <returns>The average temperature to date for each day in <paramref name="measurements"/>, rounded up or down alternately.</returns>
        public int[] getTemperatureInfo(int[] measurements)
        {
            double n = 0, total = 0;
            return measurements.Select(_ => (int)Math.Floor((total += _) / ++n + n % 2 * .99)).ToArray();
        }
    }
}