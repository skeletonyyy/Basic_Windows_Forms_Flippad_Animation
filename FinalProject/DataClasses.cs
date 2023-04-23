using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Frame
    {
        public int FrameIndex;
        public string FramePath;
        public Size FrameSize; // Frame size in pixels
        public Bitmap FrameBitmap;
        public int StrokeIndex;
        public List<Stroke> Strokes = new List<Stroke>();

        public Frame(int i, int j, string path, Size size)
        {
            FrameIndex = i;
            StrokeIndex = j;
            FramePath = path;
            FrameSize = size;
        }
    }
    public class Stroke : StrokeModel
    {
        public void addPoint(Point point)
        {
            Points.Add(point);
        }
    }

    public class Project : ProjectModel
    {
        public string FramesFolderPath;

        /*public Project()
        {
            FramesFolderPath = framesPath;
            ProjectFilePath = projectPath;
            ProjectName = name;
        }*/

        public bool isEmpty()
        {
            if (FramesFolderPath == null && ProjectFilePath == null && ProjectName == null)
            {
                return true;
            }
            return false;
        }

        public void changeName(string name)
        {
            ProjectFilePath = $"{ProjectFilePath.Remove(ProjectFilePath.Length - ProjectName.Length, ProjectName.Length)}{ProjectName}";
            ProjectName = name;
        }
    }
}
