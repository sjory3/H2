using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace FlaskeAutomatSortering
{
    class Program
    {
        //making bottle/Soda and beer array with a capacity of 10
        public static Bottles[] bottleArray = new Bottles[10];
        public static Bottles[] sodaArray = new Bottles[10];
        public static Bottles[] beerArray = new Bottles[10];
        //making a int for the spot in the respectet array to see if it is full or "Reserved"
        public static int bottleArrayReserved;
        public static int sodaArrayReserved;
        public static int beerArrayReserved;
        //making a int witch is used to 
        //public static int sodaReserved = 0;
        //public static int beerReserved = 0;

        static void Main(string[] args)
        {
            //instantiating the classes
            Producer producer = new Producer();
            SortingBottles sortingBottles = new SortingBottles();
            Consumer consume = new Consumer();
            //making and assigning them a method
            Thread producerThread = new Thread(producer.BottleMaker);
            Thread sortingThread = new Thread(sortingBottles.Sorting);
            Thread consumeSoda = new Thread(consume.SodaConsume);
            Thread consumeBeer = new Thread(consume.BeerConsume);
            //stating the threads to run the method
            producerThread.Start();
            sortingThread.Start();
            consumeBeer.Start();
            consumeSoda.Start();
            //stopping the main thread from closing
            Console.Read();
        }
    }
}
