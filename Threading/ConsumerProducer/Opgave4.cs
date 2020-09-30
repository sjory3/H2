using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsumerProducer
{
    class Program
    {
        static string[] buffer = new string[5];
        static int bufferFull;


        static void Main(string[] args)
        {

            Thread produser = new Thread(Produser);
            Thread consumer = new Thread(Consumer);

            produser.Start();
            consumer.Start();

            Console.Read();

            produser.Abort();
            consumer.Abort();

            
        }

        static void Produser()
        {
            while (true)
            {
                if (bufferFull == 0)
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = string.Format("This is totaly a object : {0}", i);
                        Console.WriteLine("ADDED : This is totaly a object : {0}", i);
                        bufferFull++;
                        Thread.Sleep(50);
                    }
                }
            }
        }

        static void Consumer()
        {
            while (true)
            {
                if (bufferFull == buffer.Length)
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = null;
                        Console.WriteLine("REMOVED : This is totaly a object : {0}", i);
                        bufferFull--;
                        Thread.Sleep(50);
                    }
                }
            }

        }
    }
}
