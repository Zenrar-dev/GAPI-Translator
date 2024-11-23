namespace Translator
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
                "Арабский язык",
                "Болгарский",
                "Чешский",
                "Датский",
                "Немецкий",
                "Греческий",
                "Английский",
                "Испанский",
                "Эстонский",
                "Финский",
                "Французский",
                "Венгерский",
                "Индонезийский",
                "Итальянский",
                "Японский",
                "Корейский",
                "Литовский",
                "Латышский",
                "Норвежский Бокмол",
                "Голландский",
                "Польский",
                "Португальский",
                "Румынский",
                "Русский",
                "Словацкий",
                "Словенский",
                "Шведский",
                "Турецкий",
                "Украинский",
                "Китайский" });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Русский";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Английский";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Немецкий";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Испанский";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb.SelectedItem = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = cb.SelectedItem;


        }
    }
}
