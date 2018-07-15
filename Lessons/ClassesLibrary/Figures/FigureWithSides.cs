using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.Figures
{
    public abstract class FigureWithSides : FigureBase
    {
        /// <summary>
        /// Значение сторон фигуры со сторонами
        /// </summary>
        public virtual int[] Sides { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FigureWithSides"/> с заданными значениями
        /// </summary>
        /// <param name="centre">Координаты центра фигуры</param>
        /// <param name="colour">Цвет фигуры</param>
        public FigureWithSides(Point centre, string colour)
            : base(centre, colour)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Figure"/> с начальными значениями
        /// </summary>
        public FigureWithSides() : this(new Point() { X = 0, Y = 0 }, "no _colour")
        {
        }
    }
}