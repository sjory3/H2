using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FlaskeAutomatSortering
{
    class Consumer
    {
        public void SodaConsume()
        {
            //keep the thread running
            while (true)
            {
                //locking the soda array
                lock (Program.sodaArray)
                {
                    //checking if there is anything in the soda array
                    if (Program.sodaArrayReserved != 0)
                    {
                        //--soda array reserved int to keep track
                        Program.sodaArrayReserved--;
                        //ouptutting what is does
                        Console.WriteLine("Consumed {0} (ID : {1})", Program.sodaArray[Program.sodaArrayReserved].Type, Program.sodaArray[Program.sodaArrayReserved].Id);
                        //removing the object from the soda array
                        Program.sodaArray[Program.sodaArrayReserved] = null;

                        //pulsing to the other threads that it is done
                        Monitor.Pulse(Program.sodaArray);
                    }
                    //waiting if the soda array is empty
                    else
                    {
                        Monitor.Wait(Program.sodaArray);
                    }
                }
            }
        }
        
        public void BeerConsume()
        {
            //keep the thread runnning
            while (true)
            {
                //locking the beer array 
                lock (Program.beerArray)
                {
                    //checking to see if there is something in the beer array
                    if (Program.beerArrayReserved != 0)
                    {
                        //-- beer array reserved int to keep track
                        Program.beerArrayReserved--;
                        //outputting what is does
                        Console.WriteLine("Consumed {0} (ID : {1})", Program.beerArray[Program.beerArrayReserved].Type, Program.beerArray[Program.beerArrayReserved].Id);
                        //removing the object from the beer array
                        Program.beerArray[Program.beerArrayReserved] = null;

                        //pulsing to the other threads that this is done
                        Monitor.Pulse(Program.beerArray);
                    }
                    //waiting if the beer array is empty
                    else
                    {
                        Monitor.Wait(Program.beerArray);
                    }
                }
            }
        }
    }
}
