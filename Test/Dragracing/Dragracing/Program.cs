using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dragracing
{
    class Program
    {
        //Calculating meters to miliseconds
        //meterInMiliseconds = topSpeed*1000/60/60
        //meterInMiliseconds = 1/meterInMiliseconds

        static void Main(string[] args)
        {
            //calling the gui, logic and race class
            GUI gui = new GUI();
            Logic logic = new Logic();
            Race race = new Race();
            //storing the first and second motor time
            float firstMotorTime;
            float secondMotorTime;
            //storing the user choice for what motor is choosen
            int firstMotorChoice = gui.FirstMotorChoice();
            int secondMotorChoice = gui.SecondMotorChoice();
            //calling the logic and sending the user choice over with it to create the motor the user wants
            Motor firstMotor = logic.FirstMotor(firstMotorChoice);
            Motor secondMotor = logic.SecondMotor(secondMotorChoice);
            //getting the first and second motor time
            firstMotorTime = race.Racing(firstMotor);
            secondMotorTime = race.Racing(secondMotor);
            //calling the method for the winner
            gui.Winner( logic.Winner(firstMotorTime, secondMotorTime),firstMotorTime,secondMotorTime);


        }
    }
}
