using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "checksum_part1": 
    /// https://codefights.com/challenge/MTgvXpcmjxQzkqpek
    /// 
    /// Given the first 11 digits of a GTIN-12 barcode as an integer (i.e. 
    /// without leading zeros), calculate the value of the last check digit.
    /// </summary>
    public class ChecksumPart1
    {
        /// <summary>
        /// Calculates the check digit value for the first 11 digits of a GTIN-12 barcode.
        /// </summary>
        /// <param name="barcode">The value of the first 11 digits.</param>
        /// <returns>The value of the check digit for <paramref name="barcode"/>.</returns>
        public int checksum_part1(long barcode)
        {
            var c = 210;
            for (; barcode > 0; barcode /= 100)
                c -= (int)(barcode * 31 / 10 % 10);
            return c % 10;
        }
    }
}