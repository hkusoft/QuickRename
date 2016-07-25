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

            var inputFilePaths = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            InputListBox.DataSource = inputFilePaths;

            if (inputFilePaths == null || inputFilePaths.Length == 0)
                return;

            //Process first item
            ProcessItem(inputFilePaths[0]);
            //Update UI
            InputListBox.SelectedIndex = -1;
            InputListBox.SelectedIndex = 0;

            //Process Other items
            Process();
        }

        void ProcessItem(string filePath)
        {
            string title = Path.GetFileNameWithoutExtension(filePath); //item.ToString()); //Name only
            var results = utils.GoogleSearch(title);
            if (results == null)
                results = utils.GetPdfTitle(filePath);
            if(results !=null)
                SearchResults[filePath] = results;
        }
        private void Process()
        {
            //Each item is the pull path of a file/folder
            var inputs = InputListBox.Items.Cast<string>();
            Parallel.ForEach(inputs, (item, state, i) =>
            {
                if (i != 0)
                    ProcessItem(item);             
            });
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
    }
}
