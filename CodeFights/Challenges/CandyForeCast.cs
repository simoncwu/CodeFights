using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "candyForeCast": 
    /// https://codefights.com/challenge/j25nRLWrMoWqoSiuj
    /// 
    /// Using the simple linear regression model, predict the next sequential 
    /// data point for a given population of data points.
    /// 
    /// Return the result as an array of strings in the following format: 
    /// [ dependent variable value, 
    ///   independent variable value, 
    ///   the correlation trend as "increasing", "decreasing", or "stable" ].
    /// If there are fewer than two data points, return an empty array.
    /// </summary>
    public class CandyForeCast
    {
        /// <summary>
        /// Predicts the next sequential data point for a given population of data points.
        /// </summary>
        /// <param name="values">An array of data point values, in pairs of alternating independent and dependent variables (i.e. x, y).</param>
        /// <returns>The predicted next sequential data point for the data points specified by <paramref name="values"/>.</returns>
        public string[] candyForeCast(int[] values)
        {
            int n = values.Length, nextX = 0;
            double xSum = 0, ySum = 0, xxSum = 0, xySum = 0;
            for (int i = 0; i < n;)
            {
                int x = values[i++];
                nextX = nextX < x ? x : nextX;
                xxSum += x * x;
                xSum += x;
                xySum += x * (x = values[i++]);
                ySum += x;
            }
            n /= 2;

            double beta;
            return n < 2 ? new string[0] : new[] { (++nextX).ToString(), SimpleLinearRegression(xSum / n, ySum / n, xxSum / n, xySum / n, nextX, out beta).ToString(), beta > 0 ? "increasing" : beta < 0 ? "decreasing" : "stable" };
        }

        /// <summary>
        /// Uses the simple linear regression model to predict the value of the dependent variable for a specified data point.
        /// </summary>
        /// <param name="mx">The mean of the independent variable for all data points.</param>
        /// <param name="my">The mean of the dependent variable for all data points.</param>
        /// <param name="mxx">The mean of the square of the independent variable for all data points.</param>
        /// <param name="mxy">The mean of the product of both variables for all data points.</param>
        /// <param name="x">The independent variable value of the requested data point.</param>
        /// <param name="beta">The computed value of the corrected correlation between the variables.</param>
        /// <returns>The prediction for the independent variable of the data point indicated by <paramref name="x"/>.</returns>
        int SimpleLinearRegression(double mx, double my, double mxx, double mxy, int x, out double beta)
        {
            beta = (mxy - mx * my) / (mxx - mx * mx);
            return (int)(beta * (x - mx) + my);
        }
    }
}
