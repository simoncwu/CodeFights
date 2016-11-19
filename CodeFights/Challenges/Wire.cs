using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "wire": 
    /// https://codefights.com/challenge/aKGLZWGFpTNjQkTL2
    /// 
    /// You are connecting several stations along a railroad with electric 
    /// wire. The ith wire goes between stations l[i] and r[i]. To avoid short 
    /// circuits, no two wires can cross, but sharing endpoints is acceptable. 
    /// Also, the wires cannot cross the tracks and must be placed to either 
    /// the left or right of the tracks.
    /// 
    /// Determine if it is possible to place the wires in such a way that none 
    /// intersect.
    /// </summary>
    public class Wire
    {
        /// <summary>
        /// Indicates whether or not a set of wires can all be placed without any of them intersecting.
        /// </summary>
        /// <param name="l">The left edges of all wires. 1 ≤ l[i] ≤ r[i] ≤ 10^9.</param>
        /// <param name="r">The right edges of all wires. ||r|| = ||l||. 1 ≤ l[i] ≤ r[i] ≤ 10^9.</param>
        /// <returns><c>true</c> if it is possible to successfully place all wires; otherwise, <c>false</c>.</returns>
        public bool wire(int[] l, int[] r)
        {
            var wires = SortWires(l, r);
            Stack<int> topWires = new Stack<int>(), bottomWires = new Stack<int>();
            int topEnd = 0, bottomEnd = 0;
            return wires.All(w => TryInsertWire(topWires, w, ref topEnd) || TryInsertWire(bottomWires, w, ref bottomEnd));
        }

        /// <summary>
        /// Attempts to insert a new wire into a stack of wires without intersecting any previous wires.
        /// </summary>
        /// <param name="s">The stack of wires to update.</param>
        /// <param name="w">The left, right endpoints of the new wire.</param>
        /// <param name="endpoint">The right endpoint of the most recently added (innermost) wire. Its value is updated by a successful insertion.</param>
        /// <returns><c>true</c> if wire <paramref name="w"/> was successfully inserted into <paramref name="s"/>; otherwise, <c>false</c>.</returns>
        bool TryInsertWire(Stack<int> s, int[] w, ref int endpoint)
        {
            if (endpoint > 0 && endpoint <= w[0])
            {
                while (s.Count > 0 && s.Peek() <= w[0])
                {
                    s.Pop();
                }
            }
            if (s.Count > 0 && w[1] > s.Peek())
                return false;
            s.Push(endpoint = w[1]);
            return true;
        }

        /// <summary>
        /// Sorts a set of wires in increasing left edge order.
        /// </summary>
        /// <param name="l">The left edges of all wires.</param>
        /// <param name="r">The right edges of all wires.</param>
        /// <returns>An array of wires sorted in increasing left edge order.</returns>
        /// <remarks>Each wire in the returned array is represented by a 2-element array: [ left edge, right edge].</remarks>
        int[][] SortWires(int[] l, int[] r)
        {
            var wires = new int[l.Length][];
            for (int i = 0; i < l.Length; i++)
            {
                wires[i] = new[] { l[i], r[i] };
            }
            Array.Sort(wires, (a, b) => a[0].CompareTo(b[0]));
            return wires;
        }
    }
}
