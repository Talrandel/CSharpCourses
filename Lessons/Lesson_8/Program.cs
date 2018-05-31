using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.Age = 18;
            student.Name = "Какой-то студент";
            Console.WriteLine(student.Name);

            //StudentWithGrant studentWithGrant = new StudentWithGrant();
            //studentWithGrant.Grant = 500;

            Person person = student;
            person.Name = "Какое-то имя";
            Console.WriteLine(person.Name);

            Student newStudent = (Student)person;
            Console.WriteLine(newStudent.Name);

            PassengerCar passengerCar = new PassengerCar();
            Vehicle vehicle = passengerCar;

            Console.ReadLine();
        }
    }
}