using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Typograf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog
            {
                DefaultExt = "*.txt",
                Filter = "Text files|*.txt"
            };
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

                    if ((Char.IsLetterOrDigit(text[i + 1]) || text[i]==probel) && text[i - 1] == probel)
                    {
                        text = text.Remove(i - 1, 1);
                        text = text.Insert(i, " ");
                    }

                    if (Char.IsLetterOrDigit(text[i + 1]) && Char.IsLetterOrDigit(text[i - 1]))
                    {
                        text = text.Insert(i, " ");
                    }
                }

                if (text[i] == '—')
                {
                    if (text[i - 1] == probel && char.IsLetterOrDigit(text[i + 1]))
                    {
                        text = text.Insert(i + 1, " ");
                    }

                    if (text[i + 1] == probel && char.IsLetterOrDigit(text[i - 1]))
                    {
                        text = text.Insert(i, " ");
                    }

                    if (char.IsLetterOrDigit(text[i + 1]) && char.IsLetterOrDigit(text[i - 1]))
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
                if (text[i + 1] == probel && text[i - 1] == probel && char.IsDigit(text[i + 2]) && char.IsDigit(text[i - 2]))
                {
                    text = text.Replace('-', '−');
                }

                if (char.IsDigit(text[i + 1]) && char.IsDigit(text[i - 1]) && (text[i] == hyphen || text[i] == '−'))
                {
                    text = text.Insert(i, " ");
                    text = text.Insert(i + 2, " ");
                    text = text.Replace('-', '−');
                }

                if (text[i + 1] == probel && char.IsDigit(text[i - 1]) && char.IsDigit(text[i + 2]))
                {
                    text = text.Insert(i, " ");
                    text = text.Replace('-', '−');
                }
                if (text[i - 1] == probel && char.IsDigit(text[i + 1]) && char.IsDigit(text[i - 2]))
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
                if (char.IsLetterOrDigit(text[i]) && text[i - 1] == '-')
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
                if (text[i] == hyphen && text[i - 1] == probel && char.IsLetterOrDigit(text[i + 1]))
                {
                    text = text.Remove(i - 1, 1);
                }

                if (text[i] == hyphen && text[i + 1] == probel && char.IsLetterOrDigit(text[i - 1]))
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
        public static string SevenRule(string text)
        {
            Dictionary<string, string> Dictionar = new Dictionary<string, string>()
            {
                {"ты", "Вы"},
{"тебе", "Вам"},
{"привет", "приветствую"},
{"пока", "до свидания"},
{"парень", "сударь"},
{"нет", "я вынужден отказаться"},
{"парню", "сударю"},
{"парней", "сударей"},
{"девушки", "барышни"},
{"Если", "Коль"},
{"Твой", "Ваш"},
{"твой", "Ваш"},
{"Твоя", "Ваша"},
{"твоя", "Ваша"},
{"Тебя", "Вас"},
{"тебя", "Вас"},
{"Парня", "Сударя"},
{"Парнем", "Сударем"},
{"Парне", "Сударе"},
{"Парням", "Сударям"},
{"Парнями", "Сударями"},
{"Здесь", "Зде"},
{"Огромный", "Зельный"},
{"Огромная", "Зельная"},
{"Огромное", "Зельное"},
{"Какой", "Экий"},
{"Какая", "Экая"},
{"Красивый", "Красный"},
{"Красивая", "Красна"},
{"Красивое", "Красно"},
{"Обманывать", "Льстить"},
{"Обманываю", "Льщу"},
{"Обманывает", "Льстит"},
{"Обманывают", "Льстят"},
{"Жестокий", "Лютый"},
{"Жестокая", "Лютая"},
{"Жестокое", "Лютое"},
{"Жестокие", "Лютые"},
{"Звать", "Величать"},
{"Хотеть", "Желать"},
{"Хочу", "Желаю"},
{"Хочет", "Желает"},
{"Хотят", "Желают"},
{"Есть", "Трапезничать"},
{"Ем", "Трапезничаю"},
{"Ест", "Трапезничает"},
{"Едят", "Трапезничают"},
{"Спать", "Почивать"},
{"Сплю", "Почиваю"},
{"Спит", "Почивает"},
{"Спят", "Почивают"},
{"Хороший", "Добрый"},
{"Хорошо", "Гоже"},
{"Хорошая", "Добрая"},
{"Хорошее", "Доброе"},
{"Хорошие", "Добрые"},
{"Вдруг", "Авось"},
{"Наверное", "Небось"},
{"Ладно", "Бог с тобой"},
{"Мальчик", "Хлопец"},
{"Мальчики", "Хлопцы"},
{"Мальчика", "Хлопца"},
{"Мальчику", "Хлопцу"},
{"Мальчиком", "Хлопцем"},
{"Мальчике", "Хлопце"},
{"Мальчиков", "Хлопцев"},
{"Мальчикам", "Хлопцам"},
{"Мальчиками", "Хлопцами"},
{"Мальчиках", "Хлопцах"},
{"Пойдем", "Извольте"},
{"Откуда", "Отколь"},
{"Отсюда", "Отсель"},
{"Упрямиться", "Артачиться"},
{"Упрямлюсь", "Артачусь"},
{"Упрямится", "Артачится"},
{"Упрямятся", "Артачатся"},
{"Зачем", "Какова причина"},
{"Грустно", "Горестно"},
{"Мама", "Матушка"},
{"Маму", "Матушку"},
{"Маме", "Матушке"},
{"Мамой", "Матушкой"},
{"Папа", "Батюшка"},
{"Папу", "Батюшку"},
{"Папе", "Батюшке"},
{"Папой", "Батюшкой"},
{"девушка", "барышня"},
{"девушке", "барышне"},
{"девушкам", "барышням"},
{"девушек", "барышень"},
{"девушками", "барышнями"},
{"девушках", "барышнях"},
{"девушку", "барышню"},
{"девушкой", "барышней"},
{"Девушкам", "Барышням"},
{"Девушек", "Барышень"},
{"Девушками", "Барышнями"},
{"Девушках", "Барышнях"},
{"Девушку", "Барышню"},
{"Девушке", "Барышне"},
{"Девушкой", "Барышней"},
{"парне", "сударе"},
{"парням", "сударям"},
{"здороваюсь", "бьюсь челом"},
{"здоровается", "бьется челом"},
{"здороваться", "бить челом"},
{"здороваются", "бьют челом"},
{"здесь", "зде"},
{"огромный", "зельный"},
{"огромная", "зельная"},
{"огромное", "зельное"},
{"огромные", "зельные"},
{"глаз", "око"},
{"глаза", "очи"},
{"глазу", "оку"},
{"глазом", "оком"},
{"глазам", "очам"},
{"глазами", "очами"},
{"глазах", "очах"},
{"какой", "экий"},
{"какая", "экая"},
{"красивый", "красный"},
{"красивая", "красна"},
{"красивое", "красно"},
{"обманывать", "льстить"},
{"обманываю", "льщу"},
{"обманывает", "льстит"},
{"обманывают", "льстят"},
{"звать", "величать"},
{"хотеть", "желать"},
{"хочу", "желаю"},
{"хочет", "желает"},
{"хотят", "желают"},
{"есть", "трапезничать"},
{"ем", "трапезничаю"},
{"ест", "трапезничает"},
{"едят", "трапезничают"},
{"хороший", "добрый"},
{"хорошо", "гоже"},
{"хорошая", "добрая"},
{"хорошее", "доброе"},
{"хорошие", "добрые"},
{"вдруг", "авось"},
{"наверное", "небось"},
{"ладно", "бог с тобой"},
{"мальчик", "хлопец"},
{"мальчики", "хлопцы"},
{"мальчика", "хлопца"},
{"мальчику", "хлопцу"},
{"мальчиком", "хлопцем"},
{"мальчике", "хлопце"},
{"мальчиков", "хлопцев"},
{"мальчикам", "хлопцам"},
{"мальчиками", "хлопцами"},
{"мальчиках", "хлопцах"},
{"пойдем", "извольте"},
{"откуда", "отколь"},
{"отсюда", "отсель"},
{"упрямиться", "артачиться"},
{"упрямлюсь", "артачусь"},
{"упрямятся", "артачатся"},
{"зачем", "какова причина"},
{"грустно", "горестно"},
{"мама", "матушка"},
{"маму", "матушку"},
{"маме", "матушке"},
{"мамой", "матушкой"},
{"папа", "батюшка"},
{"папу", "батюшку"},
{"папе", "батюшке"},
{"папой", "батюшкой"},
            };
            string result = Dictionar.Aggregate(text, (s, kvp) => s.Replace(kvp.Key, kvp.Value));
            return result;

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
                button1.Font = fd.Font;
                buttonsave.Font = fd.Font;
                shriftbutton.Font = fd.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkboxpravil1.Checked)
            {
                textBox1.Text = OneRule(textBox1.Text);
            }

            if (checkboxpravil4.Checked)
            {
                textBox1.Text = FourRule(textBox1.Text);
            }

            if (checkboxpravil3.Checked)
            {
                textBox1.Text = ThreeRule(textBox1.Text);
            }

            if (checkboxpravil5.Checked)
            {
                textBox1.Text = Fiverule(textBox1.Text);
            }

            if (checkboxpravil6.Checked)
            {
                textBox1.Text = SixRule(textBox1.Text);
            }

            if (checkboxpravil2.Checked)
            {
                textBox1.Text = TwoRule(textBox1.Text);
            }

            if (checkboxpravil7.Checked)
            {
                textBox1.Text = SevenRule(textBox1.Text);
            }
        }

        private void label(object sender, EventArgs e)
        {
            if (sender == label1pravil)
            {
                MessageBox.Show("Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом. Тире отбивается пробелом с двух сторон. Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.");
            }

            if (sender == label2pravil)
            {
                MessageBox.Show("Дефис пробелами не отбивается и всегда пишется слитно с частями слова или цифр, которые он разделяет.");
            }

            if (sender == label3pravil)
            {
                MessageBox.Show("Везде, где по правилам русского языка должно быть тире, ни в коем случае нельзя писать знак дефис, который по умолчанию доступен на клавиатуре. Символ тире задаётся конструкцией —. Например чтобы получить: «Книга — источник знания», нужно написать «Книга — источник знания».");
            }

            if (sender == label4pravil)
            {
                MessageBox.Show(" Везде, где в цифрах указывается минус, также нельзя писать знак дефиса, нужно писать знак минуса: − В арифметических конструкциях знаки операций отбиваются пробелом с двух сторон. Например «5 − 4 = 1».");
            }

            if (sender == label5pravil)
            {
                MessageBox.Show("Везде, где по правилам русского языка должен быть вопросительный знак, ни в коем случае нельзя писать вопросительный знак, который по умолчанию доступен на клавиатуре. Символ вопросительный знак задается как ¿ ");

            }

            if (sender == label6pravil)
            {
                MessageBox.Show("Следует всегда использовать букву «с». Неправильно писать вместо неё букву с в английской раскладке");
            }

            if (sender==label7pravil)
            {
                MessageBox.Show("Добро пожаловать в Древнюю Русь, когда она занимала первое место в Европе по трезвости на протяжении 3 столетий, где вино разбавляли водой, подобно грекам, хотя крепость была не выше 6%, давайте окунемся в этот мир с помощью архаизмов.");
            }

            if (sender == typograflabel)
            {
                MessageBox.Show("Это инструмент, который приводит текст в соответствие с правилами экранной типографики");
            }
        }
    }
}
