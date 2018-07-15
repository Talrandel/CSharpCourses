using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.Figures
{
    /// <summary>
    /// Представляет окружность
    /// </summary>
    public class Circle : FigureBase
    {
        /// <summary>
        /// Значение радуиса окружности
        /// </summary>
        private int _radius;
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Incorrect radius of circle");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Возвращает периметр окружности (длину окружности)
        /// </summary>
        /// <returns>Периметр окружности</returns>
        protected override double GetPerimetr()
        {
            return 2 * 3.14 * Radius;
        }

        /// <summary>
        /// Возвращает площадь окружности
        /// </summary>
        /// <returns>Площадь окружности</returns>
        protected override double GetSquare()
        {
            return Radius * Radius * 3.14;
        }

        /// <summary>
        /// Выводит на экран информацию о окружности
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine(Name + ":\n" + Centre.ToString() + "\nColour-" + Colour + "\nRadius: " + Radius + "\nPerimetr=" + GetPerimetr() + "\nSquare=" + GetSquare() + "\n");
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle"/> с заданными значениями
        /// </summary>
        /// <param name="centre">Координаты центра окружности</param>
        /// <param name="colour">Цвет окружности</param>
        /// <param name="radius">Значение радиуса окружности</param>
        public Circle(Point centre, string colour, int radius)
            : base(centre, colour)
        {
            Name = GetType().Name;
            Radius = radius;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle"/> с начальными значениями
        /// </summary>
        public Circle() : this(new Point() { X = 0, Y = 0 }, "no _colour", 0)
        {
        }
    }
}
