using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "bitWork": 
    /// https://codefights.com/challenge/y4q97ZToigDhSPSHc
    /// 
    /// Given an instruction string, return the value encoded using the following rules:
    /// <list type="number">
    /// <item><description>First calculate the sum of the ASCII values of all characters in the instruction string.</description></item>
    /// <item><description>
    /// Then modify the value obtained during the first step according to the instructions contained within the string. Instructions have several concatenated parts, each in the format <c>[rule]</c><c>[value]</c>, and should be processed in order from left to right. The possible rules are: 
    /// <list type="bullet">
    /// <item><description>"" (empty rule): ignore the value and do nothing;</description></item>
    /// <item><description>"&": calculate the value of bitwise AND between the current result and the value and assign it to the current result;</description></item>
    /// <item><description>"|": same as above, using bitwise OR;</description></item>
    /// <item><description>"^": same as above, using bitwise XOR;</description></item>
    /// <item><description>"&lt;&lt;": same as above, using bitwise left shift;</description></item>
    /// <item><description>"&gt;&gt;": same as above, using bitwise right shift operation;</description></item>
    /// <item><description>"SB": set the value-th bit (0-based from right) of the result to 1;</description></item>
    /// <item><description>"CB": set the value-th bit (0-based from right) of the result to 0.</description></item>
    /// </list>
    /// </description></item>
    /// <item><description>Finally, invert the n-th bit (0-based from right) of the result, where n is the length of the instruction string.</description></item>
    /// </list>
    /// </summary>
    public class BitWork
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instructions"></param>
        /// <returns></returns>
        public int bitWork(string instructions)
        {
            // step 1
            int result = instructions.Sum(_ => _);

            // step 2
            ParseRules(instructions).ForEach(r =>
            {
                result = Op(r[0], r[1], result);
            });

            // step 3
            result ^= 1 << instructions.Length;

            return result;
        }

        /// <summary>
        /// Performs an instruction rule operation.
        /// </summary>
        /// <param name="rule">The rule to perform.</param>
        /// <param name="value">The rule value.</param>
        /// <param name="input">The operation input.</param>
        /// <returns>The result of the instruction rule operation.</returns>
        int Op(int rule, int value, int input)
        {
            int b = 1 << value;
            switch (rule)
            {
                case '&':
                    return input & value;
                case '|':
                    return input | value;
                case '^':
                    return input ^ value;
                case '<':
                    return input << value;
                case '>':
                    return input >> value;
                case 'S':
                    return input | b;
                case 'C':
                    return input & ~b;
            }
            return input;
        }

        /// <summary>
        /// Parses an instruction string and returns it as a list of rules.
        /// </summary>
        /// <param name="instructions">The instruction string to parse.</param>
        /// <returns>A <see cref="List{T}"/> of arrays representing individual instruction rules in the form [ rule, value ].</returns>
        List<int[]> ParseRules(string instructions)
        {
            var l = new List<int[]>();
            int i = 0, n = instructions.Length;
            while (i < n && !Char.IsDigit(instructions[i]))
            {
                var r = instructions[i++];
                if (!Char.IsDigit(instructions[i]))
                    i++;

                int v = 0;
                while (i + v < n && Char.IsDigit(instructions[i + v]))
                    v++;
                l.Add(new[] { r, int.Parse(instructions.Substring(i, v)) });
                i += v;
            }
            return l;
        }
    }
}
