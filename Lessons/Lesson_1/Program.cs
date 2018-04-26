using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int32 myInt32 = 999;
            //double myDouble = 5.7;
            //bool myFlag = true;
            //char myChar = 'q';
            //string myString = "Some string!";
            //String myString2;

            //byte myByte = 100;
            //long myLong = 12345678;

            //int myInt = 157;
            //object myObject;
            ////myObject = "Строка - объект!";
            ////myObject = false;

            //// Внутри myObject лежит int 157
            //myObject = myInt;

            //int myInt2 = (int)myObject;
            //Console.WriteLine("Значение переменной myInt: ");
            //Console.WriteLine(myInt);
            //Console.WriteLine("Значение переменной myObject: ");
            //Console.WriteLine(myObject);
            //Console.WriteLine("Значение переменной myInt2: ");
            //Console.WriteLine(myInt2);
            //Console.WriteLine();

            //byte myByte = 12;
            //myObject = myByte;
            //int myInt3 = (int)myObject;

            //Console.WriteLine("Значение переменной myByte: ");
            //Console.WriteLine(myByte);
            //Console.WriteLine("Значение переменной myObject: ");
            //Console.WriteLine(myObject);
            //Console.WriteLine("Значение переменной myInt3: ");
            //Console.WriteLine(myInt3);

            //Console.Write("Вывод текста как есть.");
            //Console.WriteLine("Печать текста с новой строки.");

            //Console.WriteLine("Введите текст:");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Вы ввели следующий текст:");
            //Console.WriteLine(inputString);

            //Console.WriteLine("Введите число:");
            ////int inputNumber = Convert.ToInt32(Console.ReadLine());
            //int inputNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Вы ввели число:");
            //Console.WriteLine(inputNumber);

            //const int MyConstInt = 15;

            //MyEnum myEnum = MyEnum.First;

            //Console.WriteLine((int)myEnum);
            //Console.WriteLine((int)MyEnum.Second);
            //Console.WriteLine((int)MyEnum.Third);



            //Console.WriteLine(DayOfWeek.Monday);
            //Console.WriteLine(DayOfWeek.Sunday);
            //Console.WriteLine((int)DayOfWeek.Thursday);

            DateTime dateTime = DateTime.Now;
            DateTime dateTime2 = new DateTime();
            DateTime dateTime3 = new DateTime(2018, 5, 6);
            DateTime dateTime4 = new DateTime(2018, 5, 6, 10, 15, 25);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime2);
            Console.WriteLine(dateTime3);
            Console.WriteLine(dateTime4);

            Console.ReadLine();
        }

        enum MyEnum : int
        {
            First = 777,
            Second = 157,
            Third
        }
    }
}