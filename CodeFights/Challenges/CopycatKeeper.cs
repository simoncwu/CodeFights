using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "copycatKeeper": 
    /// https://codefights.com/challenge/ztKKQySBtPTHBHTNa
    /// 
    /// A bookshop owner wants to sort the books in a bookcase by title in 
    /// lexicographic order where the books on each shelf are left-justified. 
    /// However, he wants to sort each column separately while preserving the 
    /// number of books on each shelf.
    /// 
    /// Given the books' titles in the order appear on each shelf, sort them 
    /// as indicated and return them in the resulting order.
    /// </summary>
    public class CopycatKeeper
    {
        /// <summary>
        /// Sorts the books in a bookcase lexicographically by column while preserving the number of books per shelf.
        /// </summary>
        /// <param name="books">The contents of the bookcase, shelf by shelf.</param>
        /// <returns>The sorted arrangement of <paramref name="books"/>.</returns>
        public string[][] copycatKeeper(string[][] books)
        {
            int c = 0;
            do
            {
                // retrieve next column
                var column = books.Where(_ => _.Length > c);

                // exit when no items in the column
                if (!column.Any())
                    break;

                // sort the column
                var sorted = column.Select(_ => _[c]).ToArray();
                Array.Sort(sorted, string.CompareOrdinal);

                // copy sorted items back to column
                int i = 0;
                column.Max(_ => _[c] = sorted[i++]);
                c++;
            } while (true);
            return books;
        }
    }
}