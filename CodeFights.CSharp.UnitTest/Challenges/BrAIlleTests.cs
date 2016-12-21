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
    [TestClass]
    public class BrAIlleTests
    {
        [TestMethod]
        public void brAIlleTest()
        {
            var b = new BrAIlle();
            Func<string, string> parse = _ => _;
            var message = Util.ParseArray("[# # # # #  ,#   # # # #,#   #   #  ]", parse);
            Assert.AreEqual("pqr", b.brAIlle(message));

            message = Util.ParseArray("[# # # ,,#   #   #  ,# #  ,      #   #]", parse);
            Assert.AreEqual("mno", b.brAIlle(message));

            message = Util.ParseArray("[# # ###   # # #,    # #   #   #,    # # # #    ]", parse);
            Assert.AreEqual("c[?]4", b.brAIlle(message));

            message = Util.ParseArray("[  #,  #   # ,# #, # # #  ,#  ,        ]", parse);
            Assert.AreEqual("42", b.brAIlle(message));

            message = Util.ParseArray("[# # #   # # # #  #  #   #   #   # #   #,          #   #  # #              # #  ,#       #   # #  #  # # # # #   #   #  ]", parse);
            Assert.AreEqual("many[?]ukns", b.brAIlle(message));

            message = Util.ParseArray("[# # #   #   # #   ,  #          #  ,#   # # #   # # #           #   ,# #   #   # #   # #     #     #,# # # ##,# #                 #  ,   # #,  #       #     # #    #    #  ]", parse);
            Assert.AreEqual("nuk[?]t[?]m10[?]p", b.brAIlle(message));

            message = Util.ParseArray("[# #,  #]", parse);
            Assert.AreEqual("[?]", b.brAIlle(message));

            message = Util.ParseArray("[  # # #,# # # #,  # # #]", parse);
            Assert.AreEqual("w[?]", b.brAIlle(message));

            message = Util.ParseArray("[  # #  ,# # #   ,  #    ]", parse);
            Assert.AreEqual("wb", b.brAIlle(message));

            message = Util.ParseArray("[#,### ,###  ,##,#   #       ##  ##  #     ,       ,   # # # #   ,#   #   #   # # # ,# #,#,# , #   #, # # # # #   # # # #   #     # #     # #     ,#   #     #     ##  #     # #     #     #     ,   #   # #             #,,      # # # # #   #,,#   #   # #     #     # #   # #       # #   # #   #     # #   , # #     # # ,       # #     #   # # # # # #   #       # # #         #   #             #     #   ,#   ,#]", parse);
            Assert.AreEqual("[?]ifu[?]p455th1s[?]uw[?]1nthewar[?]", b.brAIlle(message));
        }
    }
}