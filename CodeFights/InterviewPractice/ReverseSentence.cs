using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "reverseSentence": 
    /// https://codefights.com/interview/DGnaZ3J5hnWS6xYJy
    /// 
    /// Reverse the order of words in a given string sentence. You can assume 
    /// that sentence does not have any leading, trailing or repeating spaces.
    /// </summary>
    public class ReverseSentence
    {
        /// <summary>
        /// Reverses the order of words in a string.
        /// </summary>
        /// <param name="sentence">A string consisting of letters and spaces.</param>
        /// <returns>A string of the words in <paramref name="sentence"/> in reverse order.</returns>
        public string reverseSentence(string sentence)
        {
            return string.Join(" ", sentence.Split().Reverse());
        }
    }
}