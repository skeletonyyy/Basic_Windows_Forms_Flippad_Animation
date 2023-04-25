using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace FinalProject
{
    public class Frame
    {
        public int Index;
        public string Path;
        public Size Size; // Frame size in pixels
        public Bitmap Bitmap;
        public Color BackColour;
        public List<Stroke> Strokes = new List<Stroke>();

        public Frame(int i, string path, Size size, Color colour)
        {
            Index = i;
            Path = path;
            Size = size;
            BackColour = colour;
            Bitmap = new Bitmap(Size.Width, Size.Height);
            updateBackColour(BackColour);
        }

        public void updateBackColour(Color colour)
        {
            // Inspired by Anon here: https://www.syncfusion.com/faq/windowsforms/bitmaps-and-images/how-do-i-overlay-one-bitmap-over-another
            // and Sam Saarian's answer here: https://stackoverflow.com/questions/1720160/how-do-i-fill-a-bitmap-with-a-solid-color

            Bitmap bmp = new Bitmap(Size.Width, Size.Height);
            using Graphics g = Graphics.FromImage(bmp);
            g.Clear(colour);
            Bitmap.MakeTransparent(BackColour);
            g.DrawImage(Bitmap, 0, 0);
            Bitmap.Dispose(); // help with bitmap taking too much space.
            Bitmap = bmp;
            BackColour = colour;
        }
    }
    public class Stroke : StrokeModel
    {
        public int Index;

        public Stroke(int i)
        {
            Index = i;
        }

        public void addPoint(Point point)
        {
            Points.Add(point);
        }
    }

    public class Project
    {
        public string Name;
        public string FilePath;
        public string FramesFolderPath;
        public List<Frame> Frames = new List<Frame>();

        public bool isEmpty() => FramesFolderPath == null && FilePath == null && Name == null;

        public void changeName(string name)
        {
            FilePath = $"{FilePath.Remove(FilePath.Length - Name.Length, Name.Length)}{Name}";
            Name = name;
        }
    }
}
