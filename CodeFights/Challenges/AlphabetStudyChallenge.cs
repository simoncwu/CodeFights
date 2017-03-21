using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "AlphabetStudy": 
    /// https://codefights.com/challenge/nA88LDtnefwn2TYrq
    /// 
    /// Given a set of known letters and a word, determine if all the letters 
    /// in the word are known. Both the letters and the word are guaranteed to 
    /// consist only of lowercase English letters.
    /// </summary>
    public class AlphabetStudyChallenge
    {
        /// <summary>
        /// Determines whether or not a word consists only of letters from a specific subset of the alphabet.
        /// </summary>
        /// <param name="letters">The letters to look for.</param>
        /// <param name="word">The word to analyze.</param>
        /// <returns><c>"Yes"</c> if all the letters from <paramref name="word"/> are included in <paramref name="letters"/>; otherwise, <c>"No"</c>.</returns>
        public string AlphabetStudy(string letters, string word)
        {
            return word.All(_ => letters.Contains(_)) ? "Yes" : "No";

            // more semantically representative of goal but possibly less performant
            //return w.Except(l).Any() ? "No" : "Yes";
        }
    }
}
