using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
            //HtmlDocument doc = web.Load(url);

            var webClient = new WebClient();
            var data = webClient.DownloadData(new Uri(url));
            HtmlDocument doc = new HtmlDocument();
            doc.Load(new StreamReader(new MemoryStream(data)));


            var divs = doc.DocumentNode.SelectNodes("//h2");

            var links = divs?.Descendants("a")
                .Select(a => a.InnerText)
                .ToList();
            return links;
        }

    }

}
