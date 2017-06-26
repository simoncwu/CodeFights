using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// https://codefights.com/challenge/HAa3E3KifJqEXotNt
    /// 
    /// You're running a "Buy 2, Get 1 Free" promotion where customers can 
    /// apply the discount to groups of any 3 consecutive items in their 
    /// shopping carts and the cheapest item in each group will be free. Given 
    /// the prices of each item in a cart, determine the maximum possible 
    /// discount.
    /// </summary>
    public class MaxDiscount
    {
        /// <summary>
        /// Calculates the maximum possible discount from a "Buy 2, Get 1 Free" promotion for a shopping cart.
        /// </summary>
        /// <param name="prices">The ordered array of prices for each item in a shopping cart.</param>
        /// <returns>The maximum possible discount.</returns>
        public int maxDiscount(int[] prices)
        {
            var discount = new int[prices.Length + 1];
            int p1 = 0, p2 = 0, max1 = 0, max2 = 0, max3 = 0;
            return prices.Max(p3 => max3 = Math.Max(max1 + new[] { p1, p1 = p2, p2 = p3 }.Min(), max2 = max3 + 0 * (max1 = max2)));
        }
    }
}
