using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "possibleRing": 
    /// https://codefights.com/challenge/oxTF3XbbAywnwojdx
    /// 
    /// Figure out the maximum number of carbon rings a given molecular 
    /// formula's isomers may have. The maximum number of rings can be 
    /// determined by its degree of unsaturation, or Double Bond Equivalent 
    /// (DBE). DBE is calculated as follows: 
    /// 
    /// DBE = C - H / 2 - X / 2 + N / 2 + 1
    /// 
    /// where C = # of carbons, H = # of hydrogens, X = # of halogens and N = # 
    /// of nitrogens. The DBE must be a non-negative integer; negative or 
    /// fractional results are invalid. In addition, it cannot exceed 
    /// C + N + O - 2.
    /// 
    /// Given a molecular formula, return the maximum number of rings its 
    /// isomers can have. There are no rings or if the DBE is invalid, return 
    /// -1 instead.
    /// </summary>
    public class PossibleRing
    {
        /// <summary>
        /// Returns the maximum number of carbon rings a molecular formula's isomers can have.
        /// </summary>
        /// <param name="formula">The molecular formula to analyze.</param>
        /// <returns>The maximum number of rings possible from <paramref name="formula"/> if valid ones exist; otherwise, <c>-1</c>.</returns>
        public int possibleRing(string formula)
        {
            var matches = Regex.Matches(formula, @"([A-Z][a-z]*)(\d*)");
            int c = 0, n = 0, o = 0, x = 0, errors = 0;
            foreach (Match m in matches)
            {
                int v = Math.Max(int.Parse("0" + m.Groups[2].Value), 1); // no # implies 1
                switch (m.Groups[1].Value)
                {
                    case "C":
                        errors += c;
                        c += v;
                        break;
                    case "N":
                        errors += n;
                        n += v;
                        break;
                    case "O":
                        errors += o;
                        o += v;
                        break;
                    case "H":
                    case "Cl":
                    case "F":
                    case "Br":
                    case "I":
                        errors += x;
                        x += v;
                        break;
                }
            }
            // DBE formula, with upper limit
            int r = Math.Min(c + n / 2 - x / 2 + 1, c + n + o - 2);
            return (n + x) % 2 > 0 || r < 1 || errors > 0 ? -1 : r;
        }
    }
}
