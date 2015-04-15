using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNews
{
    class Pravda : Parser
    {
        string text;

        string pravda()
        {
            string textpravda = Parser.getResponse("http://pda.pravda.com.ua/news/");
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(textpravda);
            HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//p/a[@class='a3']");

            if (nodes != null)
            {

                foreach (var t in nodes)
                {
                    text += t.InnerText + Environment.NewLine;
                }

                HtmlAgilityPack.HtmlNodeCollection nodes1 = doc.DocumentNode.SelectNodes("//p/a[@class='a2']");

                foreach (var t in nodes1)
                {
                    text += t.InnerText + Environment.NewLine;
                }
                text += Environment.NewLine;
            }
            return text;
        }
        
        public string Text
        {
            get { return pravda(); }
        }

    }
}
