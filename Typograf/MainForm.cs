using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Typograf
{
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

        public static string OneRule(string text)
        {
            char probel = ' ';
            char[] arr = { '.', ',', '-', ':', ';', '?', '!' };
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (arr.Contains((text[i])))
                {
                    if (text[i - 1] == probel && text[i + 1] == probel)
                    {
                        text = text.Remove(i - 1, 1);
                    }

                    if (Char.IsLetterOrDigit(text[i + 1]) && text[i - 1] == probel)
                    {
                        text = text.Insert(i + 1, " ");
                        text = text.Remove(i - 1, 1);
                    }

                    if (text[i - 1] == probel && text[i+1]==' ')
                    {
                        text = text.Remove(i - 1, 1);
                    }
                }

                if (text[i] == '—')
                {
                    if (text[i - 1] == probel && Char.IsLetterOrDigit(text[i + 1]))
                    {
                        text = text.Insert(i + 1, " ");
                    }

                    if (text[i + 1] == probel && Char.IsLetterOrDigit(text[i - 1]))
                    {
                        text = text.Insert(i, " ");
                    }

                    if ( Char.IsLetterOrDigit(text[i + 1]) && Char.IsLetterOrDigit(text[i-1]))
                    {
                        text = text.Insert(i + 1, " ");
                        text = text.Insert(i, " ");
                    }
                }

                char[] skobki1 = { '{', '[', '(' };
                char[] skobki2 = { '}', ']', ')' };

                if ((text[i] == '«' || text[i] == '„' || skobki1.Contains(text[i])) && text[i + 1] == probel)
                {
                    text = text.Remove(i + 1, 1);
                }

                if ((text[i + 1] == '”' || text[i + 1] == '»' || skobki2.Contains(text[i + 1])) && text[i] == probel)
                {
                    text = text.Remove(i, 1);
                }
            }
            return text;
        }

        public static string TwoRule(string text)
        {
            char hyphen = '-';
            char probel = ' ';
            for (int i = 1; i <= text.Length - 2; i++)
            {
                if (text[i + 1] == probel && text[i - 1] == probel && Char.IsDigit(text[i + 2]) && Char.IsDigit(text[i - 2]))
                {
                    text = text.Replace('-', '−');
                }

                if (Char.IsDigit(text[i + 1]) && Char.IsDigit(text[i - 1]) && (text[i] == hyphen || text[i] == '−'))
                {
                    text = text.Insert(i, " ");
                    text = text.Insert(i + 2, " ");
                    text = text.Replace('-', '−');
                }

                if (text[i + 1] == probel && Char.IsDigit(text[i - 1]) && Char.IsDigit(text[i + 2]))
                {
                    text = text.Insert(i, " ");
                    text = text.Replace('-', '−');
                }
                if (text[i - 1] == probel && Char.IsDigit(text[i + 1]) && Char.IsDigit(text[i - 2]))
                {
                    text = text.Insert(i + 1, " ");
                    text = text.Replace('-', '−');
                }
            }
            return text;
        }

        public static string ThreeRule(string text)
        {
            char probel = ' ';

            for (int i = 1; i <= text.Length - 1; i++)
            {
                if (text[i - 1] == probel && text[i + 1] == probel && text[i] == '-')
                {
                    text = text.Replace('-', '—');
                }
                if (Char.IsLetterOrDigit(text[i]) && text[i - 1] == '-')
                {
                    text = text.Replace("-", "-");
                }

                if (text[0] == '-')
                {
                    text = text.Replace("-", "–");
                }
            }
            return text;
        }

        public static string FourRule(string text)
        {
            char hyphen = '-';
            char probel = ' ';

            for (int i = 1; i < text.Length - 1; i++)
            {
                if (text[i] == hyphen && text[i - 1] == probel && Char.IsLetterOrDigit(text[i + 1]))
                {
                    text = text.Remove(i - 1, 1);
                }

                if (text[i] == hyphen && text[i + 1] == probel && Char.IsLetterOrDigit(text[i - 1]))
                {
                    text = text.Remove(i + 1, 1);
                }

                if (text[i] == hyphen && text[i - 1] == probel && text[i + 1] == probel)
                {
                    text = text.Remove(i - 1, 1);
                    text = text.Remove(i, 1);
                }
            }
            return text;
        }

        public static string Fiverule(string text)
        {
            if (text.Contains("?"))
            {
                text = text.Replace("?", "¿");
            }
            if (text.Contains("!?"))
            {
                text = text.Replace("!?", "?!");
            }

            return text;
        }

        public static string SixRule(string text)
        {
            if (text.Contains("c") || text.Contains("C"))
            {
                text = text.Replace("c", "с");
                text = text.Replace("C", "С");
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            
            if (checkboxpravil1.Checked)
            {
                textBox1.Text = OneRule(text);
            }

            if (checkboxpravil4.Checked)
            {
                textBox1.Text = FourRule(text);
            }

            if (checkboxpravil3.Checked)
            {
                textBox1.Text = ThreeRule(text);
            }

            if (checkboxpravil5.Checked)
            {
                textBox1.Text = Fiverule(text);
            }

            if (checkboxpravil6.Checked)
            {
                textBox1.Text = SixRule(text);
            }

            if (checkboxpravil2.Checked)
            {
                textBox1.Text = TwoRule(text);
            }

            if (checkboxpravil7.Checked)
            {
                Dictionary<string, string> Dictionar = File.ReadAllLines(@".\star.txt")
            .Select(x => Regex.Match(x, @"([\p{Lu}\p{Ll}]+)\s*(\d+)"))
            .ToDictionary(x => x.Groups[1].Value, x => x.Groups[2].Value);
                string result = Dictionar.Aggregate(text, (s, kvp) => s.Replace(kvp.Key, kvp.Value));
                textBox1.Text = result;
            }
        }

        private void shriftbutton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                typograflabel.Font = fd.Font;
                textBox1.Font = fd.Font;
                label1pravil.Font = fd.Font;
                label2pravil.Font = fd.Font;
                label3pravil.Font = fd.Font;
                label4pravil.Font = fd.Font;
                label5pravil.Font = fd.Font;
                label6pravil.Font = fd.Font;
                label7pravil.Font = fd.Font;
                label3.Font = fd.Font;
                checkboxpravil1.Font = fd.Font;
                checkboxpravil2.Font = fd.Font;
                checkboxpravil3.Font = fd.Font;
                checkboxpravil4.Font = fd.Font;
                checkboxpravil5.Font = fd.Font;
                checkboxpravil6.Font = fd.Font;
                checkboxpravil7.Font = fd.Font;
                buttonott.Font = fd.Font;
                buttonsave.Font = fd.Font;
                shriftbutton.Font = fd.Font;
            }
        }
    }
}
