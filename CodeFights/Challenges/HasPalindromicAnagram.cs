using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "hasPalindromicAnagram": 
    /// https://codefights.com/challenge/gRkR2xSSNnnAWADmj/solutions
    /// 
    /// Given a message, determine whether there is an anagram of the message 
    /// that is also a palindrome. Letter case and non-alphanumeric characters 
    /// should be ignored for palindrome consideration, but are factored into 
    /// anagram creation. By definition, a string cannot be an anagram of 
    /// itself.
    /// </summary>
    public class HasPalindromicAnagram
    {
        public bool hasPalindromicAnagram(string message)
        {
            // distinct alphanumerics only
            var letters = message.ToLower().Where(_ => char.IsLetterOrDigit(_)).ToLookup(_ => _);
            // # of alphanumerics with odd occurrences
            var odds = letters.Count(_ => _.Count() % 2 > 0);
            return
                // palindrome check
                odds < 2 &
                // non-identical anagram existence check
                (
                    // any non-alphanumerics
                    message.Any(_ => !letters.Contains(_)) |
                    // not already a palindrome
                    string.Concat(message.Reverse()) != message |
                    // > 1 alphanumerics with count > 1 - handles missing test case of "baaab"
                    letters.Count(_ => _.Count() > 1) > 1
                );
        }
    }
}
