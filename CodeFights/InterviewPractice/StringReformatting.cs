using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "stringReformatting": 
    /// https://codefights.com/interview/4e6LZSessGpKPx3uB
    /// 
    /// Reformat a string containing dashes by separating its characters into 
    /// groups of a fixed width, separated by dashes. If necessary, the first 
    /// group does not have to be full width. It is guaranteed that there are 
    /// no consecutive dashes in the string.
    /// </summary>
    public class StringReformatting
    {
        /// <summary>
        /// Reformats a string into fixed-width groups of characters separated by dashes.
        /// </summary>
        /// <param name="s">A string to reformat.</param>
        /// <param name="k">The width of each group.</param>
        /// <returns>A reformat of <paramref name="s"/> into dash-separated groups of width <paramref name="k"/>.</returns>
        public string stringReformatting(string s, int k)
        {
            int i = 0;
            var sb = new StringBuilder();
            foreach (var c in s.Replace("-", "").Reverse())
            {
                sb.Insert(0, c);
                if (++i % k == 0)
                    sb.Insert(0, '-');
            }
            return sb.ToString().TrimStart('-');
        }
    }
}
