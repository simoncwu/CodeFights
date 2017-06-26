using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "textJustification": 
    /// https://codefights.com/interview-practice/task/rak3HBvHDAjHRkTCW
    /// Asked By: LinkedIn, Facebook
    /// 
    /// Given an array of words and a length L, format the words as a multiline 
    /// text such that each line has exactly L characters and is fully 
    /// justified on both the left and the right. Words should be packed with 
    /// as many as possible in each line. Extra spaces between words should be 
    /// distributed as evenly as possible, with preference given to the 
    /// leftmost word boundaries over the rightmost if the number of spaces 
    /// does not divide evenly between words. If the last line of text contains 
    /// only one word, left justify it instead.
    /// </summary>
    public class TextJustificaiton
    {
        /// <summary>
        /// Formats an array of words as a multiline, full-justified text of a fixed per-line width.
        /// </summary>
        /// <param name="words">The words to format.</param>
        /// <param name="L">The per-line width.</param>
        /// <returns>An array of strings representing <paramref name="words"/> formatted as a full-justified text of width <paramref name="L"/>.</returns>
        public string[] textJustification(string[] words, int L)
        {
            int width = 0;
            var text = new List<string>(); // formatted text
            var line = new List<string>(); // single line buffer
            foreach (var w in words)
            {
                width += w.Length;
                if (width + line.Count > L)
                {
                    // buffered words + minimum separator spaces exceeds single line width
                    text.Add(FullJustify(line, L));
                    line.Clear();
                    width = w.Length;
                }
                line.Add(w);
            }
            text.Add(string.Join(" ", line).PadRight(L));
            return text.ToArray();
        }

        /// <summary>
        /// Full-justifies a line of text.
        /// </summary>
        /// <param name="words">The text to justify.</param>
        /// <param name="l">The full width of the line.</param>
        /// <returns>The words in <paramref name="words"/>, full-justified to a line of width <paramref name="l"/>.</returns>
        string FullJustify(List<string> words, int l)
        {
            int n = words.Count - 1;
            // if there is only one word, then right-pad
            if (n == 0)
                return words[0].PadRight(l);
            l -= words.Sum(_ => _.Length);
            int extra = l % n, spaces = l / n;
            var sb = new StringBuilder();
            foreach (var w in words)
            {
                sb.Append(w);
                // prioritize uneven space lengths, 1 per word
                sb.Append("".PadRight(extra-- > 0 ? spaces + 1 : spaces));
            }
            return sb.ToString().Trim();
        }
    }
}
