using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "classifyStrings": 
    /// https://codefights.com/interview-practice/task/Ss4qyHoGJQhpvaGWc
    /// Asked By: Adobe
    /// 
    /// Classify a string as good or bad, where a string is bad if it has 3 
    /// consecutive vowels (a, e, i, o, u) or 5 consecutive consonants. It is 
    /// also possible for the string to contain wildcard '?' characters, which 
    /// can represent either a vowel or a consonant. If both possible kinds of 
    /// substitutions for any wildcard will inevitably yield a bad string, it 
    /// is considered bad. Otherwise, if one substitution produces a bad string 
    /// while the other produces a good string, it is considered mixed. Only 
    /// when none of these scenarios apply is the string considered good.
    /// 
    /// Return this classification as a string: "good", "bad", or "mixed".
    /// </summary>
    public class ClassifyStrings
    {
        /// <summary>
        /// Classifies a string as good, bad, or mixed.
        /// </summary>
        /// <param name="s">A string comprised of lowercase English alphabet letters, and '?'.</param>
        /// <returns>The classification for <paramref name="s"/> as any of "good", "bad", or "mixed".</returns>
        public string classifyStrings(string s)
        {
            int vowels = 0, consonants = 0, mixedVowels = 0, mixedConsonants = 0;

            // track if we've encountered any bad or mixed scenarios at all
            bool bad = false, mixed = false;

            // process the whole string, since a mixed scenario could precede a bad one
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                switch (c)
                {
                    case '?':
                        // reset explicit vowel/consonant counts
                        vowels = consonants = 0;

                        // only increment mixed counts
                        mixedVowels++;
                        mixedConsonants++;

                        // the idea is that you can avoid both bad scenarios with any double wildcard by just alternating them, so we only need to check for solitary instances
                        if (i > 0 && s[i - 1] != '?')
                        {
                            if (mixedVowels > 2)
                                // we have a possible mixed vowel scenario, so let's take the alternative route of assigning a consonant to avoid the mixed vowel situation
                                consonants++;
                            else if (mixedConsonants > 4)
                                // same as above, but the converse
                                vowels++;
                            // note: mixed vowel AND mixed consonant scenario should never occur, because:
                            // 1) each vowel/consonant resets the count of the other, and 
                            // 2) consecutive ?s are skipped over
                        }
                        break;
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels++;
                        mixedVowels++;

                        // we've seen a vowel, so reset consonant count
                        consonants = mixedConsonants = 0;
                        break;
                    default:
                        consonants++;
                        mixedConsonants++;

                        // we've seen a consonant, so reset vowel count
                        vowels = mixedVowels = 0;
                        break;
                }
                bad |= vowels > 2 | consonants > 4;
                mixed |= mixedVowels > 2 | mixedConsonants > 4;
            }
            return bad ? "bad" : mixed ? "mixed" : "good";
        }
    }
}
