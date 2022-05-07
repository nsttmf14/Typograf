using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Typograf;

namespace UnitTestforTypogarf
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Label1pravilClick()
        {
            string text;
            string expected = "Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом. Тире отбивается пробелом с двух сторон. Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.";

            //act
            string actual;
            MainForm c = new MainForm();
            c.();
            actual = c.k;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
