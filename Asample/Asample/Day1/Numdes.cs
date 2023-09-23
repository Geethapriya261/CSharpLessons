using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day1
{
    internal class Numdes
    {
        public static void pattern()
        {
            for (int i = 1; i < 10; i++)

            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k > 0; k--)

                {
                    if (k != 1)
                    {
                        Console.Write(k);
                    }

                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
         }
     }
}