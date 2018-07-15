using System;

namespace ClassesLibrary.Figures
{
    /// <summary>
    /// Представляет треугольник
    /// </summary>
    public class Triangle : FigureWithSides
    {
        /// <summary>
        /// Кол-во сторон треугольника
        /// </summary>
        private const int SidesNumber = 3;

        /// <summary>
        /// Стороны треугольника
        /// </summary>
        public override int[] Sides { get; }

        /// <summary>
        /// Возвращает периметр треугольника
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        protected override double GetPerimetr()
        {
            return Sides[0] + Sides[1] + Sides[2];
        }

        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        protected override double GetSquare()
        {
            return (Sides[1] * Sides[2]) / 2;
        }

        /// <summary>
        /// Выводит на экран информацию о треугольнике
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine(Name + ":\n" + Centre.ToString() + "\nColour-" + Colour + "\nSides: " + Sides[0] + "," + Sides[1] + "," + Sides[2] + "\nPerimetr=" + GetPerimetr() + "\nSquare=" + GetSquare() + "\n");
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Triangle"/> с заданными значениями
        /// </summary>
        /// <param name="centre">Координаты центра треугольника</param>
        /// <param name="colour">Цвет треугольника</param>
        /// <param name="sides">Значение сторон треугольника</param>
        public Triangle(Point centre, string colour, int[] sides)
            : base(centre, colour)
        {
            Name = GetType().Name;
            if (sides.Length != SidesNumber)
            {
                throw new Exception("Incorrect number of sides of triangle");
            }
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] < 0)
                {
                    throw new Exception("Incorrect sides of triangle");
                }
            }
            Sides = sides;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Triangle"/> с начальными значениями
        /// </summary>
        public Triangle() : this(new Point() { X = 0, Y = 0 }, "no _colour", new int[3] { 0, 0, 0 })
        {
        }
    }
}