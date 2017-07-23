using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "magicParade_1": 
    /// https://codefights.com/challenge/6Q27kMBgJWfPKcxB4
    /// 
    /// The Grand Mage Parade is coming soon, and you're responsible for its 
    /// security. Three kinds of mages can participate in the parade: Water 
    /// Mages, Fire Mages, and Death Mages. All the mages walk the parade in 
    /// single file. For security reasons, there are some protocols that must 
    /// be followed:
    /// 1. There should never be 2 consecutive Death Mages, so all Death mages 
    ///    must be separated by at least one other mage.
    /// 2. There should never be more than 3 consecutive Fire Mages in a row. 
    ///    Also, any trio of Fire Mages must be followed by at least one Water 
    ///    Mage.
    /// 3. Water Mages can follow each other in unlimited numbers, but will 
    ///    never follow directly behind a Death Mage. In front of or two behind 
    ///    are okay.
    /// Given the counts of each type of mage that will participate, determine 
    /// whether or not it is possible to have a parade without violating any 
    /// security protocols.
    /// </summary>
    public class MagicParade1
    {
        /// <summary>
        /// Indicates whether or not it is possible to have a parade without violating security protocols.
        /// </summary>
        /// <param name="water">The number of Water Mages.</param>
        /// <param name="fire">The number of Fire Mages.</param>
        /// <param name="death">The number of Death Mages.</param>
        /// <returns><c>true</c> if it is possible to have a non-empty parade without violating security protocols; otherwise, <c>false</c>.</returns>
        public bool magicParade_1(int water, int fire, int death) =>
            // can only have a parade if there are any participants at all
            water + fire > -death &
            // only fire can break up death pairs, so make sure death never exceeds fire by 2
            death <= fire + 1 &
            // pair up waters with 3 fires each and deaths with 2 fires each, and make sure no more than 2 remain afterwards
            fire - 3 * water - 2 * death < 3;
    }
}
