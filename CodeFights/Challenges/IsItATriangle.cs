using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "isItATriangle": 
    /// https://codefights.com/challenge/EEKz3Qsdh7LLY9to4
    /// 
    /// Given an array of strings containing only underscores and dots, 
    /// determine whether or not the image formed by dots is a triangle and 
    /// either return the number of dots in the triangle, or 0 if the dots 
    /// don't form a valid triangle. A valid triangle is either right or 
    /// isosceles, only, and may point either up, down, left, or right, e.g.: 
    /// 
    /// __.__   _.__   _...   _._
    /// _..._   _.._   __..   _..
    /// .....   _...   ___.   _._
    /// 
    /// There is at least one dot in the image, and the dots form a single 
    /// connected image.
    /// </summary>
    public class IsItATriangle
    {
        /// <summary>
        /// Counts the number of dots that make up a valid triangle in an image.
        /// </summary>
        /// <param name="image">The image to scan.</param>
        /// <returns>The number of dots that make up the triangle if a valid one is found; otherwise, <c>0</c>.</returns>
        public int isItATriangle(string[] image)
        {
            return isItATriangleSingleConnected(image);
        }

        /// <summary>
        /// Counts the number of dots that make up a valid triangle in an image by parsing for the supported triangle patterns.
        /// </summary>
        /// <param name="image">The image to scan.</param>
        /// <returns>The number of dots that make up the triangle if a valid one is found; otherwise, <c>0</c>.</returns>
        int isItATriangleByPattern(string[] image)
        {
            int tip = FindTip(image);
            if (tip == -1)
                return 0;

            // check for upside-down triangle
            bool upsideDown = tip == image.Length - 1 || image[tip + 1].IndexOf('.') < 0;
            int col = image[tip].IndexOf('.');
            return CountTriangle(image, col, tip, upsideDown ? 0 : image.Length - 1);
        }

        /// <summary>
        /// Counts the number of dots that make up a valid triangle in an image 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        int CountTriangle(string[] image, int x, int y, int end)
        {
            int c = CountEquilateral(image, x, y, end < y);
            if (c > 0 || (c = CountRightOrSideEquilateral(image, x, y, end, false)) > 0)
                return c;
            return CountRightOrSideEquilateral(image, x, y, end, true);
        }

        int CountRightOrSideEquilateral(string[] image, int x, int y, int end, bool leftHypotenuse)
        {
            bool upsideDown = end < y;
            int dots = 1, inc = upsideDown ? -1 : 1, left = x, right = x;
            while (upsideDown ? y > end : y < end)
            {
                int first = image[y += inc].IndexOf('.');
                if (first < 0)
                    break;
                int last = image[y].LastIndexOf('.');
                if (leftHypotenuse ? first != --left || last != right : first != left || last != ++right)
                {
                    // check for side-facing triangle
                    if (!upsideDown && (leftHypotenuse ? last == right : first == left))
                    {
                        first = image[--y].IndexOf('.');
                        last = image[y].LastIndexOf('.');
                        int width = last - first + 1, otherEnd = y + width, otherTip = otherEnd - 1;
                        if (otherTip < image.Length && SingleDot(image[otherTip]) &&
                            (otherEnd == image.Length || image[otherEnd].IndexOf('.') < 0))
                        {
                            int mirror = CountRightOrSideEquilateral(image, x, otherTip, y, leftHypotenuse);
                            if (mirror > 0)
                                return dots + mirror - width;
                        }
                    }
                    return 0;
                }
                dots += last - first + 1;
            }
            return dots;
        }

        int CountEquilateral(string[] image, int x, int y, bool upsideDown)
        {
            int dots = 1, inc = upsideDown ? -1 : 1, left = x, right = x;
            while (upsideDown ? y > 0 : y < image.Length - 1)
            {
                int first = image[y += inc].IndexOf('.');
                if (first < 0)
                    break;
                int last = image[y].LastIndexOf('.');
                if (first != --left || last != ++right)
                    return 0;
                dots += last - first + 1;
            }
            return dots;
        }

        int FindTip(string[] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                if (SingleDot(image[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        bool SingleDot(string s)
        {
            return s.Count(c => c == '.') == 1;
        }

        int isItATriangleSingleConnected(string[] image)
        {
            image = image.Where(s => s.Any(c => c == '.')).ToArray();
            var widths = image.Select(s => s.Count(c => c == '.')).ToArray();
            var leftPositions = image.Select(s => s.IndexOf(".")).ToArray();

            Array.Sort(widths);
            Array.Sort(leftPositions);

            int lines = leftPositions.Length, j = lines < 2 ? 9 : widths[1], m = j > 2 ? 2 : 1, y = j < 2 ? 2 : 1;
            int leftPadding = leftPositions.Sum();

            bool r = widths[y - 1] > 1;
            for (int i = y; i < lines; i += y)
            {
                if (r |= widths[i] - widths[i - y] != m
                    | (leftPadding > leftPositions[0] * lines & leftPositions[i] - leftPositions[i - y] != 1))
                    break;
            }

            return r ? 0 : widths.Sum();
        }
    }
}
