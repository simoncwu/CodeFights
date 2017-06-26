using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Chemicals": 
    /// https://codefights.com/challenge/oeAMb5EuZmgndGTMK
    /// 
    /// Given an amount of liquid chemicals and an endless supply of containers 
    /// of various fixed capacities, find the minimum number of containers that 
    /// are needed to hold all the chemicals without leaving any containers 
    /// partially filled. If it is not possible to distribute the liquid 
    /// without partially filling any containers, return -1 instead.
    /// </summary>
    public class ChemicalsChallenge
    {
        /// <summary>
        /// Returns the minimum number of containers needed to distribute a specific amount of liquid chemicals without any partially filled containers.
        /// </summary>
        /// <param name="totalAmount">The total amount of liquid chemicals to distribute.</param>
        /// <param name="containers">An array of distinct container sizes that are available.</param>
        /// <returns>The minimum number of containers needed to distribute the liquid if it is possible to do so without any partially filled containers; otherwise, <c>-1</c>.</returns>
        public int Chemicals(int totalAmount, int[] containers)
        {
            // array of amounts
            var a = new int[totalAmount + 1];
            
            // 0-size container is implicit for amount 0
            a[0] = 1;
            foreach (var c in containers)
            {
                // start from container size as minimum possible amount
                for (int i = c; i <= totalAmount; i++)
                {
                    if (a[i - c] > 0 && // if amount lesser by current size is possible
                        (a[i] == 0 || a[i - c] < a[i])) // and current amount is not yet possible or lesser amount requires fewer containers
                        a[i] = a[i - c] + 1; // use lesser amount's containers and add 1 for current size
                }
            }
            // subtract 1 to compensate for implicit 0-size container offset, and convert impossible amounts' values to -1
            return a[totalAmount] - 1;
        }
    }
}
