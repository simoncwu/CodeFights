using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade
{
    /// <summary>
    /// Solutions for CodeFights Arcade level "Loop Tunnel": 
    /// https://codefights.com/arcade/code-arcade/loop-tunnel
    /// </summary>
    class LoopTunnel
    {
        /// <summary>
        /// Find the smallest factorial greater than or equal to a given integer.
        /// </summary>
        /// <param name="n">The minimum value of the factorial to find.</param>
        /// <returns>The smallest factorial greater than or equal to <paramref name="n"/>.</returns>
        int leastFactorial(int n)
        {
            int k = 1, i = 1;
            while (k < n)
            {
                k *= ++i;
            }
            return k;
        }
    }
}