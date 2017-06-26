using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "missingPermutations": 
    /// https://codefights.com/challenge/Sg8uKa5h2xamncCZm
    /// </summary>
    public class MissingPermutations
    {
        string[] missingPermutations(string[] P)
        {
            var p = new List<string>();
            O("", string.Concat(P[0].OrderBy(_ => _)), p);
            return p.Except(P).ToArray();
        }

        void O(string prefix, string suffix, List<string> p)
        {
            if (string.IsNullOrEmpty(suffix))
                p.Add(prefix);
            int i = 0;
            foreach (var c in suffix)
                O(prefix + c, suffix.Remove(i++, 1), p);
        }

        public string[] missingPermutations2(string[] permutationList)
        {
            var letters = permutationList[0].Distinct().ToArray();
            Array.Sort(letters);
            var p = new List<string>();
            OrderedPermutations(letters, p);
            return p.Except(permutationList).ToArray();
        }

        void OrderedPermutations(char[] a, List<string> p, int n = 0)
        {
            if (n == a.Length - 1)
            {
                p.Add(new string(a));
            }
            else
            {
                for (int i = n; i < a.Length; i++)
                {
                    var t = a[n];
                    a[n] = a[i];
                    a[i] = t;
                    OrderedPermutations(a, p, n + 1);
                }
                Array.Sort(a, n, a.Length - n);
            }
        }
    }
}