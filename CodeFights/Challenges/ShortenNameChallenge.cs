using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "ShortenName": 
    /// https://codefights.com/challenge/ueKvGPJ8X2pircnkW
    /// 
    /// Shorten a name given in [last], [first] [middle] format where [middle] 
    /// is at most 1 word long by abbreviating the middle name (if one exists).
    /// </summary>
    public class ShortenNameChallenge
    {
        /// <summary>
        /// Abbreviates a name in "last, first middle" format by replacing the middle name with an initial.
        /// </summary>
        /// <param name="name">The name to abbreviate.</param>
        /// <returns>The abbreviated version of <paramref name="name"/> if a middle name is present; otherwise, <paramref name="name"/>.</returns>
        public string ShortenName(string name)
        {
            return Regex.Replace(name, @"(\w .)\w+$", "$+.");
        }
    }
}
