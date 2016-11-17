using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade
{
    /// <summary>
    /// https://codefights.com/arcade/code-arcade/at-the-crossroads
    /// </summary>
    class AtTheCrossroads
    {
        /// <summary>
        /// Determines whether or not an RPG player levels up upon killing a monster.
        /// </summary>
        /// <param name="experience">Your current experience (XP).</param>
        /// <param name="threshold">The amount of XP required to reach the next level.</param>
        /// <param name="reward">The amount of XP to be gained from killing the monster.</param>
        /// <returns><c>true</c> if the player reaches the next level; otherwise, <c>false</c>.</returns>
        bool reachNextLevel(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }
    }
}
