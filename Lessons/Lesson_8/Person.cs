using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Person
    {
        public string Name { get; set; }

        protected int Age { get; set; }
    }

    class Student : Person
    {
        public string[] Subject { get; set; }

        void DoSomething()
        {
            
        }
    }

    class StudentWithGrant : Student
    {
        public int Grant { get; set; }
    }




    abstract class Vehicle
    {
        void Move()
        {

        }
    }

    class Motorcycle : Vehicle
    { }

    class Bicycle : Vehicle
    { }

    class Train : Vehicle
    { }

    class AirPlane : Vehicle
    { }

    class Car : Vehicle
    {
        public object[] Wheels { get; set; }
    }

    class PassengerCar : Car
    { }

    class Truck : Car
    { }
}