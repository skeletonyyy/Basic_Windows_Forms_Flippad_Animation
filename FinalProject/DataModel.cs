using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /* This data model file was heavily inspired by Christopher Diggins' data model for his SVG Editor.
       The project can be found here: https://github.com/cdiggins/svg-editor */

    public class StrokeModel
    {
        public List<Point> Points = new List<Point>();
        public Color Colour;
        public float Thickness;
    }
}
