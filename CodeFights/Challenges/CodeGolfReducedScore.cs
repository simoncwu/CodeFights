using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution to CodeFights challenge "codeGolfReducedScore": 
    /// https://codefights.com/challenge/9kmuSXmkpwEpNLkYj
    /// 
    /// Calculate the alternate character count of a JavaScript ES6 code 
    /// snippet using the following rules:
    /// <list type="bullet">
    /// <item><description>
    /// Language keywords and identifiers count as 1 point. A keyword or 
    /// identifier is a word containing English letters or digits, with the 
    /// first character being a letter.
    /// </description></item>
    /// <item><description>
    /// Whitespace characters are not counted, except when part of a string 
    /// literal.
    /// </description></item>
    /// <item><description>
    /// All other characters are counted normally.
    /// </description></item>
    /// </list>
    /// You can assume that the code does not contain any comments or regular 
    /// expressions, and that string literals do not contain any quotes.
    /// </summary>
    public class CodeGolfReducedScore
    {
        /// <summary>
        /// Returns the alternate character count/score of a JavaScript ES6 code snippet.
        /// </summary>
        /// <param name="code">A valid JavaScript (ES6) snippet.</param>
        /// <returns>The alternate character count/score for the code in <paramref name="code"/>.</returns>
        public int codeGolfReducedScore(string code)
        {
            var r = new Regex(@"(['""])[^\1]*\1");
            return
                // string literals
                r.Matches(code).Cast<Match>().Sum(_ => _.Value.Length) +
                // keywords/identifiers
                Regex.Replace(r.Replace(code, ""), @"[a-zA-Z]\w*", "a").Count(_ => _ > ' ');
        }
    }
}