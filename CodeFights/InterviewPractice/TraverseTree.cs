using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "traverseTree": 
    /// https://codefights.com/interview-practice/task/PhNPP45hZGNwpPchi
    /// 
    /// Given a binary tree of integers t, return its node values starting from 
    /// the root in breadth-first order from left to right. Solve this task 
    /// without using recursion.
    /// </summary>
    public class TraverseTree
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
        /// Returns the values of a binary tree in breadth-first order from left to right.
        /// </summary>
        /// <param name="t">The root node of a binary tree.</param>
        /// <returns>An array containing the values of <paramref name="t"/> in breadth-first order from left to right.</returns>
        public int[] traverseTree(Tree<int> t)
        {
            var q = new Queue<Tree<int>>();
            q.Enqueue(t);
            var ans = new List<int>();
            while (q.Any())
            {
                var node = q.Dequeue();
                if (node != null)
                {
                    ans.Add(node.value);

                    // queue left and right nodes to be processed before their children
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            return ans.ToArray();
        }
    }
}
