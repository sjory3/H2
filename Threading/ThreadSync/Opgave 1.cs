using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadSync
{
    class Program
    {
        //resource both threads need to have access to
        static int count;
        //lock for moniter to make a sync thread
        static object resourceLock = new object();


        static void Main(string[] args)
        {
            //initiate both threads
            Thread threadPlus = new Thread(CountUp);
            Thread threadMinus = new Thread(CountDown);
            //starts both threads
            threadPlus.Start();
            threadMinus.Start();

            Console.Read();
        }
        //method for counting up
        static void CountUp()
        {
            //while loop to keep it going forever
            while (true)
            {
                //locking the resource so the other threads have to wait
                Monitor.Enter(resourceLock);
                //try to catch exceptions
                try
                {
                    //counting up by 2
                    count = count + 2;
                    //outputting the current count and what thread that did it
                    Console.WriteLine(string.Format("+2 Count : {0}", count));
                    //sleeping the thread for 1 sec
                    Thread.Sleep(1000);

                }
                //catching exceptions
                catch (Exception ex)
                {
                    //outputting the exception
                    Console.WriteLine(ex);
                }
                //finally makes sure the resource is unlocked in case of a exception
                finally
                {
                    //releasing the resource
                    Monitor.Exit(resourceLock);
                }
            }
        }
        //count down method
        static void CountDown()
        {
            //while loop to keep it going forever
            while (true)
            {
                //locking the resource so the other thread have to wait
                Monitor.Enter(resourceLock);
                //try to catch exceptions
                try
                {
                    //count minus 1 
                    count--;
                    //outputting the current count and what thread that did it
                    Console.WriteLine(string.Format("-1 Count : {0}", count));
                    //sleeping the thread for 1 sec
                    Thread.Sleep(1000);
                }
                //catching exceptions
                catch (Exception ex)
                {
                    //ouputting the exception
                    Console.WriteLine(ex);
                }
                //finally makes sure the resource is unlocked in case of a exception
                finally
                {
                    Monitor.Exit(resourceLock);
                }
            }
        }
    }
}
