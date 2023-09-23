using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day1
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            byte b1 = 255;
            Console.WriteLine(b1);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            float f1 = 52.678f;
            Console.WriteLine(f1);
            long l1 = int.MaxValue + 1000L;
            Console.WriteLine(l1);
            double d1 = 9876543210d;
            Console.WriteLine(d1);
            decimal m1 = 12345.6789m;
            bool flag = true;
            Console.WriteLine(flag);
            Console.WriteLine(m1);
            char c1 = 'G';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);
            int y = 68;
            char c2 = (char)y;
            Console.WriteLine(c2);

        }




        public static void TestMethod()
        {
            Console.WriteLine("Test");
        }
    }
}

    
