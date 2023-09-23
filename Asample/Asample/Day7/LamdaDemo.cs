using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day7
{
    internal class LamdaDemo
    {
       public static void DemoA()
        {
            Func<int, int> foo = x => x / 2;  //<parameter,return> ie public int foo(int x){return x/2;    =>is return type
            int i = 5;
            int result =foo(i);
            Console.WriteLine(result);
        }
        public static void DemoB()
        {
            Func<int> foo = () => 100;
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC()
        {
            Func<double, double, double>Callme=(x,y)=>(x+y)/2;
            int v1 = 101;
            int v2 = 10;
            double result=Callme(v1,v2);
            Console.WriteLine(result);

        }
        public static void DemoD()
        {
            Func<int, double> foo = x =>(double) x / 2;
            int v1 = 101;
            double result = foo(v1);
            Console.WriteLine(result);
        }
        public static void DemoE()
        {
                                                 //i/p int to return double is possible but vice versa not possible. 
            //Func<double,int> foo = x => x / 2;
            //int v1 = 101;
            //double result = foo(v1);
            //Console.WriteLine(result);
        }
        public static void DemoF()
        {
            Func<double, int> foo = x => (int)x / 2;
            int v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }
        public static void Echo(Func<string>foo)
        {
            string str = foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "HELLO");
            Echo(() => "WORLD");
        }
        public static double Dotrans(Func<int,int,double> foo)
        {
            return foo(50, 5);

        }
        public static void TestDotrans()
        {
            Func<int,int,double>Multiply=(x,y)=>x*y;
            double d = Dotrans(Multiply);
            Console.WriteLine(d);
            Func<int,int,double>Add=(x,y)=>x+y;
            d = Dotrans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0) y = 1; return x / y;
            };
            double d1 = Dotrans(Divide);
            Console.WriteLine(d1);
        }
    }
}
