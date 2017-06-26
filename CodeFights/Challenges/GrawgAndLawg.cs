using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "grawgAndLawg": 
    /// https://codefights.com/challenge/YapP4jc9KPYq9RA5s
    /// 
    /// Grawg and Lawg work at a shop selling pitchforks and torches. Each 
    /// customer order consits of 3 aspects of the pitchfork: the tines shape, 
    /// the handle size, and the handle length. When an order is placed, Grawg 
    /// writes down everything said in the order in a shorthand notation. As 
    /// a customer can change his mind at various points while placing the 
    /// order, the last notation is the one to actually use. In addition, each 
    /// order can optionally come with a torch, which would be designed for the 
    /// hand opposite to that holding the pitchfork. Lawg is illiterate, and 
    /// unable to read Grawg's notes. Help Lawg by transcribing Grawg's notes 
    /// into a Unicode art representation of the order, using the following 
    /// symbols:
    /// Tines Shapes:
    /// Normal:      N => E
    /// Left-hnaded: L => Ǝ
    /// Fancy:       F => £
    /// Clearance:   C => F
    /// 
    /// Handle Sizes:
    /// Small:  S => -
    /// Medium: M => =
    /// Grande: G => ≡
    /// 
    /// Torches:
    /// Order/Cancel a torch: T
    /// Left-handed torch: ~o>==
    /// Right-handed torch: ==<o~
    /// </summary>
    public class GrawgAndLawg
    {
        /// <summary>
        /// Converts an array of pitchfork/torch orders in shorthand notation to Unicode art depictions.
        /// </summary>
        /// <param name="orders">A list of orders, each guaranteed to be valid and complete.</param>
        /// <returns>An array of Unicode art depictions of each pitchfork/torch order.</returns>
        public string[] grawgAndLawg(string[] orders)
        {
            Console.OutputEncoding = Encoding.UTF8;
            return orders.Select(o =>
            {
                //create handle
                var handle = new string("  -  =  \u2261"[o.Last(_ => "SMG".Any(c => c == _)) % 9], int.Parse(Regex.Match(o, @"\d+(?!\D*\d)").ToString()));

                // select tines
                var tines = "\u00A3     \u018EFE"[o.Last(_ => "NLFC".Any(c => c == _)) % 10];

                // determine right/left handedness
                var leftHanded = tines < 398;

                // select torch
                var torch = o.Count(_ => _ == 'T') % 2 > 0 ? leftHanded ? "~o>== " : " ==<o~" : "";

                // assemble order
                return leftHanded ? torch + handle + tines : tines + handle + torch;
            }).ToArray();
        }
    }
}
