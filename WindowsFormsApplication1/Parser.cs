using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InfoNews
{
    public class Parser
    {
        /*получаем html code*/
        public static string getResponse(string uri)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }

        string pravda(string url, string filter, string filter2)
        {
            string text = "";
            string textpravda = getResponse(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(textpravda);
            HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(filter);

            if (nodes != null)
            {

                foreach (var t in nodes)
                {
                    text += t.InnerText + Environment.NewLine;
                }

                HtmlAgilityPack.HtmlNodeCollection nodes1 = doc.DocumentNode.SelectNodes(filter2);

                foreach (var t in nodes1)
                {
                    text += t.InnerText + Environment.NewLine;
                }
                text += Environment.NewLine;
            }
            return text;
        }

        public static string TakeInfoText(string html, string searchzapros)
        {
            string outputText = "";
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);

            // Собственно, здесь и производится выборка интересующих нодов
            // В данном случае выбираем блочные элементы с классом eTitle
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes(searchzapros);

            // проверка на наличие найденных узлов
            if (NoAltElements != null)
            {
                foreach (HtmlNode HN in NoAltElements)
                {
                    //Получаем строчки
                    outputText += HN.InnerText.Trim() + Environment.NewLine;
                }
            }

            outputText = outputText.Replace("&nbsp;", "");
            outputText = outputText.Replace("&quot;", "");

            return outputText;
        }
    }
}
