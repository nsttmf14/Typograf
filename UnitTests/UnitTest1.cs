using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Typograf;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test5rulefirsttest()
        {
            var mf = new MainForm();
            string text = "Когда проект будет готов?";
            string expected = "Когда проект будет готов¿";
            string result=MainForm.Fiverule(text);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test5rulesecondtest()
        {
            var mf = new MainForm();
            string text = "Еще не сделано!?";
            string expected = "Еще не сделано!¿";
            string result = MainForm.Fiverule(text);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test6rulefirsttest()
        {
            var mf = new MainForm();
            string text = "Света, напиши код!";
            string expected = "Света, напиши код!";
            string result = MainForm.SixRule(text);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test6rulesecondtest()
        {
            var mf = new MainForm();
            string text = "Нам нужен свет";
            string expected = "Нам нужен свет";
            string result = MainForm.SixRule(text);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test4rulefirsttest()
        {
            var mf = new MainForm();
            string text = "Россия -Матушка, я тебя люблю";
            string expected = "Россия-Матушка, я тебя люблю";
            string result = MainForm.FourRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test4rulesecondtest()
        {
            var mf = new MainForm();
            string text = "Текст компьютерной программы на каком- либо языке программирования или языке разметки, который может быть прочтён человеком.";
            string expected = "Текст компьютерной программы на каком-либо языке программирования или языке разметки, который может быть прочтён человеком.";
            string result = MainForm.FourRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test4rulethirdtest()
        {
            var mf = new MainForm();
            string text = "Книга - сейф. Выгодные покупки";
            string expected = "Книга-сейф. Выгодные покупки";
            string result = MainForm.FourRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2rulefirsttest()
        {
            var mf = new MainForm();
            string text = "9-9 = 0";
            string expected = "9 − 9 = 0";
            string result = MainForm.TwoRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2rulesecondtest()
        {
            var mf = new MainForm();
            string text = "9- 9 = 0";
            string expected = "9 − 9 = 0";
            string result = MainForm.TwoRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2rulethirdtest()
        {
            var mf = new MainForm();
            string text = "9 −9 = 0";
            string expected = "9 − 9 = 0";
            string result = MainForm.TwoRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2ruleforthtest()
        {
            var mf = new MainForm();
            string text = "9 - 9 = 0";
            string expected = "9 − 9 = 0";
            string result = MainForm.TwoRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3rulefirsttest()
        {
            var mf = new MainForm();
            string text = "Мама не любит собирать эти грибы - маслята.";
            string expected = "Мама не любит собирать эти грибы — маслята.";
            string result = MainForm.ThreeRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3rulesecondtest()
        {
            var mf = new MainForm();
            string text = "Во-первых, нужно было идти домой.";
            string expected = "Во-первых, нужно было идти домой.";
            string result = MainForm.ThreeRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3rulethirdtest()
        {
            var mf = new MainForm();
            string text = "- Нет ли у тебя вещи, которую держал в руках твой отец?";
            string expected = "– Нет ли у тебя вещи, которую держал в руках твой отец?";
            string result = MainForm.ThreeRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test1rulefirsttest()
        {
            var mf = new MainForm();
            string text = "Я не мог отвести взгляд от девушки ,и она улыбалась мне в ответ";
            string expected = "Я не мог отвести взгляд от девушки, и она улыбалась мне в ответ";
            string result = MainForm.OneRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test1rulesecondtest()
        {
            var mf = new MainForm();
            string text = "Пора вставать ! Хватит отдыхать!";
            string expected = "Пора вставать! Хватит отдыхать!";
            string result = MainForm.OneRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test1rulethirdtest()
        {
            var mf = new MainForm();
            string text = "« Я буду искать клад один »";
            string expected = "«Я буду искать клад один»";
            string result = MainForm.OneRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test1ruleforthtest()
        {
            var mf = new MainForm();
            string text = "В то вре­мя ( это было боль­ше года назад ) Вера не была ещё зна­ко­ма с соседями.";
            string expected = "В то вре­мя (это было боль­ше года назад) Вера не была ещё зна­ко­ма с соседями.";
            string result = MainForm.OneRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test1rulefifthtest()
        {
            var mf = new MainForm();
            string text = "среднее тире—удерживая Alt, наберите на цифровой клавиатуре справа 0150, затем отпустите Alt";
            string expected = "среднее тире — удерживая Alt, наберите на цифровой клавиатуре справа 0150, затем отпустите Alt";
            string result = MainForm.OneRule(text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test7rulesixthtest()
        {
            var mf = new MainForm();
            string text = "«Папа, я явилась домой»";
            string expected = "«Батюшка, я явилась домой»";
            string result = MainForm.SevenRule(text);
            Assert.AreEqual(expected, result);
        }
    }
}
