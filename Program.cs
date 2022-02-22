// #18181818
using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
namespace webscrapo
{
    class Program
    {

        public static void Main()
        {
            var html = @"https://arbiscan.io/token/0xff970a61a04b1ca14834a43f5de4533ebddb5cc8#tokenExchange";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(html);
            var nodesu2 = from nodeuSE in htmlDoc.DocumentNode.Descendants("tr")
                          select nodeuSE;

            foreach (var tr in htmlDoc.DocumentNode.Descendants().Where(x => x.Name == "tr"))
            {
                foreach (var td in tr.Descendants().Where(x => x.Name == "td"))
                    Console.WriteLine(td.InnerText.Trim());
                Console.WriteLine("=====");
            }

        }
    }
}
/*
            foreach (var nodeuSE in nodesu2)
            {
                HtmlDocument Docs = new HtmlDocument();
                Docs.LoadHtml(nodeuSE.OuterHtml);
                var nodesu = from nodeuSE3 in Docs.DocumentNode.Descendants("td")
                             select nodeuSE3;
                foreach (var nodeuSE2 in nodesu)
                {
                    System.Console.WriteLine(nodeuSE2.InnerText.Replace(" ", "")); 
                }

            }
*/


//original files : DO NOT LOSE
//https://dotnetfiddle.net/SyQJz0
//https://dotnetfiddle.net/4pDLDv
//https://dotnetfiddle.net/6RYa0V
//https://dotnetfiddle.net/wSmH4z
//https://dotnetfiddle.net/Uinjl6
//https://dotnetfiddle.net/fz1P4J
//https://dotnetfiddle.net/SbEioW 
 

//for future reference: matching version of chrome <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="98.0.4758.80" />
//for future  reference:  <PackageReference Include="Selenium.WebDriver" Version="4.1.0" /> 

 
