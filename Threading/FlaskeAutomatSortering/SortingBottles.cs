using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FlaskeAutomatSortering
{
    class SortingBottles
    {

        public void Sorting()
        {
            //keep the thread running 
            while (true)
            {
                //locking the bottle array
                lock (Program.bottleArray)
                {
                    //starting if there is bottles in the bottle array
                    if (Program.bottleArrayReserved > 0)
                    {
                        //--bottlearray so the producer knows there is space in the array and stopping the thread if there is no longer any bottles
                        Program.bottleArrayReserved--;
                        //checking if the object type is soda
                        if (Program.bottleArray[Program.bottleArrayReserved].Type.ToString() == "Soda")
                        {
                            //locking the soda array
                            lock (Program.sodaArray)
                            {
                                //checking if there is space in the soda array
                                if (Program.sodaArrayReserved != 10)
                                {
                                    //moving the object from bottle array to soda array
                                    Program.sodaArray[Program.sodaArrayReserved] = Program.bottleArray[Program.bottleArrayReserved];
                                    //chaning the color to easy see that the bottle is moved in the console
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    //ouputting that the bottle is moved and what ID the bottle has
                                    Console.WriteLine("{0} move from buffer to {1} buffer (ID : {2})", Program.bottleArray[Program.bottleArrayReserved].Type, Program.bottleArray[Program.bottleArrayReserved].Type, Program.bottleArray[Program.bottleArrayReserved].Id);
                                    //chaning the color back to wite 
                                    Console.ForegroundColor = ConsoleColor.White;
                                    //++ the soda array reserved int to keep track of how full the array is
                                    Program.sodaArrayReserved++;
                                    //removing the object that is moved from bottle array
                                    Program.bottleArray[Program.bottleArrayReserved] = null;
                                    //pulsing to the other threads that this thread is done
                                    Monitor.Pulse(Program.sodaArray);
                                }
                                //if there is no space in the soda array is will wait on a pulse
                                else
                                {
                                    Monitor.Wait(Program.sodaArray);
                                }
                            }
                        }
                        //if the object type is not soda it will move it to the beer array
                        else
                        {
                            lock (Program.beerArray)
                            {
                                //checking to see if there is space in the beer array
                                if (Program.beerArrayReserved != 10)
                                {
                                    //moving the object from bottle array to beer array
                                    Program.beerArray[Program.beerArrayReserved] = Program.bottleArray[Program.bottleArrayReserved];
                                    //chaing the color so it is easy to see in the console
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    //outptting what it did
                                    Console.WriteLine("{0} move from buffer to {1} buffer (ID : {2})", Program.bottleArray[Program.bottleArrayReserved].Type, Program.bottleArray[Program.bottleArrayReserved].Type, Program.bottleArray[Program.bottleArrayReserved].Id);
                                    //chaing the color back to white
                                    Console.ForegroundColor = ConsoleColor.White;
                                    //++the beey array reserved int to keep track in the beer array
                                    Program.beerArrayReserved++;
                                    //removing the object that was moved from the bottle array
                                    Program.bottleArray[Program.bottleArrayReserved] = null;

                                    //pulsing to the other threads that this thread is done
                                    Monitor.Pulse(Program.beerArray);
                                }
                                //if there is no space in the beer array it will wait on a pulse
                                else
                                {
                                    Monitor.Wait(Program.beerArray);
                                }
                            }
                        }
                        //the same as i wrote in Producer
                        Thread.Sleep(50);

                        //pulsing to the other threads that the bottle array is unlocked
                        Monitor.Pulse(Program.bottleArray);
                    }
                    else
                    {
                        //if the array is not free waiting on a pulse
                        Monitor.Wait(Program.bottleArray);
                    }
                }
            }
        }
    }
}
