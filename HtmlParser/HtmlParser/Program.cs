using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\FatmaSeda\Desktop\KaynakKod.txt");
            string kaynak = reader.ReadToEnd();
            List<string> links = new List<string>();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();

            document.LoadHtml(kaynak);

            HtmlNodeCollection htmlNodes = document.DocumentNode.SelectNodes("//section[@class='shopContent']//div[@class='pro']//a[@href]");//[@class='catalogView'] - //div[@class='catalogView']
            ////div//div//div//div//section//div[@class='catalogView']

            foreach (var element in htmlNodes)
            {
                //var r = ((HtmlDocument)element).DocumentNode.SelectNodes("//a");
                //Console.WriteLine(element.GetDataAttribute("href"));
                //Console.WriteLine(element.InnerHtml);
                Console.WriteLine(element.GetAttributeValue("href",""));
                Console.WriteLine("*****************");
                //links.Add(baslik.InnerHtml);
                // Biraz önceki basliklar koleksiyonunu tek tek gezerek, her bir elemanının içindeki text'i alıyoruz     
            }
            Console.ReadKey();
        }
    }
}
