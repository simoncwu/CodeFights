using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class AlienBitTests
    {
        [TestMethod()]
        public void alienBitTest()
        {
            var a = new AlienBit();
            Assert.AreEqual("test#1", a.alienBit("0.116101115116035049"));
            Assert.AreEqual("Incoming Transmision", a.alienBit("0.073110099111109105110103032084114097110115109105115105111110"));
            Assert.AreEqual("testing... 12345678910", a.alienBit("0.116101115116105110103046046046032049050051052053054055056057049048"));
            Assert.AreEqual("testing... ~!@{$%^&*()#[]+=-_|?<", a.alienBit("0.116101115116105110103046046046032126033064123036037094038042040041035091093043061045095124063060"));
            Assert.AreEqual("Hello Neighbor! (<>..<>)", a.alienBit("0.072101108108111032078101105103104098111114033032040060062046046060062041"));
            Assert.AreEqual("We come in peace.", a.alienBit("0.087101032099111109101032105110032112101097099101046"));
            Assert.AreEqual("May we borrow a cup of sugar?", a.alienBit("0.077097121032119101032098111114114111119032097032099117112032111102032115117103097114063"));
            Assert.AreEqual("We hate to be a bother but we are making a Tilv'gellian Pzal'exoid Cake and you know how particular Tilv'gellians are about their Pzal'exoid Cake.", a.alienBit("0.087101032104097116101032116111032098101032097032098111116104101114032098117116032119101032097114101032109097107105110103032097032084105108118039103101108108105097110032080122097108039101120111105100032067097107101032097110100032121111117032107110111119032104111119032112097114116105099117108097114032084105108118039103101108108105097110115032097114101032097098111117116032116104101105114032080122097108039101120111105100032067097107101046"));
        }
    }
}