namespace SumoTTP
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUnpackCancel = new System.Windows.Forms.Button();
            this.buttonUnpackOutPath = new System.Windows.Forms.Button();
            this.textBoxUnpackOutPath = new System.Windows.Forms.TextBox();
            this.textBoxUnpackTocPath = new System.Windows.Forms.TextBox();
            this.buttonUnpackTocPath = new System.Windows.Forms.Button();
            this.buttonUnpackStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPackCancel = new System.Windows.Forms.Button();
            this.buttonPackOutFolder = new System.Windows.Forms.Button();
            this.textBoxPackOutPath = new System.Windows.Forms.TextBox();
            this.textBoxPackInPath = new System.Windows.Forms.TextBox();
            this.buttonPackInFolder = new System.Windows.Forms.Button();
            this.buttonPackStart = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 144);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(341, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(226, 19);
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel.TextChanged += new System.EventHandler(this.ToolStripStatusLabel_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.1028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.8972F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 144);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(335, 138);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 110);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unpack Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonUnpackCancel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonUnpackOutPath, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUnpackOutPath, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUnpackTocPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonUnpackTocPath, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonUnpackStart, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 104);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonUnpackCancel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonUnpackCancel, 2);
            this.buttonUnpackCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUnpackCancel.Enabled = false;
            this.buttonUnpackCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnpackCancel.Location = new System.Drawing.Point(163, 71);
            this.buttonUnpackCancel.Name = "buttonUnpackCancel";
            this.buttonUnpackCancel.Size = new System.Drawing.Size(155, 30);
            this.buttonUnpackCancel.TabIndex = 6;
            this.buttonUnpackCancel.Text = "Cancel";
            this.buttonUnpackCancel.UseVisualStyleBackColor = true;
            this.buttonUnpackCancel.Click += new System.EventHandler(this.ButtonUnpackCancel_Click);
            // 
            // buttonUnpackOutPath
            // 
            this.buttonUnpackOutPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUnpackOutPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnpackOutPath.Location = new System.Drawing.Point(243, 37);
            this.buttonUnpackOutPath.Name = "buttonUnpackOutPath";
            this.buttonUnpackOutPath.Size = new System.Drawing.Size(75, 28);
            this.buttonUnpackOutPath.TabIndex = 4;
            this.buttonUnpackOutPath.Text = "Browse";
            this.buttonUnpackOutPath.UseVisualStyleBackColor = true;
            this.buttonUnpackOutPath.Click += new System.EventHandler(this.ButtonUnpackOutPath_Click);
            // 
            // textBoxUnpackOutPath
            // 
            this.textBoxUnpackOutPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxUnpackOutPath, 2);
            this.textBoxUnpackOutPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnpackOutPath.Location = new System.Drawing.Point(3, 39);
            this.textBoxUnpackOutPath.Name = "textBoxUnpackOutPath";
            this.textBoxUnpackOutPath.Size = new System.Drawing.Size(234, 23);
            this.textBoxUnpackOutPath.TabIndex = 3;
            this.textBoxUnpackOutPath.Text = "Choose an output folder";
            // 
            // textBoxUnpackTocPath
            // 
            this.textBoxUnpackTocPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxUnpackTocPath, 2);
            this.textBoxUnpackTocPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnpackTocPath.Location = new System.Drawing.Point(3, 5);
            this.textBoxUnpackTocPath.Name = "textBoxUnpackTocPath";
            this.textBoxUnpackTocPath.Size = new System.Drawing.Size(234, 23);
            this.textBoxUnpackTocPath.TabIndex = 1;
            this.textBoxUnpackTocPath.Text = "Select a TOC file";
            // 
            // buttonUnpackTocPath
            // 
            this.buttonUnpackTocPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUnpackTocPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnpackTocPath.Location = new System.Drawing.Point(243, 3);
            this.buttonUnpackTocPath.Name = "buttonUnpackTocPath";
            this.buttonUnpackTocPath.Size = new System.Drawing.Size(75, 28);
            this.buttonUnpackTocPath.TabIndex = 2;
            this.buttonUnpackTocPath.Text = "Browse";
            this.buttonUnpackTocPath.UseVisualStyleBackColor = true;
            this.buttonUnpackTocPath.Click += new System.EventHandler(this.ButtonUnpackTocPath_Click);
            // 
            // buttonUnpackStart
            // 
            this.buttonUnpackStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUnpackStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnpackStart.Location = new System.Drawing.Point(3, 71);
            this.buttonUnpackStart.Name = "buttonUnpackStart";
            this.buttonUnpackStart.Size = new System.Drawing.Size(154, 30);
            this.buttonUnpackStart.TabIndex = 5;
            this.buttonUnpackStart.Text = "Unpack";
            this.buttonUnpackStart.UseVisualStyleBackColor = true;
            this.buttonUnpackStart.Click += new System.EventHandler(this.ButtonUnpackStart_ClickAsync);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 110);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pack Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.buttonPackCancel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonPackOutFolder, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPackOutPath, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPackInPath, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPackInFolder, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPackStart, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 104);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buttonPackCancel
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.buttonPackCancel, 2);
            this.buttonPackCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPackCancel.Enabled = false;
            this.buttonPackCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPackCancel.Location = new System.Drawing.Point(163, 71);
            this.buttonPackCancel.Name = "buttonPackCancel";
            this.buttonPackCancel.Size = new System.Drawing.Size(155, 30);
            this.buttonPackCancel.TabIndex = 6;
            this.buttonPackCancel.Text = "Cancel";
            this.buttonPackCancel.UseVisualStyleBackColor = true;
            this.buttonPackCancel.Click += new System.EventHandler(this.ButtonPackCancel_Click);
            // 
            // buttonPackOutFolder
            // 
            this.buttonPackOutFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPackOutFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPackOutFolder.Location = new System.Drawing.Point(243, 37);
            this.buttonPackOutFolder.Name = "buttonPackOutFolder";
            this.buttonPackOutFolder.Size = new System.Drawing.Size(75, 28);
            this.buttonPackOutFolder.TabIndex = 4;
            this.buttonPackOutFolder.Text = "Browse";
            this.buttonPackOutFolder.UseVisualStyleBackColor = true;
            this.buttonPackOutFolder.Click += new System.EventHandler(this.ButtonPackOutFolder_Click);
            // 
            // textBoxPackOutPath
            // 
            this.textBoxPackOutPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxPackOutPath, 2);
            this.textBoxPackOutPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPackOutPath.Location = new System.Drawing.Point(3, 39);
            this.textBoxPackOutPath.Name = "textBoxPackOutPath";
            this.textBoxPackOutPath.Size = new System.Drawing.Size(234, 23);
            this.textBoxPackOutPath.TabIndex = 3;
            this.textBoxPackOutPath.Text = "Choose an output folder";
            // 
            // textBoxPackInPath
            // 
            this.textBoxPackInPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxPackInPath, 2);
            this.textBoxPackInPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPackInPath.Location = new System.Drawing.Point(3, 5);
            this.textBoxPackInPath.Name = "textBoxPackInPath";
            this.textBoxPackInPath.Size = new System.Drawing.Size(234, 23);
            this.textBoxPackInPath.TabIndex = 1;
            this.textBoxPackInPath.Text = "Select a folder to pack";
            // 
            // buttonPackInFolder
            // 
            this.buttonPackInFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPackInFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPackInFolder.Location = new System.Drawing.Point(243, 3);
            this.buttonPackInFolder.Name = "buttonPackInFolder";
            this.buttonPackInFolder.Size = new System.Drawing.Size(75, 28);
            this.buttonPackInFolder.TabIndex = 2;
            this.buttonPackInFolder.Text = "Browse";
            this.buttonPackInFolder.UseVisualStyleBackColor = true;
            this.buttonPackInFolder.Click += new System.EventHandler(this.ButtonPackInFolder_Click);
            // 
            // buttonPackStart
            // 
            this.buttonPackStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPackStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPackStart.Location = new System.Drawing.Point(3, 71);
            this.buttonPackStart.Name = "buttonPackStart";
            this.buttonPackStart.Size = new System.Drawing.Size(154, 30);
            this.buttonPackStart.TabIndex = 5;
            this.buttonPackStart.Text = "Pack";
            this.buttonPackStart.UseVisualStyleBackColor = true;
            this.buttonPackStart.Click += new System.EventHandler(this.ButtonPackStart_ClickAsync);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxAbout);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(327, 110);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAbout
            // 
            this.richTextBoxAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAbout.HideSelection = false;
            this.richTextBoxAbout.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxAbout.Name = "richTextBoxAbout";
            this.richTextBoxAbout.ReadOnly = true;
            this.richTextBoxAbout.Size = new System.Drawing.Size(321, 104);
            this.richTextBoxAbout.TabIndex = 0;
            this.richTextBoxAbout.Text = "SUMO Top Tier Packer V1.3\n\nMade by Tyapp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 168);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUMO Top Tier Packer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxUnpackTocPath;
        private System.Windows.Forms.Button buttonUnpackTocPath;
        private System.Windows.Forms.Button buttonUnpackCancel;
        private System.Windows.Forms.Button buttonUnpackOutPath;
        private System.Windows.Forms.TextBox textBoxUnpackOutPath;
        private System.Windows.Forms.Button buttonUnpackStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonPackCancel;
        private System.Windows.Forms.Button buttonPackOutFolder;
        private System.Windows.Forms.TextBox textBoxPackInPath;
        private System.Windows.Forms.Button buttonPackInFolder;
        private System.Windows.Forms.Button buttonPackStart;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RichTextBox richTextBoxAbout;
        private System.Windows.Forms.TextBox textBoxPackOutPath;
    }
}

