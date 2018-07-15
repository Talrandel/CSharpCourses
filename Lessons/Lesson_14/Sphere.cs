using System;
using ClassesLibrary.Figures;

namespace Lesson_14
{
    class Sphere : Circle, IVolumeFigure
    {
        public int Height
        {
            get { return Radius; }
            set { Radius = value; }
        }

        public double GetVolume()
        {
            return GetSquare() * Height;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Высота: " + Height);
            Console.WriteLine("Объем: " + GetVolume());
        }
    }
}