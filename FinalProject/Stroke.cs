using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProject
{
    public class Stroke
    {
        public List<Point> points = new List<Point>();
        public Color StrokeColour;
        public float StrokeThickness;
        public bool IsDrawing = false;

        public void addPoint(Point point)
        {
            points.Add(point);
        }
    }
}
