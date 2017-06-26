using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "isValidNumber": 
    /// https://codefights.com/challenge/s9yv2Niz6bfomMGX8
    /// 
    /// Given the following options, check whether or not a string represents a 
    /// valid number:
    /// n: whether or not negative numbers are supported
    /// c: whether or not comma group separators are supported 
    /// d: whether or not fractional decimal point values are supported
    /// </summary>
    public class IsValidNumber
    {
        /// <summary>
        /// Determines whether or not a string represents a valid number.
        /// </summary>
        /// <param name="s">A string to evaluate.</param>
        /// <param name="n">Whether or not negative numbers are valid.</param>
        /// <param name="c">Whether or not comma group separator characters are valid.</param>
        /// <param name="d">Whether or not fractional decimal point values are valid.</param>
        /// <returns><c>true</c> if <paramref name="s"/> represents a valid number as per the specified options; otherwise, <c>false</c>.</returns>
        public bool isValidNumber(string s, bool n, bool c, bool d)
        {
            return Regex.IsMatch(s,
                "^" +
                // negative numbers
                (n ? "-?" : "") +
                @"(\d+" +
                // comma group separators
                (c ? @"|\d{1,3}(,\d{3})*" : "") +
                // decimal point digits
                (d ? @"\.\d+" : "") +
                ")$");
        }

    }
}