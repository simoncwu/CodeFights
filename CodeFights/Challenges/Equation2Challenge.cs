using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Equation2": 
    /// https://codefights.com/challenge/37BbTidNon6EYxiJD
    /// 
    /// Return a list of the distinct rational roots of a given polynomial 
    /// equation that is guaranteed to have only rational roots. Each root 
    /// should be reduced, unique, sorted in increasing order, and separated by 
    /// a comma and space. Fractions should be expressed as "p/q" where p is 
    /// the numerator and q is the denominator.
    /// </summary>
    public class Equation2Challenge
    {
        public string Equation2(string equation)
        {
            var roots = new HashSet<long[]>();
            var tested = new HashSet<double>();

            // extract terms
            var matches = Regex.Matches(equation, @"[-+]?\d*x(\^\d+)?|[-+]\d+").Cast<Match>().Select(_ => _.Value);

            // 0 constant
            int degreeOffset = ParseDegree(matches.Last());
            if (degreeOffset > 0)
                roots.Add(new[] { 0L });

            // polynomial degree
            var degree = ParseDegree(matches.First());

            // coefficients
            var c = new long[degree + 1 - degreeOffset];
            foreach (var m in matches)
            {
                c[ParseDegree(m) - degreeOffset] = ParseCoefficient(m);
            }
            Array.Reverse(c);

            // find roots
            var lFac = Factorize(c.First());
            var cFac = Factorize(c.Last());
            foreach (var p in cFac)
            {
                foreach (var q in lFac)
                {
                    var fid = 1d * p / q;
                    if (!tested.Contains(fid)) // only evaluate new candidate values
                    {
                        var factor = Reduce(p, q);
                        var count = roots.Count;
                        if (SyntheticDivide(c, factor) == 0)
                            roots.Add(factor);

                        factor = new[] { -factor[0], factor[1] };
                        if (SyntheticDivide(c, factor) == 0)
                            roots.Add(factor);

                        tested.Add(fid);
                    }
                }
                // polynomial will have exactly {degree} number of roots, so we can stop once all have been found
                if (roots.Count == degree)
                    break;
            }
            return String.Join(", ", roots.OrderBy(_ => _.Length > 1 ? 1f * _[0] / _[1] : _[0]).Select(_ => _.Length > 1 && _[1] > 1 ? _[0] + "/" + _[1] : _[0].ToString()).ToArray());
        }

        /// <summary>
        /// Reduces a rational fraction to its lowest terms.
        /// </summary>
        /// <param name="p">The fraction's numerator.</param>
        /// <param name="q">The fraction's denominator.</param>
        /// <returns>An array containing the specified fraction's reduced terms, in the format [numerator, denominator].</returns>
        long[] Reduce(long p, long q)
        {
            var gcd = GCD(p, q);
            return new[] { p / gcd, q / gcd };
        }

        /// <summary>
        /// Returns the Greatest Common Denominator of two numbers.
        /// </summary>
        /// <param name="a">The first number to compare.</param>
        /// <param name="b">The second number to compare.</param>
        /// <returns>The Greatest Common Denominator of <paramref name="a"/> and <paramref name="b"/>.</returns>
        long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        /// <summary>
        /// Performs synthetic division of a polynomial by a binomial.
        /// </summary>
        /// <param name="coefficients">The coefficients of the polynomial dividend.</param>
        /// <param name="factor">The binomial divisor constant.</param>
        /// <returns>The division quotient.</returns>
        double SyntheticDivide(long[] coefficients, long[] factor)
        {
            var f = 1d * factor[0] / factor[1];
            return Math.Round(coefficients.Select(_ => (double)_).Aggregate((r, v) => r * f + v), 8);
        }

        /// <summary>
        /// Parses a polynomial term for its degree.
        /// </summary>
        /// <param name="term">The term to parse.</param>
        /// <returns>The degree of <paramref name="term"/>.</returns>
        int ParseDegree(string term)
        {
            int i = term.IndexOf('^');
            return i > 0 ? int.Parse(term.Substring(i + 1)) : term.Contains('x') ? 1 : 0;
        }

        /// <summary>
        /// Parses a polynomial term for its coefficient.
        /// </summary>
        /// <param name="term">The term to parse.</param>
        /// <returns>The coefficient of <paramref name="term"/>.</returns>
        long ParseCoefficient(string term)
        {
            int i = term.IndexOf('x');
            return i == 0 || term.StartsWith("+x") ? 1 : term.StartsWith("-x") ? -1 : long.Parse(i > 0 ? term.Remove(i) : term);
        }

        /// <summary>
        /// Performs integer factorization on a number.
        /// </summary>
        /// <param name="n">The number to factorize.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of all possible factors for <paramref name="n"/>.</returns>
        IEnumerable<long> Factorize(long n)
        {
            n = Math.Abs(n);
            var f = new List<long>();
            for (int i = 1, r = (int)Math.Sqrt(n); i <= r; i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    if (n < 1e4) // heuristically, there probably won't be any root fractional components larger than 100
                        yield return n / i;
                }
            }
        }
    }
}
