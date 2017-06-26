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
    public class LeastTilesTests
    {
        [TestMethod()]
        public void leastTilesTest()
        {
            var l = new LeastTiles();
            Func<string, int> parse = int.Parse;
            var tiles = Util.ParseJaggedArray(@"[[2,4,16,8],[0,4,8,0],[0,0,0,0],[0,0,2,0]]", parse);
            Assert.AreEqual(1, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[2,16,32,8],[4,0,2,2],[2,0,2,0],[0,0,0,0]]", parse);
            Assert.AreEqual(2, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[4,16,32,8], 
 [8,2,8,0], 
 [2,4,2,2], 
 [2,4,0,0]]", parse);
            Assert.AreEqual(1, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[4,4,8,8], 
 [2,4,2,32], 
 [0,2,8,16], 
 [2,0,0,4]]", parse);
            Assert.AreEqual(0, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[2,4,2], 
 [4,4,0], 
 [0,0,2]]", parse);
            Assert.AreEqual(1, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[16,64,32,4], 
 [4,4,2,2], 
 [4,8,0,0], 
 [2,4,0,0], 
 [2,2,0,2]]", parse);
            Assert.AreEqual(0, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[16,64,32,8], 
 [2,16,2,0], 
 [2,4,2,4], 
 [2,0,0,2]]", parse);
            Assert.AreEqual(1, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[2,0,0,0], 
 [2,0,0,2], 
 [0,0,0,0], 
 [0,0,0,0]]", parse);
            Assert.AreEqual(0, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[2,2], 
 [0,0]]", parse);
            Assert.AreEqual(2, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[1024,0,1024,0,0,0,16,2,2048,512,32,32,64,64], 
 [16,0,64,0,512,2048,512,0,256,256,0,0,2,0]]", parse);
            Assert.AreEqual(2, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[0,0], 
 [256,0], 
 [0,0], 
 [2048,64], 
 [128,16], 
 [0,64], 
 [1024,4], 
 [1024,32], 
 [1024,1024], 
 [128,0], 
 [32,256], 
 [1024,128], 
 [64,0]]", parse);
            Assert.AreEqual(0, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[0,64,0,0,64,16], 
 [0,0,64,0,0,0], 
 [4,0,8,0,512,256], 
 [16,0,2048,512,16,256]]", parse);
            Assert.AreEqual(0, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[16,0,0], 
 [2,256,512], 
 [8,2,64], 
 [4,2048,1024], 
 [1024,4,1024], 
 [256,32,1024], 
 [512,256,256], 
 [1024,128,0], 
 [0,32,0], 
 [8,8,512], 
 [2,1024,0], 
 [2048,256,0]]", parse);
            Assert.AreEqual(2, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[0,0,0,0,8,8], 
 [32,512,2048,0,2,0], 
 [512,32,2048,0,128,2048], 
 [2048,16,32,4,0,2], 
 [1024,0,512,128,256,4], 
 [256,2048,0,256,0,0], 
 [2,128,0,2048,0,64], 
 [0,1024,0,0,32,2], 
 [0,8,1024,0,0,8]]", parse);
            Assert.AreEqual(0, l.leastTiles(tiles));

            tiles = Util.ParseJaggedArray(@"[[0,0,1024,8,16,64,2,4,0,256,16,2,256,16], 
 [2048,4,0,0,8,0,8,1024,32,0,0,4,256,0], 
 [1024,8,512,1024,0,0,1024,128,0,32,64,0,4,4], 
 [4,0,0,16,16,128,0,0,256,0,0,0,0,8], 
 [0,512,0,256,0,8,1024,0,0,0,0,256,0,256]]", parse);
            Assert.AreEqual(2, l.leastTiles(tiles));
        }
    }
}