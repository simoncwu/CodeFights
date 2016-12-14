using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class FindOperation
    {
        public string findOperation(int[] values, int result)
        {
            // NOTE: incorrect, incomplete solution
            var ops = new Stack<char>();
            FindOperators(values, 0, result, ops);
            var sb = new StringBuilder();
            int i = 0, n = values.Length;
            sb.Append(values[i]);
            while (++i < n)
            {
                sb.AppendFormat(" {0} {1}", ops.Pop(), values[i]);
            }
            sb.AppendFormat(" = {0}", result);
            return sb.ToString();
        }

        bool FindOperators(int[] values, int index, decimal result, Stack<char> ops)
        {
            int v = values[index++];
            if (index == values.Length)
                return v == result;
            if (FindOperators(values, index, result - v, ops))
            {
                ops.Push('+');
                return true;
            }
            if (FindOperators(values, index, result + v, ops))
            {
                ops.Push('-');
                return true;
            }
            if (FindOperators(values, index, result * v, ops))
            {
                ops.Push('/');
                return true;
            }
            if (v > 0 && FindOperators(values, index, Decimal.Divide(result, v), ops))
            {
                ops.Push('*');
                return true;
            }
            //ops.Pop();
            return false;
        }
    }
}
