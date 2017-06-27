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
    public class AreFollowingPatternsTests
    {
        [TestMethod()]
        public void areFollowingPatternsTest()
        {
            var a = new AreFollowingPatterns();
            Assert.IsTrue(a.areFollowingPatterns("cat dog dog".Split(), "a b b".Split()));
            Assert.IsFalse(a.areFollowingPatterns("cat dog doggy".Split(), "a b b".Split()));
            Assert.IsFalse(a.areFollowingPatterns("cat dog dog".Split(), "a b c".Split()));
            Assert.IsTrue(a.areFollowingPatterns("aaa".Split(), "aaa".Split()));
            Assert.IsFalse(a.areFollowingPatterns("aaa aaa aaa".Split(), "aaa bbb aaa".Split()));
            Assert.IsFalse(a.areFollowingPatterns("aaa aab aaa".Split(), "aaa aaa aaa".Split()));
            Assert.IsTrue(a.areFollowingPatterns("re jjinh rnz frok frok hxytef hxytef frok".Split(), "kzfzmjwe fgbugiomo ocuijka gafdrts gafdrts ebdva ebdva gafdrts".Split()));
            Assert.IsFalse(a.areFollowingPatterns("kwtfpzm kwtfpzm kwtfpzm kwtfpzm kwtfpzm wfktjrdhu anx kwtfpzm".Split(), "z z z hhwdphhnc zejhegjlha xgxpvhprdd e u".Split()));
            Assert.IsFalse(a.areFollowingPatterns("ato ato jflywws ato ato se se kiolm wizdkdqke".Split(), "ofnmiqelt ofnmiqelt flqmwoje ofnmiqelt zdohw jyk ujddjtxt s kw".Split()));
            Assert.IsTrue(a.areFollowingPatterns("syf syf oxerkx oxerkx syf xgwatff pmnfaw t ajyvgwd xmhb ajg syf syf wjddgkopae fgrpstxd t i psw wjddgkopae wjddgkopae oxerkx zf jvdtdxbefr rbmphtrmo syf yssdddhyn syf jvdtdxbefr funnd syf syf wd syf vnntavj wjddgkopae yssdddhyn wcvk wjddgkopae fh zf gpkdcwf qkbw zf teppnr jvdtdxbefr fmn i hzmihfrmq wjddgkopae syf vnntavj dung kn qkxo ajyvgwd fs kanixyaepl syf tl yzhaa dung wa syf jtucivim tl kanixyaepl oxerkx wjddgkopae ey ai zf di oxerkx dung i oxerkx wmtqpwzgh t beascd me akklwhtpi nxl cnq bighexy ddhditvzdu funnd wmt dgx fs xmhb qtcxvdcl thbmn pkrisgmr mkcfscyb x oxerkx funnd iesr funnd t".Split(), "enrylabgky enrylabgky dqlqaihd dqlqaihd enrylabgky ramsnzhyr tkibsntkbr l bgtws xwuaep o enrylabgky enrylabgky e auljuhtj l d jfzokgt e e dqlqaihd fgglhiedk nj quhv enrylabgky oadats enrylabgky nj zwupro enrylabgky enrylabgky pyw enrylabgky bedpuycdp e oadats i e fobyfznrxm fgglhiedk irxtd oyvf fgglhiedk ebpp nj p d cufxylz e enrylabgky bedpuycdp mitzb shsnw papmvh bgtws chtp pze enrylabgky klp wpx mitzb fo enrylabgky bvcigrirhe klp pze dqlqaihd e iufunacwjo bubgww fgglhiedk og dqlqaihd mitzb d dqlqaihd mysidv l naj clftmrwl fjb zjjnrffb sh gcn ouispza zwupro c rdank chtp xwuaep jufhm iyntbgm sufs mkivpe bxdd dqlqaihd zwupro vzxbbculgv zwupro l".Split()));
            Assert.IsFalse(a.areFollowingPatterns("a b c d a b c".Split(), "1 2 3 4 5 6 7".Split()));
        }
    }
}