using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragracing
{
    class GUI
    {
        //getting user input with what motor the first one is
        public int FirstMotorChoice()
        {
            Console.Clear();
            Console.WriteLine("What Motor do the first car need?\n" +
                "1) Jondamotor\n" +
                "2) Poyota\n\n" +
                "--Press 1 or 2 and then ENTER--");
            //settting a default value to 0
            int userchoice = 0;

            try
            {
                //getting the user choice and converting it to an int
                userchoice = int.Parse(Console.ReadLine());
            }
            //cathcing and outputting the exception
            catch (Exception ex)
            {
                Console.WriteLine("The following error has accrued" + ex);
            }
            //returning the choice the user made
            return userchoice;
        }


        //getting what the second motor is
        public int SecondMotorChoice()
        {
            Console.Clear();
            Console.WriteLine("What Motor do the second car need?\n" +
                "1) Jondamotor\n" +
                "2) Poyota\n\n" +
                "--Press 1 or 2 and then ENTER--");
            //setting the default value to 0
            int userchoice = 0;

            try
            {
                //getting the user choice and converting it to an int
                userchoice = int.Parse(Console.ReadLine());
            }
            //cathcing and outputting the exception
            catch (Exception ex)
            {
                Console.WriteLine("The following error has accrued" + ex);
            }
            //returning the choice the user made
            return userchoice;
        }


        //outputting who the winner is and what time the diffrent cars got
        public void Winner(int winner, float firstMotorTime, float secondMotorTime)
        {
            //clearing the console
            Console.Clear();
            
            Console.WriteLine("The winner IS number : " + winner + "\n\n" +
                "the first car time was : " + firstMotorTime + "\n" +
                "the second car time was : " + secondMotorTime);

            Console.Read();
        }
    }
}
