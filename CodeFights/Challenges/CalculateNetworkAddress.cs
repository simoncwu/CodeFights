using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "calculateNetworkAddress": 
    /// https://codefights.com/challenge/uivqcSYP9zHXXrNWz
    /// 
    /// Given an IP address in CIDR notation, calculate the network address.
    /// </summary>
    public class CalculateNetworkAddress
    {
        /// <summary>
        /// Returns the network address equivalent of an IP address in CIDR notation.
        /// </summary>
        /// <param name="cidr">An IP address in CIDR notation.</param>
        /// <returns>The network IP address equivalent of <paramref name="cidr"/>.</returns>
        public string calculateNetworkAddress(string cidr) =>
            // concatenate with dots
            string.Join(".",
                // isolate IP from subnet mask
                cidr.Split('/')[0]
                // for each octet in IP
                .Split('.').Select((_, i) =>
                // parse numeric value of octet
                int.Parse(_) &
                // create subnet mask
                ~0 << 32 - int.Parse(cidr.Split('/')[1])
                // left-shift mask to align with current octet
                >> 24 - i * 8));
    }
}
