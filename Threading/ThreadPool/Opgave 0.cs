using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        //task 1 method
        public void task1(object obj)
        {
            //loop
            for (int i = 0; i <= 2; i++)
            {
                //ouput
                Console.WriteLine("Task 1 is being executed");
            }
        }
        //Task 2 method
        public void task2(object obj)
        {
            //loop
            for (int i = 0; i <= 2; i++)
            {
                //output
                Console.WriteLine("Task 2 is being executed");
            }
        }

        static void Main(string[] args)
        {
            //class refence
            Program tdp = new Program();
            //loop
            for (int i = 0; i < 2; i++)
            {
                //thread pool to execute task1
                ThreadPool.QueueUserWorkItem(tdp.task1);
                //thread pool to execute task2
                ThreadPool.QueueUserWorkItem(tdp.task2);
            }
            //stop the program from closing
            Console.Read();
        }
    }
}
