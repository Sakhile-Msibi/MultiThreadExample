using System;
using System.Threading;

namespace MultiThreadExample
{
    class Program
    {
        static void mythread()
        {
            Console.WriteLine("In progress thread is: {0}",
                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("Completed threas is: {0}",
                Thread.CurrentThread.Name);
        }

        static void Main(string[] args)
        {
            Thread thr = new Thread(mythread);

            thr.Name = "MyThread";
            thr.Start();

            thr.IsBackground = false;

            Console.WriteLine("Main Thread Ends!!");
        }
    }
}
