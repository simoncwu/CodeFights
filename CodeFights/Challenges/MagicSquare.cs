using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "magicSquare": 
    /// https://codefights.com/challenge/MSrdnNFJJsgxkLyEr
    /// 
    /// Given integers [start], [step] and [n], return a magic square of order 
    /// [n] filled with numbers beginning from [start] and subsequently 
    /// increasing by [step]. Among all possible answers, return the 
    /// lexicographically smallest one. If there is no answer, return an empty 
    /// array.
    /// 
    /// Constraints: 1 ≤ n ≤ 4.
    /// </summary>
    public class MagicSquare
    {
        public int[][] magicSquare(int a, int e, int n)
        {
            switch (n)
            {
                case 1:
                    return new[] { new[] { a } };
                case 3:
                    // hard-coded square
                    /*
                    return new[] {
                        new[] { a + e, a + 6 * e, a + 5 * e },
                        new[] { a + 8 * e, a + 4 * e, a },
                        new[] { a + 3 * e, a + 2 * e, a + 7 * e }
                    };
                    */

                    // Siamese / De la Loubère method
                    int r = 1, c = 2;
                    var s = new int[n].Select(_ => new int[n]).ToArray();
                    for (n = a + n * n * e; a < n; a += e)
                    {
                        s[r][c] = a;
                        r = (r + 2) % 3;
                        c = ++c % 3;
                        if (s[r][c] > 0)
                        {
                            r = ++r % 3;
                            c = ++c % 3;
                        }
                    }
                    return s;
                case 4:
                    return new[] {
                        new[] { a, a + e, a + 14 * e, a + 15 * e },
                        new[] { a + 11 * e, a + 13 * e, a + 2 * e, a + 4 * e },
                        new[] { a + 12 * e, a + 6 * e, a + 9 * e, a + 3 * e },
                        new[] { a + 7 * e, a + 10 * e, a + 5 * e, a + 8 * e }
                    };
                default:
                    return new int[0][];
            }

            // space hack variation
            /*
            return n == 2 ?
                    new int[0][] :
                        (n > 3 ? @"	 	              	               
           	             	  	    
            	      	         	   
       	          	     	        " : n > 2 ? @" 	      	     
        	    	
   	  	       " : "").Split('\n').Select(_ => _.Split('	').Select(o => a + o.Length * e).ToArray()).ToArray();
            */
        }
    }
}
