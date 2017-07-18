using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "NewYearCodeFightsHacking": 
    /// https://codefights.com/challenge/Bsmyb86TtXuL9DyE3
    /// 
    /// Given a positive number n and a message string, find the minimum number 
    /// of changes required to embed the uppercase form of the message into a 
    /// banner comprised of the word "codefights" repeated n times. Valid 
    /// changes include swapping a letter with another of the same case, or 
    /// capitalizing a lowercase letter. Return -1 if it is not possible to 
    /// embed the message into the banner. Note that just the characters need 
    /// to be embedded in the same order from left to right; the letters do not 
    /// necessarily have to be contiguous.
    /// </summary>
    public class NewYearCodeFightsHackingChallenge
    {
        /// <summary>
        /// Returns the minimum number of changes required to embed the uppercase form of a message into a repeated "codefights" banner.
        /// </summary>
        /// <param name="n">The number of repetitions of <c>"codefights"</c> in the banner.</param>
        /// <param name="message">The lowercase form of the message to embed.</param>
        /// <returns>The number of changes required.</returns>
        public int NewYearCodeFightsHacking(int n, string message)
        {
            // it is only impossible if the message exceeds the banner length
            string banner = "codefights";
            if (message.Length > (n *= banner.Length))
                return -1;

            // Dynamic Programming array to track minimum number of swaps per message character
            int[] swaps = new int[message.Length + 1];

            // Seed first value with -max to create a +max offset for remainder of array (swap every message character).
            // Alternatively, could instead loop through all indices > 1 and seed max swap val of +max.
            swaps[0] = -message.Length;

            // loop through each banner char
            for (int i = 0; i < n; i++)
            {
                // pseudo-generate each character of the banner instead of actually crafting it explicitly
                var c = banner[i % banner.Length];

                // reverse loop through each message char because following computation depends on value of previous index
                for (int j = message.Length; j > 0;)
                {
                    // key step: see if swaps can be reduced: 
                    // if message character matches banner character then take previous character's minimum (no swap needed here), else add 1 for swap
                    swaps[j] = Math.Min(swaps[j], message[--j] == c ? swaps[j] : swaps[j] + 1);
                }
            }

            // add an extra swap for each message character to convert to uppercase, and +max to undo offset
            return swaps[message.Length] + message.Length + message.Length;
        }
    }
}