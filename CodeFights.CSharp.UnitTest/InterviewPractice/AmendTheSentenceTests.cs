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
    public class AmendTheSentenceTests
    {
        [TestMethod()]
        public void amendTheSentenceTest()
        {
            var a = new AmendTheSentence();
            Assert.AreEqual("codefights is awesome", a.amendTheSentence("CodefightsIsAwesome"));
            Assert.AreEqual("hello", a.amendTheSentence("Hello"));
            Assert.AreEqual("v s kw w djw ier q k mg va anior r jlerb kp dgvy k b l p nw s r wtylq kew n ft e r nu u b b h as gk t s sfdh q h j yv aigh ade g", a.amendTheSentence("vSKwWDjwIerQKMgVaAniorRJlerbKpDgvyKBLPNwSRWtylqKewNFtERNuUBBHAsGkTSSfdhQHJYvAighAdeG"));
            Assert.AreEqual("i fv f axt vi l j du w w x jespp oc l vd r a j zw bobdczkk w s p hz f lfyvm j y pdq yq r k kv l g y lw e f xc jiy y w lqj bv hjeq e", a.amendTheSentence("iFvFAxtViLJDuWWXJesppOcLVdRAJZwBobdczkkWSPHzFLfyvmJYPdqYqRKKvLGYLwEFXcJiyYWLqjBvHjeqE"));
            Assert.AreEqual("i ei m cy k adsf g m pa", a.amendTheSentence("iEiMCyKAdsfGMPa"));
            Assert.AreEqual("jh bk p baoz mn bq e wi ia o eje", a.amendTheSentence("JhBkPBaozMnBqEWiIaOEje"));
            Assert.AreEqual("tf r z gd yurvr vy eu hb o jca xn zrs e ur", a.amendTheSentence("tfRZGdYurvrVyEuHbOJcaXnZrsEUr"));
            Assert.AreEqual("viz q eogigk r z jac v e lul hj g", a.amendTheSentence("VizQEogigkRZJacVELulHjG"));
            Assert.AreEqual("d lwgq ux v f f njbf m su ru vh w z k v w sf l qr t x ux xd g j erkx w tz g anb i g qeiv rcd bb krknbsd f rjz x avq u d stp xx", a.amendTheSentence("DLwgqUxVFFNjbfMSuRuVhWZKVWSfLQrTXUxXdGJErkxWTzGAnbIGQeivRcdBbKrknbsdFRjzXAvqUDStpXx"));
            Assert.AreEqual("v e ow b x wx d tf d tn q z r kdnr oq p b s guio j ydm i s co ipg x c l x ngn h qnx snt o dx g ztimko oe yl a h uu aww ohm mkmxe bqdsx ryn a", a.amendTheSentence("VEOwBXWxDTfDTnQZRKdnrOqPBSGuioJYdmISCoIpgXCLXNgnHQnxSntODxGZtimkoOeYlAHUuAwwOhmMkmxeBqdsxRynA"));
            Assert.AreEqual("kx g v muo gggwhhs t", a.amendTheSentence("kxGVMuoGggwhhsT"));
            Assert.AreEqual("s v hi qh p f qrjir efc v r zb pwd nh h hiq", a.amendTheSentence("sVHiQhPFQrjirEfcVRZbPwdNhHHiq"));
            Assert.AreEqual("b f l h xl u r i oo b jdw yp bpecxrpl x now ntw d vlo j ngn u n b n d m t cnhmc ptu t wtg e y xy zlb ro bzoul ott ia e im r y s o s kp jyf b m", a.amendTheSentence("bFLHXlURIOoBJdwYpBpecxrplXNowNtwDVloJNgnUNBNDMTCnhmcPtuTWtgEYXyZlbRoBzoulOttIaEImRYSOSKpJyfBM"));
            Assert.AreEqual("jkl cw lha", a.amendTheSentence("JklCwLha"));
            Assert.AreEqual("i l tfw h ha jz hr r w xg z w w jevo ck y bp x p prrf z u t o j", a.amendTheSentence("ILTfwHHaJzHrRWXgZWWJevoCkYBpXPPrrfZUTOJ"));
            Assert.AreEqual("r uq o p c v e nq xwv t vhpcn utis p bt", a.amendTheSentence("RUqOPCVENqXwvTVhpcnUtisPBt"));
            Assert.AreEqual("wh o vx jmrmx w r x w m c qy l h j h jv xm oyvgc n rrv nc cw x k e m d u npu y rbczfxf f tl s lhsv x oxhy b smw a f ia vh h q fs z e y o kp e r r l g mg n c t u", a.amendTheSentence("WhOVxJmrmxWRXWMCQyLHJHJvXmOyvgcNRrvNcCwXKEMDUNpuYRbczfxfFTlSLhsvXOxhyBSmwAFIaVhHQFsZEYOKpERRLGMgNCTU"));
        }
    }
}