using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "longestPath": 
    /// https://codefights.com/interview/6cH6crkjcD3YaAZ3Z
    /// 
    /// Suppose we represent a file system's contents as a string where only 
    /// file names, but not folder names, can contain periods. For example, 
    /// "user\r\tpictures\r\t\tphoto.png\r\t\tcamera\r\tdocuments\r\t\tlectures\r\t\t\tnotes.txt" 
    /// represents:
    /// user
    ///     pictures
    ///         photo.png
    ///         camera
    ///     documents
    ///         lectures
    ///             notes.txt
    /// Given a string representing a file system in this format, find the 
    /// length of the longest (as determined by the number of characters) 
    /// absolute path to a file. For example, in the example above, the 
    /// longest absolute path is "user/documents/lectures/notes.txt", with a 
    /// length of 33.
    /// </summary>
    public class LongestPath
    {
        /// <summary>
        /// Returns the length of the longest absolute path to a file in a file system.
        /// </summary>
        /// <param name="fileSystem">A string representing the contents of a file system.</param>
        /// <returns>The length of the longest path to a file in <paramref name="fileSystem"/>.</returns>
        public int longestPath(string fileSystem)
        {
            var dirs = new Stack<int>();
            int pathLength = 0, maxLength = 0;
            foreach (var f in fileSystem.Split('\r'))
            {
                // determine current directory level
                var level = f.TakeWhile(_ => _ == '\t').Count();

                // back out of directories until count matches level
                while (level < dirs.Count)
                {
                    pathLength -= dirs.Pop();
                }

                // skip tabs that match up with directory level and interpret remaining tabs as 4 spaces in the filename
                var fname = f.Substring(dirs.Count).Replace("\t", "    ");
                if (fname.Contains('.'))
                {
                    maxLength = Math.Max(maxLength, pathLength + fname.Length);
                }
                else
                {
                    // add new subdirectory
                    var len = fname.Length + 1;
                    dirs.Push(len);
                    pathLength += len;
                }
            }
            return maxLength;
        }
    }
}
