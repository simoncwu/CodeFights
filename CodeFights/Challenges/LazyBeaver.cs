using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "lazyBeaver": 
    /// https://codefights.com/challenge/4v26NhgS8B3Z9N9eP
    /// 
    /// You are given three sets of instruction tasks that involve writing 1s 
    /// and 0s to a tape of infinite length. Each instruction set consists of a 
    /// series of states, which are arrays of six integers in the format:
    /// [a0, a1, b0, b1, c0, c1].
    /// These dictate the actions to take, depending on the value at the 
    /// current tape position. The values are to be interpreted as follows:
    /// - a0, a1: if the value at the current tape position is 0, change the 
    ///   current value to a0; otherwise, change it to a1.
    /// - b0, b1: if the value prior to performing a0/a1 is 0, advance the 
    ///   current tape position index by b0; otherwise, advance by b1.
    /// - c0, c1: if the value prior to performing a0/a1 is 0, set the state 
    ///   for the next operation to c0; otherwise, set it to c1. Halt when the 
    ///   next state becomes -1.
    /// Assuming the tape is initially zeroed, determine which instruction set 
    /// will halt first, and return the net number of 1s it will write to tape. 
    /// It is guaranteed that there will be one and only one set to halt first.
    /// </summary>
    public class LazyBeaver
    {
        /// <summary>
        /// Returns the net number of 1s that will be written to tape by the instruction task set that halts first.
        /// </summary>
        /// <param name="t1">A set of instruction tasks.</param>
        /// <param name="t2">A set of instruction tasks.</param>
        /// <param name="t3">A set of instruction tasks.</param>
        /// <returns>The number of 1s written to tape by whichever of <paramref name="t1"/>, <paramref name="t2"/>, and <paramref name="t3"/> will halt first.</returns>
        public int lazyBeaver(int[][] t1, int[][] t2, int[][] t3)
        {
            return LazyBeaverInfiniteTapeLength(t1, t2, t3);
        }

        /// <summary>
        /// Returns the net number of 1s that will be written to a tape of infinite length by the instruction task set that halts first.
        /// </summary>
        /// <param name="t1">A set of instruction tasks.</param>
        /// <param name="t2">A set of instruction tasks.</param>
        /// <param name="t3">A set of instruction tasks.</param>
        /// <returns>The number of 1s written to tape by whichever of <paramref name="t1"/>, <paramref name="t2"/>, and <paramref name="t3"/> will halt first.</returns>
        int LazyBeaverInfiniteTapeLength(int[][] t1, int[][] t2, int[][] t3)
        {
            var tasks = new[] { t1, t2, t3 };

            // represent infinite tape stream as doubly-linked list, track position via current node
            var tapes = tasks.Select(_ => new LinkedList<int>(new[] { 0 }).First).ToArray();

            // first triplet is states, second triplet is counts
            var statesAndCounts = new int[6];

            // run infinitely until exit state detected in any task track (within loop body)
            while (true)
            {
                // for each task
                for (int i = 0; i < 3; i++)
                {
                    // fetch variables for task operation
                    var state = tasks[i][statesAndCounts[i]];
                    var t = tapes[i];
                    int v = t.Value;

                    // a0/a1 (value), update 1s count
                    statesAndCounts[i + 3] += (t.Value = state[v]) - v;

                    // b0/b1 (tape position)
                    // if next position is prior to start of list or past the end, add a new node
                    tapes[i] = state[2 + v] > 0 ? t.Next ?? t.List.AddLast(0) : t.Previous ?? t.List.AddFirst(0);

                    // c0/c1 (state)
                    if ((statesAndCounts[i] = state[4 + v]) < 0)
                        return statesAndCounts[i + 3];
                }
            }
        }

        /// <summary>
        /// Returns the net number of 1s that will be written to a tape of fixed maximum length by the instruction task set that halts first.
        /// </summary>
        /// <param name="t1">A set of instruction tasks.</param>
        /// <param name="t2">A set of instruction tasks.</param>
        /// <param name="t3">A set of instruction tasks.</param>
        /// <param name="tapeLength">The length of tape available to each task set.</param>
        /// <returns>The number of 1s written to tape by whichever of <paramref name="t1"/>, <paramref name="t2"/>, and <paramref name="t3"/> will halt first.</returns>
        int LazyBeaverFixedTapeLength(int[][] t1, int[][] t2, int[][] t3, int tapeLength = 99)
        {
            // fixed length sizes
            int registerSize = 9, tapeStart = (tapeLength + 1) / 2;

            // format of memory array is a register of 9 integers of the form [ state index, tape index, 1s count ] * 3 (for each task group),
            // followed by 3 "tapeLength"s of tape
            var memory = new int[tapeLength * 3 + registerSize];

            // run infinitely until exit state detected in any task track (within loop body)
            while (true)
            {
                // for each task (literally, for each index in the register corresponding to each task)
                for (int i = 0; i < 9; i++)
                {
                    // fetch task state
                    var state = (i < 3 ? t1 : i < 6 ? t2 : t3)[memory[i]];

                    // offset tape index to center 0 at midpoint of tape length
                    int tapeIndex = memory[++i] + registerSize + tapeStart + tapeLength / 3 * i, v = memory[tapeIndex];

                    // b0/b1 (tape position)
                    memory[i] += state[2 + v];

                    // a0/a1 (value), update 1s count
                    memory[++i] += (memory[tapeIndex] = state[v]) - v;

                    // c0/c1 (state)
                    if ((memory[i - 2] = state[4 + v]) < 0)
                        return memory[i];

                    // at this point, i points to the 1s count index for each task group
                }
            }
        }
    }
}
