using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.X509;
using QuickRename.Searcher;

namespace QuickRename
{
    internal static class utils
    {

        static string[] ReadTextFile(string fileName)
        {
            string txt = File.ReadAllText(fileName);
            string[] output = txt.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return output;
        }

        static IList<string> GoogleSearch(string keyword)
        {
            return new GoogleSearcher().Search(keyword);
        }

        static IList<string> GetPdfTitle(string pdfFilePath)
        {
            return new PdfSearcher().Search(pdfFilePath);
        } 
    }
}
