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
        //making a lock for resources but the threads in this program does not use the same resource therefor the lock is useless
        //its only here because of the assingment
        static object resourceLock = new object();

        static void Main(string[] args)
        {
            //making and starting a new thread for the star method
            Thread star = new Thread(Star);
            star.Start();

            //stopping the application from closing
            Console.Read();
        }

        static void Star()
        {
            //making a thread for the hashtag method
            Thread hashtag = new Thread(Hashtag);
            //for loop to output * 60 times
            for (int i = 0; i < 60; i++)
            {
                Console.Write("*");
                //sleeping the thread for 50ms so it doesent just spit it out to fast
                Thread.Sleep(50);
            }
            //starting thread hashtag tread
            hashtag.Start();
        }

        static void Hashtag()
        {
            //making the star thread
            Thread star = new Thread(Star);
            //for loop to output # 60 yimes
            for (int j = 0; j < 60; j++)
            {
                Console.Write("#");
                Thread.Sleep(50);
            }
            //starting the star thread method
            star.Start();

        }
    }
}
