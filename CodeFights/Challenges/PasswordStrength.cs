using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "passwordStrength": 
    /// https://codefights.com/challenge/L3M46HoM4yk4dfHLi
    /// 
    /// Implement the following algorithm for computing the strength of a 
    /// password:
    /// 1. Split the letters of the password into the following groups and 
    /// count the number of unique characters in each group:
    /// - lowercase English letters;
    /// - uppercase English letters;
    /// - digits;
    /// - all other characters.
    /// 2. Compute the repetition factor for each group using the formula: 
    /// [repetition factor] = 1 - (1 - [growth factor])^[group size]
    /// where the growth factor for each group is (respectively):
    /// - 0.25
    /// - 0.4
    /// - 0.4
    /// - 0.5
    /// 3. Calculate the digit strength of the password as: 
    /// (∑([repetition factor] * [max group size]))^[password length]
    /// for all groups, where [max group size] is the maximum size of the group as given below(respectively):
    /// - 26
    /// - 26
    /// - 10
    /// - 32
    /// 4. Finally, calculate the password strength as: 
    /// [digit strength] = 2^[password strength]
    /// </summary>
    public class PasswordStrength
    {
        /// <summary>
        /// Calculates the strength of a password.
        /// </summary>
        /// <param name="p">A password string.</param>
        /// <returns>The password strength.</returns>
        public double passwordStrength(string p)
        {
            var growth_factor = new[] { .75, .6, .6, .5 };
            var max_group_size = new[] { 26, 26, 10, 32 };
            return
                Math.Log(
                    // digit strength
                    Math.Pow(
                        // unique characters
                        p.Distinct()
                        // group and count
                        .ToLookup(_ => _ > 96 && _ < 123 ? 0 : _ > 64 && _ < 91 ? 1 : _ > 47 && _ < 58 ? 2 : 3)
                        .Sum(
                            // repetition factor * max group size
                            _ => (1 - Math.Pow(growth_factor[_.Key], _.Count())) * max_group_size[_.Key]),
                        p.Length),
                    2);
        }

    }
}
