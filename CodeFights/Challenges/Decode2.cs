using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "decode2": 
    /// https://codefights.com/challenge/6FcoYgXWmxETjuuaj
    /// 
    /// Given a message, encrypt it using the following "squared encoding" 
    /// algorithm: 
    /// <list type="number">
    /// <item><description>
    /// Assign each character a number; for this challenge, use:
    /// 'a'=1, 'b'=2, ..., 'y'=25, 'z'=0.
    /// </description></item>
    /// <item><description>
    /// Calculate the square of each number modulo 26.
    /// </description></item>
    /// <item><description>
    /// Convert the result back to a character using the same character 
    /// assignment scheme.
    /// </description></item>
    /// </list>
    /// </summary>
    public class Decode2
    {
        /// <summary>
        /// Encodes a message using a "squared encoding" algorithm.
        /// </summary>
        /// <param name="message">The message to encode.</param>
        /// <returns>The square-encoding of <paramref name="message"/>.</returns>
        public string decode2(string message)
        {
            var sb = new StringBuilder();
            foreach (var c in message)
            {
                var i = c - '`';
                sb.Append((char)((i * i - 1) % 26 + 'a'));
            }
            return sb.ToString();
        }
    }
}
