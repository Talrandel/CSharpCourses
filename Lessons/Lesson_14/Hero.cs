using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    public class Hero
    {
        public IWeapon WeaponEquipped { get; set; }

        public void Equip(IWeapon weapon)
        {
            WeaponEquipped = weapon;
        }

        public void Attack()
        {
            WeaponEquipped.Attack();
        }
    }

    public interface IWeapon
    {
        int Damage { get; set; }
        void Attack();
    }

    public abstract class Weapon : IWeapon
    {
        public int Damage { get; set; }
        public abstract void Attack();
    }

    public class Sword : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Атакую мечом!");
        }
    }

    public class Bow : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }

    public class Staff : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Пускаю молнии из посоха!");
        }
    }

    public class Saw : IWeapon
    {
        public int Damage { get; set; }
        public void Attack()
        {
            Console.WriteLine("Запускаю бензопилу!");
        }
    }

    public class BaseballBat : IWeapon
    {
        public int Damage { get; set; }
        public void Attack()
        {
            Console.WriteLine("Бью бейсбольной битой!");
        }

        public void HitTheBall()
        {
            Console.WriteLine("Отбить мяч");
        }
    }
}