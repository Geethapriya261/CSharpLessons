using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day1
{
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
        return x+y;
        }
    public static int Subtract(int p1, int p2)
        {
        return p1-p2;
        }
    public static int Multiply(int s1, int s2)
    {
        return s1*s2;
    }
    public static int Divide(int q1, int q2)
    {
        return q1/q2;
    }

        internal static void Add()
        {
            throw new NotImplementedException();
        }
    }
}
