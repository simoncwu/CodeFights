using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Emojticon": 
    /// https://codefights.com/challenge/zwoGe7JRnS43tSbvm
    /// 
    /// Given a string message and a set of supported emoticon strings, detect 
    /// all isolated emotions in the message and enclose each in a pair of 
    /// square brackets ([ and ]).
    /// </summary>
    public class EmojticonChallenge
    {
        /// <summary>
        /// Encloses each supported emoticon in a message with a pair of square brackets.
        /// </summary>
        /// <param name="message">A string message.</param>
        /// <param name="emoticons">An array of supported emoticon strings.</param>
        /// <returns>The original message string with each supported emoticon enclosed in a pair of square brackets.</returns>
        public string Emojticon(string message, string[] emoticons)
        {
            //return string.Join(" ", message.Split().Select(_ => emoticons.Contains(_) ? '[' + _ + ']' : _));
            return Regex.Replace(message, @"\S*", _ => emoticons.Contains(message = _.Value) ? '[' + message + ']' : message);
        }
    }
}
