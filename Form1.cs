using System.Windows.Forms;

namespace GAPITranslator
{
    public partial class Form1 : Form
    {
        ComboBox cb;
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "Английский";
            comboBox1.SelectedItem = "Русский";
            cb = new ComboBox();
            cb.Items.AddRange(new object[] {
                "Азербайджанский",
                "Албанский",
                "Амхарский",
                "Английский",
                "Арабский",
                "Армянский",
                "Африкаанс",
                "Баскский",
                "Белорусский",
                "Бенгальский",
                "Болгарский",
                "Боснийский",
                "Валлийский",
                "Венгерский",
                "Вьетнамский",
                "Гаитянский креольский",
                "Галисийский",
                "Голландский",
                "Греческий",
                "Грузинский",
                "Гуджарати",
                "Датский",
                "Зулу",
                "Иврит",
                "Игбо",
                "Идиш",
                "Индонезийский",
                "Ирландский",
                "Исландский",
                "Испанский",
                "Итальянский",
                "Йоруба",
                "Казах",
                "Каннада",
                "Каталанский",
                "Киньяруанда",
                "Киргиз",
                "Корейский",
                "Корсиканский",
                "Курдский",
                "Кхмерский",
                "Лаосский",
                "Латинский",
                "Латышский",
                "Литовский",
                "Люксембургский",
                "Македонский",
                "Малагасийский",
                "Малайский",
                "Малаялам",
                "Мальтийский",
                "Маори",
                "Маратхи",
                "Монгольский",
                "Мьянманский (бирманский)",
                "Немецкий",
                "Непальский",
                "Норвежский",
                "Ньянджа (чичева)",
                "Одия (Ория)",
                "Панджаби",
                "Персидский",
                "Польский",
                "Португальский",
                "Пушту",
                "Румынский",
                "Русский",
                "Самоанский",
                "Сербский",
                "Сесото",
                "Сингальский",
                "Синдхи",
                "Словацкий",
                "Словенский",
                "Сомалийский",
                "Суахили",
                "Сунданский",
                "Тагальский",
                "Таджикский",
                "Тайский",
                "Тамильский",
                "Татарин",
                "Телугу",
                "Турецкий",
                "Туркменский",
                "Узбекский",
                "Уйгурский",
                "Украинский",
                "Урду",
                "Финский",
                "Французский",
                "Фризский",
                "Хауса",
                "Хинди",
                "Хорватский",
                "Хоса",
                "Чешский",
                "Шведский",
                "Шона",
                "Шотландский гэльский",
                "Эсперанто",
                "Эстонский",
                "Яванский",
                "Японский" });
            richTextBox1.Text = string.Empty;
            richTextBox1.ForeColor = Color.Black; 
            richTextBox1.Font = new Font("Segoe UI", 12); 
            richTextBox1.Enter += RichTextBox1_Enter;
            richTextBox1.Leave += RichTextBox1_Leave;
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
            richTextBox1.Paint += RichTextBox1_Paint;
        }
        private void RichTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Введите текст для перевода...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black;
            }
        }
        private void RichTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "Введите текст для перевода...";
                richTextBox1.ForeColor = Color.Gray;
            }
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.ForeColor = Color.Black;
            }
            else
            {
                richTextBox1.ForeColor = Color.Gray;
            }
        }
        private void RichTextBox1_Paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                using (Font font = new Font("Segoe UI", 12))
                using (Brush brush = new SolidBrush(Color.FromArgb(128, 169, 169, 169)))
                {
                    e.Graphics.DrawString("Введите текст для перевода...", font, brush, new Point(5, 5));
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Русский";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Английский";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Немецкий";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Испанский";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb.SelectedItem = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = cb.SelectedItem;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();
                string translatedText = await GoogleTranslate.TranslateAsync(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), richTextBox1.Text);
                richTextBox2.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! Отсутствует интернет-соединение.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GAPI-Translator v1.0\nСоздано на основе: https://translate.google.ru", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                try
                {
                    richTextBox2.Clear();
                    string translatedText = await GoogleTranslate.TranslateAsync(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), richTextBox1.Text);
                    richTextBox2.Text = translatedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка! Отсутствует интернет-соединение.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

