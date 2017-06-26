using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "theGunner": 
    /// https://codefights.com/challenge/d6Ryb6iPuyoJDHhhW
    /// 
    /// You have a gun that can hold 3 bullets of various attack powers at a 
    /// time. When the gun is reloaded, it is loaded with the same 3 bullets. 
    /// There are also up to 3 targets of various health points to shoot. Each 
    /// shot at a target reduces its health by the magnitude of the attack 
    /// power of the bullet used. Find the minimum number of times the gun has 
    /// to be reloaded (after firing) until the health of all targets have been 
    /// reduced to 0.
    /// </summary>
    public class TheGunner
    {
        /// <summary>
        /// Returns the minimum number of times a gun has to be reloaded with a set of bullets until a set of targets have been defeated.
        /// </summary>
        /// <param name="bullets">The attack powers of the bullets on hand.</param>
        /// <param name="targets">The health points for each target.</param>
        /// <returns>The minimum number of reloads needed until <paramref name="targets"/> have been defeated using <paramref name="bullets"/>.</returns>
        public int theGunner(int[] bullets, int[] targets)
        {
            // maximum of top n bullet values' worth of damage can be done before each reload,
            // answer is rounded up # of times between-reload damange divides into total target HP
            return (int)Math.Ceiling((double)targets.Sum() / bullets.OrderBy(_ => -_).Take(targets.Length).Sum());
        }

    }
}
