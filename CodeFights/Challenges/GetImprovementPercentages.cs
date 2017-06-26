using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "getImprovementPercentages": 
    /// https://codefights.com/challenge/WeYvtaMmp542asQiF
    /// 
    /// You are given some data as a non-uniform single line of text that you 
    /// must scan and parse for financial profit information. The only 
    /// requirements for a valid stream of data are:
    /// <list type="number">
    /// <item><description>
    /// Profit values may or may not contain decimals, and may be negative.
    /// </description></item>
    /// <item><description>
    /// Each profit value is separated from other data by a non-alphanumeric character.
    /// </description></item>
    /// <item><description>
    /// There must exist at least two months' worth of profit values.
    /// </description></item>
    /// </list>
    /// Measure the percentage of the total number of months given in which 
    /// profits were at least zero and an improvement from the previous month, 
    /// rounded to the nearest integer. Note that the first month does not 
    /// have any prior data for comparison and therefore can never satisfy this 
    /// condition.
    /// </summary>
    public class GetImprovementPercentages
    {
        /// <summary>
        /// Returns the percentage of total months in a financial data stream in which profits were at least zero and an improvement from the previous month.
        /// </summary>
        /// <param name="text">The data stream to parse.</param>
        /// <returns>The percentage of total months rounded to the nearest integer as a string if the stream is valid; otherwise, <c>"invalid"</c>.</returns>
        public string getImprovementPercentages(string text)
        {
            var profits = Regex.Matches(text, @"-?\b\d+\.?\d*\b").Cast<Match>().Select(_ => decimal.Parse(_.Value));
            if (profits.Count() < 2)
                return "invalid";
            var x = profits.First();
            return profits.Average(_ => x < (x = _) && x >= 0 ? 1 : 0).ToString("0%");
        }
    }
}