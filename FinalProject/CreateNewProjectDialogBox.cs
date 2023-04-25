using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CreateNewProjectDialogBox : Form
    {
        public string FramesFolderPath;
        public string ProjectFolderPath;
        public string ProjectName;
        public Size FrameSize = new Size(480, 480);

        public CreateNewProjectDialogBox()
        {
            InitializeComponent();
            textFramesPath.Text = String.Empty;
            textProjectPath.Text = String.Empty;
            tickBoxHeight.Width = tickBoxWidth.Width;
            tickBoxHeight.Height = tickBoxWidth.Height;
        }

        private void buttonSelectFramesFolder_Click(object sender, EventArgs e)
        {
            FramesFolderPath = getFolderPath();
            textFramesPath.Text = FramesFolderPath;
        }

        private void buttonSelectProjectFolder_Click(object sender, EventArgs e)
        {
            ProjectFolderPath = getFolderPath();
            textProjectPath.Text = ProjectFolderPath;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Reset the stored data
            FramesFolderPath = null;
            ProjectFolderPath = null;
            FrameSize = Size.Empty;
            ProjectName = null;

            Close();
        }

        private void tickBoxWidth_ValueChanged(object sender, EventArgs e)
        {
            Size temp = FrameSize;
            temp.Width = (int)tickBoxWidth.Value;
            FrameSize = temp;
        }

        private void tickBoxHeight_ValueChanged(object sender, EventArgs e)
        {
            Size temp = FrameSize;
            temp.Height = (int)tickBoxHeight.Value;
            FrameSize = temp;
        }

        private void textProjectName_TextChanged(object sender, EventArgs e)
        {
            ProjectName = textProjectName.Text;
        }

        public string getFolderPath()
        {
            using FolderBrowserDialog folderDialog = new();
            //var folderDialog = new FolderBrowserDialog();
            folderDialog.ShowDialog();
            return folderDialog.SelectedPath;
        }
    }
}
