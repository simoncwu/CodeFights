using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "Ubachi": 
    /// https://codefights.com/challenge/WbDRnJGc7TYLdtkcp
    /// 
    /// During World War I, the Germans used a double columnar transposition 
    /// cipher called Übchi where a message is laid out in even-width rows and 
    /// then written out column by column in a specific order. The process is 
    /// then repeated to increase the degree of encryption.
    /// 
    /// Both the row width and the column order are usually defined by the 
    /// alphabetical order of the letters in a keyword. For multiples of a 
    /// repeated letter, the order is defined by their order of appearance. For
    /// example, the keyword "pancake" defines an order of 7-1-6-3-2-5-4.
    /// 
    /// Given an encrypted message and its corresponding cipher keyword, 
    /// decrypt it and return the original message.
    /// </summary>
    public class UbachiChallenge
    {
        /// <summary>
        /// Decrypts an Übchi-encrypted message.
        /// </summary>
        /// <param name="message">The encrypted message.</param>
        /// <param name="keyword">The cipher keyword.</param>
        /// <returns>The original un-encrypted message.</returns>
        public string Ubachi(string message, string keyword)
        {
            // define column order
            var order = keyword.Select((_, i) => i).OrderBy(_ => keyword[_]).ToArray();
            order = order.OrderBy(_ => order[_]).ToArray();

            return Decrypt(Decrypt(message, order), order);
        }

        /// <summary>
        /// Performs a single pass of Übchi decryption on a message.
        /// </summary>
        /// <param name="message">The encrypted message.</param>
        /// <param name="order">The encryption column order.</param>
        /// <returns>The result of performing a single pass of Übchi decryption on <paramref name="message"/>.</returns>
        string Decrypt(string message, int[] order)
        {
            int n = message.Length, columns = order.Length;
            var s = new char[n];
            for (int row = 0, rows = n / columns; row < rows; row++)
            {
                for (int c = 0; c < columns; c++)
                {
                    // transpose rows and columns
                    s[c + row * columns] = message[row + order[c] * rows];
                }
            }
            return new String(s);
        }
    }
}
