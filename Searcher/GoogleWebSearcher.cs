using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace QuickRename.Searcher
{
    /// <summary>
    /// This class performs a google search with the given queryFilePath string/
    /// 
    /// </summary>
    class GoogleWebSearcher : ISearchProvider
    {
        private static string template = @"https://www.google.com.hk/search?q={0}";
        private static HtmlWeb web = new HtmlWeb();

        /// <summary>
        /// This function returns the textual (not the link) representation of the search
        /// </summary>
        /// <param name="queryFilePath">The keyword to search</param>
        /// <returns>A list of searching result texts that relates to the queryFilePath text.</returns>
        public List<string> Search(string queryFilePath)
        {
            string url = string.Format(template, queryFilePath);
            HtmlDocument doc = web.Load(url);

            string blockedString = "Why did this happen?";
            if (doc.DocumentNode.InnerText.Contains(blockedString))
            {
                Console.WriteLine("Too much search, google has blocked your IP temprorily");
                return null;
            }

            var divs = doc.DocumentNode.SelectNodes("//h3[@class='r']");

            var links = divs?.Descendants("a")
                .Select(a => a.InnerText)
                .ToList();
            return links;
        }
    }
}
