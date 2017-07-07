using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "anArrayGame": 
    /// https://codefights.com/challenge/nrDyb3MKnhnye9YLe
    /// 
    /// Aydeen and Yara start playing a game using an array of integers. The 
    /// game is turn-based, with Aydeen going first. At each turn, the player 
    /// picks a number from the array to add to his score, and all values 
    /// preceding it are erased. Assuming that upon each turn, each player 
    /// chooses the number that would result in the largest score differential 
    /// in his own favor, return the name of the winner and the final score 
    /// differential in the form "[winner]: [absolute difference]". If this 
    /// results in a tie score, return "Draw" instead.
    /// </summary>
    public class AnArrayGame
    {
        /// <summary>
        /// Returns the winner and score differential of a numbers array game contest between Aydeen and Yara.
        /// </summary>
        /// <param name="arr">The array of integers.</param>
        /// <returns>The name of the winner and absolute score differential, or <c>"Draw"</c> if the game results in a tie.</returns>
        public string anArrayGame(int[] arr)
        {
            // naive strategy: take last number, leaving opponent with 0, so difference is value of the number
            int scoreDifference = arr.Last();

            // test each previous number in reverse
            foreach (var _ in arr.Reverse().Skip(1))
            {
                // max is the larger of previously obtained difference (choose previous move, which erases this and all previous numbers), 
                // vs. difference between previous max and current number (choose current number, and opponent's next optimal move results in previous max difference)
                scoreDifference = Math.Max(scoreDifference, _ - scoreDifference);
            }

            // since Aydeen goes first, the value we computed is Aydeen's score differential as compared to Yara: + means win, - means lose
            return
                scoreDifference > 0 ? "Aydeen: " + scoreDifference :
                scoreDifference < 0 ? "Yara: " + -scoreDifference :
                "Draw";
        }
    }
}
