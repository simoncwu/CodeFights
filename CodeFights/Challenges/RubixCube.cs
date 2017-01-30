using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "rubixCube": 
    /// https://codefights.com/challenge/xQztPn2S7XobhMEyo
    /// 
    /// You are given a Rubix's cube as a rectangular matrix of size 3n x 4n, 
    /// where n is the length of a dimension of the cube. The matrix is 
    /// arranged into 12 nxn square grids as follows:
    /// 
    /// │        │B = Rear │         │          │
    /// ├────────┼─────────┼─────────┼──────────┤
    /// │L = Left│U = Top  │R = Right│D = Bottom│
    /// ├────────┼─────────┼─────────┼──────────┤
    /// │        │F = Front│         │          │
    /// 
    /// The ordering of the elements in each grid is such that the matrix can 
    /// be printed, cut, and folded as a single connected 2D shape into a 3D 
    /// model of the cube. The elements within a cube face are numbered from 1 
    /// to 6, representing the six colors of the cube.
    /// 
    /// You are also given a sequence of space-separated commands to execute. 
    /// Each command consists of one or two letters, followed by a number. The 
    /// first letter indicates a clockwise rotation around the axis that points 
    /// from the center of the cube towards the face indicated by the letter. 
    /// The second letter, if present, is an 'i', which indicates a 
    /// counter-clockwise rotation instead of clockwise. The number indicates 
    /// the number of the layer to rotate, with 0 being the face indicated by 
    /// the letter, and n-1 being the opposing face.
    /// 
    /// Return the final state of the cube after executing the commands given 
    /// as a rectangular matrix with the same layout as the initial state.
    /// 
    /// Constraints:
    /// 0 ≤ cube[i][j] ≤ 6, 
    /// 6 ≤ cube.length, 
    /// 8 ≤ cube[0].length, 
    /// 1 ≤ |commands|.
    /// </summary>
    public class RubixCube
    {
        /// <summary>
        /// Returns the final state of a Rubix cube after executing a series of rotations.
        /// </summary>
        /// <param name="cube">A rectangular matrix representing the state of the Rubix cube.</param>
        /// <param name="commands">A sequence of rotations to perform.</param>
        /// <returns>A rectangular matrix representing the final state of <paramref name="cube"/> after executing <paramref name="commands"/>.</returns>
        public int[][] rubixCube(int[][] cube, string commands)
        {
            foreach (var command in commands.Split(' '))
            {
                var c = Regex.Split(command, @"(?<=\D)(?=\d)");
                var l = int.Parse(c[1]);
                // normalize counter-clockwise rotations as clockwise rotations with respect to opposing face
                if (c[0].Length > 1)
                    l = cube.Length / 3 - 1 - l;

                switch (c[0])
                {
                    case "R":
                    case "Li":
                        RotateRight(cube, l);
                        break;
                    case "L":
                    case "Ri":
                        RotateLeft(cube, l);
                        break;
                    case "F":
                    case "Bi":
                        RotateFront(cube, l);
                        break;
                    case "B":
                    case "Fi":
                        RotateRear(cube, l);
                        break;
                    case "U":
                    case "Di":
                        RotateTop(cube, l);
                        break;
                    default:
                        RotateBottom(cube, l);
                        break;
                }
            }
            return cube;
        }

        /// <summary>
        /// Performs a single clockwise rotation about the axis normal to the right face of a Rubix cube.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="layer">The layer to rotate.</param>
        void RotateRight(int[][] cube, int layer)
        {
            int n = cube.Length / 3, nn = n + n, nn1 = nn - 1, nn1l = nn1 - layer, nnnl = 3 * n + layer;

            // store rear face
            var temp = cube.Take(n).Select(_ => _[nn1l]).ToArray();

            for (int i = 0; i < nn; i++)
            {
                // top->rear, front->top
                cube[i][nn1l] = cube[i + n][nn1l];
            }
            for (int i = 0; i < n; i++)
            {
                // bottom->front
                cube[nn + i][nn1l] = cube[nn1 - i][nnnl];

                // rear->bottom
                cube[nn1 - i][nnnl] = temp[i];
            }

            // face rotation
            if (layer < 1)
                RotateFace(cube, n, nn);
            else if (layer == n - 1)
                RotateFace(cube, n, 0, true);
        }

        /// <summary>
        /// Performs a single clockwise rotation about the axis normal to the left face of a Rubix cube.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="layer">The layer to rotate.</param>
        void RotateLeft(int[][] cube, int layer)
        {
            int n = cube.Length / 3, nl = n + layer, nn = n + n, nn1 = nn - 1, ll = nn1 + nn - layer;

            // store front face
            var temp = cube.Skip(nn).Select(_ => _[nl]).ToArray();

            for (int i = nn1; i >= 0; i--)
            {
                // top->front, rear->front
                cube[i + n][nl] = cube[i][nl];
            }
            for (int i = 0; i < n; i++)
            {
                // bottom->rear
                cube[i][nl] = cube[nn1 - i][ll];

                // front->bottom
                cube[nn1 - i][ll] = temp[i];
            }

            // face rotation
            if (layer < 1)
                RotateFace(cube, n, 0);
            else if (layer == n - 1)
                RotateFace(cube, n, nn, true);
        }

        /// <summary>
        /// Performs a single clockwise rotation about the axis normal to the front face of a Rubix cube.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="layer">The layer to rotate.</param>
        void RotateFront(int[][] cube, int layer)
        {
            int n = cube.Length / 3, nnn = 3 * n, nn1l = n + n - 1 - layer;

            // store bottom face
            var temp = cube[nn1l].Skip(nnn).ToArray();
            // left->top, top->right, right->bottom
            Array.Copy(cube[nn1l], 0, cube[nn1l], n, nnn);
            // bottom->left
            Array.Copy(temp, 0, cube[nn1l], 0, n);

            // face rotation
            if (layer < 1)
                RotateFace(cube, n + n, n);
            else if (layer == n - 1)
                RotateFace(cube, 0, n, true);
        }

        /// <summary>
        /// Performs a single clockwise rotation about the axis normal to the rear face of a Rubix cube.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="layer">The layer to rotate.</param>
        void RotateRear(int[][] cube, int layer)
        {
            int n = cube.Length / 3, nnn = 3 * n, nl = n + layer;

            // store left face
            var temp = cube[nl].Take(n).ToArray();
            // top->left, right->top, bottom->right
            Array.Copy(cube[nl], n, cube[nl], 0, nnn);
            // left->bottom
            Array.Copy(temp, 0, cube[nl], nnn, n);

            // face rotation
            if (layer < 1)
                RotateFace(cube, 0, n);
            else if (layer == n - 1)
                RotateFace(cube, n + n, n, true);
        }

        /// <summary>
        /// Performs a single clockwise rotation about the axis normal to the top face of a Rubix cube.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="layer">The layer to rotate.</param>
        void RotateTop(int[][] cube, int layer)
        {
            int n = cube.Length / 3, nn = n + n, nnl = nn + layer, n1l = n - 1 - layer;

            // store front face
            var temp = cube[nnl].Skip(n).Take(n).ToArray();

            // right->front
            Array.Copy(cube.Skip(n).Take(n).Select(_ => _[nnl]).Reverse().ToArray(), 0, cube[nnl], n, n);

            // rear->right
            for (int i = n; i < nn; i++)
            {
                cube[i][nnl] = cube[n1l][i];
            }

            // left->rear
            Array.Copy(cube.Skip(n).Take(n).Select(_ => _[n1l]).Reverse().ToArray(), 0, cube[n1l], n, n);

            // front->left
            for (int i = 0; i < n; i++)
            {
                cube[n + i][n1l] = temp[i];
            }

            // face rotation
            if (layer < 1)
                RotateFace(cube, n, n);
            else if (layer == n - 1)
                RotateFace(cube, n, 3 * n, true);
        }

        /// <summary>
        /// Performs a single clockwise rotation about the axis normal to the bottom face of a Rubix cube.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="layer">The layer to rotate.</param>
        void RotateBottom(int[][] cube, int layer)
        {
            int n = cube.Length / 3, n1l = n - 1 - layer, nn = n + n, nnn1l = n1l + nn;

            // store front face
            var temp = cube[nnn1l].Skip(n).Take(n).ToArray();

            // left->front
            Array.Copy(cube.Skip(n).Take(n).Select(_ => _[layer]).ToArray(), 0, cube[nnn1l], n, n);

            // rear->left
            for (int i = 0; i < n; i++)
            {
                cube[n + i][layer] = cube[layer][nn - 1 - i];
            }

            // right->rear
            Array.Copy(cube.Skip(n).Take(n).Select(_ => _[nnn1l]).ToArray(), 0, cube[layer], n, n);

            // front->right
            for (int i = 0; i < n; i++)
            {
                cube[n + i][nnn1l] = temp[n - 1 - i];
            }

            // face rotation
            if (layer < 1)
                RotateFace(cube, n, 3 * n);
            else if (layer == n - 1)
                RotateFace(cube, n, n, true);
        }

        /// <summary>
        /// Performs a single clockwise rotation of all the elements on a single Rubix cube face about its normal axis.
        /// </summary>
        /// <param name="cube">The cube's state matrix.</param>
        /// <param name="r">The row index of the top-left corner of the face to rotate in <paramref name="cube"/>.</param>
        /// <param name="c">The column index of the top-left corner of the face to rotate in <paramref name="cube"/>.</param>
        /// <param name="ccw">Whether or not to perform a counterclockwise rotation instead.</param>
        void RotateFace(int[][] cube, int r, int c, bool ccw = false)
        {
            int n = cube.Length / 3;
            var m = new int[n][];
            for (int i = 0; i < n; i++)
            {
                m[ccw ? n - 1 - i : i] = ccw ? cube.Skip(r).Take(n).Select(_ => _[c + i]).ToArray() : cube.Skip(r).Take(n).Select(_ => _[c + i]).Reverse().ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                Array.Copy(m[i], 0, cube[r + i], c, n);
            }
        }
    }
}
