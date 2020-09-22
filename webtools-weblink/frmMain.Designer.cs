namespace WebToolsWebLink
{
    partial class frmMain
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.recursiveCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkMapTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.deepScanCheckbox = new System.Windows.Forms.CheckBox();
            this.anaylyzeButton = new System.Windows.Forms.Button();
            this.domainInput = new System.Windows.Forms.TextBox();
            this.maxConcurrencyInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWorking = new System.Windows.Forms.Panel();
            this.imgWorking = new System.Windows.Forms.PictureBox();
            this.lblWorking = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTabDelimitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConcurrencyInput)).BeginInit();
            this.pnlWorking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWorking)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(359, 34);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "W3b L1nk";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditLabel
            // 
            this.creditLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.creditLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(0, 348);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(359, 13);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "Created by Vincent Lakatos";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.recursiveCheckbox);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.linkMapTreeView);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.deepScanCheckbox);
            this.pnlMain.Controls.Add(this.anaylyzeButton);
            this.pnlMain.Controls.Add(this.domainInput);
            this.pnlMain.Controls.Add(this.maxConcurrencyInput);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(359, 290);
            this.pnlMain.TabIndex = 3;
            // 
            // recursiveCheckbox
            // 
            this.recursiveCheckbox.AutoSize = true;
            this.recursiveCheckbox.Checked = true;
            this.recursiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recursiveCheckbox.Location = new System.Drawing.Point(5, 47);
            this.recursiveCheckbox.Name = "recursiveCheckbox";
            this.recursiveCheckbox.Size = new System.Drawing.Size(74, 17);
            this.recursiveCheckbox.TabIndex = 1;
            this.recursiveCheckbox.Text = "Recursive";
            this.recursiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Concurrency";
            // 
            // linkMapTreeView
            // 
            this.linkMapTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkMapTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkMapTreeView.Location = new System.Drawing.Point(5, 98);
            this.linkMapTreeView.Name = "linkMapTreeView";
            this.linkMapTreeView.Size = new System.Drawing.Size(349, 158);
            this.linkMapTreeView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Found Uris";
            // 
            // deepScanCheckbox
            // 
            this.deepScanCheckbox.AutoSize = true;
            this.deepScanCheckbox.Location = new System.Drawing.Point(89, 47);
            this.deepScanCheckbox.Name = "deepScanCheckbox";
            this.deepScanCheckbox.Size = new System.Drawing.Size(86, 17);
            this.deepScanCheckbox.TabIndex = 2;
            this.deepScanCheckbox.Text = "Deep Scan?";
            this.deepScanCheckbox.UseVisualStyleBackColor = true;
            // 
            // anaylyzeButton
            // 
            this.anaylyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anaylyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaylyzeButton.Location = new System.Drawing.Point(5, 262);
            this.anaylyzeButton.Name = "anaylyzeButton";
            this.anaylyzeButton.Size = new System.Drawing.Size(349, 23);
            this.anaylyzeButton.TabIndex = 6;
            this.anaylyzeButton.Text = "Analyze";
            this.anaylyzeButton.UseVisualStyleBackColor = true;
            // 
            // domainInput
            // 
            this.domainInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainInput.Location = new System.Drawing.Point(5, 21);
            this.domainInput.Name = "domainInput";
            this.domainInput.Size = new System.Drawing.Size(349, 20);
            this.domainInput.TabIndex = 0;
            // 
            // maxConcurrencyInput
            // 
            this.maxConcurrencyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxConcurrencyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxConcurrencyInput.Location = new System.Drawing.Point(299, 46);
            this.maxConcurrencyInput.Name = "maxConcurrencyInput";
            this.maxConcurrencyInput.Size = new System.Drawing.Size(55, 20);
            this.maxConcurrencyInput.TabIndex = 4;
            this.maxConcurrencyInput.ThousandsSeparator = true;
            this.maxConcurrencyInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website Uri (http://site.example or https://site.example):";
            // 
            // pnlWorking
            // 
            this.pnlWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorking.BackColor = System.Drawing.Color.White;
            this.pnlWorking.Controls.Add(this.imgWorking);
            this.pnlWorking.Controls.Add(this.lblWorking);
            this.pnlWorking.Location = new System.Drawing.Point(0, 57);
            this.pnlWorking.Name = "pnlWorking";
            this.pnlWorking.Size = new System.Drawing.Size(359, 291);
            this.pnlWorking.TabIndex = 5;
            this.pnlWorking.Visible = false;
            // 
            // imgWorking
            // 
            this.imgWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgWorking.Location = new System.Drawing.Point(0, 0);
            this.imgWorking.Name = "imgWorking";
            this.imgWorking.Size = new System.Drawing.Size(359, 242);
            this.imgWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgWorking.TabIndex = 0;
            this.imgWorking.TabStop = false;
            // 
            // lblWorking
            // 
            this.lblWorking.BackColor = System.Drawing.Color.SteelBlue;
            this.lblWorking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorking.ForeColor = System.Drawing.Color.White;
            this.lblWorking.Location = new System.Drawing.Point(0, 242);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Padding = new System.Windows.Forms.Padding(5);
            this.lblWorking.Size = new System.Drawing.Size(359, 49);
            this.lblWorking.TabIndex = 1;
            this.lblWorking.Text = "Working";
            this.lblWorking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(359, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVToolStripMenuItem,
            this.exportToTabDelimitedToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exportToCSVToolStripMenuItem.Text = "CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // exportToTabDelimitedToolStripMenuItem
            // 
            this.exportToTabDelimitedToolStripMenuItem.Name = "exportToTabDelimitedToolStripMenuItem";
            this.exportToTabDelimitedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exportToTabDelimitedToolStripMenuItem.Text = "Tab Delimited";
            this.exportToTabDelimitedToolStripMenuItem.Click += new System.EventHandler(this.exportToTabDelimitedToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 361);
            this.Controls.Add(this.pnlWorking);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(375, 400);
            this.Name = "frmMain";
            this.Text = "W3b L1nk";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConcurrencyInput)).EndInit();
            this.pnlWorking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgWorking)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button anaylyzeButton;
        private System.Windows.Forms.TextBox domainInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox deepScanCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView linkMapTreeView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxConcurrencyInput;
        private System.Windows.Forms.Panel pnlWorking;
        private System.Windows.Forms.PictureBox imgWorking;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.CheckBox recursiveCheckbox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTabDelimitedToolStripMenuItem;
    }
}

