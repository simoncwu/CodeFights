using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "theFather": 
    /// https://codefights.com/challenge/vdptjqniuvyqoyfh3
    /// 
    /// Recently, there have been many quarrels and clashes amongst members of 
    /// a large criminal organization, causing the main boss to decide to split 
    /// the organization into two independent groups so that all rival members 
    /// are in different groups, and no members of each group hate any other 
    /// group members.
    /// 
    /// Given a list of pairs of members who hate each other, determine whether 
    /// or not such a reorganization is possible with only two groups.
    /// </summary>
    public class TheFather
    {
        /// <summary>
        /// Indicates whether or not a group of gangsters can be split into two groups such that no members of each group hate any other group members.
        /// </summary>
        /// <param name="haters">An array of pairs of members who hate each other, given as a space-separated string of the members' names.</param>
        /// <returns><c>true</c> if it is possible to split <paramref name="haters"/> into two groups without any infighting</returns>
        public bool theFather(string[] haters)
        {
            // create a two-way adjacency list representing all rivalries, indexed by member
            var rivals = new Dictionary<string, List<string>>();
            Action<string, string> Hates = (a, b) => (rivals.ContainsKey(a) ? rivals[a] : rivals[a] = new List<string>()).Add(b);
            foreach (var h in haters)
            {
                var p = h.Split();
                Hates(p[0], p[1]);
                Hates(p[1], p[0]);
            }

            // crawl through the graph via a queue of each visited member's adjacent rivals, and attempt to alternately color each member
            var q = new Queue<string>();
            var group = new Dictionary<string, int>();
            
            // Adjacency list dictates the order in which we color. Repeat until no more members are left.
            while (rivals.Any())
            {
                // grab any member and queue him for processing as the graph coloring start point
                var name = rivals.Keys.First();
                q.Enqueue(name);

                // arbitrarily assign a group as the color
                group[name] = 0;

                // we're done when there are no more rivalries to process
                while (q.Any())
                {
                    // grab next name from queue, and associated color
                    var color = group[name = q.Dequeue()];

                    // if rivals no longer contains name, then we've visited him before, and we can skip
                    if (rivals.ContainsKey(name))
                    {
                        // process member's rival list
                        foreach (var m in rivals[name])
                        {
                            // if we haven't seen this member yet, assign him the opposite color of current member, and queue him up for further crawling
                            if (!group.ContainsKey(m))
                            {
                                group[m] = color ^ 1;
                                q.Enqueue(m);
                            }
                            else if (group[m] == color)
                            {
                                // We've already seen this member and determined he has a rival in the opposite group as well. Therefore, reorg is not possible.
                                return false;
                            }
                        }
                        // this guy passes so we no longer need his data -- remove it
                        rivals.Remove(name);
                    }
                }
            }

            // if we get to this point then all members were successfully colored into two groups without any conflicts
            return true;
        }

    }
}
