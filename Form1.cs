namespace GAPITranslator
{
    public partial class Form1 : Form
    {
        ComboBox cb;
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "Русский";
            comboBox1.SelectedItem = "Английский";
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
    }
}
