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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TrimAfterColon = new System.Windows.Forms.ToolStripButton();
            this.TrimAfterComma = new System.Windows.Forms.ToolStripButton();
            this.TrimAfterHyphen = new System.Windows.Forms.ToolStripButton();
            this.TrimAfterSemiColon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CustomWordsCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClearInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RemoveCustomWord = new System.Windows.Forms.ToolStripButton();
            this.TrimAfterCustomString = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputListBox
            // 
            this.InputListBox.AllowDrop = true;
            this.InputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputListBox.FormattingEnabled = true;
            this.InputListBox.ItemHeight = 21;
            this.InputListBox.Location = new System.Drawing.Point(3, 36);
            this.InputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputListBox.Name = "InputListBox";
            this.InputListBox.Size = new System.Drawing.Size(527, 521);
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
            this.OutputListBox.Location = new System.Drawing.Point(536, 36);
            this.OutputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(528, 521);
            this.OutputListBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.OutputListBox, "Trim words after custom string\\n in the left combo");
            this.OutputListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OutputListBox_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.InputListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OutputListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 561);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TrimAfterColon,
            this.TrimAfterComma,
            this.TrimAfterHyphen,
            this.TrimAfterSemiColon,
            this.toolStripSeparator1,
            this.CustomWordsCombo,
            this.TrimAfterCustomString,
            this.RemoveCustomWord});
            this.toolStrip2.Location = new System.Drawing.Point(533, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(534, 32);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 6, 2, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(189, 24);
            this.toolStripLabel1.Text = "Double Click to rename";
            this.toolStripLabel1.ToolTipText = "Double Click an item to rename with that string";
            // 
            // TrimAfterColon
            // 
            this.TrimAfterColon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TrimAfterColon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrimAfterColon.Image = ((System.Drawing.Image)(resources.GetObject("TrimAfterColon.Image")));
            this.TrimAfterColon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrimAfterColon.Margin = new System.Windows.Forms.Padding(5, 5, 0, 2);
            this.TrimAfterColon.Name = "TrimAfterColon";
            this.TrimAfterColon.Size = new System.Drawing.Size(34, 25);
            this.TrimAfterColon.Text = "■:";
            this.TrimAfterColon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TrimAfterColon.ToolTipText = "Trim string after :";
            this.TrimAfterColon.Click += new System.EventHandler(this.TrimAfterColon_Click);
            // 
            // TrimAfterComma
            // 
            this.TrimAfterComma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TrimAfterComma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrimAfterComma.Image = ((System.Drawing.Image)(resources.GetObject("TrimAfterComma.Image")));
            this.TrimAfterComma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrimAfterComma.Margin = new System.Windows.Forms.Padding(5, 5, 0, 2);
            this.TrimAfterComma.Name = "TrimAfterComma";
            this.TrimAfterComma.Size = new System.Drawing.Size(34, 25);
            this.TrimAfterComma.Text = "■,";
            this.TrimAfterComma.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TrimAfterComma.ToolTipText = "Trim string after ,";
            this.TrimAfterComma.Click += new System.EventHandler(this.TrimAfterComma_Click);
            // 
            // TrimAfterHyphen
            // 
            this.TrimAfterHyphen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TrimAfterHyphen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrimAfterHyphen.Image = ((System.Drawing.Image)(resources.GetObject("TrimAfterHyphen.Image")));
            this.TrimAfterHyphen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrimAfterHyphen.Margin = new System.Windows.Forms.Padding(5, 5, 0, 2);
            this.TrimAfterHyphen.Name = "TrimAfterHyphen";
            this.TrimAfterHyphen.Size = new System.Drawing.Size(36, 25);
            this.TrimAfterHyphen.Text = "■-";
            this.TrimAfterHyphen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TrimAfterHyphen.ToolTipText = "Trim string after -";
            this.TrimAfterHyphen.Click += new System.EventHandler(this.TrimAfterHyphen_Click);
            // 
            // TrimAfterSemiColon
            // 
            this.TrimAfterSemiColon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TrimAfterSemiColon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrimAfterSemiColon.Image = ((System.Drawing.Image)(resources.GetObject("TrimAfterSemiColon.Image")));
            this.TrimAfterSemiColon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrimAfterSemiColon.Margin = new System.Windows.Forms.Padding(5, 5, 0, 2);
            this.TrimAfterSemiColon.Name = "TrimAfterSemiColon";
            this.TrimAfterSemiColon.Size = new System.Drawing.Size(34, 25);
            this.TrimAfterSemiColon.Text = "■;";
            this.TrimAfterSemiColon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TrimAfterSemiColon.ToolTipText = "Trim string after ;";
            this.TrimAfterSemiColon.Click += new System.EventHandler(this.TrimAfterSemiColon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // CustomWordsCombo
            // 
            this.CustomWordsCombo.Name = "CustomWordsCombo";
            this.CustomWordsCombo.Size = new System.Drawing.Size(100, 32);
            this.CustomWordsCombo.Text = "toolStripButton2";
            this.CustomWordsCombo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomWordsCombo_KeyUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInput,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 31);
            this.toolStrip1.TabIndex = 2;
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
            // RemoveCustomWord
            // 
            this.RemoveCustomWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveCustomWord.Image = ((System.Drawing.Image)(resources.GetObject("RemoveCustomWord.Image")));
            this.RemoveCustomWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveCustomWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveCustomWord.Name = "RemoveCustomWord";
            this.RemoveCustomWord.Size = new System.Drawing.Size(36, 29);
            this.RemoveCustomWord.Text = "toolStripButton1";
            this.RemoveCustomWord.Click += new System.EventHandler(this.RemoveCustomWord_Click);
            // 
            // TrimAfterCustomString
            // 
            this.TrimAfterCustomString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TrimAfterCustomString.Image = ((System.Drawing.Image)(resources.GetObject("TrimAfterCustomString.Image")));
            this.TrimAfterCustomString.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TrimAfterCustomString.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrimAfterCustomString.Name = "TrimAfterCustomString";
            this.TrimAfterCustomString.Size = new System.Drawing.Size(36, 29);
            this.TrimAfterCustomString.ToolTipText = "Trim words after \r\nCustom String\r\nShown in left combo\r\n<----\r\n";
            this.TrimAfterCustomString.Click += new System.EventHandler(this.TrimAfterCustomString_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 561);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InputListBox;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ClearInput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton TrimAfterColon;
        private System.Windows.Forms.ToolStripButton TrimAfterComma;
        private System.Windows.Forms.ToolStripButton TrimAfterHyphen;
        private System.Windows.Forms.ToolStripButton TrimAfterSemiColon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripComboBox CustomWordsCombo;
        private System.Windows.Forms.ToolStripButton RemoveCustomWord;
        private System.Windows.Forms.ToolStripButton TrimAfterCustomString;
    }
}

