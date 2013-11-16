namespace CSV_Splitter
{
    partial class CSVSplitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVSplitter));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileToSplit = new System.Windows.Forms.TextBox();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recordsToSplitLabel = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordsToSplit = new System.Windows.Forms.TextBox();
            this.firstRowIsHeader = new System.Windows.Forms.CheckBox();
            this.copyHeaders = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.Filter = "Coma Separated Values|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(275, 202);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(196, 202);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File to Split";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose the location for your files";
            this.folderBrowserDialog1.SelectedPath = "C:\\Users";
            // 
            // fileToSplit
            // 
            this.fileToSplit.Location = new System.Drawing.Point(129, 65);
            this.fileToSplit.Name = "fileToSplit";
            this.fileToSplit.Size = new System.Drawing.Size(221, 20);
            this.fileToSplit.TabIndex = 3;
            this.fileToSplit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileToSplit_MouseClick);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(129, 91);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(221, 20);
            this.saveLocation.TabIndex = 5;
            this.saveLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveLocation_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location for Split files";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "This program is intedend to split one CSV into many CSV files for a given number " +
                "you specify. You can also choose the location for your saved files.";
            // 
            // recordsToSplitLabel
            // 
            this.recordsToSplitLabel.AutoSize = true;
            this.recordsToSplitLabel.Location = new System.Drawing.Point(12, 122);
            this.recordsToSplitLabel.Name = "recordsToSplitLabel";
            this.recordsToSplitLabel.Size = new System.Drawing.Size(82, 13);
            this.recordsToSplitLabel.TabIndex = 7;
            this.recordsToSplitLabel.Text = "Records to Split";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 237);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(378, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // recordsToSplit
            // 
            this.recordsToSplit.Location = new System.Drawing.Point(129, 119);
            this.recordsToSplit.Name = "recordsToSplit";
            this.recordsToSplit.Size = new System.Drawing.Size(100, 20);
            this.recordsToSplit.TabIndex = 9;
            this.recordsToSplit.TextChanged += new System.EventHandler(this.recordsToSplit_TextChanged);
            // 
            // firstRowIsHeader
            // 
            this.firstRowIsHeader.AutoSize = true;
            this.firstRowIsHeader.Checked = true;
            this.firstRowIsHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstRowIsHeader.Location = new System.Drawing.Point(15, 156);
            this.firstRowIsHeader.Name = "firstRowIsHeader";
            this.firstRowIsHeader.Size = new System.Drawing.Size(177, 17);
            this.firstRowIsHeader.TabIndex = 10;
            this.firstRowIsHeader.Text = "First row in Source file is Header";
            this.firstRowIsHeader.UseVisualStyleBackColor = true;
            this.firstRowIsHeader.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // copyHeaders
            // 
            this.copyHeaders.AutoSize = true;
            this.copyHeaders.Location = new System.Drawing.Point(15, 179);
            this.copyHeaders.Name = "copyHeaders";
            this.copyHeaders.Size = new System.Drawing.Size(160, 17);
            this.copyHeaders.TabIndex = 11;
            this.copyHeaders.Text = "Copy Headers into Split Files";
            this.copyHeaders.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 231);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 30);
            this.listBox1.TabIndex = 12;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 9);
            this.label4.TabIndex = 13;
            this.label4.Text = "by RJ Palombo";
            // 
            // CSVSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copyHeaders);
            this.Controls.Add(this.firstRowIsHeader);
            this.Controls.Add(this.recordsToSplit);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.recordsToSplitLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileToSplit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.close);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSVSplitter";
            this.Text = "CSV Splitter";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox fileToSplit;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label recordsToSplitLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox recordsToSplit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox firstRowIsHeader;
        private System.Windows.Forms.CheckBox copyHeaders;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}

