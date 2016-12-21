using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Equation": 
    /// https://codefights.com/challenge/B77jdSZu9LN9aT94n
    /// 
    /// Given its rational roots, create a polynomial equation in canonical 
    /// form such that all coefficients are whole integers and the leading 
    /// coefficient is both positive and as small as possible.
    /// </summary>
    public class EquationChallenge
    {
        /// <summary>
        /// Generates a polynomial equation in canonical form for a set of rational roots.
        /// </summary>
        /// <param name="roots">A comma-separated set of rational roots.</param>
        /// <returns>A polynomial equation in canonical form matching <paramref name="roots"/>.</returns>
        public string Equation(string roots)
        {
            return ToString(roots.Split(',').Select(_ => ParseFactor(_)).Aggregate((r, v) => Multiply(r, v)));
        }

        /// <summary>
        /// Converts a set of coefficients for a canonical polynomial equation to a readable string form of the equation.
        /// </summary>
        /// <param name="coefficients">The coefficients of a polynomial equation's terms, in decreasing degree order.</param>
        /// <returns>A readable string form of the polynomial equation with term coefficients <paramref name="coefficients"/>.</returns>
        string ToString(long[] coefficients)
        {
            var sb = new StringBuilder();
            int degree = coefficients.Length;
            while (--degree >= 0)
            {
                var c = coefficients[coefficients.Length - degree - 1];
                if (c != 0)
                {
                    // + for positive terms, except leading
                    if (c > 0 && sb.Length > 0)
                        sb.Append('+');
                    // - for non-constant-term -1s only
                    else if (c == -1 && degree > 0)
                        sb.Append('-');
                    // coefficient for constants or if not ±1
                    if (degree < 1 || c != 1 && c != -1)
                        sb.Append(c);
                    // include variable if degree > 0
                    if (degree > 0)
                    {
                        sb.Append('x');
                        // include degree if > 1
                        if (degree > 1)
                            sb.Append("^" + degree);
                    }
                }
            }
            sb.Append("=0");
            return sb.ToString();
        }

        /// <summary>
        /// Parses a polynomial equation root string into a polynomial factor.
        /// </summary>
        /// <param name="root">The root to parse.</param>
        /// <returns>The polynomial factor corresponding to <paramref name="root"/> as an array in the format[ coefficient, constant ].</returns>
        long[] ParseFactor(string root)
        {
            var r = root.Split('/').Select(_ => long.Parse(_)).Reverse();
            return new[] { r.Count() < 2 ? 1 : r.First(), -r.Last() };
        }

        /// <summary>
        /// Multiplies a polynomial's coefficients with at least two terms by a polynomial factor with exactly two terms.
        /// </summary>
        /// <param name="polynomial">The polynomial to multiply.</param>
        /// <param name="factor">The factor to multiply.</param>
        /// <returns>The coefficients of the result of multiplying <paramref name="polynomial"/> with <paramref name="factor"/>.</returns>
        long[] Multiply(long[] polynomial, long[] factor)
        {
            var r = new long[polynomial.Length + 1];
            for (int i = 0; i < polynomial.Length; i++)
            {
                r[i] += polynomial[i] * factor[0];
                r[i + 1] += polynomial[i] * factor[1];
            }
            return r;
        }
    }
}
