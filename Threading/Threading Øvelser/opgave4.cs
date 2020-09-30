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
        //char both the method have access to
        static char keybord = '*';
        //printer method
        public void printer()
        {
            //while loop to keep printing the char
            while (true)
            {
                Console.Write(keybord);
                //sleeping to not use all of the cpu
                Thread.Sleep(100);
            }
        }
        //reader method
        public void reader()
        {
            //while loop to keep the thread watching
            while (true)
            {
                //updating the keybord to a new char after you press enter
                keybord = Console.ReadLine()[0];
            }
        }
        
    }
    class threprog
    {
        public static void Main()
        {
            //object to access the program class
            Program pg = new Program();
            //new thread
            Thread thread = new Thread(pg.printer);
            //naming the thread
            thread.Name = "printer";
            //starting the thread
            thread.Start();

            //new thread 2
            Thread thread2 = new Thread(pg.reader);
            //naming the thread
            thread2.Name = "reader";
            //starting the thread
            thread2.Start();
            //joining the threads so they can run simultaneously
            thread2.Join();
            
            
            Console.Read();
        }
    }
}
