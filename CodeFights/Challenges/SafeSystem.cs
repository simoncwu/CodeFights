using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "safeSystem": 
    /// https://codefights.com/challenge/mATNcCZX4f5MEzQug
    /// 
    /// A mine can be represented as a tree with a root at node 1 representing 
    /// the mine entrance, each subsequent node representing a work area, and 
    /// each edge representing a passage connecting two areas. In case of an 
    /// emergency, miners are to be evacuated by simultaneously proceeding from 
    /// each area via the connected passages towards the entrance at the same 
    /// speed. Each passage has a length, and a limit to how many people can 
    /// enter it simultaneously. 
    /// 
    /// The mine is considered safe if, during an emergency evacuation, all 
    /// miners can traverse at the same speed all passages necessary to reach 
    /// the entrance from their assigned work areas without being impeded by 
    /// the passages' limit constraints. Determine the maximum number of miners 
    /// that can be safely stationed in the mine's work areas.
    /// 
    /// It is guaranteed that the mine is represented as a connected tree.
    /// </summary>
    public class SafeSystem
    {
        /// <summary>
        /// Returns the maximum number of miners that can work in a multi-area mine without violating evacuation safety protocols.
        /// </summary>
        /// <param name="prev">An array of the 1-based parent nodes for each work area, where 1 represents the entrance.</param>
        /// <param name="length">An array of the lengths of the passages from each area to its parent node.</param>
        /// <param name="limit">An array of the capacity limits of the passages from each area to its parent node.</param>
        /// <returns>The maximum number of miners that can safely work in the mine.</returns>
        public long safeSystem(int[] prev, int[] length, int[] limit)
        {
            // build parent-children map
            int i = 2;
            var children = prev.ToLookup(_ => _, _ => i++);

            // aggregate lengths relative to mine entrance
            AggregateAreaLengths(length, children, 1);

            // evacuate miners in batches per each distinct total length from entrance
            return length.Distinct().Sum(_ => MergePaths(length, limit, children, 1, _));
        }

        /// <summary>
        /// Aggregates relative lengths to areas in a mine to be absolute from a starting area.
        /// </summary>
        /// <param name="length">An array of the lengths of the passages from each area to its parent node.</param>
        /// <param name="children">A <see cref="ILookup{TKey, TElement}"/> map of parent areas to children areas.</param>
        /// <param name="start"></param>
        void AggregateAreaLengths(int[] length, ILookup<int, int> children, int start)
        {
            if (children.Contains(start))
            {
                // process node's immediate children
                foreach (var child in children[start])
                {
                    // if parent < 2 then parent is mine entrance, and child length does not require aggregation
                    if (start > 1)
                        length[child - 2] += length[start - 2];

                    // recursively aggregate child's children
                    AggregateAreaLengths(length, children, child);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">An array of the lengths of the passages from each area to the mine entrance.</param>
        /// <param name="limit">An array of the capacity limits of the passages from each area to its parent node.</param>
        /// <param name="children">A <see cref="ILookup{TKey, TElement}"/> map of parent areas to children areas.</param>
        /// <param name="root"></param>
        /// <param name="totalLength"></param>
        /// <returns></returns>
        long MergePaths(int[] length, int[] limit, ILookup<int, int> children, int root, int totalLength)
        {
            // result is smaller of sum of child areas' limits and own area limit
            return Math.Min(
                // mine entrance has no limit
                root < 2 ? long.MaxValue : limit[root - 2], 
                // if area is of desired length then return its limit
                root > 1 && length[root - 2] == totalLength ? limit[root - 2] : 
                // recursively crawl child areas for target length
                children.Contains(root) ? children[root].Sum(_ => MergePaths(length, limit, children, _, totalLength)) : 0);
        }
    }
}
