using CodeFights.CSharp.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFights.CSharp.UnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Challenges
    {
        public Challenges()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Cardinal()
        {
            var c = new Cardinal();
            Assert.AreEqual("one thousand two hundred and fifty five", c.cardinal("1255"));
            Assert.AreEqual("fifteen", c.cardinal("15"));
            Assert.AreEqual("zero", c.cardinal("0"));
            Assert.AreEqual("one billion one", c.cardinal("1000000001"));
            Assert.AreEqual("one hundred and twenty three trillion four hundred and fifty six billion seven hundred and eighty nine million twelve thousand three hundred and forty five", c.cardinal("123456789012345"));
            Assert.AreEqual("four hundred and fifty eight million", c.cardinal("458000000"));
            Assert.AreEqual("nine hundred and ninety nine trillion nine hundred and ninety nine billion nine hundred and ninety nine million nine hundred and ninety nine thousand nine hundred and ninety nine", c.cardinal("999999999999999"));
            Assert.AreEqual("ten billion", c.cardinal("10000000000"));
        }
    }
}
