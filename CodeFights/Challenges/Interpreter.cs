using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "interpreter": 
    /// https://codefights.com/challenge/4s4LjtntJmnipxntv
    /// 
    /// Implement a Brainfuck (BF) interpreter. BF operates on an array of 
    /// memory cells, each initially set to zero, and a pointer that initially 
    /// points to the first memory cell. The commands to implement are: 
    /// 
    /// &gt;<!-->-->: Move the pointer to the right.
    /// &lt;<!--<-->: Move the pointer to the left.
    /// +: Increment the memory cell under the pointer.
    /// -: Decrement the memory cell under the pointer.
    /// [: Jump past the matching ] if the cell under the pointer == 0.
    /// ]: Jump back to the matching [ if the cell under the pointer != 0.
    /// .: Output the ASCII character of the cell at the pointer.
    /// 
    /// Each memory cell is a single unsigned byte, so it can contain an 
    /// integer from 0 to 255. The values in each cell wrap, i.e. 0 - 1 = 255 
    /// and 255 + 1 = 0. It is guaranteed that at each moment of program 
    /// execution, 0 ≤ pointer ≤ 2000.
    /// </summary>
    public class Interpreter
    {
        /// <summary>
        /// Executes a Brainfuck code script.
        /// </summary>
        /// <param name="program">A valid script to execute (no infinite loops or unbalanced brackets).</param>
        /// <returns>The output resulting from execution of <paramref name="program"/>.</returns>
        public string interpreter(string program)
        {
            // the memory array
            var mem = new byte[2000];
            // to track loop entry points
            var loops = new Stack<int>();
            // memory pointer
            int address = 0;
            var output = new StringBuilder();
            for (int i = 0; i < program.Length; i++)
            {
                switch (program[i])
                {
                    case '>':
                        address++;
                        break;
                    case '<':
                        address--;
                        break;
                    case '+':
                        mem[address]++;
                        break;
                    case '-':
                        mem[address]--;
                        break;
                    case '[':
                        if (mem[address] == 0)
                        {
                            // skip code until matching closing bracket
                            int j = 1;
                            while (j > 0)
                            {
                                j += 1 / ('\\' - program[++i]);
                            }
                        }
                        else
                        {
                            loops.Push(i);
                        }
                        break;
                    case ']':
                        if (mem[address] == 0)
                            loops.Pop();
                        else
                            // only loop if cell value is nonzero
                            i = loops.Peek();
                        break;
                    case '.':
                        output.Append((char)mem[address]);
                        break;
                }
            }
            return output.ToString();
        }
    }
}