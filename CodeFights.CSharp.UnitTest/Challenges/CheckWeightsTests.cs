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
    public class CheckWeightsTests
    {
        [TestMethod()]
        public void checkWeightsTest()
        {
            var c = new CheckWeights();
            Func<string, int> parse = int.Parse;
            var boxes = Util.ParseJaggedArray("[[1,2],[3,4]]", parse);
            Assert.AreEqual(0, c.checkWeights(boxes, 10));

            boxes = Util.ParseJaggedArray("[[1,3],[8,10]]", parse);
            Assert.AreEqual(2, c.checkWeights(boxes, 35));

            boxes = Util.ParseJaggedArray("[[1,2],[3,4]]", parse);
            Assert.AreEqual(-4, c.checkWeights(boxes, 6));

            boxes = Util.ParseJaggedArray("[[1,100],[151,163],[328,572]]", parse);
            Assert.AreEqual(0, c.checkWeights(boxes, 117341));

            boxes = Util.ParseJaggedArray("[[1,100],[151,163],[328,572]]", parse);
            Assert.AreEqual(-92, c.checkWeights(boxes, 117249));

            boxes = Util.ParseJaggedArray("[[1,100],[151,163],[328,572]]", parse);
            Assert.AreEqual(65, c.checkWeights(boxes, 117406));

            boxes = Util.ParseJaggedArray(@"[[242,266], 
 [268,292], 
 [306,312], 
 [316,351], 
 [369,392], 
 [501,567], 
 [568,674], 
 [684,746], 
 [939,967]]", parse);
            Assert.AreEqual(540, c.checkWeights(boxes, 212098));

            boxes = Util.ParseJaggedArray(@"[[19,213], 
 [307,345], 
 [435,441], 
 [443,577], 
 [701,722], 
 [757,771], 
 [899,908]]", parse);
            Assert.AreEqual(-19, c.checkWeights(boxes, 143379));

            boxes = Util.ParseJaggedArray("[[649,755],[768,920]]", parse);
            Assert.AreEqual(80, c.checkWeights(boxes, 204326));

            boxes = Util.ParseJaggedArray(@"[[95,177], 
 [288,381], 
 [482,499], 
 [517,683], 
 [775,805], 
 [865,948]]", parse);
            Assert.AreEqual(14, c.checkWeights(boxes, 252410));
        }
    }
}