namespace FinalProject
{
    partial class CreateNewProjectDialogBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textProjectName = new System.Windows.Forms.TextBox();
            this.textProjectPath = new System.Windows.Forms.TextBox();
            this.buttonSelectProjectFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tickBoxWidth = new System.Windows.Forms.NumericUpDown();
            this.tickBoxHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonSelectFramesFolder = new System.Windows.Forms.Button();
            this.instructionsSelectFolder = new System.Windows.Forms.Label();
            this.textFramesPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickBoxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickBoxHeight)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Controls.Add(this.textProjectName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textProjectPath, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectProjectFolder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tickBoxWidth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tickBoxHeight, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectFramesFolder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.instructionsSelectFolder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textFramesPath, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textProjectName
            // 
            this.textProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textProjectName, 2);
            this.textProjectName.Location = new System.Drawing.Point(416, 28);
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Size = new System.Drawing.Size(701, 31);
            this.textProjectName.TabIndex = 10;
            this.textProjectName.TextChanged += new System.EventHandler(this.textProjectName_TextChanged);
            // 
            // textProjectPath
            // 
            this.textProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textProjectPath.Location = new System.Drawing.Point(673, 115);
            this.textProjectPath.Name = "textProjectPath";
            this.textProjectPath.ReadOnly = true;
            this.textProjectPath.Size = new System.Drawing.Size(444, 31);
            this.textProjectPath.TabIndex = 8;
            this.textProjectPath.Text = "ProjectFolderPath";
            // 
            // buttonSelectProjectFolder
            // 
            this.buttonSelectProjectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectProjectFolder.Location = new System.Drawing.Point(416, 98);
            this.buttonSelectProjectFolder.Name = "buttonSelectProjectFolder";
            this.buttonSelectProjectFolder.Size = new System.Drawing.Size(251, 64);
            this.buttonSelectProjectFolder.TabIndex = 7;
            this.buttonSelectProjectFolder.Text = "Select Folder";
            this.buttonSelectProjectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectProjectFolder.Click += new System.EventHandler(this.buttonSelectProjectFolder_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select a folder to select your project:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size of the frames in pixels:";
            // 
            // tickBoxWidth
            // 
            this.tickBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tickBoxWidth.Location = new System.Drawing.Point(416, 289);
            this.tickBoxWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tickBoxWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tickBoxWidth.Name = "tickBoxWidth";
            this.tickBoxWidth.Size = new System.Drawing.Size(251, 31);
            this.tickBoxWidth.TabIndex = 4;
            this.tickBoxWidth.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.tickBoxWidth.ValueChanged += new System.EventHandler(this.tickBoxWidth_ValueChanged);
            // 
            // tickBoxHeight
            // 
            this.tickBoxHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tickBoxHeight.Location = new System.Drawing.Point(673, 289);
            this.tickBoxHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tickBoxHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tickBoxHeight.Name = "tickBoxHeight";
            this.tickBoxHeight.Size = new System.Drawing.Size(203, 31);
            this.tickBoxHeight.TabIndex = 5;
            this.tickBoxHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.tickBoxHeight.ValueChanged += new System.EventHandler(this.tickBoxHeight_ValueChanged);
            // 
            // buttonSelectFramesFolder
            // 
            this.buttonSelectFramesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFramesFolder.Location = new System.Drawing.Point(416, 185);
            this.buttonSelectFramesFolder.Name = "buttonSelectFramesFolder";
            this.buttonSelectFramesFolder.Size = new System.Drawing.Size(251, 64);
            this.buttonSelectFramesFolder.TabIndex = 1;
            this.buttonSelectFramesFolder.Text = "Select Folder";
            this.buttonSelectFramesFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFramesFolder.Click += new System.EventHandler(this.buttonSelectFramesFolder_Click);
            // 
            // instructionsSelectFolder
            // 
            this.instructionsSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsSelectFolder.AutoSize = true;
            this.instructionsSelectFolder.Location = new System.Drawing.Point(3, 205);
            this.instructionsSelectFolder.Name = "instructionsSelectFolder";
            this.instructionsSelectFolder.Size = new System.Drawing.Size(407, 25);
            this.instructionsSelectFolder.TabIndex = 0;
            this.instructionsSelectFolder.Text = "Select a folder to store the GIF\'s frames:";
            // 
            // textFramesPath
            // 
            this.textFramesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textFramesPath.Location = new System.Drawing.Point(673, 202);
            this.textFramesPath.Name = "textFramesPath";
            this.textFramesPath.ReadOnly = true;
            this.textFramesPath.Size = new System.Drawing.Size(444, 31);
            this.textFramesPath.TabIndex = 2;
            this.textFramesPath.Text = "FramesFolderPath";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name your project:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Controls.Add(this.buttonAccept);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 348);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1120, 57);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(942, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 50);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(761, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(175, 50);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // CreateNewProjectDialogBox
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1120, 405);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateNewProjectDialogBox";
            this.Text = "Create a New Project";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickBoxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickBoxHeight)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label instructionsSelectFolder;
        private System.Windows.Forms.Button buttonSelectFramesFolder;
        private System.Windows.Forms.TextBox textFramesPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tickBoxWidth;
        private System.Windows.Forms.NumericUpDown tickBoxHeight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textProjectPath;
        private System.Windows.Forms.Button buttonSelectProjectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProjectName;
    }
}