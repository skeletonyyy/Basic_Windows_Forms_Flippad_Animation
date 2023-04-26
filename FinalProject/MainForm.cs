using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnimatedGif;
using Newtonsoft.Json;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private Frame _currentFrame;
        private Stroke _currentStroke;
        private Project _project = new();
        public Size FrameSize;
        public bool IsDrawing;
        public bool UpdateBack;

        public MainForm()
        {
            InitializeComponent();
            mainPictureBox.BackColor = Color.LightGray;
            buttonPickColour.BackColor = Color.Black;
            buttonBackground.BackColor = Color.White;
            tableLayoutFrameSettings.Visible = false;

            _currentStroke = new(0);
            _currentStroke.Colour = Color.Black;
            _currentStroke.Thickness = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //         Menu items
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void saveFrameMenuItem_Click(object sender, EventArgs e)
        {
            if (_project.Frames.Count != 0)
            {
                SaveFrame(_project.Frames[_currentFrame.Index]);
            }
            else
            {
                MessageBox.Show("There are no frames to save.",
                    "Error: No Frames in _project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void saveProjectMenuItem_Click(object sender, EventArgs e)
        {
            if (!_project.isEmpty())
                SaveProject();
            else
            {
                MessageBox.Show("Please start a project before saving it.",
                    "Error: No _project Started", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new();
            fileDialog.Filter = "JSON Files|*.json";
            fileDialog.Title = "Choose a Project File to Open";
            fileDialog.ShowDialog();

            if (fileDialog.FileNames.Length == 1 && !string.IsNullOrEmpty(fileDialog.FileName))
            {
                _project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(fileDialog.FileName),
                    new SizeConverter(), new BitmapConverter(), new ColorConverter(), new PointConverter());
                _currentFrame = _project.Frames.Last();
                _currentStroke = _currentFrame.Strokes.Last();
                FrameSize = _currentFrame.Size;
                foreach (var frame in _project.Frames)
                {
                    _currentFrame = frame;
                    Invalidate();
                }
                mainPictureBox.Size = FrameSize;
                projectNameLabel.Text = $"Project: {_project.Name}";
                tableLayoutFrameSettings.Visible = true;
                UpdatePictureFrame(_currentFrame);
                updateFrameCount();
            }
            else
            {
                MessageBox.Show("Please select one (1) file.",
                    "Error: Wrong Path Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentFrame.UndoStack.Count > 0)
            {
                _currentFrame.RedoStack.Push(_currentFrame.UndoStack.Pop());
                _currentFrame.Strokes.RemoveAt(_currentFrame.Strokes.Count - 1);
                if (_currentFrame.Strokes.Count > 0)
                    _currentStroke = _currentFrame.Strokes.Last();
                else
                    _currentStroke = new Stroke(0);
                _currentFrame.Bitmap.Dispose();
                _currentFrame.Bitmap = new Bitmap(FrameSize.Width, FrameSize.Height);
                _currentFrame.updateBackColour(_currentFrame.BackColour);
                UpdatePictureFrame(_currentFrame);
                mainPictureBox.Image = _currentFrame.Bitmap;
            }
        }

        private void redoMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentFrame.RedoStack.Count > 0)
            {
                _currentFrame.UndoStack.Push(_currentFrame.RedoStack.Pop());
                _currentFrame.Strokes.Add(_currentFrame.UndoStack.Peek());
                _currentStroke = _currentFrame.Strokes.Last();
                _currentFrame.Bitmap.Dispose();
                _currentFrame.Bitmap = new Bitmap(FrameSize.Width, FrameSize.Height);
                _currentFrame.updateBackColour(_currentFrame.BackColour);
                UpdatePictureFrame(_currentFrame);
                mainPictureBox.Image = _currentFrame.Bitmap;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
            using (var gif = new AnimatedGifCreator(_project.FilePath.Replace(".json", ".gif"), _project.FrameSpeed))
            {
                foreach (var frame in _project.Frames)
                {
                    gif.AddFrame(frame.Path, delay: -1, quality: GifQuality.Bit8);
                }
            }
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //      Frame menu items
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void newFrameButton_Click(object sender, EventArgs e)
        {
            
            if (!_project.isEmpty())
            {
                var frame = new Frame(_project.Frames.Count(),
                    $@"{_project.FramesFolderPath}\\{_project.Frames.Count()}.gif",
                    FrameSize,
                    buttonBackground.BackColor);

                _currentFrame = frame;
                _project.Frames.Add(frame);
                _currentFrame.Index = frame.Index;
                UpdatePictureFrame(frame);
                updateFrameCount();
                if (_currentFrame.Index > 0)
                {
                    SaveFrame(_project.Frames[_currentFrame.Index - 1]);
                }
            }
            else
            {
                MessageBox.Show("You cannot create a frame without starting a project.",
                    "Error: Must Create _project",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonPickColour_Click(object sender, EventArgs e)
        {
            using ColorDialog colourDialog = new(); 
            colourDialog.ShowDialog();
            _currentStroke.Colour = colourDialog.Color;
            buttonPickColour.BackColor = colourDialog.Color;
        }

        private void thicknessTick_ValueChanged(object sender, EventArgs e)
        {
            _currentStroke.Thickness = (int)thicknessTick.Value;
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            if (_currentFrame != null)
            {
                using ColorDialog colourDialog = new();
                colourDialog.ShowDialog();
                buttonBackground.BackColor = colourDialog.Color;
                if (UpdateBack)
                {
                    _currentFrame.updateBackColour(colourDialog.Color);
                    UpdatePictureFrame(_currentFrame);
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
            toolTipUpdateBackgroud.SetToolTip(checkBoxUpdateBackground, 
                "Checked: Updates the background of the current frame and the next created frames.\n " +
                "Unchecked: Will be the background of the next frame created.\n" +
                "NOTE: If you check the box and you used the same colour as your background " +
                "in your drawing, IT WILL BE RESET TO THE BACKGROUND'S COLOUR.");
        }

        private void previousFrameButton_Click(object sender, EventArgs e)
        {
            if (_currentFrame.Index > 0)
            {
                changeFrame(int.Parse(frameNumber.Text) - 2);
            }
            else
            {
                raiseErrorMessage("Invalid Frame Index", "Frame indices begin at 1.");
            }
        }

        private void frameNumber_LostFocus(object sender, EventArgs e)
        {
            var index = 0;
            if (int.TryParse(frameNumber.Text, out index))
            {
                changeFrame(index - 1);
            }
            else
            {
                raiseErrorMessage("Invalid Frame Index", "You did not put in a number, did you? Yeah, maybe I should've" +
                                                         " mentioned that we are using arabic numbers for the frames' indices.");
            }
        }

        private void nextFrameButton_Click(object sender, EventArgs e)
        {
            if (_currentFrame.Index < _project.Frames.Count - 1)
            {
                changeFrame(int.Parse(frameNumber.Text));
            }
            else
            {
                raiseErrorMessage("Invalid Frame Index", $"Your index is too large! Your project currently has " +
                                                         $"{_project.Frames.Count} frames.");
            }
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            // This is here literally just so that you can click away from the frame index box.
            if (frameNumber.Focused)
            {
                tableLayoutPanel1.Focus();
            }

            if (frameSpeedTick.Focused)
            {
                tableLayoutPanel1.Focus();
            }
        }

        private void tableLayoutFrameSettings_Click(object sender, EventArgs e)
        {
            // This is here literally just so that you can click away from the frame index box.
            if (frameNumber.Focused)
            {
                tableLayoutPanel1.Focus();
            }

            if (frameSpeedTick.Focused)
            {
                tableLayoutPanel1.Focus();
            }
        }

        private void frameSpeedTick_ValueChanged(object sender, EventArgs e)
        {
            _project.FrameSpeed = (int)frameSpeedTick.Value;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            toolTipFrameSpeed.SetToolTip(label3,
                "The frame speed is in ms (milliseconds).\n\n" +
                "32 ms = 30 fps\n" +
                "16 ms = 60 fps");
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //      Drawing Controls
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _currentFrame.RedoStack.Clear();
            if (_project.Frames.Count > 0)
            {
                IsDrawing = true;
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                _currentStroke = new Stroke(_currentFrame.Strokes.Count)
                {
                    // NOTE: MUST CHANGE THE CURRENT DEFAULTS
                    Colour = buttonPickColour.BackColor,
                    Thickness = _currentStroke.Thickness
                };
                _currentStroke.addPoint(point);
                _currentFrame.Strokes.Add(_currentStroke);
            }
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_project.Frames.Count > 0 && IsDrawing && e.Button == MouseButtons.Left)
            { 
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                _currentStroke.addPoint(point);
                UpdatePictureFrame(_currentFrame);
            }
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (_project.Frames.Count > 0 && IsDrawing)
            {
                var origin = mainPictureBox.PointToScreen(new Point(0, 0));
                var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
                _currentStroke.addPoint(point);
                IsDrawing = false;
                _currentStroke = new Stroke(0); // deselect the stroke
                UpdatePictureFrame(_currentFrame);
            }
            _currentFrame.UndoStack.Push(_currentFrame.Strokes.Last());
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_currentFrame != null)
            {
                foreach (var stroke in _currentFrame.Strokes)
                {
                    using Graphics g = Graphics.FromImage(_currentFrame.Bitmap);
                    using var pen = new Pen(stroke.Colour, stroke.Thickness)
                    {
                        // I was having issues with the strokes being distorted, and Mike gracefully
                        // helped me and showed me that we can do this and it might fix it, which it did!
                        // He deserves an extra 5% just for helping me out.
                        LineJoin = LineJoin.Round,
                        EndCap = LineCap.Round,
                        StartCap = LineCap.Round
                    };
                    for (int i = 0; i < stroke.Points.Count - 1; i++)
                    {
                        g.DrawLine(pen, stroke.Points[i], stroke.Points[i + 1]);
                    }
                }
                ;
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
                _project.FramesFolderPath = newProjectDialog.FramesFolderPath;
                _project.FilePath = $@"{newProjectDialog.ProjectFolderPath}\\{newProjectDialog.ProjectName}.json";
                _project.Name = newProjectDialog.ProjectName;
                FrameSize = newProjectDialog.FrameSize;
                projectNameLabel.Text = _project.Name;
                mainPictureBox.Size = FrameSize;

                newFrameButton.PerformClick();
                tableLayoutFrameSettings.Visible = true;
            }

        }

        /// <summary>
        /// Updates the total number of frames and the current frame the user is using.
        /// </summary>
        private void updateFrameCount()
        {
            frameCountLabel.Text = $"Frame: {_currentFrame.Index + 1}";
            frameNumber.Text = $"{_currentFrame.Index + 1}";
        }

        /// <summary>
        /// Save the current frame to the predetermined folder where all frames are saved. It will
        /// override whatever what previously saved.
        /// </summary>
        /// <param name="frame"></param>
        private void SaveFrame(Frame frame) => frame.Bitmap.Save(frame.Path, ImageFormat.Gif);

        /// <summary>
        /// Save the project. This will save the data for the strokes, frames, and the bitmaps.
        /// </summary>
        private void SaveProject()
        {
            SaveFrame(_currentFrame);
            File.WriteAllText(_project.FilePath, JsonConvert.SerializeObject(_project, Formatting.Indented, 
                new SizeConverter(), new BitmapConverter(), new ColorConverter(), new PointConverter()));
        }

        /// <summary>
        /// Updates mainPictureBox to what was drawn on the bitmap.
        /// </summary>
        /// <param name="frame"></param>
        private void UpdatePictureFrame(Frame frame)
        {
            mainPictureBox.Image = frame.Bitmap;
            mainPictureBox.Update();
        }

        /// <summary>
        /// Raise an dialog with an error icon and a message.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public void raiseErrorMessage(string title, string message)
        {
            MessageBox.Show(message,
                $"Error: {title}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Changes the current frame to the frame at the given index. The indices begin at 0.
        /// </summary>
        /// <param name="index"></param>
        public void changeFrame(int index)
        {
            if (index >= 0 && index < _project.Frames.Count)
            {
                _currentFrame = _project.Frames[index];
                updateFrameCount();
                UpdatePictureFrame(_currentFrame);
            }
            else
            {
                raiseErrorMessage("Invalid Frame Index", "Your frame index is invalid.");
            }
        }
    }
}
