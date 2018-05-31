using System;

namespace ClassesLibrary
{
    /// <summary>
    /// Сотрудник фирмы ООО "Рога и копыта".
    /// </summary>
    public abstract class Worker
    {
        public string Name { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public int TIN { get; set; }

        public abstract int GetSalary();

        public virtual double GetTaxes()
        {
            return 0.13;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("TIN = " + TIN);
            Console.WriteLine("Salary = " + GetSalary());
            Console.WriteLine("Taxes = " + GetSalary() * GetTaxes());
        }

        // TODO: каким методом можно попробовать заменить ShowInfo? Его нужно переопределить в данном классе, т.к. он есть у родительского (object)

        public Worker(string name, int age, int tin)
        {
            Name = name;
            Age = age;
            TIN = tin;
        }

        public Worker()
            : this("Без имени", 25, 0)
        {

        }
    }
}