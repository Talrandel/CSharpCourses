using System;

namespace Lesson_7
{
    /// <summary>
    /// Точка.
    /// </summary>
    struct Point
    {
        /// <summary>
        /// Координата по X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Координата по Y.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Печать информации о точке.
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Точка: X: " + X + ", Y: " + Y);
        }

        /// <summary>
        /// Конструктор точки.
        /// </summary>
        /// <param name="x">Координата по X.</param>
        /// <param name="y">Координата по Y.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}