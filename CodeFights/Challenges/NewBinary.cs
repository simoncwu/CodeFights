using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "newBinary": 
    /// https://codefights.com/challenge/wJBqxBg7rbbqD327Y
    /// 
    /// Today, you want to create a new type of binary data storage that will 
    /// allow arbitrary variable lengths. You will simulate this by creating a 
    /// string of 1's and 0's to imitate binary data and perform operations on 
    /// it as if it was actual binary memory storage.
    /// 
    /// Your tests will consist of two types of commands: set and del.
    /// 
    /// Set commands can both create and/or set a variable. Creation of a new 
    /// variable will allocate storage that should be appended to the end of 
    /// the existing storage string. Variables are declared as one of the 
    /// following supported types:
    /// 
    /// bool: A boolean value that can either be TRUE or FALSE and is stored as 
    /// a single bit set to either 1 or 0, respectively. Set examples:
    ///     bool x
    ///     bool y = TRUE
    ///     x = FALSE
    /// 
    /// char: A string of characters, each stored as an 8-bit number. Its size 
    /// indicates the number of characters the variable can hold. If it is 
    /// assigned a string of characters smaller than its size, the remaining 
    /// space is filled with nulls (0x00). Set examples:
    ///     char(6) x
    ///     char(3) y = 'abc'
    ///     x = 'qwerty'
    ///     
    /// int: A signed integer. Its size is specified as n[.m], where n is the 
    /// number of bytes of memory to occupy, and m, if specified, is the number 
    /// of bits to add to n. Negative integers should be stored using one's 
    /// complement. Set examples: 
    ///     int(2) x
    ///     int(4.3) y = 1234
    ///     x = -12
    ///     
    /// +int: An unsigned integer that can only be positive. Its size is 
    /// specified using the same specifications as int. Set examples: 
    ///     +int(2) x
    ///     +int(4.3) y = 1234
    ///     x = 12
    ///     
    /// dec: A signed floating point number, stored in IEEE 754 format. The 
    /// size is given as n/m, where n is the total number of bytes for the 
    /// entire variable, and m is the number of bytes reserved for the 
    /// exponent. Set examples: 
    ///     dec(4/1) x
    ///     dec(5/1) y = 0.25
    ///     x = -0.177
    ///     
    /// +dec: An unsigned floating point number that can only be positive, 
    /// stored in IEEE 754 format, without the sign bit. The size is 
    /// specified using the same specifications as dec. Set examples: 
    ///     +dec(4/1) x
    ///     +dec(5/1) y = 0.25
    ///     x = 0.177
    ///     
    /// A del command takes the name of a specific variable, removes it from 
    /// the binary string, and shifts all the data following it down to fill in 
    /// the empty space.
    /// 
    /// Given a list of commands, execute them and return the final memory 
    /// state string. It is guaranteed that the syntax of all commands adhere 
    /// to these specifications, and all values are appropriate for the type of 
    /// the variable being assigned to.
    /// </summary>
    public class NewBinary
    {
        // The binary data storage.
        StringBuilder _memory;

        // A map of variable names to their respective binary data storage address locations.
        Dictionary<string, int> _addresses;

        // A map of variable names to their respective types.
        Dictionary<string, string> _types;

        /// <summary>
        /// Simulates the results of performing a series of memory write operations on a string-based implementation of binary data storage.
        /// </summary>
        /// <param name="commands">A series of commands in the format [set/del, declaration/variable].</param>
        /// <returns>The string representation of the binary data storage upon executing all commands in <paramref name="commands"/>.</returns>
        public string newBinary(string[][] commands)
        {
            // initialize memory
            _memory = new StringBuilder();
            _addresses = new Dictionary<string, int>();
            _types = new Dictionary<string, string>();

            foreach (var c in commands)
            {
                switch (c[0])
                {
                    case "set":
                        int x = c[1].IndexOf('=');

                        // check for new variable declaration
                        var declaration = x < 0 ? c[1] : c[1].Remove(x).Trim();
                        if (declaration.Contains(' '))
                        {
                            MAlloc(declaration);
                            // strip type from command
                            c[1] = c[1].Substring(c[1].IndexOf(' '));
                        }

                        // check for value assignment
                        x = c[1].IndexOf('=');
                        if (x >= 0)
                        {
                            Set(c[1].Remove(x).Trim(), c[1].Substring(x + 1).Trim());
                        }
                        break;
                    case "del":
                        DAlloc(c[1]);
                        break;
                }
            }
            return _memory.ToString();
        }

        /// <summary>
        /// Deallocates space in the binary data storage for a specific variable.
        /// </summary>
        /// <param name="reference">The name of the variable to deallocate.</param>
        void DAlloc(string reference)
        {
            if (_addresses.ContainsKey(reference))
            {
                var address = _addresses[reference];
                var size = ParseSize(_types[reference]);

                // remove from memory
                _addresses.Remove(reference);
                _types.Remove(reference);
                _memory.Remove(address, size);

                // update addresses of variables stored after the dellocated variable to reflect new positions
                foreach (var k in _addresses.Where(_ => _.Value > address).ToArray())
                {
                    _addresses[k.Key] -= size;
                }
            }
        }

        /// <summary>
        /// Allocates space in the binary data storage for a new typed variable.
        /// </summary>
        /// <param name="declaration">A typed variable declaration.</param>
        void MAlloc(string declaration)
        {
            var d = declaration.Split(' ');
            // format should be { type, name }
            _addresses[d[1]] = _memory.Length;
            // default fill with 0s
            _memory.Append('0', ParseSize(_types[d[1]] = d[0]));
        }

        /// <summary>
        /// Parses a variable type string for the number of binary data storage bits it will use.
        /// </summary>
        /// <param name="type">A variable type.</param>
        /// <returns>The number of bits required to store a variable of type <paramref name="type"/>.</returns>
        int ParseSize(string type)
        {
            var size = ParseSizeString(type);
            switch (type.Remove(3))
            {
                case "boo":
                    return 1;
                case "cha":
                    return 8 * int.Parse(size);
                case "int":
                case "+in":
                    int x = size.IndexOf('.');
                    return 8 * int.Parse(x < 0 ? size : size.Remove(x)) + (x < 0 ? 0 : int.Parse(size.Substring(x + 1)));
                case "dec":
                case "+de":
                    return 8 * int.Parse(size.Remove(size.IndexOf('/')));
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Parses a variable-size variable type string for the portion that specifies its size.
        /// </summary>
        /// <param name="type">A variable type.</param>
        /// <returns>The portion of <paramref name="type"/> that specifies its size.</returns>
        string ParseSizeString(string type)
        {
            return type.Contains('(') ? type.Remove(type.IndexOf(')')).Substring(type.IndexOf('(') + 1) : "";
        }

        /// <summary>
        /// Parses a floating point variable type string for the number of binary data storage bits its exponent will use.
        /// </summary>
        /// <param name="type">A variable type.</param>
        /// <returns>The number of bits required to store the exponent for a floating point variable of size <paramref name="size"/>.</returns>
        int ParseFloatExponentSize(string type)
        {
            var size = ParseSizeString(type);
            return 8 * int.Parse(size.Substring(size.IndexOf('/') + 1));
        }

        /// <summary>
        /// Sets the value of a variable in the binary data storage.
        /// </summary>
        /// <param name="reference">The name of the variable to set.</param>
        /// <param name="value">The value to set <paramref name="reference"/> to.</param>
        void Set(string reference, string value)
        {
            var address = _addresses[reference];
            var type = _types[reference];
            var size = ParseSize(type);
            switch (type.Remove(2))
            {
                case "bo":
                    // boolean
                    _memory[address] = value == "FALSE" ? '0' : '1';
                    break;
                case "ch":
                    // char
                    foreach (int c in value.Trim('\'').PadRight(size / 8, '\0'))
                    {
                        foreach (var b in Convert.ToString(c, 2).PadLeft(8, '0'))
                        {
                            _memory[address++] = b;
                        }
                    }
                    break;
                case "in":
                case "+i":
                    // integer
                    // convert to binary of absolute value and use 1's complement if necessary
                    var v = Convert.ToString(value[0] == '-' ? ~uint.Parse(value.Substring(1)) : uint.Parse(value), 2).PadLeft(size, value[0] == '-' ? '1' : '0');
                    // trim string down to size if too long, since .NET generates 32-bit 1's complement strings
                    foreach (var b in v.Substring(v.Length - size))
                    {
                        _memory[address++] = b;
                    }
                    break;
                case "de":
                case "+d":
                    // floating point
                    foreach (var b in DecToBin(value, type))
                    {
                        _memory[address++] = b;
                    }
                    break;
            }
        }

        /// <summary>
        /// Converts a floating point value to its binary representation.
        /// </summary>
        /// <param name="value">A floating point value.</param>
        /// <param name="type">A floating point variable type.</param>
        /// <returns>A string representing the binary bits for storing <paramref name="bits"/>.</returns>
        string DecToBin(string value, string type)
        {
            // modified IEEE 754 format
            // sign bit (if applicable to type)
            var signBit = type[0] == '+' ? "" : value[0] == '-' ? "1" : "0";

            // before calculating exponent, determine if exponent is + or - by evaluating if value is only fractional
            var v = Math.Abs(double.Parse(value));

            // get integer bits, dropping leading 1
            // note: if value is fractional, result will be an empty string
            var bits = Convert.ToString((int)v, 2).Substring(1);

            // prepare exponent
            int m = ParseFloatExponentSize(type),
                exp = (1 << m - 1) - 1 + bits.Length, // 2^m - 1 bias
                mantissaBitsLeft = ParseSize(type) - m - signBit.Length - bits.Length;

            // need to track for leading 1 bit since we drop everything up until it (inclusive)
            bool sigFound = v >= 1;
            // compute negative powers of 2 bits until mantissa is filled
            while (mantissaBitsLeft > 0)
            {
                // isolate fractional portion and double to find next bit (negative power of 2)
                v = v % 1 * 2;

                // optimization step - bits terminate when no more fractional values remain
                if (v == 0)
                {
                    bits += new string('0', mantissaBitsLeft);
                    break;
                }

                if (sigFound)
                {
                    // only count bits that occur beyond the most significant bit
                    bits += (int)v;
                    mantissaBitsLeft--;
                }
                else
                {
                    // sig bit not yet found, ignore bit and decrement exponent
                    exp--;
                }
                
                // check for significant bit
                sigFound |= v >= 1;
            }

            // assemble computed bits
            return signBit + Convert.ToString(exp, 2).PadLeft(m, '0') + bits;
        }
    }
}
