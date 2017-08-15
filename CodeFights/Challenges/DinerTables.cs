using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "dinerTables": 
    /// https://codefights.com/challenge/hiZCrg5MS7mQ3Wy8h
    /// 
    /// A restaurant that accepts reservations has an interesting way of 
    /// allocating tables for each reservation. It starts by assigning a 
    /// minimum of one table for a reservation of size n, and then repeatedly 
    /// divides n by the number of tables, adding another table with each 
    /// round, until the number of tables is greater than n. Given a 
    /// reservation size, determine how many tables the restaurant will 
    /// allocate.
    /// </summary>
    public class DinerTables
    {
        /// <summary>
        /// Returns the number of tables the restaurant will allocate to a reservation.
        /// </summary>
        /// <param name="n">The size of the reservation.</param>
        /// <returns>The number of tables to be allocated.</returns>
        public int dinerTables(long n)
        {
            int tables = 0;

            // on each loop, add a table and check to see if it is greater than n
            for (; ++tables <= n;)
            {
                n /= tables;
            }
            return tables;
        }
    }
}
