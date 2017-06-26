using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges.Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Reverse.Tests
{
    [TestClass()]
    public class NavChallengeTests
    {
        [TestMethod()]
        public void NavTest()
        {
            var n = new NavChallenge();
            Assert.IsTrue(new[] { 0, 1, 0 }.SequenceEqual(n.Nav(">")));
            Assert.IsTrue(new[] { 0, 0, 1 }.SequenceEqual(n.Nav("+")));
            Assert.IsTrue(new[] { 0, -1, -3 }.SequenceEqual(n.Nav("---<")));
            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(n.Nav("+-<>^v")));
            Assert.IsTrue(new[] { -12, 0, 0 }.SequenceEqual(n.Nav("^-^+^-^+^<^>^<^>^-^+^^")));
            Assert.IsTrue(new[] { -22, -26, -39 }.SequenceEqual(n.Nav("v>>^<>>^vv^+>^+-<-^<^^>^<>>v<+--v<>---^^<--^-><>^v+^vv^^<-^^^-^<>+v>v><v-<^+---v<^v>^+v<<>-<-<^v->+^+^+vv^-+^--v^>^<++>vvv>-v^>-<><<v-<<-^+^<<>+^v<>>^<^<v>^v>^vv<-v>-^-<vv+^>vv+++<^^<><><^>>-<<^><+---v+<+>-^v<->>vvvv^>+<-^>^>++<^v<<<<->v+<v>>vv^>-><+<-^-<v->>+v^^--><+-+^><vv<<-^<<-^-++<v^+v+--<----+<^v+vv-<v^v<-<+-^-^v<-+^v>^+v>vv<><>+-+^><<<^v>>^++^+++v>vv-vv--<^^<<-v-^^+<-+<^<vv<v^>-v-^vv><+++^^^<<-^<^+<->+v^><^>v<v--v-^v+^^-v+<<<+>>+^v-><><^^^+-^v>-v-^<--+<^+^+v>+v<<<^<<v>v^+^-<^^^+->><<+<>>->+<v-^>v+>-+vv>+v+v^v<v>v--^<+vvv>^>v^-+v<>+>v-+^-^++-v<^^^<--v<-+^+v^vv<>>+^<^<^^^++><--v-^^-<>-<<+^^v<v<--<>>v^^>+-<+>+-<^-v^v<^>^^->^>^^-^v->+v<<<+^>-^<-^v+^>+><<>v++--->>>^<^-vv^v+<^-<>^<--<>-->>>^--v>-<>v>-^-^<>^v<<^v>v>^<>^^-^v<^--^>+^<-<+<<+^^++<<-<>v->-^-vv->>^v^^-+>v-<><v+><-vvvvv>v-^<^v+><^^+>^+<-v++<+-+^+>-^+-+>+>-+->^^v<<^<^<v+-^<<<<<->-+<--->>vv<+^-+v>->+v+>+>>+-<-<-<>^-v-v++v>>v<----^v^^-v>-<<^^<>+v+v->^vv+^<-^^>^<^v--+<v><--+vv+")));
        }
    }
}