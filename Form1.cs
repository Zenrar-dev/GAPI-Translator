using System.Windows.Forms;

namespace GAPITranslator
{
    public partial class Form1 : Form
    {
        ComboBox cb;
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "����������";
            comboBox1.SelectedItem = "�������";
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
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DrawItem += ComboBox1_DrawItem;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.DrawItem += ComboBox2_DrawItem;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            richTextBox1.Text = "";
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Font = new Font("Segoe UI", 12);
            richTextBox1.Enter += RichTextBox1_Enter;
            richTextBox1.Leave += RichTextBox1_Leave;
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
            richTextBox1.Paint += RichTextBox1_Paint;
            richTextBox1.SelectionRightIndent = 65;
            richTextBox2.SelectionRightIndent = 65;
        }
        private void RichTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "������� ����� ��� ��������...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black;
                isUserTyping = true;
            }
        }
        private void RichTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text) && !isUserTyping)
            {
                richTextBox1.Text = "������� ����� ��� ��������...";
                richTextBox1.ForeColor = Color.Gray;
            }
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.ForeColor = Color.Black;
                isUserTyping = true;
            }
            else
            {
                richTextBox1.ForeColor = Color.Gray;
                isUserTyping = false;
            }
        }
        private void RichTextBox1_Paint(object sender, PaintEventArgs e)
        {

            if (string.IsNullOrEmpty(richTextBox1.Text) && !isUserTyping)
            {
                using (Font font = new Font("Segoe UI", 12))
                using (Brush brush = new SolidBrush(Color.FromArgb(128, 169, 169, 169)))
                {
                    e.Graphics.DrawString("������� ����� ��� ��������...", font, brush, new Point(5, 5));
                }
            }
        }
        private bool isUserTyping = false;
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
                if (string.IsNullOrWhiteSpace(richTextBox1.Text) || richTextBox1.Text == "������� ����� ��� ��������...")
                {
                    return;
                }
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

        private async void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(richTextBox1.Text) || richTextBox1.Text == "������� ����� ��� ��������...")
                {
                    return;
                }
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
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }
        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "������� ����� ��� ��������...")
                {
                    MessageBox.Show("������! �� ��������� ����������� ����� �� ������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clipboard.SetText(richTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "������! �� ��������� ����������� ����� �� ������� ����.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "������! �� ��������� ����������� ����� �� ������� ����.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (comboBox1.Items[e.Index].ToString() == "--------")
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawLine(Pens.Gray, e.Bounds.Left, e.Bounds.Top, e.Bounds.Right, e.Bounds.Top);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "--------")
            {
                comboBox1.SelectedIndex = -1;
            }
        }
        private void ComboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (comboBox2.Items[e.Index].ToString() == "--------")
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawLine(Pens.Gray, e.Bounds.Left, e.Bounds.Top, e.Bounds.Right, e.Bounds.Top);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawString(comboBox2.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "--------")
            {
                comboBox2.SelectedIndex = -1;
            }
        }
    }
}


