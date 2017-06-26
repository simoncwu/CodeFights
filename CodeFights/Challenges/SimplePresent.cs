using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "simplePresent": 
    /// https://codefights.com/challenge/ShRYqMNJLa5gHD7fs
    /// </summary>
    public class SimplePresent
    {
        public string simplePresent(string[] elements)
        {
            var noconjugate = Regex.IsMatch(elements[0], @"(?i)\b(and|these|those|we|they|i|you|\w*s)\b");
            return elements[0] + " " + (
               // always try to conjugate "be"
               elements[1] == "be" ? elements[0] == "I" ? "am" : noconjugate ? "are" : "is" :
               // no conjugation necessary
               noconjugate ? elements[1] :
               // "have"
               elements[1] == "have" ? "has" :
               // "-es"
               Regex.IsMatch(elements[1], "[osxzh]$") ? elements[1] + "es" :
               // default conjugation
               elements[1] + "s"
            ) + " " + elements[2];
        }
    }
}
