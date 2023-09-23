using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.DayFive
{
    internal class DoTask
    {
        public static void  Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x) 
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
    }
}
