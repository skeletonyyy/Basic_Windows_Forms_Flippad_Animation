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
        public Frame currentFrame;
        public Stroke currentStroke;
        public Size FrameSize;
        public Project Project = new();
        public bool IsDrawing;
        public bool UpdateBack;

        public MainForm()
        {
            InitializeComponent();
            mainPictureBox.BackColor = Color.LightGray;
            buttonPickColour.BackColor = Color.Black;
            buttonBackground.BackColor = Color.White;
            tableLayoutFrameSettings.Visible = false;
            
            currentStroke = new(0);
            currentStroke.Colour = Color.Black;
            currentStroke.Thickness = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //      Tool strip items
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                var frame = new Frame(Project.Frames.Count() + 1,
                    $@"{Project.FramesFolderPath}\\{Project.Frames.Count() + 1}.gif",
                    FrameSize,
                    buttonBackground.BackColor);

                currentFrame = frame;
                Project.Frames.Add(frame);
                currentFrame.Index = frame.Index - 1; // currentFrameIndex is the index of the frame in Frames[]
                UpdatePictureFrame(frame);
                updateFrameCount();
            }
            else
            {
                MessageBox.Show("You cannot create a frame without starting a project.",
                    "Error: Must Create Project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (Project.Frames.Count > 1)
            {
                SaveFrame(Project.Frames[currentFrame.Index - 1]);
            }
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //      Frame menu items
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void buttonPickColour_Click(object sender, EventArgs e)
        {
            using ColorDialog colourDialog = new(); 
            colourDialog.ShowDialog();
            currentStroke.Colour = colourDialog.Color;
            buttonPickColour.BackColor = colourDialog.Color;
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                using ColorDialog colourDialog = new();
                colourDialog.ShowDialog();
                buttonBackground.BackColor = colourDialog.Color;
                if (UpdateBack)
                {
                    currentFrame.updateBackColour(colourDialog.Color);
                    UpdatePictureFrame(currentFrame);
                }
            }
            else
            {
                MessageBox.Show("There are no frames which can be assigned a background colour.",
                    "Error: No Frames",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void checkBoxUpdateBackground_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBack = checkBoxUpdateBackground.Checked;
        }

        private void checkBoxUpdateBackground_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(checkBoxUpdateBackground, "Checked: Updates the background of the current frame and the next created frames.\n " +
                                                          "Unchecked: Will be the background of the next frame created.\n" +
                                                          "NOTE: If you check the box and you used the same colour as your background " +
                                                          "in your drawing, IT WILL BE RESET TO THE BACKGROUND'S COLOUR.");
        }

        // ~~~~~~~~~~~~~~~~~~~
        //       Drawing 
        // ~~~~~~~~~~~~~~~~~~~
        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Project.Frames.Count > 0)
            {
                IsDrawing = true;
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                currentStroke = new Stroke(currentFrame.Strokes.Count)
                {
                    // NOTE: MUST CHANGE THE CURRENT DEFAULTS
                    Colour = buttonPickColour.BackColor,
                    Thickness = 10,
                };
                currentStroke.addPoint(point);
                currentFrame.Strokes.Add(currentStroke);
            }
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Project.Frames.Count > 0 && IsDrawing)
            { 
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                currentStroke.addPoint(point);
                UpdatePictureFrame(currentFrame);
            }
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (Project.Frames.Count > 0 && IsDrawing)
            {
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                currentStroke.addPoint(point);
                IsDrawing = false;
                UpdatePictureFrame(currentFrame);
            }
        }
        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (currentFrame != null)
            {
                foreach (var stroke in currentFrame.Strokes)
                {
                    using Graphics g = Graphics.FromImage(currentFrame.Bitmap);
                    using var pen = new Pen(stroke.Colour, stroke.Thickness);
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

        private void saveFrameMenuItem_Click(object sender, EventArgs e)
        {
            if (Project.Frames.Count != 0)
            {
                SaveFrame(Project.Frames[currentFrame.Index]);
            }
            else
            {
                MessageBox.Show("There are no frames to save.",
                    "Error: No Frames in Project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~
        //      Extra functions
        // ~~~~~~~~~~~~~~~~~~~~~~~~

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
                Project.FilePath = $"{newProjectDialog.ProjectFolderPath}\\{newProjectDialog.ProjectName}.json";
                Project.Name = newProjectDialog.ProjectName;
                FrameSize = newProjectDialog.FrameSize;

                mainPictureBox.Size = FrameSize;

                newFrameButton.PerformClick();
                tableLayoutFrameSettings.Visible = true;
            }

        }

        /// <summary>
        /// Updates the total number of frames and the current frame the user is using.
        /// </summary>
        private void updateFrameCount() => frameCountLabel.Text = $"Frame: {currentFrame.Index}";

        /// <summary>
        /// Save the current frame to the predetermined folder where all frames are saved. It will
        /// override whatever what previously saved.
        /// </summary>
        /// <param name="frame"></param>
        private void SaveFrame(Frame frame) => frame.Bitmap.Save(frame.Path, ImageFormat.Gif);

        /// <summary>
        /// Updates mainPictureBox to what was drawn on the bitmap.
        /// </summary>
        /// <param name="frame"></param>
        private void UpdatePictureFrame(Frame frame)
        {
            mainPictureBox.Image = frame.Bitmap;
            mainPictureBox.Invalidate();
        }
    }
}
