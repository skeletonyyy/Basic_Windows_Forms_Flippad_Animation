using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    // add not that the controllers are inspired by Christopher's
    public class FileController
    {
        private string _framesFolderPath;

        public string FrameFolderPath
        {
            get => _framesFolderPath;
            set => _framesFolderPath = value;
        }

        public FileController()
        {

        }
    }
}
