using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse
{
    /// <summary>
    /// Solution for CodeFights reverse challenge "decryption": 
    /// https://codefights.com/challenge/28tzsTCcFaomnxZKC
    /// </summary>
    public class Decryption
    {
        /// <summary>
        /// Decrypts an array of bytes into a message.
        /// </summary>
        /// <param name="bytelist">An array of byte values representing the encrypted message.</param>
        /// <returns>The decrypted message.</returns>
        public string decryption(int[] bytelist)
        {
            for (int i = 2; i < bytelist.Length; i++)
            {
                bytelist[i] = (bytelist[i] + bytelist[i - 2]) % 128;
            }
            return new string(Array.ConvertAll(bytelist, _ => (char)_));

            // one-liner LINQ version
            return new string(bytelist.Select((_, i) => (char)(i < 2 ? _ : (bytelist[i] += bytelist[i - 2]) % 128)).ToArray());
        }
    }
}