using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "streamValidation": 
    /// https://codefights.com/interview/MthonrDiNxzE8MChQ
    /// 
    /// A character in UTF-8 can be anywhere from 1 to 4 bytes long and subject 
    /// to the following rules:
    ///  -  A 1-byte character's first bit is a 0.
    ///  -  The first n bits of an n-byte character's first byte are all 1s, 
    ///     followed by a 0. For each of the remaining n-1 bytes, the 2 most 
    ///     significant bits are "10".
    /// 
    /// To summarize the UTF-8 octet sequences:
    /// 1 byte character: 0xxxxxxx
    /// 2 byte character: 110xxxxx 10xxxxxx
    /// 3 byte character: 1110xxxx 10xxxxxx 10xxxxxx
    /// 4 byte character: 11110xxx 10xxxxxx 10xxxxxx 10xxxxxx
    /// 
    /// Given an array of 32-bit integers each representing a single byte, 
    /// determine if it can be converted to a valid UTF-8 encoding.
    /// </summary>
    public class StreamValidation
    {
        /// <summary>
        /// Indicates whether or not an array of integers can be converted to a valid UTF-8 encoding.
        /// </summary>
        /// <param name="stream">An array of integers.</param>
        /// <returns><c>true</c> if <paramref name="stream"/> represents a valid UTF-8 encoding; otherwise, <c>false</c>.</returns>
        public bool streamValidation(int[] stream)
        {
            int bytes = 0; // count of remaining unparsed bytes of an n-byte character
            return stream.All(_ =>
            // test for and validate n-byte character's trailing bytes' bits
            bytes-- > 0 ? _ >> 6 == 2 :
            // test for 1-byte character
            _ < 128 ||
            // test and parse for n-byte character (via leading 1s)
            (bytes = _ >> 3 == 30 ? 3 : _ >> 4 == 14 ? 2 : _ >> 5 == 6 ? 1 : 0) > 0) &
            // check for missing bytes for trailing n-byte character
            bytes < 1;
        }
    }
}
