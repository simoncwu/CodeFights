using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "codeObfuscation": 
    /// https://codefights.com/challenge/sTH2tJCG8zq4sHbkP
    /// 
    /// You are given a program in the form of a linear set of instructions and 
    /// arguments, and the types of data available to the program. The data 
    /// types should be specified by a numeric ID, as follows:
    /// Numeric types:
    /// 1 - boolean
    /// 2 - integer
    /// 3 - float
    /// 4 - double
    /// Textual types:
    /// 5 - char
    /// 6 - string
    /// 
    /// The instructions should be specified by a two-character ID where each 
    /// function expects to be followed by a certain number of arguments of 
    /// specific data types, each specified as an uppercase 2-character hex 
    /// data cell address:
    /// "0R" - return (no arguments)
    /// "01" - add (number, number)
    /// "4A" - subtract (number, number)
    /// "13" - multiply (number, number)
    /// "S2" - divide (number, number)
    /// "11" - auto-increment (integer)
    /// "3F" - auto-decrement (integer)
    /// "99" - string concatenation (text, text)
    /// "G0" - string conversion (text, number)
    /// 
    /// Verify that all the instructions in the program are valid and all 
    /// expected arguments for each function are specified and of the correct 
    /// data types. Any instructions encountered after a valid return ("0R") 
    /// instruction can be ignored.
    /// </summary>
    public class CodeObfuscation
    {
        // delegates for validating argument types
        Func<int, bool>[] ArgumentValidationTests = {
            // number type (optimized for tests)
            t => t < 5,
            // number type (optimized for tests)
            t => t > 0,
            // text type (optimized for tests)
            t => t > 4,
            // text type (optimized for tests)
            t => t < 7,
            // integer type
            t => t == 2
        };

        /// <summary>
        /// Indicates whether a program is valid
        /// </summary>
        /// <param name="data">An array of the data types for each data cell available to the program.</param>
        /// <param name="program">A string of instructions to validate.</param>
        /// <returns><c>true</c> if <paramref name="program"/> is valid for the data in <paramref name="data"/>; otherwise, <c>false</c>.</returns>
        public bool codeObfuscation(int[] data, string program)
        {
            bool returnFound = false; // when return instruction has been detected
            int argumentsCount = 0, // # of arguments to expect
                cellAddress = 0; // data cell address
            Func<int, bool>[] validateArgument = null;

            // split program into 2-character pairs and validate all values
            return Regex.Replace(program, "..", "$& ").Split().All(_ =>
                 // read instruction only when no arguments are outstanding
                 argumentsCount < 1 ?

                 // check for return
                 (returnFound |= _ == "0R") |

                 // read instruction and look up arguments
                 (argumentsCount = (
                     // map instruction to argument validation tests by index in validation tests array
                     validateArgument = ArgumentValidationTests.Skip(("014A13S2G0      99              113F".IndexOf(_) + 41) % 41 / 8).Take(2).ToArray()
                 ).Length) > 0 : // valid instructions have positive argument count

                 // there are outstanding arguments, so validate them
                 // rudimentary hex digit validation
                 _.All(h => h < 71) &&
                 // data list address validation
                 (cellAddress = Convert.ToInt32(_, 16)) < data.Length &&
                 // validate next argument
                 validateArgument[--argumentsCount](data[cellAddress])
                );
        }
    }
}
