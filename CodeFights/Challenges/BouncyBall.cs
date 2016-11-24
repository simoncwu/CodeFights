using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "bouncyBall": 
    /// https://codefights.com/challenge/iNbqN6rnfbphx74Q2
    /// 
    /// On each bounce, a ball may jump over one step or it may jump over 
    /// several steps. The ball never loses momentum, so each bounce must jump 
    /// over at least as many steps as the previous bounce.
    /// 
    /// The final bounce must be exactly the right length to reach the bottom 
    /// of the staircase. For example, for a staircase of eight steps, the 
    /// sequence 3, 4, 5 is invalid since the final bounce covers more steps 
    /// than are available. The sequence 3, 4, 1 is also invalid even though 
    /// it covers the correct amount of steps because the final bounce is 
    /// smaller than the one preceding it.
    /// 
    /// Some balls also accelerate as they make their way down the stairs. If 
    /// a ball has acceleration <c>a</c>, each bounce must jump over at least 
    /// a more steps than the previous bounce. For example, for a ball with 
    /// acceleration 2, after a bounce of 4 the next bounce must be at least 
    /// (4 + 2) = 6. The first bounce has no acceleration so can be a minimum 
    /// of 1 regardless of <c>a</c>.
    /// 
    /// Given ball acceleration <c>a</c> and length of a flight of stairs 
    /// <c>n</c>, return the number of valid paths the ball can take to cover 
    /// the flight of stairs.
    /// </summary>
    public class BouncyBall
    {
        /// <summary>
        /// Returns the number of unique paths a ball can take to cover a flight of stairs.
        /// </summary>
        /// <param name="n">The (positive) length of the flight of stairs, in steps.</param>
        /// <param name="a">The (non-negative) acceleration of the ball, in steps per bounce.</param>
        /// <returns>The number of unique paths the ball can take to cover the flight of stairs.</returns>
        public delegate int BouncyBallDelegate(int n, int a);

        public BouncyBallDelegate bouncyBall;

        public BouncyBall(BouncyBallDelegate algorithm)
        {
            bouncyBall = algorithm;
        }

        /// <summary>
        /// Returns the number of unique paths a ball can take to cover a flight of stairs via a Dynamic Programming algorithm.
        /// </summary>
        /// <param name="n">The (positive) length of the flight of stairs, in steps.</param>
        /// <param name="a">The (non-negative) acceleration of the ball, in steps per bounce.</param>
        /// <returns>The number of unique paths the ball can take to cover the flight of stairs.</returns>
        /// <remarks>
        /// This method utilizes an optimal time-complexity Dynamic Programming algorithm. The DP formula used is: 
        /// For any number of steps n, let F[n] be an array F[n][n] where F[n][i] = # of valid paths for an n-length flight of stairs that start with a first bounce of at least size i.
        /// In this way, F[n][n] ≤ F[n][n-1] ≤ F[n][n-2] ≤ ... ≤ F[n][1], and F[n][1] is the answer for length n, since all bounces start with at least a length of 1.
        /// In addition, each component of F[n] can be simplified as prefixing a subset of previous solutions with a smaller initial step, so that F[n][1] = 1 + F[n-1][1+a] + F[n-2][2+a] + ... + F[n-(n-a)/2][(n-a)/2+a].
        /// The series stops at (n-a)/2 because the shortest path of 2 bounces with initial bounce of k has a minimum traversal of k + k + a ≤ n, so k ≤ (n-a)/2. The initial 1 is for covering the entire flight in one bounce, which is not possible in any solution prior to F[n].
        /// </remarks>
        public static int PathsByPathPrefixing(int n, int a)
        {
            if (2 + a > n) // two bounces are not possible if a is too big, so cover in one bounce.
                return 1;
            var paths = new int[n + 1][];
            paths[1] = new[] { 1, 1 }; // seed initial solution for a flight of length 1

            // calculate solution for every increment of stair length up to target length
            for (int steps = 2 + a; steps <= n; steps++)
            {
                int maxFirstBounce = (steps - a) / 2; // determine maximum first bounce size
                paths[steps] = new int[maxFirstBounce + 1]; // initialize result array to use 1-based indexing

                // copy and aggregate # of prior paths using each possible first bounce and subsequent second bounce
                int pathCount = 1;
                for (int firstBounce = maxFirstBounce; firstBounce > 0; firstBounce--)
                {
                    int remainingSteps = steps - firstBounce, nextBounce = firstBounce + a;
                    var previousPath = paths[remainingSteps];
                    paths[steps][firstBounce] = pathCount += nextBounce >= (previousPath?.Length ?? 0) ? 1 : previousPath[nextBounce];
                }
            }
            return paths.Last()[1];
        }

        /// <summary>
        /// Returns the number of unique paths a ball can take to cover a flight of stairs by recursively attempting all valid combinations of bounce sizes. Although a much simpler algorithm, it is also significantly slower than the Dynamic Programming approach.
        /// </summary>
        /// <param name="n">The (positive) length of the flight of stairs, in steps.</param>
        /// <param name="a">The (non-negative) acceleration of the ball, in steps per bounce.</param>
        /// <returns>The number of unique paths the ball can take to cover the flight of stairs.</returns>
        public static int PathsByBouncing(int n, int a)
        {
            int paths = 1; // at the very least, skipping all remaining steps is one guaranteed path.
            // find all valid paths with initial bounce size up to n / 2 (because two bounces cannot exceed n)
            for (int bounce = 1, e = n / 2; bounce <= e; bounce++)
            {
                paths += PathsByBouncing(n, a, bounce);
            }
            return paths;
        }

        /// <summary>
        /// Returns the number of unique paths a ball can take to cover a flight of stairs.
        /// </summary>
        /// <param name="n">The (positive) length of the flight of stairs, in steps.</param>
        /// <param name="a">The (non-negative) acceleration of the ball, in steps per bounce.</param>
        /// <param name="bounce">The size of the first bounce, in steps.</param>
        /// <returns>The number of unique paths the ball can take to cover the flight of stairs.</returns>
        static int PathsByBouncing(int n, int a, int bounce)
        {
            // perform first bounce
            n -= bounce;
            bounce += a;
            if (bounce > n) // minimal next bounce exceeds end of stairs, so no valid paths possible
                return 0;

            int paths = 1; // at the very least, skipping all remaining steps is one guaranteed path.
            int end = n / 2; // two bounces cannot exceed n
            // check paths for every increasing next bounce size
            while (bounce <= end)
            {
                paths += PathsByBouncing(n, a, bounce++);
            }
            return paths;
        }
    }
}