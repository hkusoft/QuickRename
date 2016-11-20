using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRename.Searcher
{
    class BingWebSearcher : ISearchProvider
    {        
        private static string template = @"https://www.bing.com/search?q={0}&pc=MOZI&form=MOZSBR";
        private static HtmlWeb web = new HtmlWeb();

        /// <summary>
        /// This function returns the textual (not the link) representation of the search
        /// </summary>
        /// <param name="queryFilePath">The keyword to search</param>
        /// <returns>A list of searching result texts that relates to the queryFilePath text.</returns>
        public List<string> Search(string queryFilePath)
        {
            string url = string.Format(template, queryFilePath);
            HtmlDocument doc = web.Load(url,"GET");

            //string blockedString = "Why did this happen?";
            //if (doc.DocumentNode.InnerText.Contains(blockedString))
            //{
            //    Console.WriteLine("Too much search, google has blocked your IP temprorily");
            //    return null;
            //}

            //Xpath = "id('b_results')/x:li[1]/x:h2/x:a"
            var divs = doc.DocumentNode.SelectNodes("//h2");

            var links = divs?.Descendants("a")
                .Select(a => a.InnerText)
                .ToList();
            return links;
        }
    }
}
