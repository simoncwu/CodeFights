using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "brAIlle": 
    /// https://codefights.com/challenge/X24mkBe7RSyck9pHK
    /// 
    /// Translate as much of a Braille message as possible using the following 
    /// rules:
    /// <list type="number">
    /// <item><description>
    /// If the message has fewer than three lines, it is invalid and <c>[?]</c> 
    /// should be returned.
    /// </description></item>
    /// <item><description>
    /// If the message has more than three lines, append the excess lines one 
    /// by one to the first three in round-robin order until only three lines 
    /// remain.
    /// </description></item>
    /// <item><description>
    /// The three lines of the message should be normalized by appending space 
    /// characters to be of equal length as the longest line.
    /// </description></item>
    /// <item><description>
    /// Read the three message lines from left to right as a Braille sequence 
    /// where each 3x3 matrix represents the two columns of a Braille symbol, 
    /// with a single empty column separator in between, and the character '#' 
    /// represents a single dot.
    /// </description></item>
    /// <item><description>
    /// Any symbol that does not follow the above syntax is invalid and should 
    /// be translated as <c>[?]</c>.
    /// </description></item>
    /// <item><description>
    /// Each 3x3 Braille symbol matrix should also be separated by an emtpy 
    /// column separator. If this column is not empty, both symbols on either 
    /// side of it should be invalidated.
    /// </description></item>
    /// <item><description>
    /// An empty 3x3 matrix should be ignored.
    /// </description></item>
    /// <item><description>
    /// Consecutive <c>[?]</c>s should be consolidated into a single instance.
    /// </description></item>
    /// </list>
    /// </summary>
    public class BrAIlle
    {
        /// <summary>
        /// Attempts to translate a sequence of Braille symbols to alphanumeric characters.
        /// </summary>
        /// <param name="message">A sequence of '#'s and spaces arranged to represent Braille symbols.</param>
        /// <returns>The alphanumeric translation of the Braille sequence represented by <paramref name="message"/>.</returns>
        public string brAIlle(string[] message)
        {
            if (message.Length < 3)
                return "[?]";

            // fix message
            for (int i = 3; i < message.Length; i++)
                message[i % 3] += message[i];
            int n = message.Max(_ => _.Length);
            message = message.Take(3).Select(_ => _.PadRight(n)).ToArray();

            // parse letters
            StringBuilder sb = new StringBuilder();
            bool isNumber = false;
            for (int i = 0; i < n; i += 4)
            {
                sb.Append(ParseSymbol(message, i, ref isNumber));
            }
            return Regex.Replace(sb.ToString(), @"\?+", "[?]");
        }

        string ParseSymbol(string[] message, int index, ref bool isNumber)
        {
            // check for validity
            if (index + 2 < message[0].Length && message.All(_ => _[index + 1] == ' ' && (index == 0 || _[index - 1] == ' ') && (index + 3 >= _.Length || _[index + 3] == ' ')))
            {
                // find dots
                int d = 0;
                for (int j = index; j < index + 3; j += 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (message[i][j] == '#')
                            d = d * 10 + 3 * ((j % 4 + 1) / 3) + i + 1;
                    }
                }

                // convert to letter or digit
                var c = DotsToLetter(d);

                // number indicator
                if (c == '#')
                    isNumber = true;
                if (c < 'a' || 'j' < c)
                    isNumber = false;
                return d == 0 | c == '#' ? null : (isNumber && 'a' <= c ? (char)('0' + (c - '`') % 10) : c).ToString();
            }
            return "?";
        }

        /// <summary>
        /// Converts a Braille dot value to a letter or number indicator.
        /// </summary>
        /// <param name="dots">The Braille dot value to convert.</param>
        /// <returns>The correpsonding letter equivalent of <paramref name="dots"/> if it is a letter; or '#' if it is a number indicator; otherwise, '?'.</returns>
        char DotsToLetter(int dots)
        {
            switch (dots)
            {
                case 1: return 'a';
                case 12: return 'b';
                case 14: return 'c';
                case 145: return 'd';
                case 15: return 'e';
                case 124: return 'f';
                case 1245: return 'g';
                case 125: return 'h';
                case 24: return 'i';
                case 245: return 'j';
                case 13: return 'k';
                case 123: return 'l';
                case 134: return 'm';
                case 1345: return 'n';
                case 135: return 'o';
                case 1234: return 'p';
                case 12345: return 'q';
                case 1235: return 'r';
                case 234: return 's';
                case 2345: return 't';
                case 136: return 'u';
                case 1236: return 'v';
                case 2456: return 'w';
                case 1346: return 'x';
                case 13456: return 'y';
                case 1356: return 'z';
                case 3456: return '#';
                default: return '?';
            }
        }
    }
}