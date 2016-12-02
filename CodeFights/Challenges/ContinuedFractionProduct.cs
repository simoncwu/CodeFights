using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "CFP": 
    /// https://codefights.com/challenge/X4ePf8Cb9Eke95EFJ
    /// 
    /// A continued fraction is a method of writing a rational fraction in the 
    /// following format:
    /// a0 + 1 / ( a1 + 1 / ( a2 + 1 / ( ... + 1 / an ) ) )
    /// 
    /// Given an array a containing values a1, a2, ..., an, build a reduced 
    /// fraction from it and return the product of its numerator and 
    /// denominator.
    /// </summary>
    /// <remarks>
    /// Three implementations of the same solution concept are presented in this solution. The general algorithm is to reverse iterate through the coefficients and, at each step, generate a new fraction with the new coefficient and previous denominator value, and reciprocate the numerator and denominator of the resultant fraction for use in the next (or previous, rather, since we are reverse-iterating) term.
    /// 
    /// This is implemented in three different ways:
    /// <list type="number">
    /// <item>
    /// <term><c>CFPByIteration</c></term>
    /// <description>Iterates through the continued fraction coefficients using a <c>while</c> loop.</description>
    /// </item>
    /// <item>
    /// <term><c>CFPByAggregate</c></term>
    /// <description>Iterates through the continued fraction coefficients using the LINQ <c>Aggregate</c> function, which is specially designed for use in cases such as this where the result of a computation is to be recursively passed as an input into subsequent iterations for each element of an enumeration. In this case, the "result" at each step is the denominator of each term.</description>
    /// </item>
    /// <item>
    /// <term><c>CFPByMaxLoopTrick</c></term>
    /// <description>Similar to the <c>CFPByAggregate</c> solution except instead of the LINQ <c>Aggregate</c> function, it uses the <c>Max</c> function. At each iteration/element a new denominator is calculated and then passed as the result of the selector lambda. This is somewhat hacky because at no point do we ever actually care about the "max" value of these denominators; we are only using it as a shorthand replacement for a more verbose <c>foreach</c> loop or <c>Aggregate</c> function.</description>
    /// </item>
    /// </list>
    /// </remarks>
    public class ContinuedFractionProduct
    {
        /// <summary>
        /// Evaluates a continued fraction and returns the product of its numerator and denominator.
        /// </summary>
        /// <param name="a">An array containing the coefficients of the continued fraction.</param>
        /// <returns>The product of the numerator and denominator of the continued fraction's reduced value.</returns>
        public int CFP(int[] a)
        {
            return CFPByAggregate(a);
        }

        /// <summary>
        /// Evaluates a continued fraction and returns the product of its numerator and denominator by iterating through each term.
        /// </summary>
        /// <param name="a">An array containing the coefficients of the continued fraction.</param>
        /// <returns>The product of the numerator and denominator of the continued fraction's reduced value.</returns>
        int CFPByWhileLoop(int[] a)
        {
            int i = a.Length - 1;
            int num = 1;
            int den = a[i];
            int temp;
            while (--i >= 0)
            {
                temp = den;
                den = num + a[i] * den;
                num = temp;
            }
            return num * den;
        }

        /// <summary>
        /// Evaluates a continued fraction and returns the product of its numerator and denominator by reducing its terms through the LINQ Aggregate function.
        /// </summary>
        /// <param name="a">An array containing the coefficients of the continued fraction.</param>
        /// <returns>The product of the numerator and denominator of the continued fraction's reduced value.</returns>
        int CFPByAggregate(IEnumerable<int> a)
        {
            int n = 0;
            return a.Reverse().Aggregate(1, (r, i) => n + i * (n = r)) * n;
        }

        /// <summary>
        /// Evaluates a continued fraction and returns the product of its numerator and denominator by reducing its terms using the LINQ Max foreach shorthand trick.
        /// </summary>
        /// <param name="a">An array containing the coefficients of the continued fraction.</param>
        /// <returns>The product of the numerator and denominator of the continued fraction's reduced value.</returns>
        int CFPByMaxLoopTrick(int[] a)
        {
            int n = 0, d = 1;
            a.Reverse().Max(i => d = n + i * (n = d));
            return d * n;
        }
    }
}