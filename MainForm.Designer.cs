namespace QuickRename
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputListBox = new System.Windows.Forms.ListBox();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.TopToolbar = new System.Windows.Forms.ToolStrip();
            this.ClearInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.UseBingSearch = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Root = new System.Windows.Forms.SplitContainer();
            this.Top = new System.Windows.Forms.SplitContainer();
            this.Bottom = new System.Windows.Forms.SplitContainer();
            this.MiddleToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customWordTextBox = new System.Windows.Forms.TextBox();
            this.TopToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.Root.Panel1.SuspendLayout();
            this.Root.Panel2.SuspendLayout();
            this.Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            this.Top.Panel1.SuspendLayout();
            this.Top.Panel2.SuspendLayout();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom)).BeginInit();
            this.Bottom.Panel1.SuspendLayout();
            this.Bottom.Panel2.SuspendLayout();
            this.Bottom.SuspendLayout();
            this.MiddleToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputListBox
            // 
            this.InputListBox.AllowDrop = true;
            this.InputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputListBox.FormattingEnabled = true;
            this.InputListBox.ItemHeight = 21;
            this.InputListBox.Location = new System.Drawing.Point(0, 0);
            this.InputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputListBox.Name = "InputListBox";
            this.InputListBox.Size = new System.Drawing.Size(782, 274);
            this.InputListBox.TabIndex = 0;
            this.InputListBox.SelectedIndexChanged += new System.EventHandler(this.InputListBox_SelectedIndexChanged);
            this.InputListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.InputListBox_MouseDoubleClick);
            // 
            // OutputListBox
            // 
            this.OutputListBox.AllowDrop = true;
            this.OutputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 21;
            this.OutputListBox.Location = new System.Drawing.Point(0, 0);
            this.OutputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(782, 212);
            this.OutputListBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.OutputListBox, "Trim words after custom string\\n in the left combo");
            this.OutputListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputListBox_KeyPress);
            this.OutputListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OutputListBox_MouseDoubleClick);
            // 
            // TopToolbar
            // 
            this.TopToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopToolbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TopToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInput,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.UseBingSearch});
            this.TopToolbar.Location = new System.Drawing.Point(0, 0);
            this.TopToolbar.Name = "TopToolbar";
            this.TopToolbar.Size = new System.Drawing.Size(782, 31);
            this.TopToolbar.TabIndex = 2;
            // 
            // ClearInput
            // 
            this.ClearInput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ClearInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearInput.Image = ((System.Drawing.Image)(resources.GetObject("ClearInput.Image")));
            this.ClearInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearInput.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(28, 28);
            this.ClearInput.Text = "Clear input list";
            this.ClearInput.Click += new System.EventHandler(this.ClearInput_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(204, 27);
            this.toolStripLabel2.Text = "Drag && drop files/folders ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(-4, 4, 0, 2);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(24, 25);
            // 
            // UseBingSearch
            // 
            this.UseBingSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UseBingSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UseBingSearch.Image = ((System.Drawing.Image)(resources.GetObject("UseBingSearch.Image")));
            this.UseBingSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UseBingSearch.Name = "UseBingSearch";
            this.UseBingSearch.Size = new System.Drawing.Size(28, 28);
            this.UseBingSearch.Text = "toolStripButton1";
            this.UseBingSearch.Click += new System.EventHandler(this.UseBingSearch_Click);
            // 
            // Root
            // 
            this.Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Root.Panel1
            // 
            this.Root.Panel1.Controls.Add(this.Top);
            // 
            // Root.Panel2
            // 
            this.Root.Panel2.Controls.Add(this.Bottom);
            this.Root.Size = new System.Drawing.Size(782, 553);
            this.Root.SplitterDistance = 305;
            this.Root.TabIndex = 4;
            // 
            // Top
            // 
            this.Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top.IsSplitterFixed = true;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Top.Panel1
            // 
            this.Top.Panel1.Controls.Add(this.TopToolbar);
            // 
            // Top.Panel2
            // 
            this.Top.Panel2.Controls.Add(this.InputListBox);
            this.Top.Size = new System.Drawing.Size(782, 305);
            this.Top.SplitterDistance = 27;
            this.Top.TabIndex = 5;
            // 
            // Bottom
            // 
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bottom.IsSplitterFixed = true;
            this.Bottom.Location = new System.Drawing.Point(0, 0);
            this.Bottom.Name = "Bottom";
            this.Bottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Bottom.Panel1
            // 
            this.Bottom.Panel1.Controls.Add(this.MiddleToolbar);
            this.Bottom.Panel1MinSize = 28;
            // 
            // Bottom.Panel2
            // 
            this.Bottom.Panel2.Controls.Add(this.OutputListBox);
            this.Bottom.Size = new System.Drawing.Size(782, 244);
            this.Bottom.SplitterDistance = 28;
            this.Bottom.TabIndex = 5;
            // 
            // MiddleToolbar
            // 
            this.MiddleToolbar.Controls.Add(this.label1);
            this.MiddleToolbar.Controls.Add(this.customWordTextBox);
            this.MiddleToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleToolbar.Location = new System.Drawing.Point(0, 0);
            this.MiddleToolbar.Name = "MiddleToolbar";
            this.MiddleToolbar.Size = new System.Drawing.Size(782, 28);
            this.MiddleToolbar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Suffix";
            // 
            // customWordTextBox
            // 
            this.customWordTextBox.Location = new System.Drawing.Point(121, 0);
            this.customWordTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.customWordTextBox.Name = "customWordTextBox";
            this.customWordTextBox.Size = new System.Drawing.Size(150, 29);
            this.customWordTextBox.TabIndex = 1;            
            this.customWordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.customWordTextBox_KeyUp);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Root);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Quick Rename";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.TopToolbar.ResumeLayout(false);
            this.TopToolbar.PerformLayout();
            this.Root.Panel1.ResumeLayout(false);
            this.Root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.Root.ResumeLayout(false);
            this.Top.Panel1.ResumeLayout(false);
            this.Top.Panel1.PerformLayout();
            this.Top.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            this.Top.ResumeLayout(false);
            this.Bottom.Panel1.ResumeLayout(false);
            this.Bottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bottom)).EndInit();
            this.Bottom.ResumeLayout(false);
            this.MiddleToolbar.ResumeLayout(false);
            this.MiddleToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InputListBox;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.ToolStrip TopToolbar;
        private System.Windows.Forms.ToolStripButton ClearInput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer Root;
        private System.Windows.Forms.SplitContainer Bottom;
        private System.Windows.Forms.SplitContainer Top;
        private System.Windows.Forms.ToolStripButton UseBingSearch;
        private System.Windows.Forms.FlowLayoutPanel MiddleToolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customWordTextBox;
    }
}

