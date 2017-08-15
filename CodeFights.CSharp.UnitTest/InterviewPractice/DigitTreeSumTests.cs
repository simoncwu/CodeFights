using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static CodeFights.CSharp.InterviewPractice.DigitTreeSum;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class DigitTreeSumTests
    {
        [TestMethod()]
        public void digitTreeSumTest()
        {
            var d = new DigitTreeSum();
            var tree = JsonConvert.DeserializeObject<Tree<int>>(@"{
    ""value"": 1,
    ""left"": {
        ""value"": 0,
        ""left"": {
            ""value"": 3,
            ""left"": null,
            ""right"": null
        },
        ""right"": {
            ""value"": 1,
            ""left"": null,
            ""right"": null
        }
    },
    ""right"": {
        ""value"": 4,
        ""left"": null,
        ""right"": null
    }
}");
            Assert.AreEqual(218, d.digitTreeSum(tree));

            tree = JsonConvert.DeserializeObject<Tree<int>>(@"{
    ""value"": 0,
    ""left"": {
        ""value"": 9,
        ""left"": null,
        ""right"": null
    },
    ""right"": {
        ""value"": 9,
        ""left"": {
            ""value"": 1,
            ""left"": null,
            ""right"": null
        },
        ""right"": {
            ""value"": 3,
            ""left"": null,
            ""right"": null
        }
    }
}");
            Assert.AreEqual(193, d.digitTreeSum(tree));

            tree = JsonConvert.DeserializeObject<Tree<int>>(@"{
    ""value"": 9,
    ""left"": null,
    ""right"": null
}");
            Assert.AreEqual(9, d.digitTreeSum(tree));

            tree = JsonConvert.DeserializeObject<Tree<int>>(@"{
    ""value"": 0,
    ""left"": {
        ""value"": 0,
        ""left"": null,
        ""right"": null
    },
    ""right"": {
        ""value"": 0,
        ""left"": null,
        ""right"": null
    }
}");
            Assert.AreEqual(0, d.digitTreeSum(tree));

            tree = JsonConvert.DeserializeObject<Tree<int>>(@"{
    ""value"": 0,
    ""left"": {
        ""value"": 1,
        ""left"": null,
        ""right"": null
    },
    ""right"": null
}");
            Assert.AreEqual(1, d.digitTreeSum(tree));
        }
    }
}