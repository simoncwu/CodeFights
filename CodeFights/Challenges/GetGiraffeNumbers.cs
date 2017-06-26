using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "getGiraffeNumbers": 
    /// https://codefights.com/challenge/wv4zjAcJF7yMHqJLY
    /// 
    /// A natural number is called a giraffe if no digit in the number is preceded by a greater digit. For example 0, 1, 12, and 1556 are all giraffe numbers, while 21 and 1565 are not.
    /// Given maxNum, your task is to calculate the number of non-negative giraffe numbers that are smaller than maxNum.
    /// </summary>
    public class GetGiraffeNumbers
    {
        public long getGiraffeNumbers(string maxNum)
        {
            int n = maxNum.Length;
            var counts = new long[n][];
            for (int i = 0; i < n; i++)
            {
                counts[i] = new long[11];
                for (int j = 9; j >= 0; j--)
                {
                    counts[i][j] = i > 0 ? counts[i - 1][j] + counts[i][j + 1] : 1;
                }
            }

            long count = 0;
            maxNum = "0" + maxNum;
            for (int i = 1; i <= n && maxNum[i - 1] <= maxNum[i]; i++)
            {
                for (int j = maxNum[i] - 1; j >= '0' && j >= maxNum[i - 1]; j--)
                {
                    count += counts[n - i][j - '0'];
                }
            }

            return count;
        }
    }
}
