using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "cardinal": 
    /// https://codefights.com/challenge/XRGXNwsdbBrvp66jM
    /// 
    /// Given a number n, convert it into its full cardinal form.
    /// </summary>
    public class Cardinal
    {
        /// <summary>
        /// Converts a number into a cardinal numeral.
        /// </summary>
        /// <param name="n">A string containing a non-negative integer without leading zeros. 1 ≤ n.length ≤ 15.</param>
        /// <returns>The cardinal numeral representation of <paramref name="n"/>.</returns>
        /// <example>
        /// For n = "1255", the output should be <c>cardinal(n) = "one thousand two hundred and fifty five"</c>.
        /// </example>
        public string cardinal(string n)
        {
            // special condition for just 0
            if (n == "0") return "zero";

            n = n.TrimStart('0');
            var sb = new StringBuilder();
            var s = "";
            int l = n.Length;

            // hundreds and up
            if (l > 2)
            {
                // most significant group of digits
                int digits = l == 3 ? 1 : (l - 1) % 3 + 1;
                s = n.Substring(0, digits);
                if (int.Parse(s) > 0)
                    sb.Append(cardinal(s) + " " + (l > 6 ? ((l > 12 ? "tri" : l > 9 ? "bi" : "mi") + "llion") : l > 3 ? "thousand" : "hundred") + " ");

                // remaining digits
                s = n.Substring(digits);
                if (l == 3 && int.Parse(s) > 0) // only append "and" after hundreds
                    sb.Append("and ");

                sb.Append(cardinal(s));
            }
            else if (l > 1)
            {
                if (n[0] == '1')
                {
                    // teens
                    switch (n[1])
                    {
                        case '0':
                            s = "ten";
                            break;
                        case '1':
                            s = "eleven";
                            break;
                        case '2':
                            s = "twelve";
                            break;
                        case '3':
                            s = "thirteen";
                            break;
                        case '4':
                            s = "fourteen";
                            break;
                        case '5':
                            s = "fifteen";
                            break;
                        case '6':
                            s = "sixteen";
                            break;
                        case '7':
                            s = "seventeen";
                            break;
                        case '8':
                            s = "eighteen";
                            break;
                        case '9':
                            s = "nineteen";
                            break;
                    }
                    sb.Append(s + " ");
                }
                else
                {
                    // multiples of ten
                    switch (n[0])
                    {
                        case '2':
                            s = "twen";
                            break;
                        case '3':
                            s = "thir";
                            break;
                        case '4':
                            s = "for";
                            break;
                        case '5':
                            s = "fif";
                            break;
                        case '6':
                            s = "six";
                            break;
                        case '7':
                            s = "seven";
                            break;
                        case '8':
                            s = "eigh";
                            break;
                        case '9':
                            s = "nine";
                            break;
                    }
                    sb.AppendFormat("{0}ty {1}", s, cardinal(n[1]));
                }
            }
            else if (l > 0)
            {
                // single digit
                sb.Append(cardinal(n[0]));
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Converts a digit into a cardinal numeral.
        /// </summary>
        /// <param name="d">The digit to convert.</param>
        /// <returns>The cardinal numeral representation of <paramref name="d"/>.</returns>
        /// <remarks>This method returns <c>null</c> for the number 0 instead of "zero".</remarks>
        string cardinal(char d)
        {
            switch (d)
            {
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
            }
            return null;
        }
    }
}
