using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice
{
    /// <summary>
    /// Solution for CodeFights interview practice "groupingDishes": 
    /// https://codefights.com/interview-practice/task/xrFgR63cw7Nch4vXo
    /// 
    /// You are given an array of dishes and their ingredients. Each dish is 
    /// represented by an array of its ingredients, with itself as the first 
    /// element. Pivot this data to a list of ingredients that are used in at 
    /// least two dishes, with each ingredient represented by an array of the 
    /// dishes it is used in, with itself as the first element. Sort the 
    /// result array lexicographically by ingredient name, and the dishes for 
    /// each ingredient lexicographically by dish name (while leaving the name 
    /// of the ingredient itself as the first element).
    /// </summary>
    public class GroupingDishes
    {
        /// <summary>
        /// Pivots an array of dishes and their ingredients to a lexicographically sorted array of ingredients used in two or more dishes, and the dishes they are used in
        /// </summary>
        /// <param name="dishes">An array of dishes, where each dish is an array containing first the name of the dish, and then the dish's ingredients.</param>
        /// <returns>An array of ingredients, where each ingredient is an array containing first the name of the ingredient, and then the dishes that use the ingredient.</returns>
        public string[][] groupingDishes(string[][] dishes)
        {
            // crawl through all arrays and create a mapping of ingredients to dishes they are used in
            var ingredients = new SortedDictionary<string, SortedSet<string>>(StringComparer.Ordinal);
            foreach (var d in dishes)
            {
                foreach (var i in d.Skip(1))
                {
                    (ingredients.ContainsKey(i) ? ingredients[i] : ingredients[i] = new SortedSet<string>(StringComparer.Ordinal)).Add(d[0]);
                }
            }

            // filter for ingredients used in 2+ dishes and transform to array representation, prefixing dishes with the ingredient name
            return ingredients.Where(_ => _.Value.Count > 1).Select(_ => new[] { _.Key }.Concat(_.Value).ToArray()).ToArray();
        }
    }
}
