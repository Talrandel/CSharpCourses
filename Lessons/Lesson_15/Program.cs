using System;
using ClassesLibrary;
using ClassesLibrary.Figures;

/// <summary>
/// Exceptions
/// </summary>
namespace Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 666;
            int b = 0;
            int c;
            try
            {

                int[] arr = new int[4];
                arr[0] = 16; arr[1] = 32; arr[2] = 14; arr[3] = 69;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                //Square square_lol = new Square();
                //square_lol.Name = "";
                
                throw new CustomException();

                c = a / b;
                Console.WriteLine("Всё работает!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Мы словили исключение!!!");
                c = 69;
            }
            catch (IndexOutOfRangeException ire)
            {
                Console.WriteLine(ire.Message);
                Console.WriteLine("Опять исключение!!!");
                c = 72;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Мы словили исключение!!!");
                c = 753;
                //try
                //{
                //    throw new CustomException();
                //}
                //catch
                //{
                //    Console.WriteLine(ex.Message);
                //    Console.WriteLine("ДА СКОКА МОЖНО КРАШИТЬСЯ!!!!");
                //}
            }
            finally
            {
                Console.WriteLine("Finally!");
            }
            Console.WriteLine("c = " + c);
            Console.ReadLine();
        }
    }
}