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
    public class RemoveDuplicateAdjacentTests
    {
        [TestMethod()]
        public void removeDuplicateAdjacentTest()
        {
            var r = new RemoveDuplicateAdjacent();
            Assert.AreEqual("cdefightfocod", r.removeDuplicateAdjacent("cooodefightssforrrcodee"));
            Assert.AreEqual("acac", r.removeDuplicateAdjacent("acaaabbbacdddd"));
            Assert.AreEqual("z", r.removeDuplicateAdjacent("z"));
            Assert.AreEqual("quhxgrhaxeprunfieilbothmpsg", r.removeDuplicateAdjacent("quhxgrhqqaccxeprunllfieilbothbbmpsg"));
            Assert.AreEqual("harshitsidhwa", r.removeDuplicateAdjacent("harshitsidhwa"));
            Assert.AreEqual("", r.removeDuplicateAdjacent("aaaaaaaaaaaaa"));
            Assert.AreEqual("oylvkenljbypmpixrdtldp", r.removeDuplicateAdjacent("oylvkenljbypmpixrdtldaap"));
            Assert.AreEqual("vpeyuwvgvrpc", r.removeDuplicateAdjacent("vpeyuwvgvrpc"));
            Assert.AreEqual("mey", r.removeDuplicateAdjacent("merry"));
            Assert.AreEqual("narendramodi", r.removeDuplicateAdjacent("narendramodi"));
            Assert.AreEqual("mpie", r.removeDuplicateAdjacent("mississipie"));
            Assert.AreEqual("uylrcbiuvraopn", r.removeDuplicateAdjacent("uylrcddbiuvraopn"));
            Assert.AreEqual("xezoswhzbcxjkdgstmfxbhskgqjapoizgryxhvrg", r.removeDuplicateAdjacent("xezoswhjjggzbcxjkdgstmfxbhskgqjapoizgryxhvrg"));
            Assert.AreEqual("ay", r.removeDuplicateAdjacent("azxxxzy"));
            Assert.AreEqual("uxftnqwdhzsyzohdjhbfdanioytxmbh", r.removeDuplicateAdjacent("uxftnqwdhiizsyzohdjhbfdanioytxmbh"));
            Assert.AreEqual("wsyory", r.removeDuplicateAdjacent("whoohsyouuurdaddady"));
            Assert.AreEqual("mejmiuivapyhgnwmni", r.removeDuplicateAdjacent("rrmfqqfppejmiuivapyhgnhhwmni"));
            Assert.AreEqual("ptdbztozmtiwkatnubszmhxknzguousybzqctjsrwms", r.removeDuplicateAdjacent("ptdbztozmtiwkatnubszmhxknzguousybhddwwhzqctjsrwms"));
            Assert.AreEqual("ofwcprpws", r.removeDuplicateAdjacent("ofwcprpws"));
            Assert.AreEqual("r", r.removeDuplicateAdjacent("grrrrrrrrrrrrrgr"));
            Assert.AreEqual("lop", r.removeDuplicateAdjacent("ocvvcolop"));
            Assert.AreEqual("gwikwanjdhugbphgupvpbnuhpxficp", r.removeDuplicateAdjacent("gwikwanjdhugbphgupvpbnuhpxficp"));
            Assert.AreEqual("avpankawnpvoqmfdahmrwkcizryfrbdidgembe", r.removeDuplicateAdjacent("avpankawnpvoqmfeedahmrwkcizryfrbdidgembe"));
            Assert.AreEqual("icgslpjlzcxthmivsktktlsdxogxpfuc", r.removeDuplicateAdjacent("icgslpjlzcxthmivsktktlsdxogxpfccuc"));
            Assert.AreEqual("dxzlzltfbknofovtewnurpwzvysimfrkiladlr", r.removeDuplicateAdjacent("dvvxzlzltfbknofovtewnurpweezvysimfrkiladlr"));
            Assert.AreEqual("pjgzdavjgneolzniax", r.removeDuplicateAdjacent("pjgzdavqqjgneolzniax"));
            Assert.AreEqual("eqrmtoqenmnxmfcxgtufzdsr", r.removeDuplicateAdjacent("eqrccmtoqenmnxmfcxgtaaufzdswwr"));
            Assert.AreEqual("tnpvlpkstdldlcmyduazihpvgygepycpqdvxq", r.removeDuplicateAdjacent("heehtnpvlpkstdldlcmydudiidazihprrvgygddepycpqdvxq"));
            Assert.AreEqual("cafzpn", r.removeDuplicateAdjacent("cafzpnii"));
            Assert.AreEqual("k", r.removeDuplicateAdjacent("abcdefggfedcbahijjihk"));
        }
    }
}