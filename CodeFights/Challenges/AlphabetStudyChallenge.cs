using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class AlphabetStudyChallenge
    {
        /// <summary>
        /// Determines whether or not a given collection of letters comprises all the letters in a word.
        /// </summary>
        /// <param name="letters">The letters to look for.</param>
        /// <param name="word">The word to analyze.</param>
        /// <returns><c>"Yes"</c> if <paramref name="letters"/> comprises all the letters in <paramref name="word"/>; otherwise, <c>"No"</c>.</returns>
        public string AlphabetStudy(string letters, string word)
        {
            return word.All(_ => letters.Contains(_)) ? "Yes" : "No";

            // more semantically representative of goal but possibly less performant
            //return w.Except(l).Any() ? "No" : "Yes";
        }
    }
}
