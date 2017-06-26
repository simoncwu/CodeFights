using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "iDontKnow": 
    /// https://codefights.com/challenge/xAfWeNKqLqeerhKXy
    /// </summary>
    public class IDontKnow
    {
        /// <summary>
        /// Returns the product of a nonnegative integer and the integer that is one less than it, to floating point accuracy.
        /// </summary>
        /// <param name="number">A nonnegative integer.</param>
        /// <returns>A string representing <paramref name="number"/> times <paramref name="number"/> minus <c>1</c>, to floating point accuracy.</returns>
        public string iDontKnow(int number)
        {
            return Convert.ToInt64(Convert.ToDouble(number) * ~-number) + "";
        }

    }
}
