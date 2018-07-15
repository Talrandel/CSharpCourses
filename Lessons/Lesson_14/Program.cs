using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h = new Hero();

            Sword sword = new Sword();
            Bow bow = new Bow();
            Staff staff = new Staff();

            h.Equip(sword);
            h.Attack();
            Console.WriteLine();

            h.Equip(bow);
            h.Attack();
            Console.WriteLine();

            h.Equip(staff);
            h.Attack();
            Console.WriteLine();

            Saw saw = new Saw();
            h.Equip(saw);
            h.Attack();
            Console.WriteLine();

            BaseballBat baseballBat = new BaseballBat();
            h.Equip(baseballBat);
            h.Attack();
            Console.WriteLine();

            Console.Read();
        }
    }
}