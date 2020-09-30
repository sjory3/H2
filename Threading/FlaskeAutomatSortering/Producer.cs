using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FlaskeAutomatSortering
{
    class Producer
    {
        //making a random to choose wether to make a soda or beer
        Random rng = new Random();

        public void BottleMaker()
        {
            //making the ID on every bottle
            int bottleID = 0;
            //keep the thread running
            while (true)
            {
                //locking the bottleArray so other threads have to wait to this thread is done
                lock (Program.bottleArray)
                {
                    //running if the bottle array isent full
                    if (Program.bottleArrayReserved != 10)
                    {
                        //making the number 
                        int choice = rng.Next(0, 2);
                        //checking what bottle to make out from the choice above
                        if (choice == 0)
                        {
                            //instantiating a object and putting it in the array at a free spot
                            Program.bottleArray[Program.bottleArrayReserved] = new Bottles("Soda", bottleID);
                            //outputting what is made and what ID it has
                            Console.WriteLine("Soda made (ID : {0})", Program.bottleArray[Program.bottleArrayReserved].Id);
                            //adding 1 to the int to keep track of what spot in the array is free
                            Program.bottleArrayReserved++;
                            //adding 1 to the id to make sure every bottle has a new ID and to keep track of how many bottles that is made
                            bottleID++;
                        }
                        else
                        {
                            //instantiating a object and putting it in the array at a free spot
                            Program.bottleArray[Program.bottleArrayReserved] = new Bottles("Beer", bottleID);
                            //outputting what is made and what ID it has
                            Console.WriteLine("Beer made (ID : {0})", Program.bottleArray[Program.bottleArrayReserved].Id);
                            //adding 1 to the int to keep track of what spot in the array is free
                            Program.bottleArrayReserved++;
                            //adding 1 to the id to make sure every bottle has a new ID and to keep track of how many bottles that is made
                            bottleID++;
                        }
                        //the thread sleep is to keep the program from running so fast you cant see in the console what is happening 
                        //but if you have it turned on all the arrays will only use index 0 since when it want to use index 1 index 0 is free
                        //when it is turned off the arrays will sometimes use all 10 index spots because id makes objects faster than the sort remove them

                        Thread.Sleep(50);

                        //pulse is used to notify the other threads that they no longer have to wait for the bottleArray
                        Monitor.Pulse(Program.bottleArray);
                    }
                    else
                    {
                        //if the bottle array is already lock by another thread it will wait on the pulse
                        Monitor.Wait(Program.bottleArray);
                    }
                }
            }
        }
    }
}
