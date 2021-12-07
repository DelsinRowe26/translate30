
namespace translate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBtRaNs = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.translatebox = new System.Windows.Forms.ComboBox();
            this.tBtRan = new System.Windows.Forms.TextBox();
            this.tRaNsLaToR = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tBtRaNs
            // 
            this.tBtRaNs.Location = new System.Drawing.Point(13, 28);
            this.tBtRaNs.Multiline = true;
            this.tBtRaNs.Name = "tBtRaNs";
            this.tBtRaNs.Size = new System.Drawing.Size(326, 410);
            this.tBtRaNs.TabIndex = 1;
            this.tBtRaNs.TextChanged += new System.EventHandler(this.tBtRaNs_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // translatebox
            // 
            this.translatebox.FormattingEnabled = true;
            this.translatebox.Items.AddRange(new object[] {
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
            "Бирманский",
            "Болгарский",
            "Боснийский",
            "Валлийский",
            "Венгерский",
            "Вьетнамский",
            "Гавайский",
            "Гаитянский",
            "Галисийский",
            "Греческий",
            "Грузинский",
            "Гуджарати",
            "Гэльский",
            "Датский",
            "Западнофризский",
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
            "Казахский",
            "Каннада",
            "Каталанский",
            "Киньяруанда",
            "Киргизский",
            "Китайский (традиционный)",
            "Китайский (упрощенный)",
            "Корейский",
            "Корсиканский",
            "Коса",
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
            "Немецкий",
            "Непальский",
            "Нидерландский",
            "Норвежский",
            "Ньянджа",
            "Ория",
            "Панджаби",
            "Персидский",
            "Польский",
            "Португальский",
            "Пушту",
            "Румынский",
            "Русский",
            "Самоанский",
            "Себуанский",
            "Сербский",
            "Сингальский",
            "Синдхи",
            "Словацкий",
            "Словенский",
            "Сомали",
            "Суахили",
            "Сунданский",
            "Таджикский",
            "Тайский",
            "Тамильский",
            "Татарский",
            "Телугу",
            "Турецкий",
            "Туркменский",
            "Узбекский",
            "Уйгурский",
            "Украинский",
            "Урду",
            "Филиппинский",
            "Финский",
            "Французский",
            "Хауса",
            "Хинди",
            "Хмонг",
            "Хорватский",
            "Чешский",
            "Шведский",
            "Шона",
            "Эсперанто",
            "Эстонский",
            "Южный сото",
            "Яванский",
            "Японский"});
            this.translatebox.Location = new System.Drawing.Point(811, 55);
            this.translatebox.Name = "translatebox";
            this.translatebox.Size = new System.Drawing.Size(187, 21);
            this.translatebox.TabIndex = 2;
            this.translatebox.TextChanged += new System.EventHandler(this.translatebox_TextChanged_1);
            // 
            // tBtRan
            // 
            this.tBtRan.Location = new System.Drawing.Point(460, 28);
            this.tBtRan.Margin = new System.Windows.Forms.Padding(2);
            this.tBtRan.Multiline = true;
            this.tBtRan.Name = "tBtRan";
            this.tBtRan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBtRan.Size = new System.Drawing.Size(319, 410);
            this.tBtRan.TabIndex = 3;
            // 
            // tRaNsLaToR
            // 
            this.tRaNsLaToR.Location = new System.Drawing.Point(343, 176);
            this.tRaNsLaToR.Margin = new System.Windows.Forms.Padding(2);
            this.tRaNsLaToR.Name = "tRaNsLaToR";
            this.tRaNsLaToR.Size = new System.Drawing.Size(113, 46);
            this.tRaNsLaToR.TabIndex = 4;
            this.tRaNsLaToR.Text = "Перевести";
            this.tRaNsLaToR.UseVisualStyleBackColor = true;
            this.tRaNsLaToR.Click += new System.EventHandler(this.tRaNsLaToR_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            "Бирманский",
            "Болгарский",
            "Боснийский",
            "Валлийский",
            "Венгерский",
            "Вьетнамский",
            "Гавайский",
            "Гаитянский",
            "Галисийский",
            "Греческий",
            "Грузинский",
            "Гуджарати",
            "Гэльский",
            "Датский",
            "Западнофризский",
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
            "Казахский",
            "Каннада",
            "Каталанский",
            "Киньяруанда",
            "Киргизский",
            "Китайский (традиционный)",
            "Китайский (упрощенный)",
            "Корейский",
            "Корсиканский",
            "Коса",
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
            "Немецкий",
            "Непальский",
            "Нидерландский",
            "Норвежский",
            "Ньянджа",
            "Ория",
            "Панджаби",
            "Персидский",
            "Польский",
            "Португальский",
            "Пушту",
            "Румынский",
            "Русский",
            "Самоанский",
            "Себуанский",
            "Сербский",
            "Сингальский",
            "Синдхи",
            "Словацкий",
            "Словенский",
            "Сомали",
            "Суахили",
            "Сунданский",
            "Таджикский",
            "Тайский",
            "Тамильский",
            "Татарский",
            "Телугу",
            "Турецкий",
            "Туркменский",
            "Узбекский",
            "Уйгурский",
            "Украинский",
            "Урду",
            "Филиппинский",
            "Финский",
            "Французский",
            "Хауса",
            "Хинди",
            "Хмонг",
            "Хорватский",
            "Чешский",
            "Шведский",
            "Шона",
            "Эсперанто",
            "Эстонский",
            "Южный сото",
            "Яванский",
            "Японский"});
            this.comboBox1.Location = new System.Drawing.Point(811, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1__TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "На";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tRaNsLaToR);
            this.Controls.Add(this.tBtRan);
            this.Controls.Add(this.translatebox);
            this.Controls.Add(this.tBtRaNs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TextBox tBtRaNs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox translatebox;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TextBox tBtRan;
        private System.Windows.Forms.Button tRaNsLaToR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

