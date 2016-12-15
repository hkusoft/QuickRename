using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRename
{
    public partial class MainForm : Form
    {
        List<string> InputFilePaths;
        Dictionary<string, IList<string>> SearchResults = new Dictionary<string, IList<string>>();

        StringCollection CustomWordsList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomWordsList = Properties.Settings.Default.CustomWordsList;

            InputListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            InputListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            
            OutputListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            OutputListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);

            //CustomWordsCombo.ComboBox.DataSource = Properties.Settings.Default.CustomWordsList;
            ////CustomWordsCombo.SelectedText = Properties.Settings.Default.CustomTrimSymbol;
            //CustomWordsCombo.ToolTipText =
            //    @"Input some string, after which the original string will be trimmed." + Environment.NewLine +
            //    @"e.g. if you type xxx here, 'SomeUsefulInfo xxx yyy' --> 'SomeUsefulInfo'";
            foreach (string toReplaceText in Properties.Settings.Default.CustomWordsList)
                AddTextButtonOnMiddleToolbar(toReplaceText);

        }

        void AddTextButtonOnMiddleToolbar(string ButtonCaption)
        {
            var button = new XButton(ButtonCaption);
            button.FirstButton.Click += (sender, args) => TrimAfter(ButtonCaption);                
            button.SecondButton.Click += (sender, args) => CustomWordsList.Remove(button.FirstButton.Text);
            MiddleToolbar.Controls.Add(button);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }


        private void MainForm_DragDrop(object sender, DragEventArgs e)
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
                List<string> results = new List<string>();

                bool IsItFolder = utils.IsDirectory(filePath);
                var title = IsItFolder ? Path.GetFileName(filePath) : Path.GetFileNameWithoutExtension(filePath); //Name only
                var ext = IsItFolder ? "" : Path.GetExtension(filePath);
                
                if (ext.Equals("pdf",StringComparison.CurrentCultureIgnoreCase))
                {
                    var otherTitles = utils.GetPdfTitle(filePath);
                    foreach (string item in otherTitles)
                        results.Add(item);
                }

                //Bing search is much better for this kind of search
                if(title.Count(dot =>dot.Equals('.')) >=2)  //An.Ov.of.No.Da                
                    results = utils.BingSearch(title);
                
                results.AddRange(utils.GoogleSearch(title));

                
                //---------------------------------------------
                char[] invalidPathChars = Path.GetInvalidPathChars();
                results = results.Select(item => utils.CleanInvalidChars(item)).ToList();
                
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
            Task firstTask = null;
            Parallel.ForEach(inputs, (item, state, i) =>
            {
                if (i == 0)
                    firstTask = ProcessItem(item);
                else
                    ProcessItem(item);

            });
            firstTask?.Wait();

            InputListBox.SelectedIndex = -1;
            InputListBox.SelectedIndex = 0;

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

        private void InputListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.OutputListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string sourcePath = InputListBox.SelectedItem as string;
                System.Diagnostics.Process.Start(sourcePath);

            }
        }

        private void OutputListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.OutputListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string targetName = OutputListBox.SelectedItem as string;
                string sourcePath = InputListBox.SelectedItem as string;
                string folder = Path.GetDirectoryName(sourcePath);

                if (!string.IsNullOrEmpty(targetName))
                {
                   
                    string ext = utils.IsDirectory(sourcePath) ? "" : Path.GetExtension(sourcePath);

                    string targetPath = Path.Combine(folder, targetName) + ext;

                    bool bSuccess = utils.MoveFile(sourcePath, targetPath);
                    if (bSuccess)
                    {
                        InputFilePaths.Remove(sourcePath);
                        InputListBox.DataSource = null;
                        InputListBox.DataSource = InputFilePaths;
                    }
                }
            }
        }

        private void TrimAfterComma_Click(object sender, EventArgs e)
        {
            TrimAfter(",");
        }

        void TrimAfter(string afterWhichString)
        {
            OutputListBox.DataSource = null;
            string item = InputListBox.SelectedItem as string;
            if (item != null)
            {
                if (SearchResults.ContainsKey(item))
                {
                    var results = SearchResults[item];
                    results = results.Select(entry => utils.TrimAfter(entry, afterWhichString)).ToList();
                    OutputListBox.DataSource = results;
                }
            }
            else
            {
                OutputListBox.DataSource = null;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
               

        private void OutputListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                var text = customWordTextBox.Text;
                customWordTextBox.Text = OutputListBox.SelectedItem.ToString();
            }
        }

        private void UseBingSearch_Click(object sender, EventArgs e)
        {
            UseBingSearch.Checked = !UseBingSearch.Checked;
        }

      

        private void customWordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var box = customWordTextBox;

            if (e.KeyCode == Keys.Enter)
            {
                var text = box.Text;
                if (!CustomWordsList.Contains(text))
                {
                    CustomWordsList.Add(box.Text);
                    AddTextButtonOnMiddleToolbar(box.Text);
                }
                box.Text = "";
            }

        }
    }
}
