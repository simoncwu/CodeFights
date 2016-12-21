using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "friendGroups": 
    /// https://codefights.com/challenge/por2d8kqNmPPfDvPt
    /// 
    /// Given the number of students in a class and a list of transitive 
    /// friendship pairs, calculate the number of mutually exclusive friendship networks 
    /// in the class.
    /// </summary>
    public class FriendGroups
    {
        /// <summary>
        /// Returns the number of mutually exclusive friendship networks in a class.
        /// </summary>
        /// <param name="n">The number of students in the class.</param>
        /// <param name="friends">An unordered array of 2-element arrays of friends.</param>
        /// <returns>The number of mutually exclusive friendship networks in the class.</returns>
        public int friendGroups(int n, int[][] friends)
        {
            int id = 0; // group ID counter
            var groups = new int[n]; // group ID assignments
            var overlap = new HashSet<int>(); // IDs of groups that can be absorbed as extensions to/by a lower ID group
            for (int i = 0; i < friends.Length; i++)
            {
                int k1 = friends[i][0], k2 = friends[i][1], g1 = groups[k1], g2 = groups[k2], g = g1 > g2 ? g1 : g2;
                if (g1 > 0 & g2 > 0 & g1 != g2)
                    overlap.Add(g);
                else
                    groups[k1] = groups[k2] = g > 0 ? g : ++id;
            }
            return groups.Count(_ => _ < 1) + id - overlap.Count;
        }

    }
}