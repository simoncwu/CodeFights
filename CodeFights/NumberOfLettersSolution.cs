﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp
{
    /// <summary>
    /// Solution for CodeFights challenge "NumberOfLetters": 
    /// https://codefights.com/challenge/wcNrgbtmpWWn4DTwu
    /// 
    /// Pick a positive integer, write it out in English words, then count the 
    /// total number of letters in the words. Keep repeating this process 
    /// using the total as the new number to write and eventually you will 
    /// reach an infinite loop at the number 4, no matter which number you 
    /// start from.
    /// 
    /// Your task is to find the number of steps it takes to reach the number 
    /// 4 from the given integer n.
    /// </summary>
    /// <example>
    /// For n = 377, the output should be NumberOfLetters(n) = 5.
    /// <list type="bullet">
    /// 377 would be written as three hundred seventy seven which has 24 letters.</description></item>
    /// <item><description>24 would be written as twenty four which has 10 letters.</description></item>
    /// <item><description>10 would be written as ten which has 3 letters.</description></item>
    /// <item><description>3 would be written as three which has 5 letters.</description></item>
    /// <item><description>5 would be written as five which has 4 letters.</description></item>
    /// </list>
    /// We have now reached 4 and there were 5 steps in total, so the result is 5.
    /// </example>
    class NumberOfLettersSolution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">The starting number. 0 < n < 1000000000.</param>
        /// <returns>The number of steps taken to reach 4 from n.</returns>
        int NumberOfLetters(int n)
        {
            int count = 0;
            while (n != 4)
            {
                n = ToWords(n).Length;
                count++;
            }
            return count;
        }

        string ToWords(int n)
        {
            return ToWords(n.ToString());
        }

        string ToWords(string digits)
        {
            // trim leading 0s
            digits = digits.TrimStart('0');
            if (string.IsNullOrEmpty(digits))
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            // millions
            if (digits.Length > 6)
            {
                int sep = digits.Length - 6;
                BuildGroup(digits, sb, sep, "million");
            }

            // thousands
            else if (digits.Length > 3)
            {
                int sep = digits.Length - 3;
                BuildGroup(digits, sb, sep, "thousand");
            }

            // hundreds
            else if (digits.Length > 2)
            {
                BuildGroup(digits, sb, 1, "hundred");
            }

            else if (digits.Length > 1)
            {
                if (digits[0] == '1')
                {
                    string teen = string.Empty;
                    switch (digits[1])
                    {
                        case '0':
                            teen = "ten";
                            break;
                        case '1':
                            teen = "eleven";
                            break;
                        case '2':
                            teen = "twelve";
                            break;
                        case '3':
                            teen = "thirteen";
                            break;
                        case '4':
                            teen = "fourteen";
                            break;
                        case '5':
                            teen = "fifteeen";
                            break;
                        case '6':
                            teen = "sixteen";
                            break;
                        case '7':
                            teen = "seventeen";
                            break;
                        case '8':
                            teen = "eighteen";
                            break;
                        case '9':
                            teen = "nineteen";
                            break;
                    }
                    sb.Append(teen);
                }
                else if (digits[0] != '0')
                {
                    string tens = string.Empty;
                    switch (digits[0])
                    {
                        case '2':
                            tens = "twenty";
                            break;
                        case '3':
                            tens = "thirty";
                            break;
                        case '4':
                            tens = "forty";
                            break;
                        case '5':
                            tens = "fifty";
                            break;
                        case '6':
                            tens = "sixty";
                            break;
                        case '7':
                            tens = "seventy";
                            break;
                        case '8':
                            tens = "eighty";
                            break;
                        case '9':
                            tens = "ninety";
                            break;
                    }
                    sb.Append(tens);
                    sb.Append(DigitWord(digits[1]));
                }
            }
            else
            {
                sb.Append(DigitWord(digits[0]));
            }
            return sb.ToString();
        }

        void BuildGroup(string digits, StringBuilder sb, int cutoff, string groupWord)
        {
            string grp = ToWords(digits.Substring(0, cutoff));
            if (!string.IsNullOrEmpty(grp))
            {
                sb.Append(grp);
                sb.Append(groupWord);
            }
            sb.Append(ToWords(digits.Substring(cutoff)));
        }

        string DigitWord(char c)
        {
            switch (c)
            {
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
            }
            return string.Empty;
        }
    }
}
