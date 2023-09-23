using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day6
{
    
    
        public delegate void MethodHandlerA();
        public delegate int MethodHandlerB(int x, int y);

    public class MathCalculator
    {
        public void DoTask()
        {
            Console.WriteLine("Calculator DoTask");
        }
        public int Add(int x, int y)
        {
            Console.WriteLine(x + "," + y);
            return x + y;

        }
        public int Multiply(int x, int y)
        {

            Console.WriteLine(x + "," + y);
            return x * y;
        }
        public double Divide(double x, double y)
        {
            Console.WriteLine(x + "," + y);
            return x / y;
        }
        public String GetModel()
        {
            return "x500";
        }
    }
        public class DelegateDemo
        {
            public static void TestOne()
            {
                MathCalculator mc = new MathCalculator();
            MethodHandlerA methodHandlerA = mc.DoTask;// new MethodHandlerA(mc.DoTask);
            MethodHandlerB methodHandlerB = mc.Add;// new MethodHandlerB(mc.Add);
                MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply);
                //MethodHandlerB methodHandlerThree = new MethoHandlerB(mc.Divide);
                methodHandlerA();
                int addResult = methodHandlerB(100, 50);
                Console.WriteLine(addResult);
                int multiplyResult = methodHandlerTwo(20, 5);
                Console.WriteLine(multiplyResult);
            }

        }

    
}
