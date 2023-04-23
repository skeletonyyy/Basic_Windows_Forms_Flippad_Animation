using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public List<Frame> Frames = new List<Frame>();
        public Frame currentFrame;
        public int currentStrokeIndex;
        public int currentFrameIndex;
        public Size FrameSize;
        public Project Project = new();
        public bool IsDrawing;

        public MainForm()
        {
            InitializeComponent();
            // Type defaults in here
            mainPictureBox.BackColor = Color.LightGray;
        }

        private void newFrameButton_Click(object sender, EventArgs e)
        {
            if (Project.isEmpty())
            {
                NewProject();
            }
            if (!Project.isEmpty())
            {
                // make bitmap for drawing, link it to the picturebox, and save it as .gif
                var frame = new Frame(Frames.Count() + 1, 0, $@"{Project.FramesFolderPath}\\{Frames.Count() + 1}.gif", FrameSize);
                frame.FrameBitmap = new Bitmap(FrameSize.Width, FrameSize.Height);

                currentFrame = frame;
                Frames.Add(frame);
                mainPictureBox.Image = frame.FrameBitmap;
                currentFrameIndex = frame.FrameIndex - 1; // currentFrameIndex is the index of the frame in Frames[]
                updateFrameCount();
            }
            else
            {
                MessageBox.Show("You cannot create a frame without starting a project.",
                    "Error: Must Create Project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (Frames.Count > 0)
            {
                SaveFrame(Frames[currentFrameIndex - 1]);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Frames.Count > 0)
            {
                IsDrawing = true;
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                var stroke = new Stroke()
                {
                    // NOTE: MUST CHANGE THE CURRENT DEFAULTS
                    StrokeColour = Color.Blue,
                    StrokeThickness = 10,
                };
                stroke.addPoint(point);
                currentFrame.Strokes.Add(stroke);
                currentStrokeIndex = currentFrame.Strokes.Count - 1;
            }
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Frames.Count > 0 && IsDrawing)
            { 
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                currentFrame.Strokes[currentStrokeIndex].addPoint(point);
                UpdatePictureFrame(Frames[currentFrameIndex]);
            }
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (Frames.Count > 0 && IsDrawing)
            {
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                currentFrame.Strokes[currentStrokeIndex].addPoint(point);
                IsDrawing = false;
                UpdatePictureFrame(Frames[currentFrameIndex]);
            }
        }
        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (currentFrame != null)
            {
                foreach (var stroke in currentFrame.Strokes)
                {
                    using Graphics g = Graphics.FromImage(Frames[currentFrameIndex].FrameBitmap);
                    using var pen = new Pen(stroke.StrokeColour, stroke.StrokeThickness);
                    for (int i = 0; i < stroke.Points.Count - 1; i++)
                    {
                        g.DrawLine(pen, stroke.Points[i], stroke.Points[i + 1]);
                    }
                }
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        /// <summary>
        /// Creates a new project. A dialog will open to get basic information (paths, names, sizes)
        /// </summary>
        private void NewProject()
        {
            using CreateNewProjectDialogBox newProjectDialog = new CreateNewProjectDialogBox();
            newProjectDialog.ShowDialog();
            if (newProjectDialog.DialogResult == DialogResult.OK &&
                !string.IsNullOrEmpty(newProjectDialog.FramesFolderPath) &&
                !string.IsNullOrEmpty(newProjectDialog.ProjectFolderPath) &&
                !string.IsNullOrEmpty(newProjectDialog.ProjectName) &&
                !newProjectDialog.FrameSize.IsEmpty)
                //Ensure that we are not returning some kind of empty data
            {
                Project.FramesFolderPath = newProjectDialog.FramesFolderPath;
                Project.ProjectFilePath = $"{newProjectDialog.ProjectFolderPath}\\{newProjectDialog.ProjectName}.json";
                Project.ProjectName = newProjectDialog.ProjectName;
                FrameSize = newProjectDialog.FrameSize;

                mainPictureBox.Size = FrameSize;
                mainPictureBox.BackColor = Color.White;

                newFrameButton.PerformClick();
            }

        }

        private void saveFrameMenuItem_Click(object sender, EventArgs e)
        {
            if (Frames.Count != 0)
            {
                SaveFrame(Frames[currentFrameIndex]);
            }
            else
            {
                MessageBox.Show("There are no frames to save.",
                    "Error: No Frames in Project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the total number of frames and the current frame the user is using.
        /// </summary>
        private void updateFrameCount() => frameCountLabel.Text = $"Frame: {currentFrameIndex}";

        /// <summary>
        /// Save the current frame to the predetermined folder where all frames are saved. It will
        /// override whatever what previously saved.
        /// </summary>
        /// <param name="frame"></param>
        private void SaveFrame(Frame frame) => frame.FrameBitmap.Save(frame.FramePath, ImageFormat.Gif);

        /// <summary>
        /// Updates mainPictureBox to what was drawn on the bitmap.
        /// </summary>
        /// <param name="frame"></param>
        private void UpdatePictureFrame(Frame frame)
        {
            mainPictureBox.Image = frame.FrameBitmap;
            mainPictureBox.Invalidate();
        }
    }
}
