using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp
{
    /// <summary>
    /// Solution for CodeFights challenge "encode": 
    /// https://codefights.com/challenge/u48jf3T4spZ4J8aDg
    /// 
    /// Run-length encoding (RLE) is a very simple form of lossless data 
    /// compression in which runs of data (that is, sequences in which the 
    /// same data value occurs in many consecutive data elements) are stored 
    /// as a single data value and count, rather than as the original run.
    /// 
    /// Given a string s, your task is to encode it using the RLE.
    /// </summary>
    /// <example>
    /// For s = "aabbbccc", the output should be encode(s) = "a2b3c3".
    /// </example>
    class Encode
    {
        /// <summary>
        /// Encodes a string using run-length encoding (RLE).
        /// </summary>
        /// <param name="s">A string consisting of lowercase English letters. 1 ≤ s.length ≤ 10000.</param>
        /// <returns>The encoded result.</returns>
        string encode(string s)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < s.Length)
            {
                // grab letter (1 instances)
                char c = s[i];
                int count = 1;
                i++;
                // grab all subsequent consecutive instances
                while (i < s.Length && s[i] == c)
                {
                    count++;
                    i++;
                }
                // write letter and count
                sb.Append(c);
                sb.Append(count);
            }
            return sb.ToString();
        }
    }
}
