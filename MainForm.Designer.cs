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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputListBox = new System.Windows.Forms.ListBox();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClearInput = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.PinToTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.InputListBox.Size = new System.Drawing.Size(385, 513);
            this.InputListBox.TabIndex = 0;
            this.InputListBox.SelectedIndexChanged += new System.EventHandler(this.InputListBox_SelectedIndexChanged);
            this.InputListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputListBox_DragDrop);
            this.InputListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputListBox_DragEnter);
            // 
            // OutputListBox
            // 
            this.OutputListBox.AllowDrop = true;
            this.OutputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 21;
            this.OutputListBox.Location = new System.Drawing.Point(394, 36);
            this.OutputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(385, 513);
            this.OutputListBox.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 553);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInput,
            this.PinToTop,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(391, 32);
            this.toolStrip1.TabIndex = 2;
            // 
            // ClearInput
            // 
            this.ClearInput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ClearInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearInput.Image = ((System.Drawing.Image)(resources.GetObject("ClearInput.Image")));
            this.ClearInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(36, 29);
            this.ClearInput.Text = "Clear input list";
            this.ClearInput.Click += new System.EventHandler(this.ClearInput_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(391, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(391, 28);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // PinToTop
            // 
            this.PinToTop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PinToTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PinToTop.Image = ((System.Drawing.Image)(resources.GetObject("PinToTop.Image")));
            this.PinToTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PinToTop.Name = "PinToTop";
            this.PinToTop.Size = new System.Drawing.Size(36, 29);
            this.PinToTop.Text = "Pin to top";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 6, 2, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(322, 20);
            this.toolStripLabel1.Text = "Double Click an item to rename with that string";
            this.toolStripLabel1.ToolTipText = "Double Click an item to rename with that string";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(2, 6, 0, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(169, 24);
            this.toolStripLabel2.Text = "Drag & drop files/folders ";
            this.toolStripLabel2.ToolTipText = "Double Click an item to rename with that string";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Quick Rename";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InputListBox;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ClearInput;
        private System.Windows.Forms.ToolStripButton PinToTop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

