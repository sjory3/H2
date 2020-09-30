using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragracing
{
    class Logic
    {
        //creating the first motor from the user choice we got from Main <= gui
        public Motor FirstMotor(int firstMotorChoice)
        {
            if (firstMotorChoice == 1)
            {
                //creating the motor with the top speed, acceleration time and the acceleration lenght
                Motor firstMotor = new Jondamotor(280, 2.5f, 50);
                return firstMotor;

            }
            else if (firstMotorChoice == 2)
            {
                //creating the motor with the top speed, acceleration time and the acceleration lenght
                Motor firstMotor = new Poyota(330, 4, 100);
                return firstMotor;
            }
            //in case the user wrote anything else than 1 or 2 it returns with null
            else
            {
                return null;
            }
        }


        //creating the first motor from the user choice we got from Main <= gui
        public Motor SecondMotor(int secondMotorChoice)
        {
            if (secondMotorChoice == 1)
            {
                //creating the motor with the top speed, acceleration time and the acceleration lenght
                Motor secondMotor = new Jondamotor(280, 2.5f, 50);
                return secondMotor;

            }
            else if (secondMotorChoice == 2)
            {
                //creating the motor with the top speed, acceleration time and the acceleration lenght
                Motor secondMotor = new Poyota(330, 4, 100);
                return secondMotor;
            }
            else
            {
                //returning null
                return null;
            }
        }

        //calculation who the winner is from the time each car took
        public int Winner(float firstMotorTime, float secondMotorTime)
        {
            int winner;
            //if the first motor time is bigger than the second 
            if (firstMotorTime > secondMotorTime)
            {
                //the winner is the second
                winner = 2;
            }
            else
            {
                //else the winner is the first
                winner = 1;
            }
            //returning the winner
            return winner;
        }
    }
}
