using System;

namespace Lesson_7
{
    /// <summary>
    /// Класс треугольника.
    /// </summary>
    class Triangle
    {
        // Константы
        // Статические члены
        // Приватные поля
        // Конструкторы
        // Публичные свойства и методы
        // Приватные методы
        private int _side;

        /// <summary>
        /// Базовая длина стороны треугольника.
        /// </summary>
        public const int DefaultSide = 1;
        private const string DefaultColor = "Без цвета";

        public readonly int SomeField;

        /// <summary>
        /// Конструктор треугольника по умолчанию.
        /// </summary>
        public Triangle()
            : this(DefaultSide, DefaultColor, new Point(0, 0))
        {
        }

        /// <summary>
        /// Конструктор треугольника.
        /// </summary>
        /// <param name="side">Сторона треугольника.</param>
        /// <param name="Color">Цвет треугольника.</param>
        /// <param name="center">Центр треугольника.</param>
        public Triangle(int side, string Color, Point center)
        {
            SomeField = 42;
            Name = "Треугольник";
            Side = side;
            this.Color = Color;
            Center = center;
        }

        /// <summary>
        /// Центр треугольника.
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// Имя фигуры.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Цвет треугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Сторона треугольника.
        /// </summary>
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Длина стороны треугольника не может быть меньше или равна нулю!");
                else
                    _side = value;
            }
        }

        /// <summary>
        /// Индексатор класса <see cref="Triangle"/> для получения значения свойства объекта по его имени.
        /// </summary>
        /// <param name="propertyName">Имя свойства треугольника.</param>
        /// <returns></returns>
        public string this[string propertyName]
        {
            get
            {
                switch (propertyName)
                {
                    case "Side":
                        return Side.ToString();
                    case "Color":
                        return Color;
                    case "Name":
                        return Name;
                    case "Center":
                        return Center.ToString();
                    default:
                        return "Строка, которая никак не относится к треугольнику и/или его свойствам.";
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return index.ToString();
            }
        }

        /// <summary>
        /// Печать информации о треугольнике.
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Центр треугольника: ");
            Center.ShowInfo();
            Console.WriteLine("Длина стороны: " + Side);
            Console.WriteLine("Периметр: " + GetPerimeter());
            Console.WriteLine("Площадь: " + GetSquare());
            Console.WriteLine();
        }

        private int GetPerimeter()
        {
            return Side * 3;
        }

        private double GetSquare()
        {
            return Math.Pow(Side, 2) * Math.Sqrt(3) / 4;
        }
    }
}