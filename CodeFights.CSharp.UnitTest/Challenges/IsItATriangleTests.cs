using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass]
    public class IsItATriangleTests
    {
        [TestMethod]
        public void Dot()
        {
            Assert.AreEqual(1, new IsItATriangle().isItATriangle(new[] { "." }));
        }

        [TestMethod]
        public void LeftFacingRightTriangle()
        {
            Assert.AreEqual(10, new IsItATriangle().isItATriangle(new[] {
                "___________",
                "________.__",
                "_______..__",
                "______...__",
                "_____....__",
                "___________",
                "___________"
            }));
        }

        [TestMethod]
        public void Hourglass()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "___________________",
                "___.............___",
                "_____........._____",
                "_______....._______",
                "________...________",
                "_______....._______",
                "_____........._____",
                "___.............___",
                "___________________"
            }));
        }

        [TestMethod]
        public void Unchi()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "_______________",
                "_______._______",
                "_______..._____",
                "____.....______",
                "_____.......___",
                "__.........____",
                "___..........._",
                "_______________"
            }));
        }

        [TestMethod]
        public void Circle()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "___________________",
                "________...._______",
                "______........_____",
                "_____..........____",
                "_____..........____",
                "______........_____",
                "________...._______",
                "___________________"
            }));
        }

        [TestMethod]
        public void UpsideDownRightFacingRightTriangle()
        {
            Assert.AreEqual(66, new IsItATriangle().isItATriangle(new[] {
                "_______________",
                "__...........__",
                "__..........___",
                "__.........____",
                "__........_____",
                "__.......______",
                "__......_______",
                "__.....________",
                "__...._________",
                "__...__________",
                "__..___________",
                "__.____________",
                "_______________"
            }));
        }

        [TestMethod]
        public void RightFacingEquilateral()
        {
            Assert.AreEqual(4, new IsItATriangle().isItATriangle(new[] {
                "_________________",
                "_________________",
                "_____.___________",
                "_____..__________",
                "_____.___________",
                "_________________",
                "_________________"
            }));
        }

        [TestMethod]
        public void LeftFacingEquilateral()
        {
            Assert.AreEqual(25, new IsItATriangle().isItATriangle(new[] {
                "____________",
                "____________",
                "____________",
                "_____.______",
                "____..______",
                "___...______",
                "__....______",
                "_.....______",
                "__....______",
                "___...______",
                "____..______",
                "_____.______",
                "____________"
            }));
        }

        [TestMethod]
        public void LeftFacingMountains()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "____________",
                "____________",
                "____________",
                "_____.______",
                "____..______",
                "___...______",
                "__....______",
                "_.....______",
                "__....______",
                "___...______",
                "____..______",
                "___...______",
                "__....______",
                "_.....______",
                "__....______",
                "___...______",
                "____..______",
                "_____.______",
                "____________"
            }));
        }

        [TestMethod]
        public void Equilateral()
        {
            Assert.AreEqual(36, new IsItATriangle().isItATriangle(new[] {
                "_______________",
                "_______._______",
                "______...______",
                "_____....._____",
                "____.......____",
                "___.........___",
                "__...........__",
                "_______________"
            }));
        }

        [TestMethod]
        public void CitigroupCenter()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "_______________",
                "___.___________",
                "___..__________",
                "___..._________",
                "___....________",
                "___....._______",
                "___......______",
                "___......._____",
                "___........____",
                "___.........___",
                "___.........___",
                "___.........___",
                "___.........___",
                "_______________"
            }));
        }

        [TestMethod]
        public void Line()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "_______________",
                "_______._______",
                "_______._______",
                "_______._______",
                "_______._______",
                "_______._______",
                "_______._______",
                "_______________"
            }));

        }

        [TestMethod]
        public void JaggedEdges()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "_______________",
                "___.___________",
                "___..__________",
                "___..._________",
                "___....._______",
                "___......______",
                "___......______",
                "___......._____",
                "_______________"
            }));

        }

        [TestMethod]
        public void UpsideDownEquilateral()
        {
            Assert.AreEqual(9, new IsItATriangle().isItATriangle(new[] {
                "______________",
                "______.....___",
                "_______...____",
                "________._____",
                "______________",
                "______________"
            }));
        }

        [TestMethod]
        public void LeftAlignedRightTriangle()
        {
            Assert.AreEqual(15, new IsItATriangle().isItATriangle(new[] {
                ".____________",
                "..___________",
                "...__________",
                "...._________",
                ".....________"
            }));
        }

        [TestMethod]
        public void FullUpsideDownLeftFacingRightTriangle()
        {
            Assert.AreEqual(253, new IsItATriangle().isItATriangle(new[] {
                "......................",
                "_.....................",
                "__....................",
                "___...................",
                "____..................",
                "_____.................",
                "______................",
                "_______...............",
                "________..............",
                "_________.............",
                "__________............",
                "___________...........",
                "____________..........",
                "_____________.........",
                "______________........",
                "_______________.......",
                "________________......",
                "_________________.....",
                "__________________....",
                "___________________...",
                "____________________..",
                "_____________________."
            }));
        }

        [TestMethod]
        public void Square()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "__________",
                "___....___",
                "___....___",
                "___....___",
                "__________"
            }));
        }

        [TestMethod]
        public void Parallelogram()
        {
            Assert.AreEqual(0, new IsItATriangle().isItATriangle(new[] {
                "_____________________",
                "________..........___",
                "______...........____",
                "_____..........._____",
                "___..........._______",
                "__...........________",
                "_____________________"
            }));
        }
    }
}