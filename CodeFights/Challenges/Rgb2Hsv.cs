using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "rgb2hsv": 
    /// https://codefights.com/challenge/pESxR7nBYFjtZFWjk
    /// 
    /// Convert a color in RGB format to HSV. The result should be an array of 
    /// three strings of the format: 
    /// [ Hue (rounded to the nearest integer),
    ///   Saturation % (rounded to the nearest 1 decimal point),
    ///   Value % (rounded to the nearest 1 decimal point) ]
    /// </summary>
    public class Rgb2Hsv
    {
        /// <summary>
        /// Converts an RGB color to its HSV color space equivalent.
        /// </summary>
        /// <param name="rgb">A color as an array of its RGB color space components, in the format [R, G, B].</param>
        /// <returns>The HSV color space equivalent of <paramref name="rgb"/>, in the format ["H", "S", "V"].</returns>
        public string[] rgb2hsv(int[] rgb)
        {
            int cmax = rgb.Max(),
                cmin = rgb.Min(),
                delta = cmax - cmin,
                r = rgb[0],
                g = rgb[1],
                b = rgb[2];
            var hue = delta == 0 ? 0 : (cmax == r ? g - b + 6 * delta : cmax == g ? b - r + 2 * delta : r - g + 4 * delta) / (float)delta % 6 * 60;
            var sat = cmax == 0 ? 0 : delta / .01 / cmax;
            return new[] { hue.ToString("f0"), sat.ToString("f1"), (cmax / 2.55).ToString("f1") };
        }
    }
}
