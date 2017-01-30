using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "TetrahedronMaxFace": 
    /// https://codefights.com/challenge/4epHLhsXei3JhDY8o
    /// 
    /// Given the lengths of a tetrahedron's edges, find the maximum perimeter 
    /// a single face can possibly have. If the edge lengths cannot form a 
    /// valid tetrahedron, return 0.
    /// </summary>
    public class TetrahedronMaxFaceChallenge
    {
        /// <summary>
        /// Returns the maximum single-face perimeter possible for a specified sextuple of tetrahedron edge lengths.
        /// </summary>
        /// <param name="lengths">The proposed tetrahedron edge lengths.</param>
        /// <returns>The maximum single-face perimeter of the proposed tetrahedron if <paramref name="lengths"/> form a valid simplex; otherwise, <c>0</c>.</returns>
        public int TetrahedronMaxFace(int[] lengths)
        {
            Array.Sort(lengths);
            int p = 0;
            for (int i = 5; i > 1; i--) // is this loop necessary, or can we assume that the max will always involve the largest edge?
            {
                for (int j = i - 1; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        var face = new[] { lengths[k], lengths[j], lengths[i] };
                        if (Valid(face, lengths.Where((_, x) => x != i && x != j && x != k).ToArray()))
                            p = Math.Max(p, face.Sum());
                    }
                }
            }
            return p;
        }

        /// <summary>
        /// Determines whether or not a proposed sextuple of simplex edge lengths form a valid tetrahedron.
        /// </summary>
        /// <param name="face">The edges that will form a face of the tetrahedron.</param>
        /// <param name="edges">The edges that will join in a vertex opposite to <paramref name="face"/>.</param>
        /// <returns><c>true</c> if the proposed configuration of edge lengths form a valid tetrahedron; otherwise, <c>false</c>.</returns>
        bool Valid(int[] face, int[] edges)
        {
            // for various permutations of edges, use the volume determinant to validate the proposed configuration
            return new[] {
                new[] { edges[0], edges[2], edges[1] },
                new[] { edges[1], edges[2], edges[0] },
                new[] { edges[2], edges[1], edges[0] },
                // are these tests necessary?
                //new[] { edges[0], edges[1], edges[2] },
                //new[] { edges[1], edges[0], edges[2] },
                //new[] { edges[2], edges[0], edges[1] },
            }.Any(_ =>
            {
                int
                A = face[2],
                B = face[1],
                C = face[0],
                D = _[2],
                E = _[1],
                F = _[0];
                double
                h = (A * A + C * C - B * B) * .5 / C,
                g = Math.Sqrt(A * A - h * h),
                q = (C * C + E * E - D * D) * .5 / C,
                p = (A * A + E * E - F * F - 2 * q * h) * .5 / g,
                // technically, verifying a rational i is sufficient
                i = Math.Sqrt(E * E - q * q - p * p),
                e = C - q,
                a = -p,
                d = a,
                b = -q,
                c = -i,
                f = c;
                i = -i;
                g -= p;
                h -= q;
                d = a * (e * i - f * h) - d * (b * i - c * h) + g * (b * f - c * e);
                return !double.IsNaN(d) && d > 0;
            });
        }
    }
}
