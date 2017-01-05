using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "granTurismo": 
    /// https://codefights.com/challenge/b6jdp8T8JAx7qopk3
    /// 
    /// The main objective of the driving license test "Starting and Stopping" 
    /// in the game Gran Turismo is to accelerate in a straight line from a 
    /// complete stop and come to a complete stop at the end of the runway.
    /// 
    /// Given various properties about the car and the length of the runway, 
    /// determine at which point to apply the brakes to complete this 
    /// objective. Assume the car is at any point at either maximum 
    /// acceleration or maximum deceleration.
    /// 
    /// Return the answer as a string in the format "mm:ss.fff".
    /// </summary>
    public class GranTurismo
    {
        /// <summary>
        /// Returns the time at which to begin braking in order to complete the Gran Turismo license test "Starting and Stopping".
        /// </summary>
        /// <param name="zeroTo100">The minimum time, in seconds, for the car to accelerate from a complete stop to 100 km/h.</param>
        /// <param name="topSpeed">The maximum speed of the car, in km/h.</param>
        /// <param name="brakingDistance">The minimum distance required, in meters, for the car to decelerate from 100 km/h to a complete stop.</param>
        /// <param name="runwayLength">The length of the runway, in meters.</param>
        /// <returns>The time to begin braking, in the format "mm:ss.fff".</returns>
        public string granTurismo(double zeroTo100, int topSpeed, int brakingDistance, int runwayLength)
        {
            // compute auxiliary properties using supplied arguments
            var acceleration = 100 / 3.6 / zeroTo100;
            var deceleration = 1e4 / 25.92 / brakingDistance;

            var topSpeedTime = topSpeed / 3.6 / acceleration;
            var topSpeedDistance = topSpeedTime * topSpeedTime * acceleration / 2;

            var maxBrakingDistance = topSpeed * topSpeed / 25.92 / deceleration;
            double time;

            // check if runway is long enough to reach top speed
            if (topSpeedDistance + maxBrakingDistance > runwayLength)
            {
                // point at which distance required for acceleration + distance required for deceleration = runway length
                time = Math.Sqrt(2 * runwayLength * deceleration / (acceleration + deceleration) / acceleration);
            }
            else
            {
                // full acceleration + cruising + full deceleration = runway length
                var cruisingDistance = runwayLength - topSpeedDistance - maxBrakingDistance;
                var cruisingTime = cruisingDistance / topSpeed * 3.6;
                time = topSpeedTime + cruisingTime;
            }
            time = Math.Round(time * 2) / 2;

            return string.Format("{0:00}:{1:00.000}", time / 60, time % 60);
        }

    }
}
