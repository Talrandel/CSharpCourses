using System;

namespace Lesson_4_Tasks
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            FourteenTask();
            Console.ReadLine();
        }

        static void FourteenTask()
        {
            int[,] matrix;

            Console.WriteLine("Введите размерность матрицы: ");
            int size = int.Parse(Console.ReadLine());

            matrix = new int[size, size];

            FillMatrixWithRandomNumbers(matrix);

            PrintMatrix(matrix);

            Console.WriteLine("Определитель матрицы = " + GetDeterminant(matrix));
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        private static void FillMatrixWithRandomNumbers(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] GetMinor(int[,] matrix, int x, int y)
        {
            int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            // счетчики для элементов минора
            int minorRow = 0, minorColumn = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == x)
                    continue;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j == y)
                        continue;
                    minor[minorRow, minorColumn] = matrix[i, j];
                    minorColumn++;
                }
                minorRow++;
                minorColumn = 0;
            }
            return minor;
        }

        static int GetDeterminant(int[,] matrix)
        {
            if (matrix.GetLength(0) == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];

            int determinant = 0;
            int sign = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sign = (i % 2 == 0) ? 1 : -1;
                determinant += sign * matrix[0, i] * GetDeterminant(GetMinor(matrix, 0, i));
            }

            return determinant;
        }
    }
}