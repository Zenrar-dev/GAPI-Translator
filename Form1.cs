namespace GAPITranslator
{
    public partial class Form1 : Form
    {
        ComboBox cb;
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "�������";
            comboBox1.SelectedItem = "����������";
            cb = new ComboBox();
            cb.Items.AddRange(new object[] {
                "���������������",
                "���������",
                "���������",
                "����������",
                "��������",
                "���������",
                "���������",
                "��������",
                "�����������",
                "�����������",
                "����������",
                "����������",
                "����������",
                "����������",
                "�����������",
                "���������� ����������",
                "�����������",
                "�����������",
                "���������",
                "����������",
                "���������",
                "�������",
                "����",
                "�����",
                "����",
                "����",
                "�������������",
                "����������",
                "����������",
                "���������",
                "�����������",
                "������",
                "�����",
                "�������",
                "�����������",
                "�����������",
                "������",
                "���������",
                "������������",
                "��������",
                "���������",
                "��������",
                "���������",
                "���������",
                "���������",
                "��������������",
                "�����������",
                "�������������",
                "���������",
                "��������",
                "�����������",
                "�����",
                "�������",
                "�����������",
                "����������� (����������)",
                "��������",
                "����������",
                "����������",
                "������� (������)",
                "���� (����)",
                "��������",
                "����������",
                "��������",
                "�������������",
                "�����",
                "���������",
                "�������",
                "����������",
                "��������",
                "������",
                "�����������",
                "������",
                "���������",
                "����������",
                "�����������",
                "�������",
                "����������",
                "����������",
                "����������",
                "�������",
                "����������",
                "�������",
                "������",
                "��������",
                "�����������",
                "���������",
                "���������",
                "����������",
                "����",
                "�������",
                "�����������",
                "��������",
                "�����",
                "�����",
                "����������",
                "����",
                "�������",
                "��������",
                "����",
                "����������� ��������",
                "���������",
                "���������",
                "��������",
                "��������" });
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "�������";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "����������";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "��������";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "���������";
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
                MessageBox.Show(ex.Message, "������! ����������� ��������-����������.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GAPI-Translator v1.0\n������� �� ������: https://translate.google.ru", "� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
