using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "fillTemplate": 
    /// https://codefights.com/challenge/uKiWry5XEwSuMveQM
    /// 
    /// Client side templates have a way to denote placeholders, to be filled in with dynamic content later. A placeholder in a template has the format {{placeholder}}, and it gets replace with the appropriate value one the page is loaded. For example, a welcome page template may greet a user as "Hello {{name}}" where the user's name is determined later.
    /// 
    /// Your task is to implement a function that will replace the placeholders in the given template.Note, that the template can contain nested placeholders.
    /// </summary>
    public class FillTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="template">An unfilled template.</param>
        /// <param name="placeholders">An array mapping template variables to values. ||placeholders[i]|| = 2.</param>
        /// <returns>The template string with all valid placeholders substituted.</returns>
        /// <remarks>
        /// It is guaranteed that template variables in <paramref name="template"/> will not contain { or } symbols.
        /// Each element of <paramref name="placeholders"/> is given in the format <c>[ variable, value ]</c>.
        /// It is guaranteed that <paramref name="placeholders"/> contains only unique variables, and neither variables nor values contain { or } symbols.
        /// </remarks>
        public string fillTemplate(string template, string[][] placeholders)
        {
            int i = 0;
            while (i < placeholders.Length)
            {
                string p = $"{{{{{placeholders[i][0]}}}}}";
                if (template.Contains(p))
                {
                    template = template.Replace(p, placeholders[i][1]);
                    i = 0; // reset after each substitution to handle nested placeholders
                    continue;
                }
                i++;
            }
            return template;
        }
    }
}
