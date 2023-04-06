using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Frame
    {
        // not sure if we'll need this, but add path to Frame's file, index
        private string _framePath;
        public static int Index;

        public Frame(string path, int i)
        {
            _framePath = path;
            Index = i;
        }

        public string FramePath => _framePath;
    }
}
