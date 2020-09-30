using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        // Random object r
        Random r = new Random();
        //storing the random number in the class so both threads can access it
        int num;
        //counting how many  times the alert has gone off
        public int alerttimer = 0;
        //random number generator
        public void RandomNumberGen()
        {
            //while loop to keep making numbers 
            while (true)
            {
                //waiting 2 sec before the next number
                Thread.Sleep(2000);
                //making the random number between -20 and 120
                num = r.Next(-20, 120);
                //outputting the number to the console
                Console.WriteLine(num);
            }
        }
        //alert method
        public void Alert()
        {
            //while loop to keep the thread checking the temperatur
            while (alerttimer < 3)
            {
                //try/catch in case of exception
                try
                {
                    //checking if the number is over 100
                    if (num > 100)
                    {
                        //outputting the temperatur is too high
                        Console.WriteLine("Alert Temperatur too high");
                        //making the alerttimer go up by 1
                        alerttimer++;
                        //sleeping for 2 sec
                        Thread.Sleep(2000);
                    }
                    //checking if the number to under 0
                    else if (num < 0)
                    {
                        //outputting the temperatur is too low
                        Console.WriteLine("Alert Temperatur too low");
                        //making the alerttimer go up by 1
                        alerttimer++;
                        //sleeping for 2 sec
                        Thread.Sleep(2000);
                    }
                }
                //catching the exception
                catch (Exception ex)
                {
                    //outputting the exception to the user
                    Console.WriteLine(ex);
                }
            }
        }

    }
    class threprog
    {
        public static void Main()
        {
            //object to access the program class
            Program pg = new Program();
            //making a new thread for the RandomNumberGen
            Thread thread = new Thread(pg.RandomNumberGen);
            //nameing the thread to randomnumber
            thread.Name = "RandomNumber";
            //starting the thread
            thread.Start();
            //making another thread for the alert
            Thread thread2 = new Thread(pg.Alert);
            //nameing the thread to alert
            thread2.Name = "Alert";
            //starting the thread
            thread2.Start();
            //keep the main thread checking if the alert thread is alive
            while (thread2.IsAlive)
            {
                try
                {
                    //making the check every 10 sec
                    Thread.Sleep(10000);
                    //if the thread is inactive
                    if (thread2.IsAlive != true)
                    {
                        //aborting the thread
                        thread2.Abort();
                    }
                }
                //catching the exception
                catch (Exception ex)
                {
                    //outputting the exception
                    Console.WriteLine(ex);
                }
            }
            //outputting the alert thread is abortet
            Console.WriteLine("Alarm-tråd termineret!");


            //keep the console from closing
            Console.Read();
        }
    }
}
