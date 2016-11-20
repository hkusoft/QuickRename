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
        /// <summary>
        /// This function returns if a file path is a directory or file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsDirectory(string filePath)
        {
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(filePath);
            //.Net 4.0+
            return attr.HasFlag(FileAttributes.Directory);
        }

        public static bool MoveFile(string src, string tgt)
        {
            try
            {
                var file = new FileInfo(src);
                file.MoveTo(tgt);
                return true;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }
        
        public static bool MoveDirectory(string src, string tgt)
        {
            try
            {
                FileSystem.MoveDirectory(src, tgt, UIOption.AllDialogs);
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public static bool MoveDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                foreach (DirectoryInfo dir in source.GetDirectories())
                    MoveDirectory(dir, target.CreateSubdirectory(dir.Name));
                foreach (FileInfo file in source.GetFiles())
                    file.MoveTo(Path.Combine(target.FullName, file.Name));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static string[] ReadTextFile(string fileName)
        {
            string txt = File.ReadAllText(fileName);
            string[] output = txt.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            return output;
        }

        public static List<string> GoogleSearch(string keyword)
        {
            return new GoogleWebSearcher().Search(keyword);
        }

        public static List<string> BingSearch(string keyword)
        {
            return new BingWebSearcher().Search(keyword);
        }

        public static IList<string> GetPdfTitle(string pdfFilePath)
        {
            return new PdfSearcher().Search(pdfFilePath);
        }

        public static string ReplaceAll(this string seed, char[] chars, char replacementCharacter)
        {
            return chars.Aggregate(seed, (str, cItem) => str.Replace(cItem, replacementCharacter));
        }

        public static string GetLongestCommonSubstring(this IList<string> strings)
        {
            if (strings == null)
                throw new ArgumentNullException("strings");
            if (!strings.Any() || strings.Any(s => string.IsNullOrEmpty(s)))
                throw new ArgumentException("None string must be empty", "strings");

            var commonSubstrings = new HashSet<string>(strings[0].GetSubstrings());
            foreach (string str in strings.Skip(1))
            {
                commonSubstrings.IntersectWith(str.GetSubstrings());
                if (commonSubstrings.Count == 0)
                    return null;
            }
            return commonSubstrings.OrderByDescending(s => s.Length).First();
        }

        public static IEnumerable<string> GetSubstrings(this string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("str must not be null or empty", "str");

            for (int c = 0; c < str.Length - 1; c++)
            {
                for (int cc = 1; c + cc <= str.Length; cc++)
                {
                    yield return str.Substring(c, cc);
                }
            }
        }


        /// <summary>
        /// This function finds the last index of the "symbol" and if found
        /// the input string from beginning to this found index is kept, and 
        /// the rest is trimmed.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static string TrimAfter(string input, string symbol)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            int pos = input.LastIndexOf(symbol, StringComparison.CurrentCultureIgnoreCase);
            if (pos != -1)
                return input.Substring(0, pos);

            return input;
        }

        public static string CleanInvalidChars(string input)
        {
            var invalidChars = Path.GetInvalidFileNameChars();

            if(input.IndexOfAny(invalidChars) == -1)
                return input;

            foreach (var c in invalidChars)
            {
                input = input.Replace(c.ToString(), "");
            }
            return input;
        }
    }
}
