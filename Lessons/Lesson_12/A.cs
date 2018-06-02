using System;

namespace Lesson_12
{
    class A
    {
        public byte Byte;
        public virtual void Do()
        {
            Console.WriteLine();
            Console.WriteLine("A.Do - virtual");
        }
    }

    class B : A
    {
        public int Int;
        public override void Do()
        {
            base.Do();
            Console.WriteLine("B.Do - override");
        }

        /// <summary>
        /// Оператор неявного приведения типа int к типу B -> B b =(B)int;
        /// </summary>
        /// <param name="i"></param>
        public static implicit operator B(int i)
        {
            return new B { Int = i };
        }

        /// <summary>
        /// Оператор неявного приведения типа F к типу B -> B b = (B)F;
        /// </summary>
        /// <param name="f"></param>
        public static implicit operator B(F f)
        {
            return new B { Int = (int)f.Long };
        }

        /// <summary>
        /// Оператор явного приведения типа B к типу int -> int x = new B() { Int = 5};
        /// </summary>
        /// <param name="b"></param>
        public static explicit operator int(B b)
        {
            return b.Int;
        }

        /// <summary>
        /// Оператор явного приведения типа B к типу string -> string s = new B();
        /// </summary>
        /// <param name="b"></param>
        public static explicit operator string(B b)
        {
            return "Тип B всегда приводится к такой строке!";
        }
    }

    class C : B
    {
        public new virtual void Do()
        {
            Console.WriteLine();
            Console.WriteLine("C.Do - new virtual");
        }
    }

    sealed class D : C
    {

        public override void Do()
        {
            base.Do();
            Console.WriteLine("D.Do - override");
        }
    }

    class F
    {
        public long Long;
    }
}