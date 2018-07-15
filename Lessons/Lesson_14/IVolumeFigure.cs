using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    interface IVolumeFigure
    {
        int Height { get; set; }

        double GetVolume();
    }
}
