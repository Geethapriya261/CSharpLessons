using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day2
{
    internal class Box
    {
        public int height;
        public int width;
        public const string type = "Wooden";
        
    }
    internal class TestBox
    {
        public static void TestOne()
        {
          
            //Box.width = 200; 
            Box firstBox = new Box();
            Box secondBox = new Box();
            firstBox.width = 300;
            secondBox.width = 400;
            firstBox.height = 100;
            secondBox.height = 100;

            Console.WriteLine($"FirstBox={firstBox.width},{firstBox.height}");
            Console.WriteLine($"SecondBox={secondBox.width},{secondBox.height}");
            Console.WriteLine(Box.type);
            // Box.type="Glass"
            firstBox.height = 500;
            Console.WriteLine($"FirstBox={firstBox.width},{firstBox.height}");
            Console.WriteLine($"SecondBox={secondBox.width},{secondBox.height}");
        }
    }
}
