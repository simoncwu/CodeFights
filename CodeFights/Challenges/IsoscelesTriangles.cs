using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "isoscelesTriangles": 
    /// https://codefights.com/challenge/vL9BYbHYiAnMPxqiX
    /// 
    /// You have several sticks of various lengths in your possession. How many isosceles triangles can you form using these sticks? Naturally, each stick can be used only once.
    /// </summary>
    public class IsoscelesTriangles
    {
        public int isoscelesTriangles(int[] sticks)
        {
            // sort distinct stick lengths and cache counts per length
            var counts = sticks.ToLookup(_ => _).ToDictionary(_ => _.Key, _ => _.Count());
            sticks = counts.Keys.ToArray();
            Array.Sort(sticks);

            int triangles = 0, thirdSideIndex = 0, thirdSticks = 0;
            foreach (var l in sticks)
            {
                // aggregate # of sticks short enough to be a third side per isosceles triangle candidate
                while (thirdSideIndex < sticks.Length && sticks[thirdSideIndex] < l + l)
                {
                    thirdSticks += counts[sticks[thirdSideIndex++]];
                }

                int c = counts[l];
                triangles +=
                    // non-equilateral isosceles triangles: 3rd sides * c Choose 2
                    (thirdSticks - c) * c * (c - 1) / 2 +
                    // equilateral triangles: c Choose 3
                    c * --c * --c / 3 / 2;
            }
            return triangles;
        }
    }
}