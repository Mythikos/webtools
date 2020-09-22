namespace WebToolsFuzzyLink
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
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imgWorking = new System.Windows.Forms.PictureBox();
            this.lblWorking = new System.Windows.Forms.Label();
            this.pnlWorking = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.uriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.webRequestReponseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bruteForcePanel = new System.Windows.Forms.Panel();
            this.bruteForceMaximumCharacters = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bruteForceMinimumCharacters = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bruteForceCharacterSetInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wordListPanel = new System.Windows.Forms.Panel();
            this.wordlistSelectButton = new System.Windows.Forms.Button();
            this.wordlistPathInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wordListRadioButton = new System.Windows.Forms.RadioButton();
            this.bruteForceRadioButton = new System.Windows.Forms.RadioButton();
            this.uriToFuzzInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxConcurrencyInput = new System.Windows.Forms.NumericUpDown();
            this.processButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgWorking)).BeginInit();
            this.pnlWorking.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webRequestReponseItemBindingSource)).BeginInit();
            this.bruteForcePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bruteForceMaximumCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bruteForceMinimumCharacters)).BeginInit();
            this.wordListPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConcurrencyInput)).BeginInit();
            this.SuspendLayout();
            // 
            // imgWorking
            // 
            this.imgWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgWorking.Location = new System.Drawing.Point(0, 0);
            this.imgWorking.Name = "imgWorking";
            this.imgWorking.Size = new System.Drawing.Size(464, 366);
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
            this.lblWorking.Location = new System.Drawing.Point(0, 366);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Padding = new System.Windows.Forms.Padding(5);
            this.lblWorking.Size = new System.Drawing.Size(464, 49);
            this.lblWorking.TabIndex = 1;
            this.lblWorking.Text = "Working";
            this.lblWorking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlWorking
            // 
            this.pnlWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorking.BackColor = System.Drawing.Color.White;
            this.pnlWorking.Controls.Add(this.imgWorking);
            this.pnlWorking.Controls.Add(this.lblWorking);
            this.pnlWorking.Location = new System.Drawing.Point(0, 0);
            this.pnlWorking.Name = "pnlWorking";
            this.pnlWorking.Size = new System.Drawing.Size(464, 415);
            this.pnlWorking.TabIndex = 10;
            this.pnlWorking.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlWorking);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.bruteForcePanel);
            this.pnlMain.Controls.Add(this.wordListPanel);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.processButton);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 34);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(464, 414);
            this.pnlMain.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 109);
            this.panel2.TabIndex = 3;
            // 
            // dataOutput
            // 
            this.dataOutput.AllowUserToAddRows = false;
            this.dataOutput.AllowUserToDeleteRows = false;
            this.dataOutput.AutoGenerateColumns = false;
            this.dataOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uriDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.errorDataGridViewTextBoxColumn,
            this.viewDataGridViewButtonColumn});
            this.dataOutput.DataSource = this.webRequestReponseItemBindingSource;
            this.dataOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOutput.Location = new System.Drawing.Point(0, 0);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.ReadOnly = true;
            this.dataOutput.RowHeadersVisible = false;
            this.dataOutput.Size = new System.Drawing.Size(454, 109);
            this.dataOutput.TabIndex = 0;
            // 
            // uriDataGridViewTextBoxColumn
            // 
            this.uriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uriDataGridViewTextBoxColumn.DataPropertyName = "Uri";
            this.uriDataGridViewTextBoxColumn.HeaderText = "Uri";
            this.uriDataGridViewTextBoxColumn.Name = "uriDataGridViewTextBoxColumn";
            this.uriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 65;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Error";
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorDataGridViewTextBoxColumn.Width = 54;
            // 
            // viewDataGridViewButtonColumn
            // 
            this.viewDataGridViewButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.viewDataGridViewButtonColumn.HeaderText = "View";
            this.viewDataGridViewButtonColumn.Name = "viewDataGridViewButtonColumn";
            this.viewDataGridViewButtonColumn.ReadOnly = true;
            this.viewDataGridViewButtonColumn.Text = "View";
            this.viewDataGridViewButtonColumn.Width = 36;
            // 
            // webRequestReponseItemBindingSource
            // 
            this.webRequestReponseItemBindingSource.AllowNew = false;
            this.webRequestReponseItemBindingSource.DataSource = typeof(WebToolsCore.Objects.Net.WebResponseItem);
            // 
            // bruteForcePanel
            // 
            this.bruteForcePanel.Controls.Add(this.bruteForceMaximumCharacters);
            this.bruteForcePanel.Controls.Add(this.label4);
            this.bruteForcePanel.Controls.Add(this.bruteForceMinimumCharacters);
            this.bruteForcePanel.Controls.Add(this.label5);
            this.bruteForcePanel.Controls.Add(this.bruteForceCharacterSetInput);
            this.bruteForcePanel.Controls.Add(this.label2);
            this.bruteForcePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bruteForcePanel.Location = new System.Drawing.Point(5, 150);
            this.bruteForcePanel.Name = "bruteForcePanel";
            this.bruteForcePanel.Size = new System.Drawing.Size(454, 127);
            this.bruteForcePanel.TabIndex = 18;
            this.bruteForcePanel.Visible = false;
            // 
            // bruteForceMaximumCharacters
            // 
            this.bruteForceMaximumCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bruteForceMaximumCharacters.Location = new System.Drawing.Point(295, 102);
            this.bruteForceMaximumCharacters.Name = "bruteForceMaximumCharacters";
            this.bruteForceMaximumCharacters.Size = new System.Drawing.Size(156, 20);
            this.bruteForceMaximumCharacters.TabIndex = 3;
            this.bruteForceMaximumCharacters.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximum characters";
            // 
            // bruteForceMinimumCharacters
            // 
            this.bruteForceMinimumCharacters.Location = new System.Drawing.Point(3, 102);
            this.bruteForceMinimumCharacters.Name = "bruteForceMinimumCharacters";
            this.bruteForceMinimumCharacters.Size = new System.Drawing.Size(156, 20);
            this.bruteForceMinimumCharacters.TabIndex = 2;
            this.bruteForceMinimumCharacters.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minimum characters";
            // 
            // bruteForceCharacterSetInput
            // 
            this.bruteForceCharacterSetInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bruteForceCharacterSetInput.Location = new System.Drawing.Point(3, 16);
            this.bruteForceCharacterSetInput.Multiline = true;
            this.bruteForceCharacterSetInput.Name = "bruteForceCharacterSetInput";
            this.bruteForceCharacterSetInput.Size = new System.Drawing.Size(448, 67);
            this.bruteForceCharacterSetInput.TabIndex = 1;
            this.bruteForceCharacterSetInput.Text = "abcdefghijklmnopqrstuvwxyz\r\nABCDEFGHIJKLMNOPQRSTUVWXYZ\r\n0123456789\r\n~` !@#$%^&*()" +
    "_+-={}[]:\";\'<>,.?/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Character Set";
            // 
            // wordListPanel
            // 
            this.wordListPanel.Controls.Add(this.wordlistSelectButton);
            this.wordListPanel.Controls.Add(this.wordlistPathInput);
            this.wordListPanel.Controls.Add(this.label6);
            this.wordListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wordListPanel.Location = new System.Drawing.Point(5, 78);
            this.wordListPanel.Name = "wordListPanel";
            this.wordListPanel.Size = new System.Drawing.Size(454, 72);
            this.wordListPanel.TabIndex = 17;
            // 
            // wordlistSelectButton
            // 
            this.wordlistSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wordlistSelectButton.Location = new System.Drawing.Point(377, 41);
            this.wordlistSelectButton.Name = "wordlistSelectButton";
            this.wordlistSelectButton.Size = new System.Drawing.Size(75, 23);
            this.wordlistSelectButton.TabIndex = 2;
            this.wordlistSelectButton.Text = "Select";
            this.wordlistSelectButton.UseVisualStyleBackColor = true;
            // 
            // wordlistPathInput
            // 
            this.wordlistPathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordlistPathInput.Location = new System.Drawing.Point(3, 19);
            this.wordlistPathInput.Name = "wordlistPathInput";
            this.wordlistPathInput.Size = new System.Drawing.Size(448, 20);
            this.wordlistPathInput.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Wordlist Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wordListRadioButton);
            this.panel1.Controls.Add(this.bruteForceRadioButton);
            this.panel1.Controls.Add(this.uriToFuzzInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maxConcurrencyInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 73);
            this.panel1.TabIndex = 13;
            // 
            // wordListRadioButton
            // 
            this.wordListRadioButton.AutoSize = true;
            this.wordListRadioButton.Checked = true;
            this.wordListRadioButton.Location = new System.Drawing.Point(3, 43);
            this.wordListRadioButton.Name = "wordListRadioButton";
            this.wordListRadioButton.Size = new System.Drawing.Size(70, 17);
            this.wordListRadioButton.TabIndex = 11;
            this.wordListRadioButton.TabStop = true;
            this.wordListRadioButton.Text = "Word List";
            this.wordListRadioButton.UseVisualStyleBackColor = true;
            // 
            // bruteForceRadioButton
            // 
            this.bruteForceRadioButton.AutoSize = true;
            this.bruteForceRadioButton.Location = new System.Drawing.Point(89, 43);
            this.bruteForceRadioButton.Name = "bruteForceRadioButton";
            this.bruteForceRadioButton.Size = new System.Drawing.Size(80, 17);
            this.bruteForceRadioButton.TabIndex = 12;
            this.bruteForceRadioButton.Text = "Brute Force";
            this.bruteForceRadioButton.UseVisualStyleBackColor = true;
            this.bruteForceRadioButton.Visible = false;
            // 
            // uriToFuzzInput
            // 
            this.uriToFuzzInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uriToFuzzInput.Location = new System.Drawing.Point(3, 19);
            this.uriToFuzzInput.Name = "uriToFuzzInput";
            this.uriToFuzzInput.Size = new System.Drawing.Size(448, 20);
            this.uriToFuzzInput.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Uri (http://site.example/?id=<<FUZZ>>):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 45);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Concurrency";
            // 
            // maxConcurrencyInput
            // 
            this.maxConcurrencyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxConcurrencyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxConcurrencyInput.Location = new System.Drawing.Point(396, 45);
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
            // processButton
            // 
            this.processButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processButton.Location = new System.Drawing.Point(5, 386);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(454, 23);
            this.processButton.TabIndex = 6;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            // 
            // creditLabel
            // 
            this.creditLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.creditLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(0, 448);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(464, 13);
            this.creditLabel.TabIndex = 7;
            this.creditLabel.Text = "Created by Vincent Lakatos";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(464, 34);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Fu77y L1nk";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 461);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.titleLabel);
            this.MinimumSize = new System.Drawing.Size(375, 350);
            this.Name = "frmMain";
            this.Text = "Fuzzy Link";
            ((System.ComponentModel.ISupportInitialize)(this.imgWorking)).EndInit();
            this.pnlWorking.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webRequestReponseItemBindingSource)).EndInit();
            this.bruteForcePanel.ResumeLayout(false);
            this.bruteForcePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bruteForceMaximumCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bruteForceMinimumCharacters)).EndInit();
            this.wordListPanel.ResumeLayout(false);
            this.wordListPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConcurrencyInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox imgWorking;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.Panel pnlWorking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel bruteForcePanel;
        private System.Windows.Forms.Panel wordListPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxConcurrencyInput;
        private System.Windows.Forms.RadioButton wordListRadioButton;
        private System.Windows.Forms.RadioButton bruteForceRadioButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox bruteForceCharacterSetInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bruteForceMaximumCharacters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bruteForceMinimumCharacters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button wordlistSelectButton;
        private System.Windows.Forms.TextBox wordlistPathInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox uriToFuzzInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.BindingSource webRequestReponseItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn viewDataGridViewButtonColumn;
    }
}

