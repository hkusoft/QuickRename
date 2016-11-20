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
        public List<string> Search(string queryFilePath)
        {
            List<string> output = new List<string>();
            try
            {
                PdfReader document = new PdfReader(queryFilePath);
                var info = document.Info;
                document.Close();
                if (info != null)
                    if (info.ContainsKey("title"))
                        output.Add(info["title"]);
                    else if (info.ContainsKey("Title"))
                        output.Add(info["Title"]);                
            }
            catch (System.Exception)
            {

            }
            return output;
        }
    }
}
