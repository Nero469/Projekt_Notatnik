using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Projekt_Notatnik;
using System.IO;

namespace Notatnik_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOtworzPlik()
        {
            var f1 = new Form1();
            var s = f1.OtworzPlik();

            Assert.AreEqual("ala ma kota",s);
        }

        [TestMethod]
        public void TestZapiszPlik()
        {
            var f1 = new Form1();
            f1.ZapiszJako("test");
            var s = f1.OtworzPlik();

            Assert.AreEqual("test", s);
        }

        [TestMethod]
        public void TestNull()
        {
            var f1 = new Form1();
            var s = f1.OtworzPlik();

            Assert.AreEqual("Pusty string", s);

        }
    }   
}
