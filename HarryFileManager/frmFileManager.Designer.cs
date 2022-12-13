namespace HarryFileManager
{
    partial class frmFileManager
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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlPath = new System.Windows.Forms.Panel();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.splt = new System.Windows.Forms.SplitContainer();
            this.rtbAllFiles = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt)).BeginInit();
            this.splt.Panel1.SuspendLayout();
            this.splt.Panel2.SuspendLayout();
            this.splt.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.Location = new System.Drawing.Point(6, 6);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(1204, 26);
            this.txtFolderPath.TabIndex = 0;
            // 
            // pnlPath
            // 
            this.pnlPath.Controls.Add(this.btnSelectPath);
            this.pnlPath.Controls.Add(this.txtFolderPath);
            this.pnlPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPath.Location = new System.Drawing.Point(0, 0);
            this.pnlPath.Name = "pnlPath";
            this.pnlPath.Size = new System.Drawing.Size(1265, 37);
            this.pnlPath.TabIndex = 1;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.Location = new System.Drawing.Point(1215, 6);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(38, 26);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // splt
            // 
            this.splt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt.Location = new System.Drawing.Point(0, 37);
            this.splt.Name = "splt";
            // 
            // splt.Panel1
            // 
            this.splt.Panel1.Controls.Add(this.rtbAllFiles);
            this.splt.Panel1MinSize = 50;
            // 
            // splt.Panel2
            // 
            this.splt.Panel2.Controls.Add(this.rtbResult);
            this.splt.Size = new System.Drawing.Size(1265, 651);
            this.splt.SplitterDistance = 421;
            this.splt.TabIndex = 2;
            // 
            // rtbAllFiles
            // 
            this.rtbAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAllFiles.Location = new System.Drawing.Point(0, 0);
            this.rtbAllFiles.Name = "rtbAllFiles";
            this.rtbAllFiles.Size = new System.Drawing.Size(421, 651);
            this.rtbAllFiles.TabIndex = 0;
            this.rtbAllFiles.Text = "";
            // 
            // rtbResult
            // 
            this.rtbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResult.Location = new System.Drawing.Point(0, 0);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(840, 651);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnDeleteFile);
            this.pnlAction.Controls.Add(this.btnDeleteFolder);
            this.pnlAction.Controls.Add(this.btnSearch);
            this.pnlAction.Controls.Add(this.txtFilter);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Location = new System.Drawing.Point(0, 37);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(1265, 37);
            this.pnlAction.TabIndex = 3;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(1116, 5);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(137, 28);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "Delete &File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFolder.Location = new System.Drawing.Point(972, 5);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(137, 28);
            this.btnDeleteFolder.TabIndex = 2;
            this.btnDeleteFolder.Text = "&Delete Folder";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(828, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(6, 6);
            this.txtFilter.MaxLength = 200;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(816, 26);
            this.txtFilter.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.statusStrip1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 655);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1265, 33);
            this.pnlFooter.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 11);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1265, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(118, 17);
            this.tsStatus.Text = "toolStripStatusLabel1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // frmFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 688);
            this.Controls.Add(this.splt);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlPath);
            this.Name = "frmFileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.pnlPath.ResumeLayout(false);
            this.pnlPath.PerformLayout();
            this.splt.Panel1.ResumeLayout(false);
            this.splt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt)).EndInit();
            this.splt.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel pnlPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.SplitContainer splt;
        private System.Windows.Forms.RichTextBox rtbAllFiles;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

