using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "appendHTML": 
    /// https://codefights.com/challenge/eR6Ru8tojfaKRDdY9
    /// 
    /// You are given the following three strings:
    /// - htmlDoc: a partial, valid HTML snippet
    /// - target: a jQuery-style element selector
    /// - htmlString: a valid HTML string to inject
    /// 
    /// Append [htmlString] to the end of the inner text for every [target] DOM 
    /// node in [htmlDoc]. [target] can be one of three formats:
    /// - selector, which represents a tag name;
    /// - #selector, which reprepresents an element's ID;
    /// - .selector, which represents an element's class.
    /// </summary>
    public class AppendHTML
    {
        /// <summary>
        /// Appends an HTML string to the inner text of all DOM nodes in a partial HTML document string that match a given selector.
        /// </summary>
        /// <param name="htmlDoc">A valid HTML string.</param>
        /// <param name="target">A string defining the elements, which can represent IDs, class names, or tag names.</param>
        /// <param name="htmlString">A valid HTML string to inject.</param>
        /// <returns>A string with <paramref name="htmlString"/> appended to the inner text of all <paramref name="target"/> DOM nodes in <paramref name="htmlDoc"/>.</returns>
        public string appendHTML(string htmlDoc, string target, string htmlString)
        {
            // regex for matching against tag attributes
            var tagAttributes = "([^<>\"]|\"[^\"]*\")*";

            // regex for matching against DOM nodes
            var regex = string.Format(
                // element ID
                target[0] == '#' ? @"<\w{1} id=""{0}""{1}>" :
                // class name
                target[0] == '.' ? @"<\w{1} class=""([^""]* )?{0}( [^""]*)?""{1}>" :
                // tag name
                "<{0}{1}>",
                target.TrimStart('.', '#'), tagAttributes);

            // insert strings in reverse order so as to avoid affecting match indices between each insert
            foreach (var match in Regex.Matches(htmlDoc, regex).Cast<Match>().Reverse())
            {
                // start at beginning of node's inner text
                int i = match.Index + match.Value.Length, children = 0;
                // search for tags
                for (; ; i = htmlDoc.IndexOf('<', i))
                {
                    // check for closing tag
                    if (htmlDoc.Substring(i, 2) == "</")
                    {
                        if (children == 0) // final closing tag found
                            break;
                        // consume child closing tag
                        children--;
                        i = htmlDoc.IndexOf('>', i);
                    }
                    else
                    {
                        // consume opening tag and increment children counter (if necessary)
                        var childTag = Regex.Match(htmlDoc.Substring(i), "^<\\w" + tagAttributes + ">").Value;
                        if (!string.IsNullOrEmpty(childTag))
                        {
                            i += childTag.Length;
                            if (!childTag.EndsWith("/>")) // skip self-closing tags
                                children++;
                        }
                    }
                }
                // actual insert
                htmlDoc = htmlDoc.Insert(i, htmlString);
            }
            return htmlDoc;
        }
    }
}
