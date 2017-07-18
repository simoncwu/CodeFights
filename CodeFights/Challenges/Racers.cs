using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "racers": 
    /// https://codefights.com/challenge/TAoHxosd5ZeebJ9mr
    /// 
    /// Determine the results of a race given the length of a straight track, 
    /// and each contestant's acceleration and maximum speed. Assume each 
    /// contestant accelerates at a constant rate starting from a rest position 
    /// until the maximum speed is achieved, at which point the speed remains 
    /// constant until the race is over. Return the results as an array of the 
    /// respective 0-based finishing positions (0 is first) matching each 
    /// contestant in the given arrays. In the case of a tie, the contestant 
    /// with the lower array position wins.
    /// </summary>
    public class Racers
    {
        /// <summary>
        /// Returns the finishing positions (0-based) of a group of contestants in a race.
        /// </summary>
        /// <param name="track">The length of the race track.</param>
        /// <param name="accel">An array of each contestant's acceleration as a measure of speed per unit time.</param>
        /// <param name="spd">An array of each constant's acceleration as a measure of distance per unit time.</param>
        /// <returns>An array of the 0-based finishing positions for each contestant in <paramref name="accel"/>/<paramref name="spd"/>.</returns>
        public int[] racers(int track, int[] accel, int[] spd)
        {
            int rank = 0;
            float x, t;
            foreach (var racerPosition in
                // generate IDs for each racer
                accel.Select((_, i) => i)
                // compute and sort by finishing time:
                .OrderBy(_ =>
                // if (1: time to cover distance at constant accel with no speed cap) is greater than
                (x = track / (t = accel[_]) * 2) >
                // (2: time until max speed is achieved) then
                (t = spd[_] / t) * t ?
                // return (2) plus (time to cover remaining distance at max speed)
                (t += x / t) * t :
                // else return (1)
                4 * x))
            {
                // reuse spd array to store ranks
                spd[racerPosition] = rank++;
            };
            return spd;
        }
    }
}
