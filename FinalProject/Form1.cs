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
    public partial class Form1 : Form
    {
        public List<Frame> Frames = new List<Frame>();
        public List<Stroke> Strokes = new List<Stroke>();
        public int currentStroke;

        public Form1()
        {
            InitializeComponent();
            // Type defaults in here
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void drawingBoardMain_MouseDown(object sender, MouseEventArgs e)
        {
            var origin = drawingBoardMain.PointToScreen(new Point(0, 0));
            var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
            var stroke = new Stroke()
            {
                // NOTE: MUST CHANGE THE CURRENT DEFAULTS
                StrokeColour = Color.Blue,
                StrokeThickness = 10,
                IsDrawing = true,
            };
            stroke.addPoint(point);
            Strokes.Add(stroke);
            currentStroke = Strokes.Count - 1;
        }

        private void drawingBoardMain_MouseMove(object sender, MouseEventArgs e)
        {
            var origin = drawingBoardMain.PointToScreen(new Point(0, 0));
            var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
            if (Strokes.Count != 0 && Strokes[currentStroke].IsDrawing)
            {
                Strokes[currentStroke].addPoint(point);
            }
            drawingBoardMain.Invalidate();
        }

        private void drawingBoardMain_MouseUp(object sender, MouseEventArgs e)
        {
            var origin = drawingBoardMain.PointToScreen(new Point(0, 0));
            var point = new Point(MousePosition.X - origin.X, MousePosition.Y - origin.Y);
            Strokes[currentStroke].addPoint(point);
            Strokes[currentStroke].IsDrawing = false;
            drawingBoardMain.Invalidate();
        }

        private void drawingBoardMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var stroke in Strokes)
            {
                using var pen = new Pen(stroke.StrokeColour, stroke.StrokeThickness);
                for (int i = 0; i < stroke.points.Count - 1; i++)
                {
                    e.Graphics.DrawLine(pen, stroke.points[i], stroke.points[i+1]);
                }
            }
        }

        /// <summary>
        /// Updates the total number of frames and the current frame the user is using.
        /// </summary>
        private void updateFrameCount()
        {
            frameCountLabel.Text = $"Frame: {0}";
        }

        private void newLine()
        {

        }
    }
}
