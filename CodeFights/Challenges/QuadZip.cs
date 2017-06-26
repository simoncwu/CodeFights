using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "quadZip": 
    /// https://codefights.com/challenge/z4rytKFWoT7xrJACN
    /// 
    /// Given four strings, zip them by taking the first character from each 
    /// string, then the second character from each string, and so on, until 
    /// there are no more characters left in all of the strings.
    /// </summary>
    public class QuadZip
    {
        /// <summary>
        /// Zips four strings together into a single string, one character per string at a time.
        /// </summary>
        /// <param name="one">A first string of characters.</param>
        /// <param name="two">A second string of characters.</param>
        /// <param name="three">A third string of characters.</param>
        /// <param name="four">A fourth string of characters.</param>
        /// <returns>The result of zipping the characters of the four strings together.</returns>
        public string quadZip(string one, string two, string three, string four)
        {
            int index = 0;
            IEnumerable<string> sources = new[] { one, two, three, four };
            var sb = new StringBuilder();
            while (sources.Any())
            {
                // loop through strings and take character at index
                foreach (var str in sources)
                {
                    sb.Append(str[index]);
                }

                // advance index
                index++;

                // filter for only strings that are long enough for next index
                sources = sources.Where(_ => _.Length > index);
            }
            return sb.ToString();
        }
    }
}
