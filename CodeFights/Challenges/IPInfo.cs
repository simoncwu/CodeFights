using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "ipinfo": 
    /// https://codefights.com/challenge/PQ2ZtjHQcDC65wYhh
    /// 
    /// Given an IPv4 address in Classless Inter-Domain Routing notation, 
    /// return an array with the following information: 
    /// - IP address
    /// - subnet mask
    /// - subnet ID/IP address
    /// - first subnet host address
    /// - last subnet host address
    /// - subnet broadcast address
    /// </summary>
    public class IPInfo
    {
        /// <summary>
        /// Returns an array containing various details about an IP address's subnet.
        /// </summary>
        /// <param name="ip">An IPv4 address in CIDR notation.</param>
        /// <returns>An array containing subnet details for <paramref name="ip"/> in the format [ IP address, subnet mask, subnet IP, first subnet host, last subnet host, subnet broadcast IP ].</returns>
        public string[] ipinfo(string ip)
        {
            uint bitValue = 0, subnetMask = 0;
            int i = ip.IndexOf('/');

            // parse IP to a 32-bit unsigned integer
            bitValue = ip.Remove(i).Split('.').Aggregate(0U, (r, v) => r * 256U + uint.Parse(v));

            return new[] {
                // the ip itself
                ToResultString(bitValue),
                // create subnet mask based on the number after the '/' (# of significant bits set)
                ToResultString(subnetMask = ~0U << 32 - int.Parse(ip.Substring(i + 1))),
                // subnet ID: ip address AND subnet mask
                ToResultString(bitValue &= subnetMask),
                // subnet host address range start: subnet ID + 1
                ToResultString(++bitValue),
                // subnet host address range end: range start XOR inverse of subnet mask
                ToResultString(bitValue ^= ~subnetMask),
                // subnet broadcast address: host address range end + 1
                ToResultString(++bitValue)
            };
        }

        /// <summary>
        /// Converts an IP address its binary and decimal dot notations, separated by a space.
        /// </summary>
        /// <param name="address">An IP address as a <see cref="Int64"/>.</param>
        /// <returns>The binary and decimal dot representations of <paramref name="address"/>, separated by a space.</returns>
        string ToResultString(uint address)
        {
            var bytes = new[] { 24, 16, 8, 0 }.Select(_ => address >> _ & 255);
            return string.Join(".", bytes.Select(_ => Convert.ToString(_, 2).PadLeft(8, '0'))) + " " + string.Join(".", bytes);
        }
    }
}
