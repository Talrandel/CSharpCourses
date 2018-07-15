using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace ClassesLibrary.Figures
{
    public abstract class FigureBase
    {
        private Point _centre;
        /// <summary>
        /// Координаты центра фигуры
        /// </summary>
        public Point Centre { get { return _centre; } private set { _centre = value; } }

        private string _colour;
        /// <summary>
        /// Цвет фигуры
        /// </summary>
        public string Colour { get { return _colour; } private set { _colour = value; } }

        /// <summary>
        /// Имя фигуры
        /// </summary>
        private string _name;
        public string Name {
            get { return _name; }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Некорректное значение свойства Name класса FigureBase");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает периметр
        /// </summary>
        /// <returns>Периметр</returns>
        protected abstract double GetPerimetr();

        /// <summary>
        /// Возвращает площадь
        /// </summary>
        /// <returns>Площадь</returns>
        protected abstract double GetSquare();

        /// <summary>
        /// Выводит на экран информацию о фигуре
        /// </summary>
        public abstract void ShowInfo();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Figure"/> с заданными значениями
        /// </summary>
        /// <param name="centre">Координаты центра фигуры</param>
        /// <param name="colour">Цвет фигуры</param>
        public FigureBase(Point centre, string colour)
        {
            _centre = centre;
            _colour = colour;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Figure"/> с начальными значениями
        /// </summary>
        public FigureBase() : this(new Point() { X = 0, Y = 0 }, "no _colour")
        {
        }
    }
}