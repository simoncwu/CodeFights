using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "digitTreeSum": 
    /// https://codefights.com/interview-practice/task/2oxNWXTS8eWBzvnRB
    /// 
    /// You are given a binary tree where each node stores a single numeric 
    /// digit and each path from the root to a leaf encodes a non-negative 
    /// integer via the digits stored in each node along the path. Find the sum 
    /// of all the numbers encoded in the tree from its root to each leaf.
    /// </summary>
    public class DigitTreeSum
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
        /// Returns the sum of all the numbers encoded in a binary tree from its root to its leaves via the digits stored in its nodes.
        /// </summary>
        /// <param name="t">A binary tree.</param>
        /// <returns>The sum of all the numbers encoded in the tree rooted at <paramref name="t"/>.</returns>
        public long digitTreeSum(Tree<int> t)
        {
            long sum = 0;

            // start crawling from the root node, associated with a zero prefix
            var path = new Stack<Tuple<Tree<int>, long>>(new[] { Tuple.Create(t, 0L) });
            while (path.Any())
            {
                var p = path.Pop();
                t = p.Item1; // the next node in the tree
                var number = p.Item2 + t.value; // incorporate the prefix associated with the node into its value

                // check for leaf or intermediate node
                if (t.left == null && t.right == null)
                {
                    // leaf, so add to sum
                    sum += number;
                }
                else
                {
                    // intermediate node, so shift value left one digit and associate the result with the node's children
                    number *= 10;
                    foreach (var child in new[] { t.left, t.right })
                    {
                        if (child != null)
                        {
                            path.Push(Tuple.Create(child, number));
                        }
                    }
                }
            }
            return sum;
        }
    }
}
