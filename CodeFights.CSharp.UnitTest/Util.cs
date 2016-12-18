using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFights.CSharp.UnitTest
{
    internal class Util
    {
        /// <summary>
        /// Parses a string declaration of an array into an in-memory array instance.
        /// </summary>
        /// <typeparam name="T">The type of values contained in the array.</typeparam>
        /// <param name="array">The array string to parse.</param>
        /// <param name="parse">A function for converting each string element to type <typeparamref name="T"/>.</param>
        /// <returns>An in-memory array instance of the data described by <paramref name="array"/>.</returns>
        public static T[] ParseArray<T>(string array, Func<string, T> parse)
        {
            array = array ?? string.Empty;
            array = array.Trim();
            if (array.Length > 1 && array[0] == '[' && array.Last() == ']')
                array = array.Remove(array.Length - 1).Substring(1);
            return array.Split(',').Select(_ => parse(_)).ToArray();
        }

        /// <summary>
        /// Parses a string declaration of a jagged array into an in-memory array instance.
        /// </summary>
        /// <typeparam name="T">The type of values contained in the array.</typeparam>
        /// <param name="array">The jagged array string to parse.</param>
        /// <param name="parse">A function for converting each string element to type <typeparamref name="T"/>.</param>
        /// <returns>An in-memory jagged array instance of the data described by <paramref name="array"/>.</returns>
        public static T[][] ParseJaggedArray<T>(string array, Func<string, T> parse)
        {
            if (array.Length > 1 && array.StartsWith("[") && array.EndsWith("]"))
                array = array.Remove(array.Length - 1).Substring(1);
            return Regex.Matches(array, @"(\[[^\[\]]*\]),?").Cast<Match>().Select(_ => ParseArray(_.Groups[1].Value, parse)).ToArray();
        }

        /// <summary>
        /// Converts an array into a string representation of its contents.
        /// </summary>
        /// <typeparam name="T">The type of values contained in the array.</typeparam>
        /// <param name="array">The array to convert.</param>
        /// <returns>A string representation of array <paramref name="array"/> and its contents.</returns>
        public static string ArrayToString<T>(T[] array)
        {
            return $"[{String.Join(",", array)}]";
        }

        /// <summary>
        /// Converts a jagged array into a string representation of its contents.
        /// </summary>
        /// <typeparam name="T">The type of values contained in the jagged array.</typeparam>
        /// <param name="array">The jagged array to convert.</param>
        /// <returns>A string representation of <paramref name="array"/> and its contents.</returns>
        public static string JaggedArrayToString<T>(T[][] array)
        {
            return $"[{String.Join(",", array.Select(_ => ArrayToString(_)))}]";
        }
    }
}