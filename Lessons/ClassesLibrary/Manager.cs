using System;

namespace ClassesLibrary
{
    public class Manager : Worker
    {
        public int ProjectCount { get; set; }

        public Manager(string name, int age, int tin, int projectCount)
            : base(name, age, tin)
        {
            ProjectCount = projectCount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ProjectCount = " + ProjectCount);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            return ProjectCount * 2500;
        }

        public override double GetTaxes()
        {
            return 0.2;
        }
    }
}