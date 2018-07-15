using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.Figures
{
    /// <summary>
    /// Представляет квадрат
    /// </summary>
    public class Square : FigureWithSides
    {
        /// <summary>
        /// Кол-во сторон квадрата
        /// </summary>
        private const int SidesNumber = 4;

        /// <summary>
        /// Стороны квадрата
        /// </summary>
        public override int[] Sides { get; }

        /// <summary>
        /// Возвращает периметр квадрата
        /// </summary>
        /// <returns>Периметр квадрата</returns>
        protected override double GetPerimetr()
        {
            return 4 * Sides[0];
        }

        /// <summary>
        /// Возвращает площадь квадрата
        /// </summary>
        /// <returns>Площадь квадрата</returns>
        protected override double GetSquare()
        {
            return (Sides[1] * Sides[2]);
        }

        /// <summary>
        /// Выводит на экран информацию о квадрате
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine(Name + ":\n" + Centre.ToString() + "\nColour-" + Colour + "\nSides: " + Sides[0] + "," + Sides[1] + "," + Sides[2] + "," + Sides[3] + "\nPerimetr=" + GetPerimetr() + "\nSquare=" + GetSquare() + "\n");
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Square"/> с заданными значениями
        /// </summary>
        /// <param name="centre">Координаты центра квадрата</param>
        /// <param name="colour">Цвет квадрата</param>
        /// <param name="sides">Значение сторон квадрата</param>
        public Square(Point centre, string colour, int[] sides)
            : base(centre, colour)
        {
            Name = GetType().Name;
            if (sides.Length != SidesNumber)
            {
                throw new Exception("Incorrect number of sides of foursquare");
            }
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] < 0)
                {
                    throw new Exception("Incorrect sides of foursquare");
                }
            }
            Sides = sides;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Square"/> с начальными значениями
        /// </summary>
        public Square() : this(new Point() { X = 0, Y = 0 }, "no _colour", new int[4] { 0, 0, 0, 0 })
        {
        }
    }
}
