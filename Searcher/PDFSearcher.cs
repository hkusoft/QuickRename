using System.Collections.Generic;
using System.IO;
using iTextSharp.text.pdf;

namespace QuickRename.Searcher
{
    /// <summary>
    /// This class performs a search using iTextSharp, to extract the title information for a given PDF file
    /// </summary>
    internal class PdfSearcher : ISearchProvider
    {
        public IList<string> Search(string queryFilePath)
        {
            if (!File.Exists(queryFilePath))
                return null;

            PdfReader document = new PdfReader(queryFilePath);
            var info = document.Info;
            document.Close();
            if (info != null && (info.ContainsKey("title") || info.ContainsKey("Title")))
                return new List<string>()
                {
                    info["Title"]
                };

            return null;
        }
    }
}
