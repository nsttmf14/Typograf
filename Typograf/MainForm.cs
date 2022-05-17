using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char probel = ' ';
            char[] arr = { '.', ',', '-', ':', ';', '?', '!' };

            if (checkboxpravil1.Checked)
            {
                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (arr.Contains((text[i])))
                    {
                        if (text[i - 1] == probel && text[i + 1] == probel)
                        {
                            text = text.Remove(i - 1, 1);
                            textBox1.Text = text;
                        }

                        if (Char.IsLetterOrDigit(text[i + 1]) && text[i - 1] == probel)
                        {
                            text = text.Insert(i + 1, " ");
                            text = text.Remove(i - 1, 1);
                            textBox1.Text = text;
                        }
                    }

                    /*if (text[i]== '—' && Char.IsLetterOrDigit(text[i-1]) && Char.IsLetterOrDigit(text[i + 1]))
                    {
                        text = text.Insert(i + 1 , " ");
                        text = text.Insert(i - 1 , " ");
                        textBox1.Text = text;
                    }

                    if (text[i] == '—' && Char.IsLetterOrDigit(text[i - 1]) && text[i + 1] == probel)
                    {
                        text = text.Insert(i - 1, " ");
                        textBox1.Text = text;
                    }

                    if (text[i] == '—' && text[i-1]==probel && Char.IsLetterOrDigit(text[i + 1]))
                    {
                        text = text.Insert(i + 1, " ");
                        textBox1.Text = text;
                    }
                    */
                    char[] skobki1 = { '{', '[', '(' }; 
                    char[] skobki2= { '}', ']', ')' };

                    if ((text[i] == '«' || text[i] == '"' || skobki1.Contains(text[i])) && text[i + 1] == probel)
                    {
                        text = text.Remove(i + 1, 1);
                        textBox1.Text = text;
                    }

                    //if ((text[i] == '»' || text[i] == '"' || skobki2.Contains(text[i])) && text[i - 1] == probel)
                    //{
                    //    text = text.Remove(i - 1, 1);
                    //    textBox1.Text = text;
                    //}

                    //if ((text[i] == '«' || text[i] == '„' || skobki1.Contains(text[i])) && text[i + 1] == probel && (text[i] == '»' || text[i] == '“' || skobki2.Contains(text[i])) && text[i - 1] == probel)
                    //{
                    //    text = text.Remove(i - 1, 1);
                    //    text = text.Remove(i + 1, 1);
                    //    textBox1.Text = text;
                    //}

                    
                }

                char hyphen = '-';

                if (checkboxpravil4.Checked)
                {
                    for (int i = 1; i < text.Length - 1; i++)
                    {
                        if (text[i] == hyphen && text[i - 1] == probel && Char.IsLetterOrDigit(text[i + 1]))
                        {
                            text = text.Remove(i - 1, 1);
                            textBox1.Text = text;
                        }

                        if (text[i] == hyphen && text[i + 1] == probel && Char.IsLetterOrDigit(text[i - 1]))
                        {
                            text = text.Remove(i + 1, 1);
                            textBox1.Text = text;
                        }

                        if (text[i] == hyphen && text[i - 1] == probel && text[i + 1] == probel)
                        {
                            text = text.Remove(i - 1, 1);
                            text = text.Remove(i, 1);
                            textBox1.Text = text;
                        }

                    }
                }

                if (checkboxpravil3.Checked)
                {
                    for (int i = 1; i <= text.Length - 1; i++)
                    {
                        if (text[i] == probel && Char.IsLetterOrDigit(text[i + 1]))
                        {
                            textBox1.Text = textBox1.Text.Replace('-', '—');
                        }
                        if (Char.IsLetterOrDigit(text[i]) && text[i - 1] == '-')
                        {
                            textBox1.Text = textBox1.Text.Replace("-", "-");
                        }

                        if (textBox1.Text[0] == '-')
                        {
                            textBox1.Text = textBox1.Text.Replace("-", "_");
                        }
                    }
                }

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
                    for (int i = 1; i <= text.Length - 2; i++)
                    {
                        if (text[i + 1] == probel && text[i - 1] == probel && Char.IsDigit(text[i + 2]) && Char.IsDigit(text[i - 2]))
                        {
                            textBox1.Text = textBox1.Text.Replace('-', '−');
                        }

                        if (Char.IsDigit(text[i + 1]) && Char.IsDigit(text[i - 1]) && (text[i] == hyphen || text[i] == '−'))
                        {
                            textBox1.Text = textBox1.Text.Replace('-', '−');
                            text = text.Insert(i, " ");
                            text = text.Insert(i + 2, " ");
                            textBox1.Text = text;
                        }

                        if (text[i + 1] == probel && Char.IsDigit(text[i - 1]) && Char.IsDigit(text[i + 2]))
                        {
                            textBox1.Text = textBox1.Text.Replace('-', '−');
                            text = text.Insert(i, " ");
                            textBox1.Text = text;

                        }
                        if (text[i - 1] == probel && Char.IsDigit(text[i + 1]) && Char.IsDigit(text[i - 2]))
                        {
                            textBox1.Text = textBox1.Text.Replace('-', '−');
                            text = text.Insert(i + 2, " ");
                            textBox1.Text = text;
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
}
