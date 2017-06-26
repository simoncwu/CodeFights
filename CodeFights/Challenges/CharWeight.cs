using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "charWeight": 
    /// https://codefights.com/challenge/XJsMeeEhnPXyNnRdB
    /// 
    /// Given a string, calculate the weight of each of its characters, where 
    /// weight is the number of case-insensitive occurrences in the string. 
    /// Return the answer as a string in the format: 
    /// char1{weight1}char2{weight2}...
    /// The characters in the answer should be sorted by increasing weight, 
    /// then by increasing char code.
    /// </summary>
    public class CharWeight
    {
        /// <summary>
        /// Performs a case-insensitive calculation of the weight of the characters in a string.
        /// </summary>
        /// <param name="s">A string of English letters and digits.</param>
        /// <returns>The weights of the characters in <paramref name="s"/>.</returns>
        public string charWeight(string s)
        {
            return string.Concat(from _ in s
                                 group _ by (char)(_ | ' ') into _ // logical OR will convert uppercase chars to lowercase chars while preserving digits and lowercase chars
                                 orderby -_.Count(), _.Key
                                 select string.Format("{0}{{{1}}}", _.Key, _.Count())
                );
        }
    }
}
