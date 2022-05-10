using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Activities.Statements;

namespace Typograf
{
    enum State
    {
        letter, coma, dash, space, hyphen
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void typograflabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это инструмент, который приводит текст в соответствие с правилами экранной типографики");
        }

        private void label2pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дефис пробелами не отбивается и всегда пишется слитно с частями слова или цифр, которые он разделяет.");
        }

        private void label1pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом. Тире отбивается пробелом с двух сторон. Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.");
        }

        private void label3pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Везде, где по правилам русского языка должно быть тире, ни в коем случае нельзя писать знак дефис, который по умолчанию доступен на клавиатуре. Символ тире задаётся конструкцией —. Например чтобы получить: «Книга — источник знания», нужно написать «Книга — источник знания».");
        }

        private void label4pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Везде, где в цифрах указывается минус, также нельзя писать знак дефиса, нужно писать знак минуса: − В арифметических конструкциях знаки операций отбиваются пробелом с двух сторон. Например «5 − 4 = 1».");
        }

        private void label5pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Везде, где по правилам русского языка должен быть вопросительный знак, ни в коем случае нельзя писать вопросительный знак, который по умолчанию доступен на клавиатуре. Символ вопросительный знак задается как ¿ ");
        }

        private void label6pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Следует всегда использовать букву «с». Неправильно писать вместо неё букву с в английской раскладке");
        }

        private void label7pravil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Абсурда пока нет");
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                }
            }
        }


        private void checkboxpravil1_CheckedChanged(object sender, EventArgs e)
        {
            string strochka = textBox1.Text;
            char probel = ' ';
            var dash = '–';
            State state1 = State.letter;
            State state2 = State.coma;
            State state3 = State.dash;
            State state4 = State.space;
            char kav1='\'';
            char skobki1 = '(';
            char kav2 = '\"';
            char skobki2 = ')';

            for (int i = 0; i < strochka.Length; i++)
            {
                var letter = Convert.ToChar(strochka[i]);
                var letter0 = Convert.ToChar(strochka[i-1]);
                if (/*ничего нет первее*/ true)
                {
                    
                }

                if (strochka[i-1]==probel && state4==State.space)
                {
                    if (strochka[i]==probel && state4==State.space)
                    {

                    }

                    if (strochka[i]==dash && state3==State.dash)
                    {

                    }

                    if ((strochka[i]==kav1 || strochka[i]==kav2 || strochka[i] == skobki1 || strochka[i] == skobki2) && (state2==State.coma))
                    {

                    }

                    if (char.IsLetterOrDigit(letter) && state1==State.letter)
                    {

                    }

                    /*if (пустая)
                    {

                    }*/
                }
                
                if (strochka[i - 1]== dash && state3==State.dash)
                {
                    if (strochka[i] == probel && state4 == State.space)
                    {

                    }

                    if (strochka[i] == dash && state3 == State.dash)
                    {

                    }

                    if ((strochka[i] == kav1 || strochka[i] == kav2 || strochka[i] == skobki1 || strochka[i] == skobki2) && (state2 == State.coma))
                    {

                    }

                    if (char.IsLetterOrDigit(letter) && state1 == State.letter)
                    {

                    }
                }

                if ((strochka[i-1] == kav1 || strochka[i-1] == kav2 || strochka[i-1] == skobki1 || strochka[i-1] == skobki2) && (state2 == State.coma))
                {
                    if (strochka[i]==probel && state4==State.space)
                    {

                    }

                    if (strochka[i]==dash && state3==State.dash)
                    {

                    }

                    if ((strochka[i]==kav1 || strochka[i]==kav2 || strochka[i] == skobki1 || strochka[i] == skobki2) && (state2==State.coma))
                    {

                    }

                    if (char.IsLetterOrDigit(letter) && state1==State.letter)
                    {

                    }
                }

                if (char.IsLetterOrDigit(letter0) && state1 == State.letter)
                {
                    if (strochka[i] == probel && state4 == State.space)
                    {

                    }

                    if (strochka[i] == dash && state3 == State.dash)
                    {

                    }

                    if ((strochka[i] == kav1 || strochka[i] == kav2 || strochka[i] == skobki1 || strochka[i] == skobki2) && (state2 == State.coma))
                    {

                    }

                    if (char.IsLetterOrDigit(letter) && state1 == State.letter)
                    {

                    }
                }
            }
        }

        private void checkboxpravil4_CheckedChanged(object sender, EventArgs e)
        {
            State state1 = State.letter;
            State state2 = State.hyphen;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char hyphen = '-';
                var letter = Convert.ToChar(textBox1.Text[i]);
                var letter0 = Convert.ToChar(textBox1.Text[i - 1]);
                if (textBox1.Text[i]==hyphen && state2 == State.hyphen)
                {
                    if (char.IsLetterOrDigit(letter0) && state1 == State.letter)
                    {
                        
                    }

                    else
                    {
                        
                    }
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (checkboxpravil5.Checked)
            {
                if (textBox1.Text.Contains("?"))
                {
                    textBox1.Text = textBox1.Text.Replace("?", "¿");
                }
                if (textBox1.Text.Contains("!?"))
                {
                    textBox1.Text = textBox1.Text.Replace("!?", "?!");
                }
            }

            if (checkboxpravil6.Checked)
            {
                if (textBox1.Text.Contains("c") || textBox1.Text.Contains("C"))
                {
                    textBox1.Text = textBox1.Text.Replace("c", "с");
                    textBox1.Text = textBox1.Text.Replace("C", "С");
                }
            }

            if (checkboxpravil2.Checked)
            {
                string numbers = "1234567890";
                char dash = '-';
                char minus = '-';

                for (int i = 0; i < text.Length; i++)
                {
                    //Если текст представляет собой выражение типа "5 - 2" или "5-2" с тире вместо минуса
                    if (numbers.Contains(text[i - 1]) || numbers.Contains(text[i - 2]) && (numbers.Contains(text[i + 1]) || numbers.Contains(text[i + 2])) && text[i] == dash)
                    {
                        //Меняем на минус
                        textBox1.Text = textBox1.Text.Replace("-", "-");
                    }
                        //Если текст представляет собой выражение, не являющеется числовым и имеет минус вместо тире
                    if (!(numbers.Contains(text[i - 1]) || numbers.Contains(text[i - 2]) && !(numbers.Contains(text[i + 1]) || numbers.Contains(text[i + 2])) && text[i] == minus))
                    {
                            //Меняем на тире
                            textBox1.Text = textBox1.Text.Replace("-", "-");
                    }
                }
            }
            if (checkboxpravil7.Checked)
            {
                Dictionary<string, string> Dictionar = new Dictionary<string, string>()
            {
                { "Ты", "Вы"},
                { "Тебе", "Вам"},
                { "Привет", "Приветствую"},
                { "Пока", "До свидания"},
                   { "Девушка", "Барышня"},
                  {  "Девушке", "Барышне"},
                  {  "Парню", "Сударю"},
                   { "Парни", "Судари"},
                    { "Парней", "Сударей"},
                    { "Нет", "Я вынужден отказаться"},
                   {  "Девушек", "Барышень"},
                  {   "Парень", "Сударь"},
                   { "Девушки", "Барышни"}
            };
                string result = Dictionar.Aggregate(text, (s, kvp) => s.Replace(kvp.Key, kvp.Value));
                textBox1.Text = result;
            }
        }
    }
}
