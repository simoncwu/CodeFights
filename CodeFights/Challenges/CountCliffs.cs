using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "countCliffs": 
    /// https://codefights.com/challenge/6eeBErC6dHrTQnyhj
    /// 
    /// You are given a rectangular grid map of a sea as a 2D array. The map 
    /// shows the positions of cliffs in the area by marking each square 
    /// containing a cliff with a 1; otherwise, a 0 means there is no cliff in 
    /// that square. Two cliffs form a cliff line if they are connected; i.e., 
    /// they neighbor each other directly on their north/south or east/west 
    /// borders. Calculate the number of cliff lines on the map.
    /// </summary>
    public class CountCliffs
    {
        /// <summary>
        /// Counts the number of cliff lines on a sea map.
        /// </summary>
        /// <param name="seaMap">A rectangular matrix depicting the cliffs in an area of sea, where a '1' indicates the presence of a cliff, and '0' indicates the absence of it.</param>
        /// <returns>The number of cliff lines in <paramref name="seaMap"/>.</returns>
        public int countCliffs(int[][] seaMap)
        {
            int cliffs = 0;
            for (int r = 0; r < seaMap.Length; r++)
            {
                for (int c = 0; c < seaMap[0].Length; c++)
                {
                    if (CliffLineAt(seaMap, r, c))
                        cliffs++;
                }
            }
            return cliffs;
        }

        /// <summary>
        /// Indicates whether or not a cliff line exists at a coordinate on a sea map, and erases the entire cliff line if found.
        /// </summary>
        /// <param name="map">A rectangular matrix depicting the cliffs in an area of sea, where a '1' indicates the presence of a cliff, and '0' indicates the absence of it.</param>
        /// <param name="r">The index of a row in <paramref name="map"/>.</param>
        /// <param name="c">The index of a column in <paramref name="map"/>.</param>
        /// <returns><c>true</c> if a cliff line exists at <paramref name="map"/>[<paramref name="r"/>][<paramref name="c"/>]; otherwise, <c>false</c>.</returns>
        /// <remarks>This operation is destructive, and will erase cliff lines that are found before returning.</remarks>
        bool CliffLineAt(int[][] map, int r, int c)
        {
            return
                // verify coordinate is within map bounds
                r >= 0 && c >= 0 && r < map.Length && c < map[0].Length &&
                // verify presence of, and erase cliff
                map[r][c] > (map[r][c] = 0) &&
                // recursively count/erase connected cliffs
                true | CliffLineAt(map, r - 1, c) | CliffLineAt(map, r + 1, c) | CliffLineAt(map, r, c - 1) | CliffLineAt(map, r, c + 1);
        }
    }
}
