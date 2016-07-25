using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderReanmeWithGoogle
{
    internal class PDFSearcher
    {
        internal static List<string> Search(string oldFilePath)
        {
            PdfReader document = new PdfReader(oldFilePath);
            if (document == null)
                return null;

            var info = document.Info;
            document.Close();
            if (info != null && (info.ContainsKey("title") || info.ContainsKey("Title")))
                return new List<string>() {
                    //Path.Combine(Path.GetDirectoryName(oldFilePath), info["Title"])
                    info["Title"]
                };
            

            return null;            
        }
    }
}
