using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRename
{
    public partial class XButton : UserControl
    {
        public XButton()
        {
            InitializeComponent();
        }

        public XButton(string caption)
        {
            InitializeComponent();
            Caption = caption;
        }
        public string Caption
        {
            get { return CaptionButton.Text; }
            set { CaptionButton.Text = value; }
        }
        public Button FirstButton { get { return CaptionButton; } }
        public Button SecondButton { get { return CloseButton; } }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;
            parent.Controls.Remove(this);
        }
    }
}
