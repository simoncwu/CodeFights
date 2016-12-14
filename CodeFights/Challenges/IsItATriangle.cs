using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class IsItATriangle
    {
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


        public int isItATriangle(string[] image)
        {
            return isItATriangleSingleConnected(image);

            int tip = FindTip(image);
            if (tip == -1)
                return 0;

            int col = image[tip].IndexOf('.');
            bool upsideDown = tip == image.Length - 1 || image[tip + 1].IndexOf('.') < 0;
            return CountTriangle(image, col, tip, upsideDown ? 0 : image.Length - 1);
        }

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
    }
}
