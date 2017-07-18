using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "schedulable": 
    /// https://codefights.com/challenge/Wph6jWaomwnsBW6Sc
    /// 
    /// Rate-monotonic scheduling (RMS) is a priority assignment algorithm used 
    /// in real-time operating systems. Given a set of tasks, your job is to 
    /// determine whether they are schedulable by checking the Liu-Layland 
    /// system utilization condition.
    /// 
    /// Liu & Layland proved that for a set of periodic tasks with unique 
    /// periods, there exists a feasible schedule that will always meet 
    /// deadlines if the CPU utilization is below a specific bound which 
    /// depends on the number of tasks.The schedulability test they came up 
    /// with is as follows:
    /// 
    /// ∑(Ci/Ti) ≤ n * (2^(1/n) - 1)
    /// 
    /// where Ci and Ti are the computation time and period of the ith task, 
    /// respectively.
    /// 
    /// For the given tasks, return true if they satisfy the Liu-Layland 
    /// condition and false otherwise.
    /// </summary>
    public class Schedulable
    {
        /// <summary>
        /// Indicates whether or not a set of tasks are schedulable per the Liu-Layland system utilization condition.
        /// </summary>
        /// <param name="tasks">An array of tasks in the format [computation time, period].</param>
        /// <returns><c>true</c> if all tasks in <paramref name="tasks"/> are schedulable; otherwise, <c>false</c>.</returns>
        public bool schedulable(int[][] tasks)
        {
            int n = tasks.Length;
            return tasks.Sum(_ => _[0] * 1F / _[1]) <= n * Math.Pow(2, 1F / n) - n;
        }
    }
}
