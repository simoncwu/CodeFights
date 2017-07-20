using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static CodeFights.CSharp.InterviewPractice.LargestValuesInTreeRows;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class LargestValuesInTreeRowsTests
    {
        [TestMethod()]
        public void largestValuesInTreeRowsTest()
        {
            var l = new LargestValuesInTreeRows();
            var tree = @"{
    ""value"": -1,
    ""left"": {
        ""value"": 5,
        ""left"": null,
        ""right"": null
    },
    ""right"": {
        ""value"": 7,
        ""left"": null,
        ""right"": {
            ""value"": 1,
            ""left"": null,
            ""right"": null
        }
    }
}";
            Assert.IsTrue(new[] { -1, 7, 1 }.SequenceEqual(l.largestValuesInTreeRows(JsonConvert.DeserializeObject<Tree<int>>(tree))));

            tree = "";
            Assert.IsTrue(new int[0].SequenceEqual(l.largestValuesInTreeRows(JsonConvert.DeserializeObject<Tree<int>>(tree))));

            tree = @"{
    ""value"": -1,
    ""left"": null,
    ""right"": null
}";
            Assert.IsTrue(new[] { -1 }.SequenceEqual(l.largestValuesInTreeRows(JsonConvert.DeserializeObject<Tree<int>>(tree))));

            tree = @"{
    ""value"": -1,
    ""left"": {
        ""value"": 5,
        ""left"": null,
        ""right"": null
    },
    ""right"": {
        ""value"": 7,
        ""left"": null,
        ""right"": {
            ""value"": 1,
            ""left"": {
                ""value"": 5,
                ""left"": null,
                ""right"": null
            },
            ""right"": null
        }
    }
}";
            Assert.IsTrue(new[] { -1, 7, 1, 5 }.SequenceEqual(l.largestValuesInTreeRows(JsonConvert.DeserializeObject<Tree<int>>(tree))));

            tree = @"{
    ""value"": -1,
    ""left"": {
        ""value"": 5,
        ""left"": {
            ""value"": -1,
            ""left"": {
                ""value"": 10,
                ""left"": null,
                ""right"": null
            },
            ""right"": null
        },
        ""right"": null
    },
    ""right"": {
        ""value"": 7,
        ""left"": null,
        ""right"": {
            ""value"": 1,
            ""left"": {
                ""value"": 5,
                ""left"": null,
                ""right"": null
            },
            ""right"": null
        }
    }
}";
            Assert.IsTrue(new[] { -1, 7, 1, 10 }.SequenceEqual(l.largestValuesInTreeRows(JsonConvert.DeserializeObject<Tree<int>>(tree))));
        }
    }
}