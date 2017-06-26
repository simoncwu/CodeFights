using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class Extrapolation
    {
        public long extrapolation(long[] values)
        {
            return values.Any() ? values.Last() + extrapolation(values.Skip(1).Select((_, i) => _ - values[i]).ToArray()) : 0;
        }
    }
}
