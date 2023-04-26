namespace FinalProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFrameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMePlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.selectFrameFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutFrameSettings = new System.Windows.Forms.TableLayoutPanel();
            this.newFrameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPickColour = new System.Windows.Forms.Button();
            this.previousFrameButton = new System.Windows.Forms.Button();
            this.frameNumber = new System.Windows.Forms.TextBox();
            this.nextFrameButton = new System.Windows.Forms.Button();
            this.labelBackground = new System.Windows.Forms.Label();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.checkBoxUpdateBackground = new System.Windows.Forms.CheckBox();
            this.thicknessTick = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frameSpeedTick = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.projectNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.frameCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipUpdateBackgroud = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFrameSpeed = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutFrameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSpeedTick)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1803, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveFrameMenuItem,
            this.saveProjectMenuItem,
            this.toolStripSeparator3,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newProjectToolStripMenuItem.Text = "New project";
            this.newProjectToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // saveFrameMenuItem
            // 
            this.saveFrameMenuItem.Name = "saveFrameMenuItem";
            this.saveFrameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFrameMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveFrameMenuItem.Text = "Save Frame";
            this.saveFrameMenuItem.Click += new System.EventHandler(this.saveFrameMenuItem_Click);
            // 
            // saveProjectMenuItem
            // 
            this.saveProjectMenuItem.Name = "saveProjectMenuItem";
            this.saveProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveProjectMenuItem.Text = "Save project";
            this.saveProjectMenuItem.Click += new System.EventHandler(this.saveProjectMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.redoMenuItem,
            this.toolStripSeparator1,
            this.stuffToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoMenuItem.Text = "Undo";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoMenuItem.Text = "Redo";
            this.redoMenuItem.Click += new System.EventHandler(this.redoMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.stuffToolStripMenuItem.Text = "Stuff";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.invertSelectionToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.invertSelectionToolStripMenuItem.Text = "Invert Selection?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMePlsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMePlsToolStripMenuItem
            // 
            this.helpMePlsToolStripMenuItem.Name = "helpMePlsToolStripMenuItem";
            this.helpMePlsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.helpMePlsToolStripMenuItem.Text = "Help me pls ;-;";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainPictureBox.Location = new System.Drawing.Point(453, 130);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1346, 716);
            this.mainPictureBox.TabIndex = 3;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            // 
            // selectFrameFolder
            // 
            this.selectFrameFolder.Description = "Please pick a folder to store your frames";
            this.selectFrameFolder.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.mainPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutFrameSettings, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 977F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1803, 977);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // tableLayoutFrameSettings
            // 
            this.tableLayoutFrameSettings.ColumnCount = 3;
            this.tableLayoutFrameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutFrameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutFrameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.tableLayoutFrameSettings.Controls.Add(this.newFrameButton, 0, 0);
            this.tableLayoutFrameSettings.Controls.Add(this.label1, 0, 1);
            this.tableLayoutFrameSettings.Controls.Add(this.buttonPickColour, 1, 1);
            this.tableLayoutFrameSettings.Controls.Add(this.previousFrameButton, 0, 4);
            this.tableLayoutFrameSettings.Controls.Add(this.frameNumber, 1, 4);
            this.tableLayoutFrameSettings.Controls.Add(this.nextFrameButton, 2, 4);
            this.tableLayoutFrameSettings.Controls.Add(this.labelBackground, 0, 3);
            this.tableLayoutFrameSettings.Controls.Add(this.buttonBackground, 1, 3);
            this.tableLayoutFrameSettings.Controls.Add(this.checkBoxUpdateBackground, 2, 3);
            this.tableLayoutFrameSettings.Controls.Add(this.label2, 0, 2);
            this.tableLayoutFrameSettings.Controls.Add(this.label3, 0, 5);
            this.tableLayoutFrameSettings.Controls.Add(this.frameSpeedTick, 2, 5);
            this.tableLayoutFrameSettings.Controls.Add(this.thicknessTick, 2, 2);
            this.tableLayoutFrameSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFrameSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFrameSettings.Name = "tableLayoutFrameSettings";
            this.tableLayoutFrameSettings.RowCount = 7;
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.504801F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.4952F));
            this.tableLayoutFrameSettings.Size = new System.Drawing.Size(444, 971);
            this.tableLayoutFrameSettings.TabIndex = 4;
            this.tableLayoutFrameSettings.Click += new System.EventHandler(this.tableLayoutFrameSettings_Click);
            // 
            // newFrameButton
            // 
            this.newFrameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newFrameButton.Location = new System.Drawing.Point(3, 8);
            this.newFrameButton.Name = "newFrameButton";
            this.newFrameButton.Size = new System.Drawing.Size(174, 42);
            this.newFrameButton.TabIndex = 3;
            this.newFrameButton.Text = "New Frame";
            this.newFrameButton.UseVisualStyleBackColor = true;
            this.newFrameButton.Click += new System.EventHandler(this.newFrameButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stroke Colour";
            // 
            // buttonPickColour
            // 
            this.buttonPickColour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPickColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPickColour.Location = new System.Drawing.Point(183, 62);
            this.buttonPickColour.Name = "buttonPickColour";
            this.buttonPickColour.Size = new System.Drawing.Size(45, 45);
            this.buttonPickColour.TabIndex = 5;
            this.buttonPickColour.UseVisualStyleBackColor = false;
            this.buttonPickColour.Click += new System.EventHandler(this.buttonPickColour_Click);
            // 
            // previousFrameButton
            // 
            this.previousFrameButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previousFrameButton.Location = new System.Drawing.Point(65, 232);
            this.previousFrameButton.Name = "previousFrameButton";
            this.previousFrameButton.Size = new System.Drawing.Size(112, 55);
            this.previousFrameButton.TabIndex = 6;
            this.previousFrameButton.Text = "Previous";
            this.previousFrameButton.UseVisualStyleBackColor = true;
            this.previousFrameButton.Click += new System.EventHandler(this.previousFrameButton_Click);
            // 
            // frameNumber
            // 
            this.frameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.frameNumber.Location = new System.Drawing.Point(183, 244);
            this.frameNumber.Name = "frameNumber";
            this.frameNumber.Size = new System.Drawing.Size(46, 31);
            this.frameNumber.TabIndex = 8;
            this.frameNumber.LostFocus += new System.EventHandler(this.frameNumber_LostFocus);
            // 
            // nextFrameButton
            // 
            this.nextFrameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextFrameButton.Location = new System.Drawing.Point(235, 232);
            this.nextFrameButton.Name = "nextFrameButton";
            this.nextFrameButton.Size = new System.Drawing.Size(112, 55);
            this.nextFrameButton.TabIndex = 9;
            this.nextFrameButton.Text = "Next";
            this.nextFrameButton.UseVisualStyleBackColor = true;
            this.nextFrameButton.Click += new System.EventHandler(this.nextFrameButton_Click);
            // 
            // labelBackground
            // 
            this.labelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(3, 172);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(174, 50);
            this.labelBackground.TabIndex = 0;
            this.labelBackground.Text = "Background colour";
            // 
            // buttonBackground
            // 
            this.buttonBackground.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackground.Location = new System.Drawing.Point(183, 175);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(45, 45);
            this.buttonBackground.TabIndex = 1;
            this.buttonBackground.UseVisualStyleBackColor = false;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // checkBoxUpdateBackground
            // 
            this.checkBoxUpdateBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUpdateBackground.AutoSize = true;
            this.checkBoxUpdateBackground.Location = new System.Drawing.Point(235, 183);
            this.checkBoxUpdateBackground.Name = "checkBoxUpdateBackground";
            this.checkBoxUpdateBackground.Size = new System.Drawing.Size(206, 29);
            this.checkBoxUpdateBackground.TabIndex = 2;
            this.checkBoxUpdateBackground.Text = "Update";
            this.checkBoxUpdateBackground.UseVisualStyleBackColor = true;
            this.checkBoxUpdateBackground.CheckedChanged += new System.EventHandler(this.checkBoxUpdateBackground_CheckedChanged);
            this.checkBoxUpdateBackground.MouseHover += new System.EventHandler(this.checkBoxUpdateBackground_MouseHover);
            // 
            // thicknessTick
            // 
            this.thicknessTick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thicknessTick.Location = new System.Drawing.Point(235, 123);
            this.thicknessTick.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.thicknessTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessTick.Name = "thicknessTick";
            this.thicknessTick.Size = new System.Drawing.Size(112, 31);
            this.thicknessTick.TabIndex = 10;
            this.thicknessTick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessTick.ValueChanged += new System.EventHandler(this.thicknessTick_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 50);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stroke Thickness";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gif frame speed";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // frameSpeedTick
            // 
            this.frameSpeedTick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.frameSpeedTick.Location = new System.Drawing.Point(235, 301);
            this.frameSpeedTick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frameSpeedTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameSpeedTick.Name = "frameSpeedTick";
            this.frameSpeedTick.Size = new System.Drawing.Size(112, 31);
            this.frameSpeedTick.TabIndex = 12;
            this.frameSpeedTick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameSpeedTick.ValueChanged += new System.EventHandler(this.frameSpeedTick_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectNameLabel,
            this.frameCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 979);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1803, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(50, 17);
            this.projectNameLabel.Text = "Project: ";
            // 
            // frameCountLabel
            // 
            this.frameCountLabel.Name = "frameCountLabel";
            this.frameCountLabel.Size = new System.Drawing.Size(46, 17);
            this.frameCountLabel.Text = "Frame: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 1001);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Flip-a-Gif!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutFrameSettings.ResumeLayout(false);
            this.tableLayoutFrameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSpeedTick)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFrameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMePlsToolStripMenuItem;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.FolderBrowserDialog selectFrameFolder;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel frameCountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFrameSettings;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.CheckBox checkBoxUpdateBackground;
        private System.Windows.Forms.ToolTip toolTipUpdateBackgroud;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel projectNameLabel;
        private System.Windows.Forms.Button newFrameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPickColour;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button previousFrameButton;
        private System.Windows.Forms.TextBox frameNumber;
        private System.Windows.Forms.Button nextFrameButton;
        private System.Windows.Forms.NumericUpDown thicknessTick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown frameSpeedTick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipFrameSpeed;
    }
}

