using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day3
{
    internal abstract class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }
    }
    // end of class
    internal class Car:Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car constructor");
        }
    }
    class VehicleTester
    {
        public static void TestOne()
        {
            // Vehicle tester = new Vehicle();
            Vehicle Tester = new Car();
            Tester.Start();
        }

    }
}
