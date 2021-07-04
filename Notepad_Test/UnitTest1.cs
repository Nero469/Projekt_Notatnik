using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_Notatnik;
using System.Windows.Forms;
namespace Notepad_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var f1 = new Form1();
            var s = f1.OtworzPlik();


        }
    }
}
        