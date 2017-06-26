using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "BookKeeper": 
    /// https://codefights.com/challenge/AuX98Kv7Pactpwk2d
    /// 
    /// Given the titles of the books in a bookcase, sort all the books 
    /// ordinally by title while ignoring the article words "of", "a", "the", 
    /// and "and". Sort the bookcase in column-first order while preserving the 
    /// number of books on each shelf.
    /// </summary>
    public class BookKeeperChallenge
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="books">A jagged array of book title strings.</param>
        /// <returns>The contents of <paramref name="books"/>, sorted ordinally by character while ignoring articles in column-first order.</returns>
        public string[][] BookKeeper(string[][] books)
        {
            // sort in ordinal order, ignoring articles
            var sorted = books.SelectMany(_ => _).OrderBy(_ => Regex.Replace(_, @"\b(?i:of|a|the|and)\b ", ""), StringComparer.Ordinal).ToArray();

            // iterate through each column
            for (int i = 0, column = 0; i < sorted.Length; column++)
            {
                // iterate through each row
                foreach (var shelf in books)
                {
                    // place next book if shelf has enough columns
                    if (column < shelf.Length)
                        shelf[column] = sorted[i++];
                }
            }
            return books;
        }
    }
}