using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "alientBit":
    /// https://codefights.com/challenge/aEPJbWzkSjEuuH3cH
    /// 
    /// You have intercepted some space transmissions that are encoded as a 
    /// decimal fraction between 0 and 1 where the decimal digits represent 
    /// ASCII character values, 3 digits per character. Given a transmission 
    /// message's value as a string, decode the message.
    /// </summary>
    public class AlienBit
    {
        /// <summary>
        /// Decodes a message encoded as a decimal fraction where the digits represent ASCII characters.
        /// </summary>
        /// <param name="abit">A string representation of a decimal fraction between 0 and 1 where the number of decimal places is a multiple of 3.</param>
        /// <returns></returns>
        public string alienBit(string abit)
        {
            var sb = new StringBuilder();
            // group digits 3 at a time using regular expressions
            foreach (var m in Regex.Matches(abit, "\\d{3}"))
            {
                sb.Append((char)int.Parse(m.ToString()));
            }
            return sb.ToString();
        }
    }
}
