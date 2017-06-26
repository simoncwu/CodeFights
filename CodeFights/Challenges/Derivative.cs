using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "derivative": 
    /// https://codefights.com/challenge/8wnEp7GjPotzJ7uZq
    /// 
    /// Given a polynomial in one variable and the value of that variable, 
    /// evaluate its derivative. Each term is given in the format 
    /// [coef]*x^[power], where:
    /// - [coef] and [power] are integers; 
    /// - [coef] and the * symbol may be omitted when equal to 1; 
    /// - [power] and with the ^ symbol may be omitted when equal to 1; and
    /// - [power] and the "x^" prefix may be omitted when equal to 0.
    /// All terms are separated by " + " or " - ".
    /// </summary>
    public class Derivative
    {
        /// <summary>
        /// Evaluates the derivative of a polynomial in one variable.
        /// </summary>
        /// <param name="polynomial">A polynomial in one variable.</param>
        /// <param name="x">The value of the variable in <paramref name="polynomial"/>.</param>
        /// <returns>The value of the derivative of <paramref name="polynomial"/> at <paramref name="x"/>.</returns>
        public int derivative(string polynomial, int x)
        {
            int sign = 1, coefficient, exponent;
            return polynomial.Split().Sum(
                t =>
                // addition operator
                t == "+" ? 0 * (sign = 1) :

                // subtraction operator
                t == "-" ? 0 * (sign = -1) :

                // variable term
                t.Contains('x') ?
                // look for indices of coefficient and exponent
                0 * (coefficient = t.IndexOf('*')) * (exponent = t.IndexOf('^')) +
                // check for leading negative sign
                (t.StartsWith("-x") ? -sign : sign) *
                // read exponent
                (exponent = exponent < 0 ? 1 : int.Parse(t.Substring(exponent + 1))) *
                // read coefficient
                (coefficient < 0 ? 1 : int.Parse(t.Remove(coefficient))) *
                // substitute variable and raise to decremented exponent
                (int)Math.Pow(x, exponent - 1) :

                // constant term
                0);
        }
    }
}
