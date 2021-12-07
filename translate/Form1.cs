using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleTranslateLib;
using GoogleTranslateFreeApi;
using Newtonsoft.Json;

namespace translate
{
    public partial class Form1 : Form
    {
        int pos;
        int index;
        string text, txtfilt;
        //Translate GoogleAPI;
        public Form1()
        {
            InitializeComponent();
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void translatebox_TextChanged_1(object sender, EventArgs e)
        {
            index = translatebox.FindString(translatebox.Text);//нахождение индекса 1-го совпадения с вводимым значением
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            tBtRaNs.Text = fileText;
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, tBtRan.Text);
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBtRaNs_TextChanged(object sender, EventArgs e)
        {

        }

        private async void tRaNsLaToR_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                btn.Enabled = false;
                var res = await Translate.TranslateText(tBtRaNs.Text, (lang)comboBox1.SelectedValue, (lang)translatebox.SelectedValue);
                tBtRan.Text = "";//res.ToString();
                Object json = JsonConvert.DeserializeObject(res.Response);
                foreach(dynamic sent in res.Result.sentences) {
                    tBtRan.AppendText("\n" + sent.trans);
                }
                //tBtRan.AppendText("\n" + res.Result.sentences[0].trans+"\n"+ res.Result.sentences.Count());
                btn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var lst = Translate.GetLangusges().ToList();
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.DataSource = lst;

            translatebox.DisplayMember = "Value";
            translatebox.ValueMember = "Key";
            translatebox.DataSource = lst.ToList();

            comboBox1.SelectedValue = lang.en;
            translatebox.SelectedValue = lang.ru;
        }
        private void comboBox1__TextChanged_1(object sender, EventArgs e)
        {
            index = comboBox1.FindString(comboBox1.Text);//нахождение индекса 1-го совпадения с вводимым значением
        }
        /*Google.Cloud.Translation.V2
        Google.Apis.Translate.v2 может установиться сразу автоматически после Google.Cloud.Translation.V2, если же не установиться автоматически, то нужно будет установить в ручную
        Возможно разберешься как работать TranslatorService
        Yandex.Translator 
        YandexLinguistics.NET тут больше возможностей чем в предыдущей
        */
    }
}
