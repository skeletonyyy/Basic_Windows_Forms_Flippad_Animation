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
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.selectFrameFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutFrameSettings = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.labelBackground = new System.Windows.Forms.Label();
            this.checkBoxUpdateBackground = new System.Windows.Forms.CheckBox();
            this.newFrameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPickColour = new System.Windows.Forms.Button();
            this.previousFrameButton = new System.Windows.Forms.Button();
            this.frameNumber = new System.Windows.Forms.TextBox();
            this.nextFrameButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.projectNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.frameCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipUpdateBackgroud = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutFrameSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1803, 40);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(426, 44);
            this.newProjectToolStripMenuItem.Text = "New project";
            this.newProjectToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(426, 44);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(423, 6);
            // 
            // saveFrameMenuItem
            // 
            this.saveFrameMenuItem.Name = "saveFrameMenuItem";
            this.saveFrameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFrameMenuItem.Size = new System.Drawing.Size(426, 44);
            this.saveFrameMenuItem.Text = "Save Frame";
            this.saveFrameMenuItem.Click += new System.EventHandler(this.saveFrameMenuItem_Click);
            // 
            // saveProjectMenuItem
            // 
            this.saveProjectMenuItem.Name = "saveProjectMenuItem";
            this.saveProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectMenuItem.Size = new System.Drawing.Size(426, 44);
            this.saveProjectMenuItem.Text = "Save project";
            this.saveProjectMenuItem.Click += new System.EventHandler(this.saveProjectMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(423, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(426, 44);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.redoMenuItem,
            this.toolStripSeparator1,
            this.stuffToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(286, 44);
            this.undoMenuItem.Text = "Undo";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuItem.Size = new System.Drawing.Size(286, 44);
            this.redoMenuItem.Text = "Redo";
            this.redoMenuItem.Click += new System.EventHandler(this.redoMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(286, 44);
            this.stuffToolStripMenuItem.Text = "Stuff";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.invertSelectionToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.invertSelectionToolStripMenuItem.Text = "Invert Selection?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMePlsToolStripMenuItem,
            this.refreshMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMePlsToolStripMenuItem
            // 
            this.helpMePlsToolStripMenuItem.Name = "helpMePlsToolStripMenuItem";
            this.helpMePlsToolStripMenuItem.Size = new System.Drawing.Size(304, 44);
            this.helpMePlsToolStripMenuItem.Text = "Help me pls ;-;";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(304, 44);
            this.refreshMenuItem.Text = "Refresh canvas";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainPictureBox.Location = new System.Drawing.Point(453, 122);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 961F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1803, 961);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutFrameSettings
            // 
            this.tableLayoutFrameSettings.ColumnCount = 3;
            this.tableLayoutFrameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutFrameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutFrameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.tableLayoutFrameSettings.Controls.Add(this.buttonBackground, 1, 2);
            this.tableLayoutFrameSettings.Controls.Add(this.labelBackground, 0, 2);
            this.tableLayoutFrameSettings.Controls.Add(this.checkBoxUpdateBackground, 2, 2);
            this.tableLayoutFrameSettings.Controls.Add(this.newFrameButton, 0, 0);
            this.tableLayoutFrameSettings.Controls.Add(this.label1, 0, 1);
            this.tableLayoutFrameSettings.Controls.Add(this.buttonPickColour, 1, 1);
            this.tableLayoutFrameSettings.Controls.Add(this.previousFrameButton, 0, 3);
            this.tableLayoutFrameSettings.Controls.Add(this.frameNumber, 1, 3);
            this.tableLayoutFrameSettings.Controls.Add(this.nextFrameButton, 2, 3);
            this.tableLayoutFrameSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFrameSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFrameSettings.Name = "tableLayoutFrameSettings";
            this.tableLayoutFrameSettings.RowCount = 5;
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.504801F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutFrameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.4952F));
            this.tableLayoutFrameSettings.Size = new System.Drawing.Size(444, 955);
            this.tableLayoutFrameSettings.TabIndex = 4;
            // 
            // buttonBackground
            // 
            this.buttonBackground.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackground.Location = new System.Drawing.Point(157, 124);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(45, 45);
            this.buttonBackground.TabIndex = 1;
            this.buttonBackground.UseVisualStyleBackColor = false;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // labelBackground
            // 
            this.labelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(3, 134);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(148, 25);
            this.labelBackground.TabIndex = 0;
            this.labelBackground.Text = "Background:";
            // 
            // checkBoxUpdateBackground
            // 
            this.checkBoxUpdateBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUpdateBackground.AutoSize = true;
            this.checkBoxUpdateBackground.Location = new System.Drawing.Point(212, 132);
            this.checkBoxUpdateBackground.Name = "checkBoxUpdateBackground";
            this.checkBoxUpdateBackground.Size = new System.Drawing.Size(229, 29);
            this.checkBoxUpdateBackground.TabIndex = 2;
            this.checkBoxUpdateBackground.Text = "Update";
            this.checkBoxUpdateBackground.UseVisualStyleBackColor = true;
            this.checkBoxUpdateBackground.CheckedChanged += new System.EventHandler(this.checkBoxUpdateBackground_CheckedChanged);
            this.checkBoxUpdateBackground.MouseHover += new System.EventHandler(this.checkBoxUpdateBackground_MouseHover);
            // 
            // newFrameButton
            // 
            this.newFrameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newFrameButton.Location = new System.Drawing.Point(3, 12);
            this.newFrameButton.Name = "newFrameButton";
            this.newFrameButton.Size = new System.Drawing.Size(148, 42);
            this.newFrameButton.TabIndex = 3;
            this.newFrameButton.Text = "New Frame";
            this.newFrameButton.UseVisualStyleBackColor = true;
            this.newFrameButton.Click += new System.EventHandler(this.newFrameButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stroke Colour";
            // 
            // buttonPickColour
            // 
            this.buttonPickColour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPickColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPickColour.Location = new System.Drawing.Point(157, 70);
            this.buttonPickColour.Name = "buttonPickColour";
            this.buttonPickColour.Size = new System.Drawing.Size(45, 45);
            this.buttonPickColour.TabIndex = 5;
            this.buttonPickColour.UseVisualStyleBackColor = false;
            this.buttonPickColour.Click += new System.EventHandler(this.buttonPickColour_Click);
            // 
            // previousFrameButton
            // 
            this.previousFrameButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previousFrameButton.Location = new System.Drawing.Point(39, 177);
            this.previousFrameButton.Name = "previousFrameButton";
            this.previousFrameButton.Size = new System.Drawing.Size(112, 57);
            this.previousFrameButton.TabIndex = 6;
            this.previousFrameButton.Text = "Previous";
            this.previousFrameButton.UseVisualStyleBackColor = true;
            this.previousFrameButton.Click += new System.EventHandler(this.previousFrameButton_Click);
            // 
            // frameNumber
            // 
            this.frameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.frameNumber.Location = new System.Drawing.Point(157, 190);
            this.frameNumber.Name = "frameNumber";
            this.frameNumber.Size = new System.Drawing.Size(49, 31);
            this.frameNumber.TabIndex = 8;
            this.frameNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frameNumber_KeyPress);
            this.frameNumber.Leave += new System.EventHandler(this.frameNumber_Leave);
            // 
            // nextFrameButton
            // 
            this.nextFrameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextFrameButton.Location = new System.Drawing.Point(212, 177);
            this.nextFrameButton.Name = "nextFrameButton";
            this.nextFrameButton.Size = new System.Drawing.Size(112, 57);
            this.nextFrameButton.TabIndex = 9;
            this.nextFrameButton.Text = "Next";
            this.nextFrameButton.UseVisualStyleBackColor = true;
            this.nextFrameButton.Click += new System.EventHandler(this.nextFrameButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectNameLabel,
            this.frameCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 959);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1803, 42);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(99, 32);
            this.projectNameLabel.Text = "Project: ";
            // 
            // frameCountLabel
            // 
            this.frameCountLabel.Name = "frameCountLabel";
            this.frameCountLabel.Size = new System.Drawing.Size(92, 32);
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
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.Button previousFrameButton;
        private System.Windows.Forms.TextBox frameNumber;
        private System.Windows.Forms.Button nextFrameButton;
    }
}

