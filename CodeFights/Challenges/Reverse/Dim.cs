﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution to CodeFights reverse challenge "dim": 
    /// https://codefights.com/challenge/pngP3vJ74YdtyBaWb
    /// </summary>
    public class Dim
    {
        /// <summary>
        /// Returns the minimum number of bits needed to store the value of an integer.
        /// </summary>
        /// <param name="n">A nonnegative integer.</param>
        /// <returns>The minimum number of bits needed to store the value of <paramref name="n"/>.</returns>
        public int dim(long n) => n < 2 ? 1 : 1 + dim(n / 2);
    }
}
