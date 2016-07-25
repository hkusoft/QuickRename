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
    class GoogleSearcher : ISearchProvider
    {
        private static string template = @"https://www.google.com.hk/search?q={0}";
        private static HtmlWeb web = new HtmlWeb();

        /// <summary>
        /// This function returns the textual (not the link) representation of the search
        /// </summary>
        /// <param name="queryFilePath">The keyword to search</param>
        /// <returns>A list of searching result texts that relates to the queryFilePath text.</returns>
        public IList<string> Search(string queryFilePath)
        {
            string url = string.Format(template, queryFilePath);
            HtmlDocument doc = web.Load(url);
            var divs = doc.DocumentNode.SelectNodes("//h3[@class='r']");

            var links = divs?.Descendants("a")
                .Select(a => a.InnerText)
                .ToList();
            return links;
        }
    }
}
