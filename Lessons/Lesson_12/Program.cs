using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Перекрытие методов
            //A a = new A();
            //A b = new B();
            //C c = new C();
            //A d = new D();

            //a.Do();
            //b.Do();
            //c.Do();
            //d.Do(); 
            #endregion

            // Явное преобразование
            //c = (C)d;

            //int x = (int)d;

            //long l = 157;
            //object o = l;
            //int i = (int)o;

            B b = new B() { Int = 5 };

            int x = (int)b;
            Console.WriteLine(x);

            string s1 = (string)b;
            Console.WriteLine(s1);

            string s2 = (string)new B();
            Console.WriteLine(s2);

            B newB = 157;
            Console.WriteLine(newB.Int);


            Console.ReadLine();
        }
    }
}