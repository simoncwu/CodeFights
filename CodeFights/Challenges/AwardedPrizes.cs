using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "awardedPrizes": 
    /// https://codefights.com/challenge/FQJuF4Tsz632pcWgX
    /// 
    /// In a guessing contest, a finite number of prizes are awarded to 
    /// contestants based on the rank of their guess. Guesses are ranked based 
    /// upon their deviation from the correct answer, in increasing order. 
    /// Furthermore, all guesses that do not exceed the correct answer are 
    /// ranked higher than all guesses that do. Multiple guesses of the same 
    /// value are awarded by evenly splitting the sum of all prizes that can be 
    /// awarded to their respective ranks, and rounding up to the nearest cent. 
    /// In addition prizes are defined as range arrays of the format [starting 
    /// rank, ending rank (inclusive), prize value].
    /// 
    /// Given an array representing the prizes paid for each rank, an array of 
    /// guesses, and the correct answer, return an array of the prizes awarded 
    /// to each guess that corresponds by index to the array of guesses.
    /// </summary>
    public class AwardedPrizes
    {
        /// <summary>
        /// Returns the prize values awarded at the completion of a guessing contest.
        /// </summary>
        /// <param name="prizes">The prizes to be awarded based on ranges of ranks.</param>
        /// <param name="guesses">The contestants' guesses.</param>
        /// <param name="answer">The correct answer in the contest.</param>
        /// <returns>An array corresponding to <paramref name="guesses"/> of the prizes awarded for each guess.</returns>
        public double[] awardedPrizes(int[][] prizes, int[] guesses, int answer)
        {
            return AwardedPrizesByGuessIndex(prizes, guesses, answer);
        }

        /// <summary>
        /// Returns the prize values awarded at the completion of a guessing contest by ranking guess indices.
        /// </summary>
        /// <param name="prizes">The prizes to be awarded based on ranges of ranks.</param>
        /// <param name="guesses">The contestants' guesses.</param>
        /// <param name="answer">The correct answer in the contest.</param>
        /// <returns>An array corresponding to <paramref name="guesses"/> of the prizes awarded for each guess.</returns>
        double[] AwardedPrizesByGuessIndex(int[][] prizes, int[] guesses, int answer)
        {
            // sort group and sort guess IDs by guess/rank
            var winners = guesses.Select((_, i) => i).GroupBy(_ => guesses[_]).OrderBy(_ => _.Key <= answer ? -_.Key : _.Key);

            // calculate and assign awards 
            var awards = new double[guesses.Length];
            int rank = 0;
            foreach (var grp in winners)
            {
                var prize =
                    // enumerate ranks
                    grp.Select(_ => ++rank)
                    // calculate average prize for group's ranks
                    .Average(_ => prizes.Where(p => _ >= p[0] && _ <= p[1]).Sum(p => p[2]));
                // optional optimization step: stop awarding prizes once they've run out
                if (prize == 0)
                    break;
                foreach (var i in grp)
                {
                    awards[i] = Math.Ceiling(prize * 100) / 100;
                }
            }
            return awards;
        }

        /// <summary>
        /// Returns the prize values awarded at the completion of a guessing contest by mapping guess values to prize values.
        /// </summary>
        /// <param name="prizes">The prizes to be awarded based on ranges of ranks.</param>
        /// <param name="guesses">The contestants' guesses.</param>
        /// <param name="answer">The correct answer in the contest.</param>
        /// <returns>An array corresponding to <paramref name="guesses"/> of the prizes awarded for each guess.</returns>
        double[] AwardedPrizesByGuessValue(int[][] prizes, int[] guesses, int answer)
        {
            int rank = 0;
            var guessPrizeMap = guesses
                // in answer rank order
                .OrderBy(_ => _ <= answer ? -_ : _)
                // generate ranks
                .ToLookup(_ => _, _ => ++rank)
                // map answers to awarded prize values
                .ToDictionary(g => g.Key, g => g
                // calculate awarded prize value by looking up associated ranks in prizes definition
                .Average(_ => prizes.Where(p => _ >= p[0] && _ <= p[1]).Sum(p => p[2])));

            // look up the awarded prize value for each guess
            return guesses.Select(_ => Math.Ceiling(guessPrizeMap[_] * 100) / 100).ToArray();
        }
    }
}