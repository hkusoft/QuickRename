﻿using HtmlAgilityPack;
using Newtonsoft.Json;
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

        private static string template = @"http://www.bing.com/search?q={0}";    // Old one, no longer works
        //private static string template = @"https://api.cognitive.microsoft.com/bing/v5.0/search?q={0}&count=5&offset=0&mkt=en-us&safesearch=Moderate";
        private static HtmlWeb web = new HtmlWeb();

        //Ocp-Apim-Subscription-Key
        private static string SubscriptionKey = "1763fff52c254801a175674b061e0b34";

        /// <summary>
        /// This function returns the textual (not the link) representation of the search
        /// </summary>
        /// <param name="queryFilePath">The keyword to search</param>
        /// <returns>A list of searching result texts that relates to the queryFilePath text.</returns>
        public List<string> Search(string queryFilePath)
        {
            string url = string.Format(template, queryFilePath);
            HtmlDocument doc = web.Load(url);
            var divs = doc.DocumentNode.SelectNodes("//h2");

            var links = divs?.Descendants("a")
                .Select(a => a.InnerText)
                .ToList();
            return links;

            //var json = BingSearch(queryFilePath);
            //var result = JsonConvert.DeserializeObject<Rootobject>(json);

            //return result?.webPages.value.Select(item => item.name).ToList();
            
            
        }



        public string BingSearch(string keywords)
        {
            string JsonString = null;
            string url = string.Format(template, keywords);

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.AcceptLanguage] = "es-ES";
                //client.Headers[HttpRequestHeader.UserAgent] = "some user agent if you wish";
                client.Headers["Ocp-Apim-Subscription-Key"] = SubscriptionKey;
                string html = client.DownloadString(url);
                // feed the HTML to HTML Agility Pack
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                JsonString = doc.DocumentNode.InnerText;
                return JsonString;
            }
        }
    }
}


/// <summary>
/// Embeded classes for serialization of Bing search results json string
/// </summary>
public class Rootobject
{
    public string _type { get; set; }
    public Webpages webPages { get; set; }
    public Rankingresponse rankingResponse { get; set; }
}

public class Webpages
{
    public string webSearchUrl { get; set; }
    public int totalEstimatedMatches { get; set; }
    public Value[] value { get; set; }
}

public class Value
{
    public string id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string displayUrl { get; set; }
    public string snippet { get; set; }
    public DateTime dateLastCrawled { get; set; }
}

public class Rankingresponse
{
    public Mainline mainline { get; set; }
}

public class Mainline
{
    public Item[] items { get; set; }
}

public class Item
{
    public string answerType { get; set; }
    public int resultIndex { get; set; }
    public Value1 value { get; set; }
}

public class Value1
{    public string id { get; set; }
}
