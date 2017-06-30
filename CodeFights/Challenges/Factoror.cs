using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class Factoror
    {
        public int[] factoror(int[] numbers)
        {
            return numbers.Select(n =>
            {
                int steps = 0;

                // initialize f to n, but increment n so n != f
                int factorSum = n++;

                // perform a step of factoror-ing until factor sum == n (previous n value)
                while (n != factorSum)
                {
                    // perform prime factorization of factor sum and generate new factor sum
                    for (int x = n = factorSum + (factorSum = 0), i = 2; x > 1; x /= i)
                    {
                        // find next prime factor
                        while (x % i > 0)
                        {
                            i++;
                        }
                        factorSum += i;
                    }
                    steps++;
                }
                return steps;
            }).ToArray();
        }
    }
}