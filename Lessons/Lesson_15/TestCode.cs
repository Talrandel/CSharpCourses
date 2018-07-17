using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class TestCode
    {
        static void ExceptionsTest()
        {
            try
            {
                //int a = 157;
                //int b = 0;
                //int c = a / b;
                //Console.WriteLine(c);
                //Console.WriteLine("Успешное деление!");

                //Circle c = new Circle();
                //c.Name = null;

                //throw new Exception("Первый уровень");
                try
                {
                    int a = 157;
                    int b = 0;
                    int c = a / b;
                }
                catch (DivideByZeroException ex2)
                {
                    Console.WriteLine("Exception!");
                    Console.WriteLine(ex2.Message);
                    throw new Exception("Inner exception!", ex2);
                }
            }
            //catch (NullReferenceException nre)
            //{
            //    Console.WriteLine("NullReferenceException!");
            //    Console.WriteLine(nre.Message);
            //}
            //catch (DivideByZeroException div)
            //{
            //    Console.WriteLine("DivideByZeroException!");
            //    Console.WriteLine(div.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
                Console.WriteLine(ex.Message);
                try
                {
                    throw new Exception("Второй уровень");
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Exception 222!");
                    Console.WriteLine(ex2.Message);
                }
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.Read();
        }
    }
}
