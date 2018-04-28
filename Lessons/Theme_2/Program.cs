using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theme_2.Subnamespace;

namespace Theme_2
{
    class Program
    {
        static bool SomeBool;

        // Именование переменных
        // underlineLowerCamelCase
        static int _lowerCamelCase = -1;
        // lowerCamelCase
        static int lowerCamelCase = 1;
        // UpperCamelCase
        static int MyHeight = 157;

        const int SOME_CONST = 5;

        static void Main(string[] args)
        {
            // Области видимости
            Theme_2.Subnamespace.SomeClass.Number = 10;
            // TODO: напомнить в контексте циклов
            //int x = 157;
            //Console.WriteLine("x = " + x);
            //{
            //    int y = 23;
            //    int x = 1000;
            //}
            //int x = 157;
            //Console.WriteLine("x = " + x);

            // Преобразования типов
            //byte b = 25;
            //Console.WriteLine("b = " + b);
            //// Неявное преобразование byte к int
            //int x = b + 260;
            //Console.WriteLine("x = " + x);
            //// Явно преобразование int к byte
            //byte newByte = (byte)x;
            //Console.WriteLine("newByte = " + newByte);
            //// Явно преобразование double к int
            //int newInt = (int)9.6;
            //Console.WriteLine("newInt = " + newInt);
            //// Явно преобразование double к int
            //int newInt2 = Convert.ToInt32(-127.7);
            //Console.WriteLine("newInt2 = " + newInt2);

            // Арифметические операции
            // + - * / % - бинарные операции, требуют два операнда
            // ++ и -- - унарные операции
            //int a = 5 + 7;
            //Console.WriteLine("a = " + a);
            ////a++; // постфиксная
            //Console.WriteLine("a = " + a++);
            ////++a; // префиксная
            //Console.WriteLine("a = " + ++a);

            //// Длинный вариант
            //a = a + 10;
            //// Короткий вариант
            //a += 10;
            //// Аналогично для инкремента
            //a = a + 1;
            //a++;

            // Логические операции
            //bool trueBool = true;
            //Console.WriteLine("trueBool = " + trueBool);
            //// Объявлена над методом Main
            //Console.WriteLine("SomeBool = " + SomeBool);

            //// Двойные операторы - вычисляется выражение до первой "несостыковки"
            //bool first = true && true;
            //bool second = true || false;
            //Console.WriteLine("first = " + first);
            //Console.WriteLine("second = " + second);
            //Console.WriteLine();
            //bool third = true ^ true;
            //Console.WriteLine("third = " + third);
            //third = true ^ false;
            //Console.WriteLine("third = " + third);
            //third = false ^ false;
            //Console.WriteLine("third = " + third);

            //// Одиночные операторы - вычисляется все выражение
            //bool result1 = true | false && (true && false) || (true ^ (true || false));
            //bool result2 = false & true | true;
            //// Операции сравнения: >, <, ==, >=, =<


            // Ветвление
            //int input;
            //Console.WriteLine("Введи число: ");
            //input = Convert.ToInt32(Console.ReadLine());
            //// Первый вариант:
            ////if (input > 0)
            ////{
            ////    Console.WriteLine("Число больше 0!");
            ////}
            ////else if (input == 0)
            ////{
            ////    Console.WriteLine("Число равно 0!");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Число меньше 0!");
            ////}
            //if (input > 0)
            //{
            //    Console.WriteLine("Число больше 0!");
            //    Console.WriteLine("Press Enter to exit.");
            //    Console.ReadLine();
            //    return;
            //}
            ////else
            ////{
            //    Console.WriteLine("Число меньше 0!");
            //    return;
            ////}

            //// switch case operator
            //int input;
            //Console.WriteLine("Введи день недели (1-7): ");
            //input = Convert.ToInt32(Console.ReadLine()) % 7;
            //DayOfWeek day = (DayOfWeek)input;
            //switch (day)
            //{
            //    case DayOfWeek.Monday:
            //    case DayOfWeek.Tuesday:
            //    case DayOfWeek.Wednesday:
            //    case DayOfWeek.Thursday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Work day!");
            //        break;
            //    default:
            //        Console.WriteLine("Weekend!");
            //        break;
            //}

            //// Тернарный оператор
            //string message = (day == DayOfWeek.Sunday) ? "It's sunday!" : "It's not a sunday!";
            //if (day == DayOfWeek.Sunday)
            //{
            //    message = "It's sunday!";
            //}
            //else
            //{
            //    message = "It's not a sunday!";
            //}
            //Console.WriteLine(message);

            // Циклы:
            // While
            while (false)
            {
                Console.WriteLine("ААААААА");
            }
            // do while
            do
            {
                Console.WriteLine("В отличие от while, я выполнюсь хотя бы один раз!");
            } while (false);
            Console.WriteLine();
            // for
            //int i = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine("Итерация №" + i);
                //if (i > 5)
                //    break;
                for (int j = 0; j < 10; j++)
                {

                }
            }
            //Console.WriteLine("i после цикла = " + i);


            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}

namespace Theme_2.Subnamespace
{
    class SomeClass
    {
        public static int Number = 157;
    }
}