using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MultiThreading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SampleThreadDemo obj=new SampleThreadDemo();
            //obj.M1();
            //obj.M2();

            //Thread t1 = new Thread(new ThreadStart(obj.M1));
            //Thread t2 = new Thread(new ThreadStart(obj.M2));
            //t1.Name = "First Thread";
            //t2.Name = "Second Thread";


            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority= ThreadPriority.Highest;

            //t1.Start();
            //t2.Start();
            Console.WriteLine("-----------------");
            SampleThreadDemo obj1 = new SampleThreadDemo();

            Thread t1=new Thread(new ThreadStart(obj1.M3));
            Thread t2 = new Thread(new ThreadStart(obj1.M3));
            t1.Start();
            t2.Start();
        }
    }
}
