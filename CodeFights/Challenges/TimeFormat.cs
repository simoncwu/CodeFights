using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "timeFormat": 
    /// https://codefights.com/challenge/rmG5EvvP8jubgyeEf
    /// 
    /// Given a time span in milliseconds, convert it to a string in a 
    /// specified format. The format only contains the following units of time: 
    /// 'y' for years (assume a 365-day year); 
    /// 'd' for days; 
    /// 'h' for hours; 
    /// 'm' for minutes; 
    /// 's' for the seconds; 
    /// 'ms' for the milliseconds.
    /// It is guaranteed that the format specifiers are always space-separated 
    /// and in decreasing duration order. If a unit specifier has a '%' prefix, 
    /// include the unit in the result; otherwise, just return the numeric 
    /// value.
    /// 
    /// If no format is specified, use the following default format: 
    /// "%y %d %h %m %s %ms".
    /// </summary>
    public class TimeFormat
    {
        // Table for mapping format specifiers to their respective millisecond multipliers for unit conversion.
        Dictionary<string, long> _conversionTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFormat"/> class.
        /// </summary>
        public TimeFormat()
        {
            long ms = 1;
            _conversionTable = new Dictionary<string, long> {
                { "ms", ms },
                { "s", ms *= 1000 },
                { "m", ms *= 60 },
                { "h", ms *= 60 },
                { "d", ms *= 24 },
                { "y", ms *= 365 }
            };
        }

        /// <summary>
        /// Converts a given millisecond time span to a string representation, using a custom format.
        /// </summary>
        /// <param name="value">A time span value, in milliseconds.</param>
        /// <param name="f">a time format string.</param>
        /// <returns>A string representation of value of the <paramref name="value"/> as specified by <paramref name="f"/>.</returns>
        public string timeFormat(long value, string f)
        {
            return string.Join(" ", (f == "" ? "%y %d %h %m %s %ms" : f).Split().Select(format =>
            {
                string unit = format.TrimStart('%');
                var u = _conversionTable[unit];
                return value / u + 0 * (value %= u) + (format[0] == '%' ? unit : "");
            }));
        }
    }
}
