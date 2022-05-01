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
            MessageBox.Show("траляля");
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
            var probel =" ";

            for (int i = 0; i < strochka.Length; i++)
            {
                if (strochka[i-1]==probel)
                {
                    if (strochka[i]==prev)
                    {

                    }

                    if (/*тире*/)
                    {

                    }

                    if (/*символ кавычка или скобка*/)
                    {

                    }

                    if (/*буква же*/)
                    {

                    }
                }
                
                if (strochka[i - 1]==тире)
                {
                    if (strochka[i] == prev)
                    {

                    }

                    if (/*тире*/)
                    {

                    }

                    if (/*символ кавычка или скобка*/)
                    {

                    }

                    if (/*буква же*/)
                    {

                    }
                }

                if (strochka[i - 1] == кавычки)
                {
                    if (strochka[i] == prev)
                    {

                    }

                    if (/*тире*/)
                    {

                    }

                    if (/*символ кавычка или скобка*/)
                    {

                    }

                    if (/*буква же*/)
                    {

                    }
                }

                if (strochka[i - 1] == буква)
                {
                    if (strochka[i] == prev)
                    {

                    }

                    if (/*тире*/)
                    {

                    }

                    if (/*символ кавычка или скобка*/)
                    {

                    }

                    if (/*буква же*/)
                    {

                    }
                }
            }
        }
    }
}
