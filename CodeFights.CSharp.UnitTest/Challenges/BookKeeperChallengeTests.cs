using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFights.CSharp.UnitTest;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class BookKeeperChallengeTests
    {
        [TestMethod()]
        public void BookKeeperTest()
        {
            var b = new BookKeeperChallenge();
            Func<string, string> parse = _ => _;
            var books = Util.ParseJaggedArray(@"[[Of Mice and Men,The Hunger Games,The Grapes of Wrath], 
 [Black Beauty,The Book Thief], 
 [Harry Potter and the Sorcerer's Stone,Divergent,Java For Dummies]]", parse);
            var expected = "[[Black Beauty,The Grapes of Wrath,Java For Dummies],[The Book Thief,Harry Potter and the Sorcerer's Stone],[Divergent,The Hunger Games,Of Mice and Men]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray("[[A Book]]", parse);
            expected = "[[A Book]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray(@"[[Harry the Otter,Ship of Thorns], 
 [Of The English,Devilish me], 
 [A PORTRAIT OF THE ARTIST AS A YOUNG MAN,The Slithering Elves,The Planet of the Night]]", parse);
            expected = "[[Devilish me,A PORTRAIT OF THE ARTIST AS A YOUNG MAN],[Of The English,The Planet of the Night],[Harry the Otter,Ship of Thorns,The Slithering Elves]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray(@"[[Blade in the Danger,The Grapes of Wrath,The Silent Men,Harry the Otter,Harry otter,Harry Potter and the Sorcerer's Stone], 
 [Black Beauty,Hairy Trotter,And the Shades of a Color]]", parse);
            expected = "[[Black Beauty,The Grapes of Wrath,Harry the Otter,Harry otter,And the Shades of a Color,The Silent Men],[Blade in the Danger,Hairy Trotter,Harry Potter and the Sorcerer's Stone]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray("[[A PORTRAIT OF THE ARTIST AS A YOUNG MAN,Words in the Dreams,The Hunger Games,The Book Thief,The Great Gatsby,Harry otter,The Vacant Servant]]", parse);
            expected = "[[The Book Thief,The Great Gatsby,Harry otter,The Hunger Games,A PORTRAIT OF THE ARTIST AS A YOUNG MAN,The Vacant Servant,Words in the Dreams]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray(@"[[The Sparks of the Winter,A PORTRAIT OF THE ARTIST AS A YOUNG MAN], 
 [Shoo Shoo Birdy,The Grapes of Wrath,And the Theodor said,The Red Door,Java For Dummies], 
 [The Planet of the Night,Harry otter,The Hunger Games,The Vacant Servant,Black Beauty], 
 [Ship of Thorns,The Spark of the Planet,Blade in the Danger,Of Mice and Men,The Flowers of the Fire,The Great Gatsby]]", parse);
            expected = "[[Black Beauty,The Great Gatsby],[Blade in the Danger,Harry otter,Of Mice and Men,The Red Door,The Spark of the Planet],[The Flowers of the Fire,The Hunger Games,A PORTRAIT OF THE ARTIST AS A YOUNG MAN,Ship of Thorns,The Sparks of the Winter],[The Grapes of Wrath,Java For Dummies,The Planet of the Night,Shoo Shoo Birdy,And the Theodor said,The Vacant Servant]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray(@"[[The Flowers of the Fire], 
 [Of Mice and Men,Blade in the Danger,The Red Door,Ship of Thorns,Tears of Slaves,Words in the Dreams,The Book Thief]]", parse);
            expected = "[[Blade in the Danger],[The Book Thief,The Flowers of the Fire,Of Mice and Men,The Red Door,Ship of Thorns,Tears of Slaves,Words in the Dreams]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));

            books = Util.ParseJaggedArray("[[The Slithering Elves,The Book Thief,Ship of Thorns]]", parse);
            expected = "[[The Book Thief,Ship of Thorns,The Slithering Elves]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(b.BookKeeper(books)));
        }
    }
}