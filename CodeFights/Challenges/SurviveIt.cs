using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "surviveIt": 
    /// https://codefights.com/challenge/Bw63XoZg24SpfJtcR
    /// 
    /// Your spaceship is defending itself against a fleet of enemy spacecrafts 
    /// sequentially numbered starting from 1, and destroys all enemies at odd 
    /// positions with each attack. What is the number of the enemy spacecraft 
    /// that survives the most rounds?
    /// </summary>
    public class SurviveIt
    {
        /// <summary>
        /// Returns the number of the spacecraft that survives the most rounds of attacks on every other ship.
        /// </summary>
        /// <param name="spacecrafts">The number spacecrafts.</param>
        /// <returns>The 1-based number of the spacecraft that survives the most rounds of attacks.</returns>
        public int surviveIt(int spacecrafts)
        {
            // Each round eliminates all ships NOT numbered 2^i where i is the 1-based round.
            // The last ship remaining is the one numbered the highest power of 2^i.
            while ((spacecrafts & spacecrafts - 1) > 0)
            {
                // unset rightmost 1 bit
                spacecrafts &= spacecrafts - 1;
            }
            return spacecrafts;
        }
    }
}
