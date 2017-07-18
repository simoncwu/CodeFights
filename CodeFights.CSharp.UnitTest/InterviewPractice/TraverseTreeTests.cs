using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class TraverseTreeTests
    {
        [TestMethod()]
        public void traverseTreeTest()
        {
            var t = new TraverseTree();
            var tree = @"{
    ""value"": 1,
    ""left"": {
        ""value"": 2,
        ""left"": null,
        ""right"": {
            ""value"": 3,
            ""left"": null,
            ""right"": null
        }
    },
    ""right"": {
        ""value"": 4,
        ""left"": {
            ""value"": 5,
            ""left"": null,
            ""right"": null
        },
        ""right"": null
    }
}";
            var expected = new[] { 1, 2, 4, 3, 5 };
            Assert.IsTrue(expected.SequenceEqual(t.traverseTree(JsonConvert.DeserializeObject<TraverseTree.Tree<int>>(tree))));

            tree = @"";
            expected = new int[0];
            Assert.IsTrue(expected.SequenceEqual(t.traverseTree(JsonConvert.DeserializeObject<TraverseTree.Tree<int>>(tree))));

            tree = @"{
    ""value"": 2,
    ""left"": {
        ""value"": 1,
        ""left"": null,
        ""right"": {
            ""value"": 0,
            ""left"": null,
            ""right"": null
        }
    },
    ""right"": null
}";
            expected = new[] { 2, 1, 0 };
            Assert.IsTrue(expected.SequenceEqual(t.traverseTree(JsonConvert.DeserializeObject<TraverseTree.Tree<int>>(tree))));

            tree = @"{
    ""value"": 15,
    ""left"": {
        ""value"": 15,
        ""left"": null,
        ""right"": null
    },
    ""right"": null
}";
            expected = new[] { 15, 15 };
            Assert.IsTrue(expected.SequenceEqual(t.traverseTree(JsonConvert.DeserializeObject<TraverseTree.Tree<int>>(tree))));
        }
    }
}