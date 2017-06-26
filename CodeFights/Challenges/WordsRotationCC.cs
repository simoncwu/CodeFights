using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "wordsRotationCc": 
    /// https://codefights.com/challenge/c6TgF2asHrFEN8X3Z
    /// 
    /// Given a rectangular matrix of letters, rotate the letters 
    /// counterclockwise by 90°.
    /// </summary>
    public class WordsRotationCCS
    {
        /// <summary>
        /// Rotates the letters in an array of even-length words clockwise by 90°.
        /// </summary>
        /// <param name="words">An array of even-length strings.</param>
        /// <returns>An array representing the characters of <paramref name="words"/> rotated clockwise by 90°.</returns>
        public string[] wordsRotationCc(string[] words)
        {
            return words[0].Select((_, i) => words.Aggregate("", (r, v) => r + v[i])).Reverse().ToArray();
        }
    }
}
