using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "ISBN13": 
    /// https://codefights.com/challenge/P7YGDX6JWwzym93Qu
    /// 
    /// Given an ISBN-10 number with an incorrect or absent check digit, 
    /// correct and return it along with its ISBN-13 counterpart as an 
    /// array of strings in the following format: 
    /// ["ISBN-10: x-xxx-xxxxx-x", "ISBN-13: xxx-x-xxx-xxxxx-x"].
    /// The given ISBN-10 may or may not contain hyphens at various 
    /// positions.
    /// </summary>
    public class Isbn13
    {
        /// <summary>
        /// Analyzes the check digit of an ISBN-10 number and returns the corrected full identifier in both ISBN-10 and ISBN-13 formats.
        /// </summary>
        /// <param name="number">The ISBN-10 number to analyze with possibly an incorrect or missing check digit.</param>
        /// <returns>An array containing the corrected ISBN-10 and ISBN-13 values for <paramref name="number"/>.</returns>
        public string[] ISBN13(string number)
        {
            number = number.Replace("-", "").Substring(0, 9);
            var N = number.Insert(4, "-").Insert(1, "-") + "-";
            return new[] { "ISBN-10: " + N + ChecksumIsbn10(number), "ISBN-13: 978-" + N + ChecksumIsbn13("978" + number) };
        }

        /// <summary>
        /// Returns the checksum digit for an ISBN-10 number.
        /// </summary>
        /// <param name="isbn">The ISBN-10 number to analyze, without the checksum digit.</param>
        /// <returns>The checksum digit for <paramref name="isbn"/>.</returns>
        char ChecksumIsbn10(string isbn)
        {
            int i = 10;
            i = (11 - isbn.Sum(_ => _ % 12 * i--) % 11) % 11;
            return i > 9 ? 'X' : (char)(i + '0');
        }

        /// <summary>
        /// Returns the checksum digit for an ISBN-13 number.
        /// </summary>
        /// <param name="isbn">The ISBN-13 number to analyze, without the checksum digit.</param>
        /// <returns>The checksum digit for <paramref name="isbn"/>.</returns>
        int ChecksumIsbn13(string isbn)
        {
            int i = 3;
            return (10 - isbn.Sum(_ => (i += 2) % 4 * _ % 48) % 10) % 10;
        }
    }
}
