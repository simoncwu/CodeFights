using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Arcade.Intro
{
    /// <summary>
    /// Solutions for CodeFights Arcade "Intro" level "Level 5":
    /// https://codefights.com/arcade/intro/level-5
    /// </summary>
    class Level5
    {
        /// <summary>
        /// Call two people equally strong if their strongest arms are equally strong, and so are their weakest arms. Given your and your friend's arms' lifting capabilities find out if you two are equally strong.
        /// </summary>
        /// <param name="yourLeft">A non-negative integer representing the heaviest weight you can lift with your left arm.</param>
        /// <param name="yourRight">A non-negative integer representing the heaviest weight you can lift with your right arm.</param>
        /// <param name="friendsLeft">A non-negative integer representing the heaviest weight your friend can lift with his or her left arm.</param>
        /// <param name="friendsRight">A non-negative integer representing the heaviest weight your friend can lift with his or her right arm.</param>
        /// <returns><c>true</c> if you and your friend are equally strong, <c>false</c> otherwise.</returns>
        bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return yourLeft + yourRight == friendsLeft + friendsRight && Math.Max(yourLeft, yourRight) == Math.Max(friendsLeft, friendsRight);
        }

        /// <summary>
        /// Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
        /// </summary>
        /// <param name="inputArray">An non-empty array of integers.</param>
        /// <returns>The maximal absolute difference.</returns>
        int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int last = inputArray[0];
            return inputArray.Max(_ => Math.Abs(last - (last = _)));
        }

        bool isIPv4Address(string inputString)
        {
            try
            {
                return inputString.Split('.').Select(byte.Parse).Count() == 4;
            }
            catch
            {
                return false;
            }

            // via regex, without try/catch
            return inputString.Count(_ => _ == '.') == 3 && inputString.Split('.').All(_ => Regex.IsMatch(_, @"^(25[0-5]|2[0-4]\d|1?\d\d?)$"));
        }

        /// <summary>
        /// Given an array of integers representing coordinates of obstacles situated on a straight line, find the minimal jump length that will allow you to avoid all obstacles by evenly-spaced jumping from coordinate 0.
        /// </summary>
        /// <param name="inputArray">Non-empty array of positive integers.</param>
        /// <returns>The desired length.</returns>
        int avoidObstacles(int[] inputArray)
        {
            int n = 2;
            while (inputArray.Any(_ => _ % n < 1))
            {
                n++;
            }
            return n;
        }

        /// <summary>
        /// Apply box blur to a photo by cropping edge pixels and averaging each remaining pixel value with those of its 8 surrounding pixels. All fractions should be rounded down to the nearest integer.
        /// </summary>
        /// <param name="image">An image is stored as a rectangular matrix of non-negative integers.</param>
        /// <returns>A blurred image.</returns>
        int[][] boxBlur(int[][] image)
        {
            return image.Skip(2)
                .Select((_, i) => _.Skip(2).Select(
                    (c, j) => (int)image.Skip(i).Take(3).SelectMany(r => r.Skip(j).Take(3)).Average()
                    ).ToArray()).ToArray();
        }

        /// <summary>
        /// Each cell in a Minesweeper board contains either a mine or a number indicating the total number of mines in its neighboring cells. Starting off with some arrangement of mines, create a Minesweeper game setup.
        /// </summary>
        /// <param name="matrix">A non-empty rectangular matrix consisting of boolean values indicating whether or not each cell contains a mine.</param>
        /// <returns>Rectangular matrix corresponding to <paramref name="matrix"/> where each cell's value indicates the number of mines in the neighboring cells.</returns>
        int[][] minesweeper(bool[][] matrix)
        {
            return matrix.Select(
                (_, i) => _.Select(
                    (c, j) => matrix.Skip(i - 1).Take(i < 1 || i == matrix.Length - 1 ? 2 : 3).SelectMany(
                        r => r.Skip(j - 1).Take(j < 1 || j == _.Length - 1 ? 2 : 3)).Count(m => m == true) - (matrix[i][j] ? 1 : 0)).ToArray()).ToArray();
        }
    }
}