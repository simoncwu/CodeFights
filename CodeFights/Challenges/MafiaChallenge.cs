using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Mafia": 
    /// https://codefights.com/challenge/9MGJonqLaLGREtAnW
    /// 
    /// Of 100 residents in a town, ten of them are mafiosi. Given a list of 
    /// ten mafioso suspects from every resident (indexed by ID) where no 
    /// mobsters give up any other mobsters and every regular civilian 
    /// correctly identifies at least seven mafiosi, return a list of the ten 
    /// mafiosi in ascending ID order.
    /// </summary>
    public class MafiaChallenge
    {
        /// <summary>
        /// Returns a list of the ten mafiosi in a town of 100 residents.
        /// </summary>
        /// <param name="suspects">A list of ten mafioso suspects from each of the 100 residents, indexed by ID.</param>
        /// <returns>An array containing the IDs of the ten mafiosi in the town, in ascending order.</returns>
        public int[] Mafia(int[][] suspects)
        {
            return MafiaByOverlap(suspects);
        }

        /// <summary>
        /// Returns a list of the ten mafiosi in a town of 100 residents with preference towards those with the highest votes.
        /// </summary>
        /// <param name="suspects">A list of ten mafioso suspects from each of the 100 residents, indexed by ID.</param>
        /// <returns>An array containing the IDs of the ten mafiosi in the town, in ascending order.</returns>
        int[] MafiaByVotes(int[][] suspects)
        {
            // tally votes
            var votes = new int[100];
            foreach (var a in suspects.SelectMany(_ => _))
            {
                votes[a]++;
            }

            // process candidates in decreasing vote order
            var mafia = new HashSet<int>();
            foreach (var v in votes.Select((_, i) => i).OrderByDescending(_ => votes[_]))
            {
                mafia.Add(v);

                // For any set of top 10 votegetters, false-positive civilians will have a 40+% list overlap with correct answers, and mafiosi will have a <30% list overlap with incorrect answers
                mafia.RemoveWhere(m => mafia.Intersect(suspects[m]).Count() > 3);

                // stop once we have 10 valid suspects
                if (mafia.Count > 9)
                    break;
            }

            return mafia.OrderBy(_ => _).ToArray();
        }

        /// <summary>
        /// Returns a list of the ten mafiosi in a town of 100 residents by analyzing the overlap of each resident's list of suspects.
        /// </summary>
        /// <param name="suspects">A list of ten mafioso suspects from each of the 100 residents, indexed by ID.</param>
        /// <returns>An array containing the IDs of the ten mafiosi in the town, in ascending order.</returns>
        int[] MafiaByOverlap(int[][] suspects)
        {
            // leverages the invariant that all civilians have a 40+% list overlap with the other 69 civilians, and conversely that all mafiosi can have a 40+% overlap with only the 10 mafiosi (themselves included)
            return suspects.Select((_, i) => i).Where(i => suspects.Count(I => suspects[i].Intersect(I).Count() > 3) < 11).ToArray();
        }
    }
}
