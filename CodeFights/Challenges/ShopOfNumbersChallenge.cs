using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "ShopOfNumbers": 
    /// https://codefights.com/challenge/PJTZRNxMzuJP4HKgu
    /// 
    /// Given the prices for all non-zero digits in an arbitrary base, 
    /// calculate the expected price for the leading digit of any power of 2 
    /// in that base.
    /// </summary>
    /// <remarks>
    /// For bases that are powers of 2, the first digit is evenly distributed 
    /// amongst a specific subset of all non-zero digits. Use that exact 
    /// frequency instead of an estimate.
    /// </remarks>
    public class ShopOfNumbersChallenge
    {
        /// <summary>
        /// Returns the expected price for any leading digit of a power of 2 in an arbitrary base.
        /// </summary>
        /// <param name="prices">The prices of all non-zero digits in the given base, in increasing digit order.</param>
        /// <returns>The expected price for any leading digit of a power of 2 in the given base.</returns>
        public double ShopOfNumbers(int[] prices)
        {
            // implement Benford's Law, except for powers of 2 in which case the challenge's expectation is even distribution amongst powers of 2 digits.
            int b = prices.Length + 1;
            return (b & --b) == 0 ? prices.Where((p, x) => (x & ++x) == 0).Average() : prices.Select((p, d) => p * Math.Log(1 + 1d / ++d, b)).Sum();
        }
    }
}