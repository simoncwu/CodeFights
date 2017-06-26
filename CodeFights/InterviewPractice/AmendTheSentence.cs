using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "amendTheSentence": 
    /// https://codefights.com/interview-practice/task/yXDg4rAk9ooEjLjdj
    /// Asked By: Adobe
    /// 
    /// Given a string containing some English words without spaces where only 
    /// the first letter of each word is capitalized, add spaces between each 
    /// word and convert the uppercase letters to lowercase.
    /// </summary>
    public class AmendTheSentence
    {
        /// <summary>
        /// Adds spaces between the words in a string containing non-space-separated English words with capital initial letters, and converts all capitals to lowercase.
        /// </summary>
        /// <param name="s">A string containing uppercase and lowercase English letters.</param>
        /// <returns>A space separated, lowercase version of <paramref name="s"/>.</returns>
        public string amendTheSentence(string s)
        {
            return s.Aggregate("", (r, v) => v < 97 ? r + " " + (v += ' ') : r + v).Trim();
        }
    }
}
