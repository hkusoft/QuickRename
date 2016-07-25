using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Org.BouncyCastle.Asn1.X509;
using QuickRename.Searcher;

namespace QuickRename
{
    internal static class utils
    {
        public static void MoveDirectory(string src, string tgt)
        {
            try
            {
                FileSystem.MoveDirectory(src, tgt, UIOption.AllDialogs);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        public static void MoveDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                foreach (DirectoryInfo dir in source.GetDirectories())
                    MoveDirectory(dir, target.CreateSubdirectory(dir.Name));
                foreach (FileInfo file in source.GetFiles())
                    file.MoveTo(Path.Combine(target.FullName, file.Name));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

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
