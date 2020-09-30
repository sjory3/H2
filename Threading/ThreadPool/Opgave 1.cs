using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a stopwatch to time the diffrent proesses
            Stopwatch myWatch = new Stopwatch();
            //outputing that the thread pool startet
            Console.WriteLine("Thread Pool Execution");
            //starting the stopwatch
            myWatch.Start();
            //execute the thread pool method
            ProcessWithThreadPoolMethod();
            //stopign the stopwatch
            myWatch.Stop();
            //outputing the time it took
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + myWatch.ElapsedTicks.ToString());
            //reseting the stopwatch for a new time
            myWatch.Reset();
            //outpuing the thread execution
            Console.WriteLine("Thread Execution");
            //starting the stopwatch
            myWatch.Start();
            //calling the thread method
            ProcessWithThreadMethod();
            //stoping the stopwatch
            myWatch.Stop();
            //outputing the time it took
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + myWatch.ElapsedTicks.ToString());
            //stoping the aplication from closing
            Console.Read();
        }

        static void ProcessWithThreadMethod()
        {
            //loop to check the time
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                //starting the thread
                obj.Start();
            }
        }

        static void ProcessWithThreadPoolMethod()
        {
            //loop the check the time
            for (int i = 0; i <= 10; i++)
            {
                //starting the thread pool
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
        //Process need to have a Object agument because callback uses the object 
        static void Process(object obj)
        {

        }
    }
}
