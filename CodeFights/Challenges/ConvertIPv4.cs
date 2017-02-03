using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "convertIPv4": 
    /// https://codefights.com/challenge/in6dpQuF99YPNazib
    /// 
    /// Given an IPv4 address, find its integer and IPv6 equivalents and return 
    /// them as an array of strings. If the input in not a valid IPv4 address, 
    /// return an empty array instead.
    /// </summary>
    public class ConvertIPv4
    {
        /// <summary>
        /// Returns the integer and IPv6 equivalents of an IPv4 address.
        /// </summary>
        /// <param name="ip_v4_address">A string to convert.</param>
        /// <returns>An array of the integer and IPv6 equivalents of <paramref name="ip_v4_address"/> if it is a valid IPv4 address; otherwise, an empty array.</returns>
        public string[] convertIPv4(string ip_v4_address)
        {
            var octetPattern = @"(25[0-5]|2[0-4]\d|[01]?\d\d?)";
            if (!Regex.IsMatch(ip_v4_address, "^(" + octetPattern + @"\.){3}" + octetPattern + "$"))
                return new string[0];
            var n = ip_v4_address.Split('.').Select(_ => long.Parse(_)).Aggregate((r, _) => 256 * r + _);
            return new[] { n.ToString(), $"0:0:0:0:0:ffff:{n >> 16:x}:{n % 0x10000:x}" };
        }
    }
}
