using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "listOfNumbers": 
    /// https://codefights.com/challenge/5eqj9PTETb8MS5Xuo
    /// 
    /// For each entry in an array of credit card numbers and issuing networks, 
    /// determine if the number is valid by validating its issuer 
    /// identification number (IIN), length, and checksum (using the Luhn 
    /// algorithm). Since IINs are unique, make sure to check for overlaps in 
    /// prefix ranges. For example, although Maestro IINs can begin with a 6, 
    /// they cannot begin with a 6011 because that prefix is associated with 
    /// Discover Card.
    /// 
    /// This challenge only supports the issuing networks Visa, MasterCard, 
    /// Maestro, JCB, Discover Card, American Express, Laser, and InterPayment.
    /// 
    /// Card numbers only contain digits, spaces, and hyphens.
    /// </summary>
    public class Validate
    {
        /// <summary>
        /// Validates an array of credit card numbers for valid IIN, length, and checksum.
        /// </summary>
        /// <param name="listOfNumbers">An array of credit card numbers in the format [issuer name, card number].</param>
        /// <returns>An array of <see cref="Boolean"/> values indicating whether or not each respective entry in <paramref name="listOfNumbers"/> is valid.</returns>
        public bool[] validate(string[][] listOfNumbers)
        {
            return listOfNumbers.Select(_ => ValidateLuhnChecksum(_[1] = Regex.Replace(_[1], " |-", "")) & ValidateCreditCardFormat(_[0], _[1])).ToArray();
        }

        /// <summary>
        /// Validates a credit card number's checksum using the Luhn algorithm.
        /// </summary>
        /// <param name="n">The credit card number to validate.</param>
        /// <returns><c>true</c> if the checksum for <paramref name="n"/> is valid.</returns>
        bool ValidateLuhnChecksum(string n)
        {
            int i = 0, x;
            return n.Reverse().Sum(d => (x = ++i % 2 < 1 ? d + d - 96 : d - 48) - x / 10 * 9) % 10 == 0;
        }

        /// <summary>
        /// Validates that a credit card number has the correct IIN and length per its issuer.
        /// </summary>
        /// <param name="issuer">The name of the credit carding issuer.</param>
        /// <param name="n">The credit card number to validate.</param>
        /// <returns><c>true</c> if <paramref name="n"/> has the correct IIN and length for <paramref name="issuer"/>; otherwise, <c>false</c>.</returns>
        bool ValidateCreditCardFormat(string issuer, string n)
        {
            int x;
            Func<string, string, bool> M = Regex.IsMatch;
            switch (issuer)
            {
                case "Visa":
                    return Regex.IsMatch(n, "^4(.{12}|.{15}|.{18})$");
                case "MasterCard":
                    return n.Length == 16 & ((x = int.Parse(n.Remove(4))) > 5099 & x < 5600 | x > 2220 & x < 2721);
                case "Maestro":
                    return Regex.IsMatch(n, "^(5[06-8]|(?!636)6.).{10,17}$") & !ValidateCreditCardFormat("Discover Card", n) & !ValidateCreditCardFormat("Laser", n);
                case "JCB":
                    return Regex.IsMatch(n, "^35(2[89]|[3-8][0-9]).{12}$");
                case "Discover Card":
                    return Regex.IsMatch(n, "^(.{16}|.{19})$") & Regex.IsMatch(n, "^6(011|4[4-9]|5|22)");
                case "American Express":
                    return Regex.IsMatch(n, "^3[47].{13}$");
                case "Laser":
                    return Regex.IsMatch(n, "^(6304|67(0[69]|71)).{12,15}$");
                case "InterPayment":
                    return Regex.IsMatch(n, "^636.{13,16}$");
                default:
                    return false;
            }
        }
    }
}