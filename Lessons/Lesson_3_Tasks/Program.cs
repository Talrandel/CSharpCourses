using System;

namespace Lesson_3_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //Second();
            //Third();
            Fourth();
            Console.ReadLine();
        }

        static void First()
        {

        }

        static void Second()
        {
            int a, b;
            Console.WriteLine("Введите число а: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            b = int.Parse(Console.ReadLine());

            // a = 5
            // b = 7
            if (a > b)
            {
                // Swap to int numbers without using temp variable
                //a = a + b; // 12
                //b = a - b; // 5
                //a = a - b; // 7

                // a = 101
                // b = 111

                a = a ^ b; // 010
                b = a ^ b; // 010 ^ 111 = 101
                a = a ^ b; // 010 ^ 101 = 111
            }

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }

            Console.WriteLine("Сумма нечетных целых чисел в диапазоне [" + a + ", " + b + "] " + sum);

        }

        static void Third()
        {
            Console.WriteLine("Введите высоту");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 0; j < h - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("^");
                }
                for (int j = 0; j < h - j; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Fourth()
        {
            Console.WriteLine(DateTime.Now);
            int q;
            string surname;
            int age;
            int average;
            int max = 0;
            int min = 120;
            int sum = 0;
            string maxsurname = "You haven't entered any names", minsurname = "You haven't entered any names";


            Console.WriteLine("Enter the quantity of visitors: ");
            q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("Visitor " + (i + 1));
                Console.Write("surname: ");
                surname = Console.ReadLine();
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < min)
                {
                    min = age;
                    minsurname = surname;
                }
                if (age > max)
                {
                    max = age;
                    maxsurname = surname;
                }
                sum = sum + age;
            }
            Console.WriteLine("the oldest visitor is " + maxsurname + "  It's age:" + max);
            Console.WriteLine("the youngest visitor is " + minsurname + "  It's age:" + min);
            average = sum / q;
            Console.WriteLine("Average age is " + average);
            Console.ReadLine();
        }
    }
}
