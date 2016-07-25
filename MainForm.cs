using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRename
{
    public partial class MainForm : Form
    {
        List<string> InputFilePaths;
        Dictionary<string, IList<string>> SearchResults = new Dictionary<string, IList<string>>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InputListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;

        }

        private void InputListBox_DragDrop(object sender, DragEventArgs e)
        {
            SearchResults.Clear();

            InputFilePaths = (e.Data.GetData(DataFormats.FileDrop, false) as string[]).ToList();
            InputListBox.DataSource = InputFilePaths;

            if (InputFilePaths == null || InputFilePaths.Count == 0)
                return;

            Process();
        }

        /// <summary>
        /// This function searches the given file's name (without ext) using:
        ///     - Google Web Search
        ///     - PDF search title (using iTextSharp)
        ///     - Other means
        ///     
        /// The results are saved in 
        ///     Dictionary<string, IList<string>> SearchResults
        /// where the key is the file name, and the value is a list of strings searched, which 
        /// is regarded as the target name to replace the input file anme
        /// </summary>
        /// <param name="filePath">The file/folder path to be searched</param>
        Task ProcessItem(string filePath)
        {
            //Using task to avoid UI blocking
            return Task.Factory.StartNew(() =>
            {
                string title = Path.GetFileNameWithoutExtension(filePath); //item.ToString()); //Name only
                var results = utils.GoogleSearch(title);

                var otherTitles = utils.GetPdfTitle(filePath);
                foreach (string item in otherTitles)
                    results.Add(item);

                //---------------------------------------------
                char[] invalidPathChars = Path.GetInvalidPathChars();
                results = results.Select(item => item.ReplaceAll(invalidPathChars, ' ')).ToList();
                //---------------------------------------------
                if (results != null)
                    SearchResults[filePath] = results;
            });
        }

        /// <summary>
        /// This function processes a list of file paths by searching with google, pdf meta info extraction etc.
        /// </summary>
        private void Process()
        {
            //Each item is the full path of a file/folder
            var inputs = InputListBox.Items.Cast<string>();
            Parallel.ForEach(inputs, (item, state, i) => ProcessItem(item));
        }

        private void InputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputListBox.DataSource = null;
            string item = InputListBox.SelectedItem as string;
            if (item != null)
            {
                if (SearchResults.ContainsKey(item))
                {
                    var results = SearchResults[item];
                    OutputListBox.DataSource = results;
                }
            }
            else
            {
                OutputListBox.DataSource = null;
            }

        }

        private void ClearInput_Click(object sender, EventArgs e)
        {
            InputListBox.DataSource = null;
            SearchResults.Clear();
        }

        private void PinToTop_Click(object sender, EventArgs e)
        {

        }

        private void OutputListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.OutputListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string targetName = OutputListBox.SelectedItem as string;
                string sourcePath = InputListBox.SelectedItem as string;
                string folder = Path.GetDirectoryName(sourcePath);
                string ext = Path.GetExtension(sourcePath);
                string targetPath = Path.Combine(folder, targetName) + ext;

                utils.MoveFile(sourcePath, targetPath);

                InputFilePaths.Remove(sourcePath);
                InputListBox.DataSource = null;
                InputListBox.DataSource = InputFilePaths;
            }
        }
    }
}
