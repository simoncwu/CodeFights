using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "relativePrimes": 
    /// https://codefights.com/challenge/EH6J85jT7i7CbGti6
    /// 
    /// Given an array of integers greater than 1, find all the numbers in it 
    /// that are 1010-relatively prime, i.e. they do not share any common 
    /// divisors less than 1010 other than 1. Return the results in the same 
    /// order as they appear in the original array.
    /// </summary>
    public class RelativePrimes
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int[] relativePrimes(int[] values)
        {
            //var nonPrimes = new HashSet<int>(); // to track verified non-relatively-prime numbers
            var nonPrimes = new bool[values.Length]; // to track verified non-relatively-prime numbers

            // test all possible factors up to cutoff
            for (int divisor = 2; divisor <= 1009; divisor++)
            {
                int nonPrimeIndex = -1;
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] % divisor == 0)
                    {
                        if (nonPrimeIndex < 0)
                            nonPrimeIndex = i;
                        else
                            nonPrimes[nonPrimeIndex] = nonPrimes[i] = true;
                    }
                }
            }
            return values.Where((_, i) => !nonPrimes[i]).ToArray();

            /*
            int cutoff = 1009; // ignore divisors beyond cutoff for coprime test
            var divisorCounts = new int[cutoff + 1];
            foreach (var v in values)
            {
                // increment counts for all divisors up to cutoff
                for (int i = 1; ++i <= cutoff;)
                {
                    if (v % i == 0)
                        divisorCounts[i]++;
                }
            }

            // isolate divisors of non-relatively-prime values, i.e., divisors that were counted more than once
            var nonRelativelyPrimeDivisors = divisorCounts.Select((_, i) => i).Where(_ => divisorCounts[_] > 1);

            // filter for only values that are not divisible by any of the non-relatively-prime divisors
            return values.Where(_ => nonRelativelyPrimeDivisors.All(d => _ % d != 0)).ToArray();
            */
        }
    }
}
