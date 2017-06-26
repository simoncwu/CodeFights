using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.InterviewPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.InterviewPractice.Tests
{
    [TestClass()]
    public class FindFirstSubstringOccurrenceTests
    {
        [TestMethod()]
        public void findFirstSubstringOccurrenceTest()
        {
            var s = new FindFirstSubstringOccurrence();
            Assert.AreEqual(-1, s.strstr("CodefightsIsAwesome", "IA"));
            Assert.AreEqual(10, s.strstr("CodefightsIsAwesome", "IsA"));
            Assert.AreEqual(0, s.strstr("a", "a"));
            Assert.AreEqual(-1, s.strstr("a", "A"));
            Assert.AreEqual(1, s.strstr("sst", "st"));
            Assert.AreEqual(38, s.strstr("lrnkbldxguzgcseccinlizyogwqzlifxcthdgmanjztlt", "an"));
            Assert.AreEqual(9, s.strstr("ffbefbdbacbccecaceddcbcaeaebfedfcfdbeecffdbbf", "cb"));
            Assert.AreEqual(-1, s.strstr("aBcDefghaBcdEFgh", "ghb"));
            Assert.AreEqual(14, s.strstr("abcdefghabcdefghi", "ghi"));
            Assert.AreEqual(1, s.strstr("fefcafcdedeceadbbdaacdbdcdaeb", "ef"));
            Assert.AreEqual(59, s.strstr("ATErUUeUkVFVNfxfUKtntOErKmZLUpWpHRASdxjUhzzxygmnNnKabPPgPqyvCLSCZObaNNGCXQssfEEDDJIPBwtkMmTniKapBlrd", "vCLSCZObaNNGCXQssfEEDDJIPBwtkMmTniKa"));
            Assert.AreEqual(-1, s.strstr("IckcYWDCgWkDBMudMVWZOBatEloOzayVtvsLgUSsaaFxZQAivbqtuGerRravCLSCZObaNNGCXQssfEEDDJIPBwtkMmTniKxNrWZl", "vCLSCZObaNNGCXQssfEEDDJIPBwtkMmTniKa"));
            Assert.AreEqual(-1, s.strstr("GTgpEYIWKIWrlEtByHryETrBeTWNkHutWKOCvVNRSGSxaynjzTatJMKSwCLSCZObaNNGCXQssfEEDDJIPBwtkMmTniKaKfqaOtvO", "vCLSCZObaNNGCXQssfEEDDJIPBwtkMmTniKa"));
        }
    }
}