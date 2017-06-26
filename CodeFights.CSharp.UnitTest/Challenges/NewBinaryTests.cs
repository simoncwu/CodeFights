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
    public class NewBinaryTests
    {
        [TestMethod()]
        public void newBinaryTest()
        {
            var n = new NewBinary();
            var commands = Util.ParseJaggedArray(@"[[set,+int(5.1) x = 5],
 [set,int(4) y = -6],
 [set,x = 17],
 [set,dec(4/1) tmp],
 [set,bool abce = TRUE],
 [del,x],
 [set,tmp = 0.015627],
 [set,+dec(4/1) tmp2 = 3.013],
 [set,char(6) z = 'abcdef']]", _ => _);
            var expected = "1111111111111111111111111111100100111100100000000000010000110001110000000100000011010100111111011011000010110001001100011011001000110010101100110";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,+int(5.2) pwqv = 210], 
 [del,pwqv], 
 [set,dec(4/1) r = -0.98], 
 [set,char(2) alto = 'pG'], 
 [set,dec(3/1) tbyfc = 0.77], 
 [set,dec(5/1) pte], 
 [set,alto = 'TX'], 
 [set,+dec(5/1) zco = 0.0515], 
 [set,tbyfc = -0.443], 
 [set,pte = -0.6], 
 [set,zco = 0.54], 
 [set,alto = 'ua'], 
 [set,+dec(3/1) e]]", _ => _);
            expected = "10111111011110101110000101000111011101010110000110111110111000101101000010111111000110011001100110011001100110010111111000010100011110101110000101000111000000000000000000000000";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,bool xq = FALSE],
 [set,xq = FALSE],
 [set,bool lo = FALSE],
 [set,char(3) n = 'bTc'],
 [del,xq],
 [set,lo = TRUE],
 [set,n = 'q3c'],
 [set,lo = TRUE],
 [set,lo = TRUE],
 [set,int(3) hfbix = 65],
 [set,dec(6/1) afcda],
 [del,hfbix],
 [del,lo],
 [del,n],
 [set,afcda = 0.7782],
 [set,bool zaju = TRUE],
 [set,afcda = 0.5164],
 [set,dec(6/1) xvg],
 [del,afcda],
 [set,zaju = TRUE]]", _ => _);
            expected = "1000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,+dec(3/1) kjop = 0.44], 
 [del,kjop], 
 [set,bool jqas], 
 [set,jqas = FALSE], 
 [set,char(5) bvkb], 
 [set,+dec(7/1) czt = 0.7], 
 [set,bvkb = 'YF8y6'], 
 [set,int(2.2) lmph = -123], 
 [set,lmph = 90], 
 [set,czt = 0.133], 
 [del,bvkb], 
 [set,char(3) r], 
 [set,r = 't63'], 
 [set,char(3) bhvq], 
 [del,czt], 
 [set,bool bm = FALSE], 
 [set,jqas = TRUE], 
 [set,bm = TRUE], 
 [set,lmph = -58]]", _ => _);
            expected = "11111111111110001010111010000110110001100110000000000000000000000001";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,bool u = FALSE], 
 [set,char(4) bt = 'hASF'], 
 [set,char(2) ccvr], 
 [set,bt = 'iTfX'], 
 [set,bt = 'iKdo'], 
 [del,u], 
 [set,ccvr = '6t'], 
 [set,ccvr = 'dz'], 
 [set,ccvr = 'Hw'], 
 [set,int(5.5) ytjpd]]", _ => _);
            expected = "011010010100101101100100011011110100100001110111000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,bool rwpp], 
 [set,char(3) o = 'UaG'], 
 [set,rwpp = FALSE], 
 [set,rwpp = TRUE], 
 [set,+dec(5/1) mehv = 0.6213], 
 [set,o = 'Bs5'], 
 [set,o = 'blM'], 
 [set,+dec(6/1) ig]]", _ => _);
            expected = "10110001001101100010011010111111000111110000110110000100010011010000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,int(3) b = -42], 
 [set,b = -124], 
 [set,dec(3/1) psisz = 0.736], 
 [del,psisz], 
 [set,int(4.5) y = 35], 
 [del,b], 
 [set,y = 99], 
 [set,y = -18], 
 [set,y = 37], 
 [set,y = -57], 
 [set,bool yf], 
 [set,y = -34], 
 [set,y = -26], 
 [set,y = -61], 
 [set,yf = FALSE], 
 [set,yf = TRUE], 
 [set,yf = TRUE], 
 [set,int(3.5) yigpf], 
 [set,yf = TRUE], 
 [set,+dec(6/1) sdr], 
 [set,dec(3/1) zxgdq = -0.893]]", _ => _);
            expected = "1111111111111111111111111111111000010100000000000000000000000000000000000000000000000000000000000000000000000000000101111110110010010011011";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,int(1.2) tbi = 85], 
 [set,tbi = -127], 
 [set,+int(3.7) v = 88], 
 [set,bool mh = FALSE], 
 [set,mh = TRUE], 
 [set,tbi = 28], 
 [del,v], 
 [set,tbi = 7], 
 [set,tbi = -115], 
 [set,+int(4) dx = 106], 
 [set,+dec(3/1) jqf = 0.180], 
 [set,int(5.6) kj = -98], 
 [del,dx], 
 [set,mh = FALSE], 
 [set,dec(7/1) wrav = 0.1], 
 [set,mh = TRUE], 
 [set,dec(5/1) ff], 
 [set,dec(4/1) wqjlf = -0.63], 
 [set,mh = TRUE], 
 [set,kj = 119], 
 [set,char(1) lzhbr = 's']]", _ => _);
            expected = "1110001100101111100011100001010001100000000000000000000000000000000000000011101110011110111001100110011001100110011001100110011001100110000000000000000000000000000000000000000001011111100100001010001111010111001110011";
            Assert.AreEqual(expected, n.newBinary(commands));

            commands = Util.ParseJaggedArray(@"[[set,+int(5.1) pg = 197], 
 [set,pg = 229], 
 [del,pg], 
 [set,char(4) gtzeq], 
 [set,bool amxtv = FALSE], 
 [del,amxtv], 
 [set,gtzeq = 'sPhN'], 
 [set,gtzeq = 'sP1c'], 
 [del,gtzeq], 
 [set,bool sbnuz], 
 [set,bool qcn = TRUE], 
 [set,int(2) t], 
 [set,int(5) vyy = 21], 
 [set,sbnuz = TRUE], 
 [set,t = -84]]", _ => _);
            expected = "1111111111101010110000000000000000000000000000000000010101";
            Assert.AreEqual(expected, n.newBinary(commands));
        }
    }
}