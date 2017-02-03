using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "alpha4": 
    /// https://codefights.com/challenge/ofAvn2vDpaq33hbqh
    /// </summary>
    public class Alpha4
    {
        /// <summary>
        /// Returns a numeric mod hash of a string based on groupings of 4 characters at a time.
        /// </summary>
        /// <param name="s">The string to hash.</param>
        /// <returns>The hashed value of <paramref name="s"/>.</returns>
        public string alpha4(string s)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i += 4)
                sb.Append(s.Skip(i).Take(4).Sum(_ => --_) % 4);
            return sb.ToString();

            // one-liner using LINQ grouping
            //return String.Join("", s.GroupBy(_ => i++ / 4).Select(_ => _.Sum(c => c - 1) % 4 + ""));

            // one-liner without intermediary loop counter
            //return String.Join("", s.Select((_, i) => new[] { _ - 1, i }).GroupBy(_ => _[1] / 4).Select(g => g.Sum(_ => _[0]) % 4 + "").ToArray());
        }
    }
}
