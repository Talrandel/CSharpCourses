using System;

namespace Lesson_4
{
    static class Program
    {
        static void Main()
        {

            #region Методы

            // ИмяМетода();
            //SimpleMethod();

            //int methodResult = SimpleMethodInt();
            //Console.WriteLine("Результат выполнения метода сохранен в переменную methodResult и равен " + methodResult);

            // Вызываем метод, возвращающий значение, не сохраняя результат.
            //SimpleMethodInt();

            //int x = 5, y = 7;
            //int methodResult2 = SimpleMethodWithParameters(x, y);

            //int sum1 = Sum(5, 10);
            //double sum2 = Sum(20.1, 17);
            //long sum3 = Sum(10000000000, 1);

            //int sum4 = Sum(1, 2, 3);
            //int sum5 = Sum();
            //int sum6 = Sum(1);
            //int sum7 = Sum(1, 2);
            //int sum8 = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            //int intRef = 1;
            //Console.WriteLine("intRef до вызова метода: " + intRef);
            //SimpleMethodRefParameter(ref intRef);
            //Console.WriteLine("intRef после вызова метода: " + intRef);


            //int intOut;
            ////Console.WriteLine("intOut до вызова метода: " + intOut);
            //SimpleMethodOutParameter(out intOut);
            //Console.WriteLine("intOut после вызова метода: " + intOut);


            //int input;
            //Console.WriteLine("Введи число: ");
            //string inputString = Console.ReadLine();
            //// Нормальное преобразование строки к числу - TryParse
            ////bool parseResult = int.TryParse(inputString, out input);
            //if (int.TryParse(inputString, out input))
            //{
            //    Console.WriteLine("Пользователь ввел число: " + input);
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Пользователь ввел не число! Переменная input равна " + input);
            //}
            //// Не самое удачное преобразование строки к числу с возможным падением программы
            //input = int.Parse(inputString);
            //Console.WriteLine("Пользователь ввел число: " + input);


            #endregion

            #region Массивы

            // Одномерные массивы
            // тип[] имя
            int[] array;
            // инициализация массива - первый вариант
            array = new int[5];
            // второй вариант
            int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
            // третий вариант - работает только при объявлении и инициализации в одной строке
            int[] array3 = { 1, 2, 3, 4, 5 };

            //array[0] = 0;
            //array[1] = 1;
            //array[2] = 2;
            //array[3] = 3;
            //array[4] = 4;

            //int x = array[0];
            //Console.WriteLine("a[0] = " + x);
            //Console.WriteLine("Длина массива array: " + array.Length);

            //for (int i = 0; i < array.Length + 1; i++)
            //{
            //    array[i] = i;
            //    Console.WriteLine(array[i]);
            //}

            // Двумерные массивы
            //int[,] twoDimensionalArray = new int[3, 3];
            //for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
            //    {
            //        twoDimensionalArray[i, j] = i * twoDimensionalArray.GetLength(0) + j;
            //        Console.Write(twoDimensionalArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Количество элементов массива: " + twoDimensionalArray.Length);
            //Console.WriteLine("Размерность массива: " + twoDimensionalArray.Rank);
            // Многомерный массив
            //int[,,,] strangeArray = new int[2, 4, 6, 8];

            Random rand = new Random();
            rand.Next(0, 10);

            int[][] jaggedArray = new int[5][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[rand.Next(1, 7)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rand.Next(0, 100);
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            #endregion
            
            Console.WriteLine("Нажми Enter для выхода.");
            Console.ReadLine();
        }

        // Сигнатура метода - void SimpleMethod()
        static void SimpleMethod()
        {
            Console.WriteLine("Эта строка напечатается внутри метода SimpleMethod.");
            return;
        }

        // Сигнатура метода - int SimpleMethodInt()
        // ТипВозвращаемогоЗначения ИмяМетода(параметры)
        static int SimpleMethodInt()
        {
            int a = 5;
            int b = 7;
            int c = a + b;
            return c;
        }

        // Параметры методов
        static int SimpleMethodWithParameters(int a, int b)
        {
            int c = a + b;
            return c;
        }

        // Перегрузка метода
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static long Sum(long a, long b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // params - только к последнему параметру метода
        static int Sum(params int[] intParams)
        {
            int result = 0;
            for (int i = 0; i < intParams.Length; i++)
            {
                result += intParams[i];
            }
            return result;
        }

        // ref
        static void SimpleMethodRefParameter(ref int a)
        {
            a = 100;
        }

        // out
        static void SimpleMethodOutParameter(out int a)
        {
            a = 100;
        }

    }
}