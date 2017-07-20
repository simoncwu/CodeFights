using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "largestValuesInTreeRows": 
    /// Given a binary tree t, find the largest value in each row (nodes of 
    /// equal depth). Return The results as an array in increasing row depth 
    /// order.
    /// </summary>
    public class LargestValuesInTreeRows
    {
        /// <summary>
        /// A binary tree node.
        /// </summary>
        /// <typeparam name="T">The type of elements in the tree.</typeparam>
        public class Tree<T>
        {
            /// <summary>
            /// Gets or sets the node value.
            /// </summary>
            public T value { get; set; }

            /// <summary>
            /// Gets or sets the left child node.
            /// </summary>
            public Tree<T> left { get; set; }

            /// <summary>
            /// Gets or sets the right child node.
            /// </summary>
            public Tree<T> right { get; set; }
        }

        /// <summary>
        /// Returns an array containing the largest value in each row of a binary tree, in increasing row depth order.
        /// </summary>
        /// <param name="t">A binary tree.</param>
        /// <returns>An array of the largest value in each row of <paramref name="t"/>, in increasing depth order.</returns>
        public int[] largestValuesInTreeRows(Tree<int> t)
        {
            // to hold max value of each row, sorted in increasing depth order
            var ans = new SortedDictionary<int, int>();

            // depth-first crawling of tree
            var s = new Stack<Tuple<int, Tree<int>>>();
            s.Push(Tuple.Create(0, t));
            while (s.Any())
            {
                var tuple = s.Pop();
                var level = tuple.Item1;
                var node = tuple.Item2;
                if (node != null)
                {
                    // add value if it is the first encountered for depth, or larger than existing value
                    if (!ans.ContainsKey(level) || node.value > ans[level])
                        ans[level] = node.value;

                    // continue to process left and right child nodes
                    s.Push(Tuple.Create(level + 1, node.left));
                    s.Push(Tuple.Create(level + 1, node.right));
                }
            }
            return ans.Values.ToArray();
        }
    }
}
