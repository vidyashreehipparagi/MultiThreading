using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program2
    {
        public void M1()
        {
            Monitor.Enter(this);
            {
                for(int i=1;i<=5;i++)
                {
                    Console.WriteLine(i);
                }
                Monitor.Wait(this, 2000);
            }
            Monitor.Exit(this);
        }
    }
}
