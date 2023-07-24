using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MultiThreading;

namespace MultiThreading
{
    internal class SampleThreadDemo
    {
        public void M1()
        {
            Thread t1=Thread.CurrentThread;
            Console.WriteLine(t1.Name);
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void M2()
        {
            Thread t1=Thread.CurrentThread;
            Console.WriteLine(t1.Name);
            for( int i = 10; i <= 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void M3()
        {
            Monitor.Enter(this);
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Monitor.Exit(this);
        }
    }
}
