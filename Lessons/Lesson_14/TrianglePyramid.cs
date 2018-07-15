using ClassesLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class TrianglePyramid : Triangle, IVolumeFigure
    {
        public int Height { get; set; }

        public double GetVolume()
        {
            return GetSquare() * Height;
        }
    }
}