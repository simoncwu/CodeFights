using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "graphDistances": 
    /// https://codefights.com/interview-practice/task/QTirmApTj7sWaidLk
    /// Asked By: Adobe, Samsung
    /// 
    /// You are given a connected, weighted, directed graph as a square matrix, 
    /// where g[i][j] is the weight of the edge from vertex i to vertex j, or 
    /// -1 if no such edge exists. Given a specific starting vertex, find the 
    /// minimal distance to each vertex in the graph.
    /// </summary>
    public class GraphDistances
    {
        /// <summary>
        /// Returns the minimal distance from a starting vertex to every vertex in a connected, weighted, directed graph.
        /// </summary>
        /// <param name="g">An array of the weights from each vertex to every other directly connected vertex, or -1 if no such edge exists.</param>
        /// <param name="s">The starting vertex (0-based).</param>
        /// <returns>An array of the minimal distances from <paramref name="s"/> to every vertex in <paramref name="g"/>.</returns>
        public int[] graphDistances(int[][] g, int s)
        {
            var distances = new int[g.Length].Select(_ => -1).ToArray();
            distances[s] = 0; // path to start is 0

            var stack = new Stack<int>();
            stack.Push(s); // start with start
            while (stack.Any())
            {
                s = stack.Pop();

                // for every possible vertex
                for (int v = 0; v < g.Length; v++)
                {
                    // where there is a connection from s to the vertex
                    if (g[s][v] != -1)
                    {
                        // compute distance from s to vertex
                        var d = distances[s] + g[s][v];
                        // if distance to vertex has not yet been computed, or distance is shorter than previously computed
                        if (distances[v] == -1 || d < distances[v])
                        {
                            distances[v] = d;
                            // (re)compute distances from vertex onwards
                            stack.Push(v);
                        }
                    }
                }
            }

            return distances;
        }
    }
}
