namespace DumpViewer.Views.Forms
{
    partial class DumpHeaderView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDumpFileTime = new System.Windows.Forms.TextBox();
            this.textBoxDumpFileSize = new System.Windows.Forms.TextBox();
            this.textBoxMinorVersion = new System.Windows.Forms.TextBox();
            this.textBoxMajorVersion = new System.Windows.Forms.TextBox();
            this.textBoxProcessorsCount = new System.Windows.Forms.TextBox();
            this.textBoxFullPath = new System.Windows.Forms.TextBox();
            this.textBoxVersionArchitecture = new System.Windows.Forms.TextBox();
            this.textBoxProcessor = new System.Windows.Forms.TextBox();
            this.textBoxParameter4 = new System.Windows.Forms.TextBox();
            this.textBoxParameter3 = new System.Windows.Forms.TextBox();
            this.textBoxParameter2 = new System.Windows.Forms.TextBox();
            this.textBoxParameter1 = new System.Windows.Forms.TextBox();
            this.textBoxBugCheckCode = new System.Windows.Forms.TextBox();
            this.textBoxBugCheckString = new System.Windows.Forms.TextBox();
            this.textBoxDumpFile = new System.Windows.Forms.TextBox();
            this.labelDumpFileSize = new System.Windows.Forms.Label();
            this.labelDumpFileTime = new System.Windows.Forms.Label();
            this.labelMinorVersion = new System.Windows.Forms.Label();
            this.labelMajorVersion = new System.Windows.Forms.Label();
            this.labelProcessorsCount = new System.Windows.Forms.Label();
            this.labelFullPath = new System.Windows.Forms.Label();
            this.labelVersionArchitecture = new System.Windows.Forms.Label();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.labelParameter4 = new System.Windows.Forms.Label();
            this.labelParameter3 = new System.Windows.Forms.Label();
            this.labelParameter2 = new System.Windows.Forms.Label();
            this.labelParameter1 = new System.Windows.Forms.Label();
            this.labelBugCheckCode = new System.Windows.Forms.Label();
            this.labelBugCheckString = new System.Windows.Forms.Label();
            this.labelDumpFile = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBoxDumpFileTime);
            this.panel1.Controls.Add(this.textBoxDumpFileSize);
            this.panel1.Controls.Add(this.textBoxMinorVersion);
            this.panel1.Controls.Add(this.textBoxMajorVersion);
            this.panel1.Controls.Add(this.textBoxProcessorsCount);
            this.panel1.Controls.Add(this.textBoxFullPath);
            this.panel1.Controls.Add(this.textBoxVersionArchitecture);
            this.panel1.Controls.Add(this.textBoxProcessor);
            this.panel1.Controls.Add(this.textBoxParameter4);
            this.panel1.Controls.Add(this.textBoxParameter3);
            this.panel1.Controls.Add(this.textBoxParameter2);
            this.panel1.Controls.Add(this.textBoxParameter1);
            this.panel1.Controls.Add(this.textBoxBugCheckCode);
            this.panel1.Controls.Add(this.textBoxBugCheckString);
            this.panel1.Controls.Add(this.textBoxDumpFile);
            this.panel1.Controls.Add(this.labelDumpFileSize);
            this.panel1.Controls.Add(this.labelDumpFileTime);
            this.panel1.Controls.Add(this.labelMinorVersion);
            this.panel1.Controls.Add(this.labelMajorVersion);
            this.panel1.Controls.Add(this.labelProcessorsCount);
            this.panel1.Controls.Add(this.labelFullPath);
            this.panel1.Controls.Add(this.labelVersionArchitecture);
            this.panel1.Controls.Add(this.labelProcessor);
            this.panel1.Controls.Add(this.labelParameter4);
            this.panel1.Controls.Add(this.labelParameter3);
            this.panel1.Controls.Add(this.labelParameter2);
            this.panel1.Controls.Add(this.labelParameter1);
            this.panel1.Controls.Add(this.labelBugCheckCode);
            this.panel1.Controls.Add(this.labelBugCheckString);
            this.panel1.Controls.Add(this.labelDumpFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(739, 498);
            this.panel1.TabIndex = 1;
            this.panel1.VisibleChanged += new System.EventHandler(this.Panel1_VisibleChanged);
            // 
            // textBoxDumpFileTime
            // 
            this.textBoxDumpFileTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDumpFileTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDumpFileTime.Location = new System.Drawing.Point(374, 442);
            this.textBoxDumpFileTime.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxDumpFileTime.Name = "textBoxDumpFileTime";
            this.textBoxDumpFileTime.ReadOnly = true;
            this.textBoxDumpFileTime.Size = new System.Drawing.Size(169, 23);
            this.textBoxDumpFileTime.TabIndex = 29;
            // 
            // textBoxDumpFileSize
            // 
            this.textBoxDumpFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDumpFileSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDumpFileSize.Location = new System.Drawing.Point(374, 412);
            this.textBoxDumpFileSize.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxDumpFileSize.Name = "textBoxDumpFileSize";
            this.textBoxDumpFileSize.ReadOnly = true;
            this.textBoxDumpFileSize.Size = new System.Drawing.Size(169, 23);
            this.textBoxDumpFileSize.TabIndex = 28;
            // 
            // textBoxMinorVersion
            // 
            this.textBoxMinorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinorVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinorVersion.Location = new System.Drawing.Point(374, 382);
            this.textBoxMinorVersion.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxMinorVersion.Name = "textBoxMinorVersion";
            this.textBoxMinorVersion.ReadOnly = true;
            this.textBoxMinorVersion.Size = new System.Drawing.Size(169, 23);
            this.textBoxMinorVersion.TabIndex = 27;
            // 
            // textBoxMajorVersion
            // 
            this.textBoxMajorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMajorVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMajorVersion.Location = new System.Drawing.Point(374, 352);
            this.textBoxMajorVersion.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxMajorVersion.Name = "textBoxMajorVersion";
            this.textBoxMajorVersion.ReadOnly = true;
            this.textBoxMajorVersion.Size = new System.Drawing.Size(169, 23);
            this.textBoxMajorVersion.TabIndex = 26;
            // 
            // textBoxProcessorsCount
            // 
            this.textBoxProcessorsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcessorsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProcessorsCount.Location = new System.Drawing.Point(374, 322);
            this.textBoxProcessorsCount.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxProcessorsCount.Name = "textBoxProcessorsCount";
            this.textBoxProcessorsCount.ReadOnly = true;
            this.textBoxProcessorsCount.Size = new System.Drawing.Size(169, 23);
            this.textBoxProcessorsCount.TabIndex = 25;
            // 
            // textBoxFullPath
            // 
            this.textBoxFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullPath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullPath.Location = new System.Drawing.Point(374, 292);
            this.textBoxFullPath.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxFullPath.Name = "textBoxFullPath";
            this.textBoxFullPath.ReadOnly = true;
            this.textBoxFullPath.Size = new System.Drawing.Size(169, 23);
            this.textBoxFullPath.TabIndex = 24;
            // 
            // textBoxVersionArchitecture
            // 
            this.textBoxVersionArchitecture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVersionArchitecture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVersionArchitecture.Location = new System.Drawing.Point(374, 262);
            this.textBoxVersionArchitecture.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxVersionArchitecture.Name = "textBoxVersionArchitecture";
            this.textBoxVersionArchitecture.ReadOnly = true;
            this.textBoxVersionArchitecture.Size = new System.Drawing.Size(169, 23);
            this.textBoxVersionArchitecture.TabIndex = 23;
            // 
            // textBoxProcessor
            // 
            this.textBoxProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcessor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProcessor.Location = new System.Drawing.Point(374, 232);
            this.textBoxProcessor.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxProcessor.Name = "textBoxProcessor";
            this.textBoxProcessor.ReadOnly = true;
            this.textBoxProcessor.Size = new System.Drawing.Size(169, 23);
            this.textBoxProcessor.TabIndex = 22;
            // 
            // textBoxParameter4
            // 
            this.textBoxParameter4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParameter4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParameter4.Location = new System.Drawing.Point(374, 202);
            this.textBoxParameter4.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxParameter4.Name = "textBoxParameter4";
            this.textBoxParameter4.ReadOnly = true;
            this.textBoxParameter4.Size = new System.Drawing.Size(169, 23);
            this.textBoxParameter4.TabIndex = 21;
            // 
            // textBoxParameter3
            // 
            this.textBoxParameter3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParameter3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParameter3.Location = new System.Drawing.Point(374, 172);
            this.textBoxParameter3.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxParameter3.Name = "textBoxParameter3";
            this.textBoxParameter3.ReadOnly = true;
            this.textBoxParameter3.Size = new System.Drawing.Size(169, 23);
            this.textBoxParameter3.TabIndex = 20;
            // 
            // textBoxParameter2
            // 
            this.textBoxParameter2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParameter2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParameter2.Location = new System.Drawing.Point(374, 142);
            this.textBoxParameter2.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxParameter2.Name = "textBoxParameter2";
            this.textBoxParameter2.ReadOnly = true;
            this.textBoxParameter2.Size = new System.Drawing.Size(169, 23);
            this.textBoxParameter2.TabIndex = 19;
            // 
            // textBoxParameter1
            // 
            this.textBoxParameter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParameter1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParameter1.Location = new System.Drawing.Point(374, 112);
            this.textBoxParameter1.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxParameter1.Name = "textBoxParameter1";
            this.textBoxParameter1.ReadOnly = true;
            this.textBoxParameter1.Size = new System.Drawing.Size(169, 23);
            this.textBoxParameter1.TabIndex = 18;
            // 
            // textBoxBugCheckCode
            // 
            this.textBoxBugCheckCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBugCheckCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBugCheckCode.Location = new System.Drawing.Point(374, 82);
            this.textBoxBugCheckCode.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxBugCheckCode.Name = "textBoxBugCheckCode";
            this.textBoxBugCheckCode.ReadOnly = true;
            this.textBoxBugCheckCode.Size = new System.Drawing.Size(169, 23);
            this.textBoxBugCheckCode.TabIndex = 17;
            // 
            // textBoxBugCheckString
            // 
            this.textBoxBugCheckString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBugCheckString.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBugCheckString.Location = new System.Drawing.Point(374, 52);
            this.textBoxBugCheckString.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxBugCheckString.Name = "textBoxBugCheckString";
            this.textBoxBugCheckString.ReadOnly = true;
            this.textBoxBugCheckString.Size = new System.Drawing.Size(169, 23);
            this.textBoxBugCheckString.TabIndex = 16;
            // 
            // textBoxDumpFile
            // 
            this.textBoxDumpFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDumpFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDumpFile.Location = new System.Drawing.Point(374, 22);
            this.textBoxDumpFile.MinimumSize = new System.Drawing.Size(100, 10);
            this.textBoxDumpFile.Name = "textBoxDumpFile";
            this.textBoxDumpFile.ReadOnly = true;
            this.textBoxDumpFile.Size = new System.Drawing.Size(169, 23);
            this.textBoxDumpFile.TabIndex = 15;
            // 
            // labelDumpFileSize
            // 
            this.labelDumpFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDumpFileSize.AutoEllipsis = true;
            this.labelDumpFileSize.AutoSize = true;
            this.labelDumpFileSize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDumpFileSize.Location = new System.Drawing.Point(157, 442);
            this.labelDumpFileSize.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelDumpFileSize.Name = "labelDumpFileSize";
            this.labelDumpFileSize.Size = new System.Drawing.Size(200, 23);
            this.labelDumpFileSize.TabIndex = 14;
            this.labelDumpFileSize.Text = "Dump File Size:";
            // 
            // labelDumpFileTime
            // 
            this.labelDumpFileTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDumpFileTime.AutoEllipsis = true;
            this.labelDumpFileTime.AutoSize = true;
            this.labelDumpFileTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDumpFileTime.Location = new System.Drawing.Point(157, 412);
            this.labelDumpFileTime.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelDumpFileTime.Name = "labelDumpFileTime";
            this.labelDumpFileTime.Size = new System.Drawing.Size(200, 23);
            this.labelDumpFileTime.TabIndex = 13;
            this.labelDumpFileTime.Text = "Dump File Time:";
            // 
            // labelMinorVersion
            // 
            this.labelMinorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinorVersion.AutoEllipsis = true;
            this.labelMinorVersion.AutoSize = true;
            this.labelMinorVersion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinorVersion.Location = new System.Drawing.Point(157, 382);
            this.labelMinorVersion.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelMinorVersion.Name = "labelMinorVersion";
            this.labelMinorVersion.Size = new System.Drawing.Size(200, 23);
            this.labelMinorVersion.TabIndex = 12;
            this.labelMinorVersion.Text = "Minor Version:";
            // 
            // labelMajorVersion
            // 
            this.labelMajorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMajorVersion.AutoEllipsis = true;
            this.labelMajorVersion.AutoSize = true;
            this.labelMajorVersion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMajorVersion.Location = new System.Drawing.Point(157, 352);
            this.labelMajorVersion.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelMajorVersion.Name = "labelMajorVersion";
            this.labelMajorVersion.Size = new System.Drawing.Size(200, 23);
            this.labelMajorVersion.TabIndex = 11;
            this.labelMajorVersion.Text = "Major Version:";
            // 
            // labelProcessorsCount
            // 
            this.labelProcessorsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessorsCount.AutoEllipsis = true;
            this.labelProcessorsCount.AutoSize = true;
            this.labelProcessorsCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessorsCount.Location = new System.Drawing.Point(157, 322);
            this.labelProcessorsCount.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelProcessorsCount.Name = "labelProcessorsCount";
            this.labelProcessorsCount.Size = new System.Drawing.Size(200, 23);
            this.labelProcessorsCount.TabIndex = 10;
            this.labelProcessorsCount.Text = "Processors Count:";
            // 
            // labelFullPath
            // 
            this.labelFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullPath.AutoEllipsis = true;
            this.labelFullPath.AutoSize = true;
            this.labelFullPath.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullPath.Location = new System.Drawing.Point(157, 292);
            this.labelFullPath.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelFullPath.Name = "labelFullPath";
            this.labelFullPath.Size = new System.Drawing.Size(200, 23);
            this.labelFullPath.TabIndex = 9;
            this.labelFullPath.Text = "Full Path:";
            // 
            // labelVersionArchitecture
            // 
            this.labelVersionArchitecture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersionArchitecture.AutoEllipsis = true;
            this.labelVersionArchitecture.AutoSize = true;
            this.labelVersionArchitecture.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersionArchitecture.Location = new System.Drawing.Point(157, 262);
            this.labelVersionArchitecture.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelVersionArchitecture.Name = "labelVersionArchitecture";
            this.labelVersionArchitecture.Size = new System.Drawing.Size(200, 23);
            this.labelVersionArchitecture.TabIndex = 8;
            this.labelVersionArchitecture.Text = "Version Architecture:";
            // 
            // labelProcessor
            // 
            this.labelProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessor.AutoEllipsis = true;
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor.Location = new System.Drawing.Point(157, 232);
            this.labelProcessor.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(200, 23);
            this.labelProcessor.TabIndex = 7;
            this.labelProcessor.Text = "Processor:";
            // 
            // labelParameter4
            // 
            this.labelParameter4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParameter4.AutoEllipsis = true;
            this.labelParameter4.AutoSize = true;
            this.labelParameter4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParameter4.Location = new System.Drawing.Point(157, 202);
            this.labelParameter4.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelParameter4.Name = "labelParameter4";
            this.labelParameter4.Size = new System.Drawing.Size(200, 23);
            this.labelParameter4.TabIndex = 6;
            this.labelParameter4.Text = "Parameter 4:";
            // 
            // labelParameter3
            // 
            this.labelParameter3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParameter3.AutoEllipsis = true;
            this.labelParameter3.AutoSize = true;
            this.labelParameter3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParameter3.Location = new System.Drawing.Point(157, 172);
            this.labelParameter3.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelParameter3.Name = "labelParameter3";
            this.labelParameter3.Size = new System.Drawing.Size(200, 23);
            this.labelParameter3.TabIndex = 5;
            this.labelParameter3.Text = "Parameter 3:";
            // 
            // labelParameter2
            // 
            this.labelParameter2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParameter2.AutoEllipsis = true;
            this.labelParameter2.AutoSize = true;
            this.labelParameter2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParameter2.Location = new System.Drawing.Point(157, 142);
            this.labelParameter2.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelParameter2.Name = "labelParameter2";
            this.labelParameter2.Size = new System.Drawing.Size(200, 23);
            this.labelParameter2.TabIndex = 4;
            this.labelParameter2.Text = "Parameter 2:";
            // 
            // labelParameter1
            // 
            this.labelParameter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParameter1.AutoEllipsis = true;
            this.labelParameter1.AutoSize = true;
            this.labelParameter1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParameter1.Location = new System.Drawing.Point(157, 112);
            this.labelParameter1.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelParameter1.Name = "labelParameter1";
            this.labelParameter1.Size = new System.Drawing.Size(200, 23);
            this.labelParameter1.TabIndex = 3;
            this.labelParameter1.Text = "Parameter 1:";
            // 
            // labelBugCheckCode
            // 
            this.labelBugCheckCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBugCheckCode.AutoEllipsis = true;
            this.labelBugCheckCode.AutoSize = true;
            this.labelBugCheckCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBugCheckCode.Location = new System.Drawing.Point(157, 82);
            this.labelBugCheckCode.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelBugCheckCode.Name = "labelBugCheckCode";
            this.labelBugCheckCode.Size = new System.Drawing.Size(200, 23);
            this.labelBugCheckCode.TabIndex = 2;
            this.labelBugCheckCode.Text = "Bug Check Code:";
            // 
            // labelBugCheckString
            // 
            this.labelBugCheckString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBugCheckString.AutoEllipsis = true;
            this.labelBugCheckString.AutoSize = true;
            this.labelBugCheckString.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBugCheckString.Location = new System.Drawing.Point(157, 52);
            this.labelBugCheckString.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelBugCheckString.Name = "labelBugCheckString";
            this.labelBugCheckString.Size = new System.Drawing.Size(200, 23);
            this.labelBugCheckString.TabIndex = 1;
            this.labelBugCheckString.Text = "Bug Check String:";
            // 
            // labelDumpFile
            // 
            this.labelDumpFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDumpFile.AutoEllipsis = true;
            this.labelDumpFile.AutoSize = true;
            this.labelDumpFile.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDumpFile.Location = new System.Drawing.Point(157, 22);
            this.labelDumpFile.MinimumSize = new System.Drawing.Size(200, 10);
            this.labelDumpFile.Name = "labelDumpFile";
            this.labelDumpFile.Size = new System.Drawing.Size(200, 23);
            this.labelDumpFile.TabIndex = 0;
            this.labelDumpFile.Text = "Dump File:";
            // 
            // DumpHeaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DumpHeaderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DumpViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMinorVersion;
        private System.Windows.Forms.Label labelMajorVersion;
        private System.Windows.Forms.Label labelProcessorsCount;
        private System.Windows.Forms.Label labelFullPath;
        private System.Windows.Forms.Label labelVersionArchitecture;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.Label labelParameter4;
        private System.Windows.Forms.Label labelParameter3;
        private System.Windows.Forms.Label labelParameter2;
        private System.Windows.Forms.Label labelParameter1;
        private System.Windows.Forms.Label labelBugCheckCode;
        private System.Windows.Forms.Label labelBugCheckString;
        private System.Windows.Forms.Label labelDumpFile;
        private System.Windows.Forms.Label labelDumpFileSize;
        private System.Windows.Forms.Label labelDumpFileTime;
        private System.Windows.Forms.TextBox textBoxDumpFileTime;
        private System.Windows.Forms.TextBox textBoxDumpFileSize;
        private System.Windows.Forms.TextBox textBoxMinorVersion;
        private System.Windows.Forms.TextBox textBoxMajorVersion;
        private System.Windows.Forms.TextBox textBoxProcessorsCount;
        private System.Windows.Forms.TextBox textBoxFullPath;
        private System.Windows.Forms.TextBox textBoxVersionArchitecture;
        private System.Windows.Forms.TextBox textBoxProcessor;
        private System.Windows.Forms.TextBox textBoxParameter4;
        private System.Windows.Forms.TextBox textBoxParameter3;
        private System.Windows.Forms.TextBox textBoxParameter2;
        private System.Windows.Forms.TextBox textBoxParameter1;
        private System.Windows.Forms.TextBox textBoxBugCheckCode;
        private System.Windows.Forms.TextBox textBoxBugCheckString;
        private System.Windows.Forms.TextBox textBoxDumpFile;
    }
}