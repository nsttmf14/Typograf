using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Typograf;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void Test5rulefirsttest()
        {
            var mf = new MainForm();
            string text = "Когда проект будет готов?";
            string expected = "Когда проект будет готов¿";
            string result=MainForm.Fiverule(text);
            Assert.AreEqual(expected, result);
        }

        public void Test5rulesecondtest()
        {
            var mf = new MainForm();
            string text = "Еще не сделано!?";
            string expected = "Еще не сделано?!";
            string result = MainForm.Fiverule(text);
            Assert.AreEqual(expected, result);
        }
    }
}
