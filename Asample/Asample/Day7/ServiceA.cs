using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day7
{
    internal class ServiceA
    {
        int x = 0;   // x is a global variable
        public void DoTask()
        {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTaskA");
            Console.WriteLine("\t Thread ID:"+id);
            // int x = 0;  x is a local variable
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ":X=" + x + "icount" + icount);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
