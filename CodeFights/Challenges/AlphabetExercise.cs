using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "alphabetExercise": 
    /// https://codefights.com/challenge/5hLYKfPRHuv9paBqH
    /// 
    /// Given a vocabulary list of nonrepeating words, assign to each letter of 
    /// the alphabet a unique word that contains that letter such that the 
    /// total number of letters across all words is minimal. Return this 
    /// number. It is guaranteed a solution is always possible.
    /// </summary>
    public class AlphabetExercise
    {
        /// <summary>
        /// Counts the minimum possible number of letters in a subset of words from a vocabulary list that can be uniquely mapped to a letter of the alphabet that it contains, for all letters of the alphabet.
        /// </summary>
        /// <param name="vocabulary">A list of distinct words to choose from.</param>
        /// <returns>The minimum possible number of letters in a subset of <paramref name="vocabulary"/> that can be used to represent the entire alphabet.</returns>
        public int alphabetExercise(string[] vocabulary)
        {
            int answer = 0;

            // sort vocabulary by length (for some reason must be stable sort)
            vocabulary = vocabulary.OrderBy(_ => _.Length).ToArray();

            // create mapping of alphabet to words containing each letter
            var index = new Dictionary<char, List<string>>();
            foreach (var w in vocabulary)
            {
                foreach (var l in w.Distinct())
                {
                    (index.ContainsKey(l) ? index[l] : index[l] = new List<string>()).Add(w);
                }
            }

            // main algorithm - repeat while mappings exist
            while (index.Any())
            {
                // option 1: low-hanging fruit - grab all letters with only one choice for word
                var onlyChoices = (
                    from _ in index
                    where _.Value.Count == 1
                    select _.Key
                    ).ToList();
                answer += onlyChoices.Any() ?
                    onlyChoices.Sum(_ => RemoveLetter(index, _))

                    // option 2: hard part - pick letter with max length difference between 1st and 2nd words.
                    // not really sure why this is guaranteed to yield the optimal answer with no risk of unassigned letters though... seems to also be dependent upon stability of initial vocabulary sort
                    : RemoveLetter(index, index.Keys.OrderBy(_ => index[_][0].Length - index[_][1].Length).First());
            }

            return answer;
        }

        /// <summary>
        /// Removes the first (shortest) word mapped to a specified letter, and the associated letter, from an index, returns the length of the removed word.
        /// </summary>
        /// <param name="index">An index mapping alphabet letters to vocabulary words that contain that letter.</param>
        /// <param name="c">The ltter whose first word is to be removed.</param>
        /// <returns>The length of the first (shortest) word removed from <paramref name="index"/> that contains the letter <paramref name="c"/>.</returns>
        int RemoveLetter(Dictionary<char, List<string>> index, char c)
        {
            var word = index[c][0];
            index.Remove(c);
            foreach (var l in index.Values)
            {
                l.Remove(word);
            }
            return word.Length;
        }
    }
}
