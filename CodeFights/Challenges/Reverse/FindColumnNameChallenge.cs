using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "FindColumnName": 
    /// https://codefights.com/challenge/cqMmqTmGeP4umMcD7
    /// </summary>
    public class FindColumnNameChallenge
    {
        /// <summary>
        /// Converts a numeric column index to an alphabetic column name.
        /// </summary>
        /// <param name="Col">The index of the column to convert.</param>
        /// <returns>The name for the <paramref name="Col"/>-th column in a spreadsheet.</returns>
        public string FindColumnName(int Col)
        {
            var sb = new StringBuilder();
            while (Col > 0)
            {
                sb.Insert(0, (char)((--Col) % 26 + 65));
                Col /= 26;
            }
            return sb.ToString();
        }

    }
}
