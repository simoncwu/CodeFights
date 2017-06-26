using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "checkWeights": 
    /// https://codefights.com/challenge/hWKhTrLciWip9D3qZ
    /// 
    /// A company is about to ship a package containing several boxes of 
    /// weights. Each box is supposed to contain a set of weights of various 
    /// distinct, consecutive weights within a certain range, which is 
    /// indicated on a label on the box. However, due to production errors, 
    /// sometimes the contents are incorrect.
    /// 
    /// Given the actual total weight of the entire package and a list of the 
    /// label values for each box in it, calculate the discrepancy, if any, 
    /// between the actual package weight and its expected weight.
    /// </summary>
    public class CheckWeights
    {
        /// <summary>
        /// Returns the discrepancy between a package's actual total weight and its expected weight according to its contents' labels.
        /// </summary>
        /// <param name="boxes">An array of the label values for each box in the package, in the form [lowest weight, highest weight].</param>
        /// <param name="packageWeight">The actual total weight of the package.</param>
        /// <returns>The amount of weight that is missing (negative) or in excess (positive) from the package. If the weight is correct, return <c>0</c>.</returns>
        public int checkWeights(int[][] boxes, int packageWeight)
        {
            return packageWeight - boxes.Sum(_ => (_[1] - _[0] + 1) * _.Sum() / 2);
        }
    }
}