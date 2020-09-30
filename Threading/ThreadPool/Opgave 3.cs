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
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void ProcessWithThreadMethod()
        {
            try
            {

            Thread obj = new Thread(Process);
            //the obj is now a background wich we use if we dont care if the thread is done in 3ms or 3000ms
            obj.IsBackground = true;
            //ouputting the state
            Console.WriteLine("is the thread a Bakcground : " + obj.IsBackground);
            //settign the thread background to flase
            obj.IsBackground = false;
            //outputting the state
            Console.WriteLine("is the thread a background : " + obj.IsBackground);
            //setting the thread priority
            obj.Priority = ThreadPriority.Highest;
            //ouputting the thread priority
            Console.WriteLine("Thread Priority : " + obj.Priority);
            //starting the thread
            obj.Start();
            //sleeping the thread for 100ms 
            Thread.Sleep(100);
            //suspending the thread until it has been resumed....but the thread is already dead so it changes nothing 
            //obj.Suspend();
            //resuming a suspended thread but the thread is already done
            //obj.Resume();
            //terminating the thread
            obj.Abort();
            //joining the threads so they wait for eachother
            obj.Join();
            //checking to see if the thread is alive
            Console.WriteLine("the Thread is alive : " + obj.IsAlive);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        static void ProcessWithThreadPoolMethod()
        {
            //starting the thread pool
            ThreadPool.QueueUserWorkItem(Process);

        }
        //Process need to have a Object agument because callback uses the object 
        static void Process(object callback)
        {

        }
    }
}
