using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution to CodeFights challenge "switchDemSigns": 
    /// https://codefights.com/challenge/CHajJHHfGYuGKMW7D
    /// 
    /// Given a string that represents a linear algebraic expression, invert 
    /// each plus or minus sign that is outside of any brackets in the 
    /// expression.
    /// 
    /// Note that:
    /// <list type="bullet">
    /// <item><description>
    /// There are only round (), curly {}, and square [] brackets.
    /// </description></item>
    /// <item><description>
    /// If the first variable does not have a sign, a plus sign is implied.
    /// </description></item>
    /// </list>
    /// </summary>
    public class SwitchDemSigns
    {
        /// <summary>
        /// Inverts all plus and minus signs in an algebraic expression not contained within a bracket.
        /// </summary>
        /// <param name="linEq">The expression to convert.</param>
        /// <returns></returns>
        public string switchDemSigns(string linEq)
        {
            var s = (linEq[0] > '-' ? "+ " + linEq : linEq).ToArray();
            int brackets = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                    case '[':
                    case '{':
                        brackets++;
                        break;
                    case ')':
                    case ']':
                    case '}':
                        brackets--;
                        break;
                    case '+':
                    case '-':
                        if (brackets == 0)
                            s[i] = s[i] == '-' ? '+' : '-';
                        break;
                }
            }
            return new string(s);

            // single-line LINQ space-hack algorithm
            string str = "";
            int x = 0;
            return (linEq[0] > '-' ? "+ " + linEq : linEq)
                .Max(_ =>
                     str += (brackets += (x = ")]}([{".IndexOf(_)) < 0 ? 0 : x / 3 * 2 - 1) < 1 & _ > 42 & _ < 46 ?
                         "                                           - +"[_] :
                         _);
        }
    }
}
