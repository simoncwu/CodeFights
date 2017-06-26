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
    public class CopycatKeeperTests
    {
        [TestMethod()]
        public void copycatKeeperTest()
        {
            var c = new CopycatKeeper();
            var books = Util.ParseJaggedArray(@"[[Of Mice and Men,The Hunger Games,The Grapes of Wrath], 
 [Black Beauty,The Book Thief],
 [Harry Potter and the Sorcerer's Stone,Divergent,Java For Dummies]]", _ => _);
            var expected = "[[Black Beauty,Divergent,Java For Dummies],[Harry Potter and the Sorcerer's Stone,The Book Thief],[Of Mice and Men,The Hunger Games,The Grapes of Wrath]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = Util.ParseJaggedArray(@"[[A Book]]", _ => _);
            expected = "[[A Book]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = Util.ParseJaggedArray(@"[[Harry the Otter], 
 [Of The English], 
 [A PORTRAIT OF THE ARTIST AS A YOUNG MAN,The Slithering Elves,The Planet of the Night,Ship of Thorns,Devilish me]]", _ => _);
            expected = "[[A PORTRAIT OF THE ARTIST AS A YOUNG MAN],[Harry the Otter],[Of The English,The Slithering Elves,The Planet of the Night,Ship of Thorns,Devilish me]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = Util.ParseJaggedArray(@"[[Harry the Otter], 
 [Of The English], 
 [A PORTRAIT OF THE ARTIST AS A YOUNG MAN], 
 [The Slithering Elves], 
 [The Planet of the Night], 
 [Ship of Thorns,Devilish me]]", _ => _);
            expected = "[[A PORTRAIT OF THE ARTIST AS A YOUNG MAN],[Harry the Otter],[Of The English],[Ship of Thorns],[The Planet of the Night],[The Slithering Elves,Devilish me]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = new[]
            {
                new[] { "Clear Your Clutter with Feng Shui (Revised and Updated)", "Lie Down in Darkness", "Cora", "The Girl Before", "Milk and Honey", "The Unlikely Spy", "Wake a Sleeping Tiger", "Episode 1: Victoria & Shannon", "When Breath Becomes Air", "Beach Lane", "The Tea Girl of Hummingbird Lane", "Trouble in a Tight Dress", "Here on Earth", "The Subtle Art of Not Giving a F*ck", "Rough", "The Collapsing Empire", "Selected Stories", "Big Little Lies", "Bound Together", "Kingdom Prayer", "Just Friends", "A Harmless Little Ruse", "A Harmless Little Plan", "From Fear to Eternity", "The Duchess Contest", "Lone Wolf: A Noah Wolf Thriller", "The Healthy Make-Ahead Cookbook: Wholesome, Flavorful Freezer Meals the Whole Family Will Enjoy", "The Great Gatsby", "Man Overboard", "A Discovery of Witches", "A Gentleman in Moscow", "Hillbilly Elegy", "The Healthy Spiralizer Cookbook: Flavorful and Filling Salads, Soups, Suppers, and More for Low-Carb Living", "Loch (The Powers That Be, Book 3)", "Burn", "Devan Chronicles Series: Books 1-3", "The American Heir", "When a Marquis Chooses a Bride", "Promise and Protect", "Sex", "Camino Island", "A Sudden Country", "Unshakeable", "The Marriage Lie", "Heartbreak Hotel", "Dragon Hunter Box Set", "Small Great Things", "Mindfulness Made Simple: An Introduction to Finding Calm Through Mindfulness & Meditation", "The Play Mate", "Echoes in Death", "A Simple Christianity" }
            };
            expected = "[[Clear Your Clutter with Feng Shui (Revised and Updated),Lie Down in Darkness,Cora,The Girl Before,Milk and Honey,The Unlikely Spy,Wake a Sleeping Tiger,Episode 1: Victoria & Shannon,When Breath Becomes Air,Beach Lane,The Tea Girl of Hummingbird Lane,Trouble in a Tight Dress,Here on Earth,The Subtle Art of Not Giving a F*ck,Rough,The Collapsing Empire,Selected Stories,Big Little Lies,Bound Together,Kingdom Prayer,Just Friends,A Harmless Little Ruse,A Harmless Little Plan,From Fear to Eternity,The Duchess Contest,Lone Wolf: A Noah Wolf Thriller,The Healthy Make-Ahead Cookbook: Wholesome, Flavorful Freezer Meals the Whole Family Will Enjoy,The Great Gatsby,Man Overboard,A Discovery of Witches,A Gentleman in Moscow,Hillbilly Elegy,The Healthy Spiralizer Cookbook: Flavorful and Filling Salads, Soups, Suppers, and More for Low-Carb Living,Loch (The Powers That Be, Book 3),Burn,Devan Chronicles Series: Books 1-3,The American Heir,When a Marquis Chooses a Bride,Promise and Protect,Sex,Camino Island,A Sudden Country,Unshakeable,The Marriage Lie,Heartbreak Hotel,Dragon Hunter Box Set,Small Great Things,Mindfulness Made Simple: An Introduction to Finding Calm Through Mindfulness & Meditation,The Play Mate,Echoes in Death,A Simple Christianity]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = new[]
            {
                new[] { "Clear Your Clutter with Feng Shui (Revised and Updated)", "The Shack", "Thirteen Reasons Why", "The Boy Who Harnessed the Wind", "The Unlikely Spy", "Killing the Rising Sun", "Wake a Sleeping Tiger", "Mississippi Blood", "Kingdom Prayer", "Iron Wolf", "Small Great Things", "Thin Line (Jack Noble #3)", "10-Day Green Smoothie Cleanse", "The Temporary Duchess", "Milk and Honey", "The Great Gatsby", "A Discovery of Witches", "Promise and Protect", "Episode 1: Victoria & Shannon", "The Collapsing Empire", "A Sea of Troubles", "Defensive Zone", "Playmates", "A Gentleman in Moscow", "Here on Earth", "Beach Lane", "Scared Selfless", "A Man Called Ove", "Camino Island", "From Fear to Eternity", "A Simple Christianity", "Trouble in a Tight Dress", "Heartbreak Hotel", "A Harmless Little Plan", "Sex", "Cora", "Man Overboard", "The Tea Girl of Hummingbird Lane", "The Duchess Contest", "The Girl Before", "The Marriage Lie", "Just Friends", "Lone Wolf: A Noah Wolf Thriller", "Dangerous Games" }
            };
            expected = "[[Clear Your Clutter with Feng Shui (Revised and Updated),The Shack,Thirteen Reasons Why,The Boy Who Harnessed the Wind,The Unlikely Spy,Killing the Rising Sun,Wake a Sleeping Tiger,Mississippi Blood,Kingdom Prayer,Iron Wolf,Small Great Things,Thin Line (Jack Noble #3),10-Day Green Smoothie Cleanse,The Temporary Duchess,Milk and Honey,The Great Gatsby,A Discovery of Witches,Promise and Protect,Episode 1: Victoria & Shannon,The Collapsing Empire,A Sea of Troubles,Defensive Zone,Playmates,A Gentleman in Moscow,Here on Earth,Beach Lane,Scared Selfless,A Man Called Ove,Camino Island,From Fear to Eternity,A Simple Christianity,Trouble in a Tight Dress,Heartbreak Hotel,A Harmless Little Plan,Sex,Cora,Man Overboard,The Tea Girl of Hummingbird Lane,The Duchess Contest,The Girl Before,The Marriage Lie,Just Friends,Lone Wolf: A Noah Wolf Thriller,Dangerous Games]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = new[]
            {
                new[] { "The Cutthroat", "The Duchess Contest", "Rough", "The Girl Before" },
                new[] { "Vicious Circle","The Healthy Make-Ahead Cookbook: Wholesome, Flavorful Freezer Meals the Whole Family Will Enjoy","Buttons & Lace" },
                new[] { "Playmates","When Breath Becomes Air","The Shack","Take Me Back" },
                new[] { "I Sing the Body Electric","The Whistler A Novel" },
                new[] { "The Stranger in the Woods","The Marriage Lie" },
                new[] { "Selected Stories","Killing the Rising Sun","Milk and Honey","The Joy Luck Club","Defensive Zone","A Sudden Country","A Weekend of Misbehaving" },
                new[] { "Mississippi Blood","Everything, Everything","The Subtle Art of Not Giving a F*ck","The Underground Railroad","Man Overboard","An Act of Courage","Just Friends","10-Day Green Smoothie Cleanse" },
                new[] { "A Harmless Little Ruse","Ghosts","Burn" },
                new[] { "A Gentleman in Moscow","Bound Together" }
            };
            expected = "[[A Gentleman in Moscow,Bound Together,Burn,Take Me Back],[A Harmless Little Ruse,Everything, Everything,Buttons & Lace],[I Sing the Body Electric,Ghosts,Milk and Honey,The Girl Before],[Mississippi Blood,Killing the Rising Sun],[Playmates,The Duchess Contest],[Selected Stories,The Healthy Make-Ahead Cookbook: Wholesome, Flavorful Freezer Meals the Whole Family Will Enjoy,Rough,The Joy Luck Club,Defensive Zone,A Sudden Country,A Weekend of Misbehaving],[The Cutthroat,The Marriage Lie,The Shack,The Underground Railroad,Man Overboard,An Act of Courage,Just Friends,10-Day Green Smoothie Cleanse],[The Stranger in the Woods,The Whistler A Novel,The Subtle Art of Not Giving a F*ck],[Vicious Circle,When Breath Becomes Air]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = new[]
            {
                new[] { "Iron Wolf", "Thirteen Reasons Why", "Burn", "Camino Island", "A Harmless Little Plan", "Maine", "The Marriage Lie", "A Harmless Little Ruse", "The American Heir", "Man Overboard", "Big Little Lies" },
                new[] { "The Temporary Duchess","The Unlikely Spy","The Subtle Art of Not Giving a F*ck","Murder on Location Boxed Set Books 1-3","When a Marquis Chooses a Bride" },
                new[] { "The Couple Next Door","10-Day Green Smoothie Cleanse","The Egg and I","Scared Selfless","Vicious Circle" },
                new[] { "I Sing the Body Electric","The Healthy Make-Ahead Cookbook: Wholesome, Flavorful Freezer Meals the Whole Family Will Enjoy","The Cutthroat","Playmates","Clear Your Clutter with Feng Shui (Revised and Updated)","Dragon Hunter Box Set","The Whistler A Novel","Milk and Honey","A Discovery of Witches","The 5 Love Languages","A Man Called Ove" },
                new[] { "A Sea of Troubles","Pretty Girls","Small Great Things" },
                new[] { "Cora","Devan Chronicles Series: Books 1-3","The Stranger in the Woods","Bruno, Chief of Police","Selected Stories","Mindfulness Made Simple: An Introduction to Finding Calm Through Mindfulness & Meditation" },
                new[] { "Beach Lane","Everything, Everything","When Breath Becomes Air","Episode 1: Victoria & Shannon","The Duchess Contest","Rough" }
            };
            expected = "[[A Sea of Troubles,10-Day Green Smoothie Cleanse,Burn,Bruno, Chief of Police,A Harmless Little Plan,Dragon Hunter Box Set,The Marriage Lie,A Harmless Little Ruse,A Discovery of Witches,Man Overboard,A Man Called Ove],[Beach Lane,Devan Chronicles Series: Books 1-3,Small Great Things,Camino Island,Clear Your Clutter with Feng Shui (Revised and Updated)],[Cora,Everything, Everything,The Cutthroat,Episode 1: Victoria & Shannon,Selected Stories],[I Sing the Body Electric,Pretty Girls,The Egg and I,Murder on Location Boxed Set Books 1-3,The Duchess Contest,Maine,The Whistler A Novel,Milk and Honey,The American Heir,The 5 Love Languages,Big Little Lies],[Iron Wolf,The Healthy Make-Ahead Cookbook: Wholesome, Flavorful Freezer Meals the Whole Family Will Enjoy,The Stranger in the Woods],[The Couple Next Door,The Unlikely Spy,The Subtle Art of Not Giving a F*ck,Playmates,Vicious Circle,Mindfulness Made Simple: An Introduction to Finding Calm Through Mindfulness & Meditation],[The Temporary Duchess,Thirteen Reasons Why,When Breath Becomes Air,Scared Selfless,When a Marquis Chooses a Bride,Rough]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = new[]
            {
                new[] { "Buttons & Lace", "The Shack", "Bound Together" },
                new[] { "Loch (The Powers That Be, Book 3)","When Breath Becomes Air","Mississippi Blood","The Girl Before","Vicious Circle","Here on Earth","Iron Wolf" },
                new[] { "Defensive Zone","Bruno, Chief of Police","The Stranger in the Woods","The Subtle Art of Not Giving a F*ck" },
                new[] { "Everything, Everything","Just Friends","Mindfulness Made Simple: An Introduction to Finding Calm Through Mindfulness & Meditation","Lilac Girls","The Underground Railroad","Heartbreak Hotel","Killing the Rising Sun","Milk and Honey" },
                new[] { "The 5 Love Languages","Thirteen Reasons Why","10-Day Green Smoothie Cleanse","A Gentleman in Moscow","The Duchess Contest","A Man Called Ove","Pretty Girls"},
                new string[] {},
                new[] { "Devan Chronicles Series: Books 1-3", "Hillbilly Elegy","The Room Mate","Clear Your Clutter with Feng Shui (Revised and Updated)" },
                new[] { "The Egg and I","The American Heir","Every Tongue Got to Confess","Small Great Things","Black Obsidian" },
                new[] { "The Play Mate","Playmates","Man Overboard","The Cutthroat","Promise and Protect","Maine" }
            };
            expected = "[[Buttons & Lace,Bruno, Chief of Police,10-Day Green Smoothie Cleanse],[Defensive Zone,Hillbilly Elegy,Bound Together,A Gentleman in Moscow,Black Obsidian,A Man Called Ove,Iron Wolf],[Devan Chronicles Series: Books 1-3,Just Friends,Every Tongue Got to Confess,Clear Your Clutter with Feng Shui (Revised and Updated)],[Everything, Everything,Playmates,Man Overboard,Lilac Girls,Promise and Protect,Heartbreak Hotel,Killing the Rising Sun,Milk and Honey],[Loch (The Powers That Be, Book 3),The American Heir,Mindfulness Made Simple: An Introduction to Finding Calm Through Mindfulness & Meditation,Small Great Things,The Duchess Contest,Here on Earth,Pretty Girls],[],[The 5 Love Languages,The Shack,Mississippi Blood,The Cutthroat],[The Egg and I,Thirteen Reasons Why,The Room Mate,The Girl Before,The Underground Railroad],[The Play Mate,When Breath Becomes Air,The Stranger in the Woods,The Subtle Art of Not Giving a F*ck,Vicious Circle,Maine]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));

            books = new[]
            {
                new[] { "The Unlikely Spy", "The Shack", "A Harmless Little Plan", "The Stranger in the Woods", "Burn", "Murder on Location Boxed Set Books 1-3", "Milk and Honey", "Unshakeable", "A Weekend of Misbehaving" },
                new[] { "When a Marquis Chooses a Bride","Everything, Everything","A Man Called Ove","Sex","The Tea Girl of Hummingbird Lane","Every Tongue Got to Confess","Killing the Rising Sun" },
                new[] { "A Discovery of Witches", "From Fear to Eternity", "The American Heir", "Playmates", "Lone Wolf: A Noah Wolf Thriller", "The Cutthroat", "When Breath Becomes Air", "A Sea of Troubles", "Dangerous Games" },
                new[] { "Defensive Zone","The Underground Railroad","The Room Mate" }
            };
            expected = "[[A Discovery of Witches,Everything, Everything,A Harmless Little Plan,Playmates,Burn,Every Tongue Got to Confess,Killing the Rising Sun,A Sea of Troubles,A Weekend of Misbehaving],[Defensive Zone,From Fear to Eternity,A Man Called Ove,Sex,Lone Wolf: A Noah Wolf Thriller,Murder on Location Boxed Set Books 1-3,Milk and Honey],[The Unlikely Spy,The Shack,The American Heir,The Stranger in the Woods,The Tea Girl of Hummingbird Lane,The Cutthroat,When Breath Becomes Air,Unshakeable,Dangerous Games],[When a Marquis Chooses a Bride,The Underground Railroad,The Room Mate]]";
            Assert.AreEqual(expected, Util.JaggedArrayToString(c.copycatKeeper(books)));
        }
    }
}