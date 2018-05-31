using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace Lesson_11
{
    class Program
    {
        static Random random;

        static string[] Names = { "Вася", "Петя", "Елисей" };
        static int[] Age = { 18, 25, 40 };
        static int[] TIN = { 1111, 2222, 3333 };
        static string[] MachineNames = { "Жигули", "Порше", "Ниссан" };


        static void Main(string[] args)
        {
            random = new Random();

            Worker[] workers = new Worker[10];

            for (int i = 0; i < workers.Length; i++)
            {
                int workerType = random.Next(1, 4);
                if (workerType == 1)
                    workers[i] = new Manager(Names[random.Next(0, Names.Length - 1)], Age[random.Next(0, Age.Length - 1)], TIN[random.Next(0, TIN.Length - 1)], random.Next(1, 21));
                if (workerType == 2)
                    workers[i] = new Driver(Names[random.Next(0, Names.Length - 1)], Age[random.Next(0, Age.Length - 1)], TIN[random.Next(0, TIN.Length - 1)], MachineNames[random.Next(0, MachineNames.Length - 1)], random.Next(100, 501));
                if (workerType == 3)
                    workers[i] = new Programmer(Names[random.Next(0, Names.Length - 1)], Age[random.Next(0, Age.Length - 1)], TIN[random.Next(0, TIN.Length - 1)], (Language)random.Next(1, 5));
            }

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].ShowInfo();
            }

            Console.ReadLine();
        }
    }
}