using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "consecutiveBit": 
    /// https://codefights.com/challenge/fW66dxr49QERhv8KK
    /// 
    /// Given an integer, determine if there are any consecutive 1s in its 
    /// binary representation.
    /// </summary>
    public class ConsecutiveBit
    {
        /// <summary>
        /// Determines whether or not there are any consecutive 1s in an integer's binary representation.
        /// </summary>
        /// <param name="num">A non-negative integer.</param>
        /// <returns><c>true</c> if the binary representation of <paramref name="num"/> contains any consecutive 1s; otherwise, <c>false</c>.</returns>
        public bool consecutiveBit(int num)
        {
            return (num & num << 1) > 0;
        }
    }
}