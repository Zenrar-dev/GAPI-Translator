namespace Translator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem1 = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            выходToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            richTextBox2 = new RichTextBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(912, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, выходToolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(106, 6);
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(109, 22);
            выходToolStripMenuItem1.Text = "Выход";
            выходToolStripMenuItem1.Click += выходToolStripMenuItem1_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 26);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(109, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(11, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 131);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(432, 88);
            button1.Name = "button1";
            button1.Size = new Size(52, 39);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(819, 222);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 5;
            button2.Text = "Перевести\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(12, 45);
            button3.Name = "button3";
            button3.Size = new Size(87, 34);
            button3.TabIndex = 6;
            button3.Text = "Русский";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(105, 45);
            button4.Name = "button4";
            button4.Size = new Size(87, 34);
            button4.TabIndex = 7;
            button4.Text = "Английский";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(490, 48);
            button5.Name = "button5";
            button5.Size = new Size(85, 34);
            button5.TabIndex = 8;
            button5.Text = "Немецкий";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(581, 48);
            button6.Name = "button6";
            button6.Size = new Size(85, 34);
            button6.TabIndex = 9;
            button6.Text = "Испанский";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] {
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
            comboBox2.Location = new Point(672, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 28);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
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
            comboBox1.Location = new Point(198, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 28);
            comboBox1.TabIndex = 12;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(490, 85);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(414, 131);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(912, 395);
            Controls.Add(richTextBox2);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Translator";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox2;
        private ToolStripSeparator toolStripSeparator1;
    }
}
