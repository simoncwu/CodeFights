using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "HeavenlyBlissRecipe": 
    /// https://codefights.com/challenge/8xMSNMBHuXbFgykWL
    /// 
    /// Given three sets of inscriptions, each containing non-negative values 
    /// for Love, Peace, and Happiness; and a ratio of non-negative values for 
    /// each ingredient, determine the integer propotions of each inscription 
    /// that are required to achieve a mix of the specified ratio and return 
    /// them as an array. If a combination of only non-negative proportions is 
    /// impossible, return an array of zeros instead. The proportion values 
    /// should be as small as possible.
    /// </summary>
    public class HeavenlyBlissRecipeChallenge
    {
        /// <summary>
        /// Returns the proportions of a set of inscriptions that are required to achieve a mix of its contents in a specified ratio.
        /// </summary>
        /// <param name="inscriptions">The inscriptions whose values are to be combined, each as an array in the format [ L, P, H ].</param>
        /// <param name="ratio">The desired final ratio of inscription contents.</param>
        /// <returns>The <paramref name="inscriptions"/> proportions required to achieve a mix of <paramref name="ratio"/>, if possible; otherwise, an array of zeros.</returns>
        public int[] HeavenlyBlissReceipe(int[][] inscriptions, int[] ratio)
        {
            // solve determinants for variables L, P, H for equation Σ(n) = ratio(n)
            int dl = Determinant(new[] { ratio, inscriptions[1], inscriptions[2] }),
                dp = Determinant(new[] { inscriptions[0], ratio, inscriptions[2] }),
                dh = Determinant(new[] { inscriptions[0], inscriptions[1], ratio });

            // find GCD
            int gcd = GCD(dl, GCD(dp, dh));

            // reduce values
            ratio = new[] { dl / gcd, dp / gcd, dh / gcd };

            // check for any negative proportions
            return ratio.Any(_ => _ < 0) ? new int[3] : ratio;
        }

        /// <summary>
        /// Returns the determinant of a square matrix.
        /// </summary>
        /// <param name="matrix">A square matrix.</param>
        /// <returns>The determinant of <paramref name="matrix"/>.</returns>
        int Determinant(int[][] matrix)
        {
            int a = matrix[0][0],
                b = matrix[1][0],
                c = matrix[2][0],
                d = matrix[0][1],
                e = matrix[1][1],
                f = matrix[2][1],
                g = matrix[0][2],
                h = matrix[1][2],
                i = matrix[2][2];
            return a * (e * i - f * h) - d * (b * i - c * h) + g * (b * f - c * e);
        }

        /// <summary>
        /// Returns the Greatest Common Denominator of two numbers.
        /// </summary>
        /// <param name="a">The first number to compare.</param>
        /// <param name="b">The second number to compare.</param>
        /// <returns>The Greatest Common Denominator of <paramref name="a"/> and <paramref name="b"/>.</returns>
        int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}