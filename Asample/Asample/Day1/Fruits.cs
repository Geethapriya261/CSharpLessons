using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day1
{
    internal class Fruits
    {
        public static void printst()
        {
            for (int i = 1; i <= 100; i++)
            {
                if  (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("Grapes");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Orange");
                }
                else if (i % 3 == 0)
                {    
                   Console.WriteLine("Apple");
                
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
