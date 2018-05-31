using System;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle();
            //tr.ShowInfo();
            //tr.Side = 5;
            //tr.Color = "Белый";
            //tr.Center = new Point() { X = 5, Y = 7 };

            tr = new Triangle(5, "Белый", new Point(5, 7));
            tr.ShowInfo();

            Console.WriteLine(tr["Side"]);
            Console.WriteLine(tr["Color"]);

            int[] array = new int[5];

            array[0] = 5;
            array.SetValue(5, 0);

            int x = array[0];
            x = (int)array.GetValue(0);

            Console.WriteLine(tr["блаблабла"]);

            Console.ReadLine();
        }
    }
}