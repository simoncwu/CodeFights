using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class GroupingDishesTests
    {
        [TestMethod()]
        public void groupingDishesTest()
        {
            var g = new GroupingDishes();
            Func<string, string> parse = _ => _;
            var dishes = Util.ParseJaggedArray(@"[[Salad,Tomato,Cucumber,Salad,Sauce], 
 [Pizza,Tomato,Sausage,Sauce,Dough], 
 [Quesadilla,Chicken,Cheese,Sauce], 
 [Sandwich,Salad,Bread,Tomato,Cheese]]", parse);
            var expected = "[[Cheese,Quesadilla,Sandwich],[Salad,Salad,Sandwich],[Sauce,Pizza,Quesadilla,Salad],[Tomato,Pizza,Salad,Sandwich]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(g.groupingDishes(dishes)));

            dishes = Util.ParseJaggedArray(@"[[Pasta,Tomato Sauce,Onions,Garlic], 
 [Chicken Curry,Chicken,Curry Sauce], 
 [Fried Rice,Rice,Onions,Nuts], 
 [Salad,Spinach,Nuts], 
 [Sandwich,Cheese,Bread], 
 [Quesadilla,Chicken,Cheese]]", parse);
            expected = "[[Cheese,Quesadilla,Sandwich],[Chicken,Chicken Curry,Quesadilla],[Nuts,Fried Rice,Salad],[Onions,Fried Rice,Pasta]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(g.groupingDishes(dishes)));

            dishes = Util.ParseJaggedArray(@"[[Pasta,Tomato Sauce,Onions,Garlic], 
 [Chicken Curry,Chicken,Curry Sauce], 
 [Fried Rice,Rice,Onion,Nuts], 
 [Salad,Spinach,Nut], 
 [Sandwich,Cheese,Bread], 
 [Quesadilla,Chickens,Cheeseeee]]", parse);
            expected = "[]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(g.groupingDishes(dishes)));

            dishes = Util.ParseJaggedArray(@"[[First,a,b,c,d,e,f,g,h,i], 
 [Second,i,h,g,f,e,x,c,b,a]]", parse);
            expected = "[[a,First,Second],[b,First,Second],[c,First,Second],[e,First,Second],[f,First,Second],[g,First,Second],[h,First,Second],[i,First,Second]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(g.groupingDishes(dishes)));

            dishes = Util.ParseJaggedArray("[[first,a,b,c,d,e,f,g,H,i],[Second,i,H,g,f,e,x,c,b,a]]", parse);
            expected = "[[H,Second,first],[a,Second,first],[b,Second,first],[c,Second,first],[e,Second,first],[f,Second,first],[g,Second,first],[i,Second,first]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(g.groupingDishes(dishes)));
        }
    }
}