using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "endianWar": 
    /// https://codefights.com/challenge/ChcFLSa3rfJsKNgkC
    /// 
    /// Joe Stoy, in his book "Denotational Semantics", tells the following 
    /// story about Alan Turing: "One early British computer had numbers 
    /// running from right to left (because the spot on an oscilloscope tube 
    /// runs from left to right, but in serial logic the least significant 
    /// digits are dealt with first). Turing used to mystify audiences at 
    /// public lectures when, quite by accident, he would slip into this mode 
    /// even for decimal arithmetic, and write things like 73+42=16...".
    /// 
    /// You are given an expression that was presumably written in such a 
    /// manner. Determine if it is a correct expression when interpreted in 
    /// little-endian decimal order.
    /// </summary>
    public class EndianWar
    {
        /// <summary>
        /// Indicates whether or not a mathematical expression is correct when interpreted in little-endian decimal order.
        /// </summary>
        /// <param name="expression">An expression in the format "a+b=c", where a, b, and c are integers, possibly with leading zeros.</param>
        /// <returns><c>true</c> if <paramref name="expression"/> is valid in little-endian notation; otherwise, <c>false</c>.</returns>
        public bool endianWar(string expression)
        {
            var e = expression.Split('=');
            Func<string, int> Eval = _ => _.Split('+').Sum(o => int.Parse(string.Concat(o.Reverse())));
            return Eval(e[0]) == Eval(e[1]);
        }
    }
}
