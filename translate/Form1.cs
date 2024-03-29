﻿using System;
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
using Amazon.Translate;
using Amazon;
using Amazon.Runtime;
using Amazon.Translate.Model;
using Google.Cloud.Translation.V2;
using Google.Apis.Services;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Api;
using Google.LongRunning;
using Google;
using Newtonsoft.Json;

namespace translate
{
    public partial class Form1 : Form
    {
        int index;
        string input;
        string languagePair;
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
            MessageBox.Show("Файл открыт");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, tBtRan.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBtRaNs_TextChanged(object sender, EventArgs e)
        {

        }

        private void tRaNsLaToR_Click(object sender, EventArgs e)
        {
            /*string url = "https://translate.google.com/?hl=ru&sl=auto&tl=ru&text=&op=translate";
            url = "https://translate.google.com/?hl=ru&sl=auto&tl=ru&text=" + tBtRaNs.Text + "&op=translate";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream resStream = response.GetResponseStream();
            
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    tBtRan.Text = reader.ReadToEnd();
                }
            }
            response.Close();
            //tBtRan.Text = url;*/
            BasicAWSCredentials credentials = new BasicAWSCredentials("AccessKeyID", "SecretAccessKey");
            AmazonTranslateClient amazonTranslateClient = new AmazonTranslateClient(credentials, RegionEndpoint.USEast1);
            TranslateTextRequest translateTextRequest = new TranslateTextRequest();
            translateTextRequest.Text = tBtRaNs.Text;
            translateTextRequest.SourceLanguageCode = "en";
            translateTextRequest.TargetLanguageCode = "ru";
            TranslateTextResponse translateTextResponse = amazonTranslateClient.TranslateText(translateTextRequest);
            tBtRan.Text = translateTextResponse.TranslatedText;
            /*TranslationClient client = TranslationClient.Create();
            var response = client.TranslateText(tBtRan.Text, "ru");
            tBtRaNs.Text = tBtRaNs.Text + response;*/

        }

        private void tBtRan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
