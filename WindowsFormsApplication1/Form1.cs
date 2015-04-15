using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Threading;

namespace InfoNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                Pravda pd = new Pravda();
                textBox_pravda.Text = pd.Text;
                Censor();
                Correspond();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Censor()
        {
            textBox_censor.Text += Parser.TakeInfoText("http://censor.net.ua/", "//article[@class='item type2']");
        }
        
        public void Correspond()
        {
            textBox_korrespondent.Text += Parser.TakeInfoText("http://korrespondent.net", "//div[@class='article article_top_small']/div[@class='article__title']");
            textBox_korrespondent.Text += Environment.NewLine + "_______________________________________" + Environment.NewLine;
            textBox_korrespondent.Text += Parser.TakeInfoText("http://korrespondent.net", "//div[@class='article article_top_small article_top_noimg']/div[@class='article__title']");
        }

        public void Clear()
        {
            textBox_pravda.Clear();
            textBox_censor.Clear();
            textBox_korrespondent.Clear();
        }

        // переход на главную страницу сайта при нажатии на линке
        private void linkLabel_pravda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel clicklabel = (LinkLabel)sender;
            string uri = clicklabel.Tag.ToString();
            System.Diagnostics.Process.Start(uri);
        }
    }
}





