using System;

namespace ClassesLibrary
{
    public class Driver : Worker
    {
        public string MachineName { get; set; }

        public int Hours { get; set; }

        public Driver(string name, int age, int tin, string machineName, int hours)
            : base(name, age, tin)
        {
            MachineName = machineName;
            Hours = hours;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("MachineName = " + MachineName);
            Console.WriteLine("Hours = " + Hours);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            return Hours * 500;
        }
    }
}