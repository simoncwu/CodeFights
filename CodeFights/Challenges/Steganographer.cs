using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "steganographer": 
    /// https://codefights.com/challenge/PyzYWH2rf7eJDh9QH
    /// 
    /// A steganographer is an application that hides a message within another 
    /// file, like a picture. Since a color code difference of just 1 is barely 
    /// distinguishable to the human eye, it is possible to use the least 
    /// significant bit of certain colors in an RGBA construct to represent the 
    /// ASCII character code bits of a hidden message.
    /// 
    /// Take an image encoded as an array of 32-bit RGBA pixels (8 bits per 
    /// color component) and extract the message hidden in it using a 4-bit 
    /// code whose binary bits indicate which of the 4 components contain 
    /// message bits (e.g., 3 = 0011 indicates the 'B' and 'A' components).
    /// </summary>
    public class Steganographer
    {
        /// <summary>
        /// Returns a message hidden within a rectangular image.
        /// </summary>
        /// <param name="rgba_arr">A matrix of integers representing the 4x8 RGBA values of an image's pixels.</param>
        /// <param name="code">A 4-bit code indicating which RGBA color components contain message bits.</param>
        /// <returns>The message hidden within <paramref name="rgba_arr"/>.</returns>
        public string steganographer(long[][] rgba_arr, int code)
        {
            var sb = new StringBuilder();
            long charCode = 0, charBits = 0;

            // translate code into the (ordered from right to left) positions of the message bits
            var bitShift = new[] { 3, 2, 1, 0 }.Where(_ => (code & 1 << _) > 0).Select(_ => 8 * _);

            foreach (var pixel in rgba_arr.SelectMany(_ => _))
            {
                foreach (var s in bitShift)
                {
                    // aggregate each bit, using only the least significant 7 bits
                    charCode = charCode + charCode + (pixel >> s & 1) & 127;

                    // once 7 bits have been aggregated, convert to an ASCII code, and reset the aggregate result
                    if (++charBits > 6)
                    {
                        sb.Append((char)charCode);
                        charBits = 0;
                    }
                }
            }
            return sb.ToString();
        }
    }
}