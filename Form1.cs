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
                "Английский",
                "Русский",
                "Французский",
                "Немецкий",
                "Испанский",
                "Итальянский",
                "Португальский" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
                MessageBox.Show(ex.Message,"Ошибка! Отсутствует интернет-соединение.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
