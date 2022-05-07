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
        letter, coma, dash, space
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
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                }
            }
        }

        public string[] Getstroka()
        {
            string[] stroca = new string[textBox1.Lines.Count()];
            for (int i = 0; i < stroca.Length; i++)
                stroca[i] = textBox1.Lines[i];
            return stroca;
        }

        private void checkboxpravil1_CheckedChanged(object sender, EventArgs e)
        {
            string[] strochka = Getstroka();
            var probel = " ";
            var dash = "–";
            State state1 = State.letter;
            State state2 = State.coma;
            State state3 = State.dash;
            State state4 = State.space;
            var kav1="\"";
            var skobki1 = "(";
            var kav2 = "\"";
            var skobki2 = ")";

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

                    if (strochka[i] == "пустая")
                    {

                    }
                }
                
                if (strochka[i - 1]== "–" && state3==State.dash)
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
    }
}
