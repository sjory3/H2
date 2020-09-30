using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragracing
{
    class Race
    {
        //so since i havent used threads in this because i couldent start with implementing threads
        //because is ran into a stop when i throught about it i dident use threads
        //so the time for the motor will always be the same
        //because the time is calculatet with only math and there isent any "who startet first"
        //as there would be in the real world or with threads

        
        public float Racing(Motor motor)
        {
            //setting the lenght for the race
            int raceLenght = 400;
            //getting the time
            float timer = 0f;
            //calculating how long it takes a car in top speed to go 1 meter
            //this is done with taking the top speed and * with 1000 to get how many meters it goes in a hour
            //the / with 60 to get minutes and again to get seconds
            float meterInSeconds = motor.TopSpeed * 1000 / 60 / 60;
            //so now we know how many meters it can go in a second but we need to know how long it takes to go 1 meter
            //  ex(poyota goes around 91 meter in a sec so 1 meter would be 1/91 sec
            float meterInMiliseconds = 1 / meterInSeconds;
            
            //setting the lenght is took to accelerate
            raceLenght = raceLenght - motor.AccelerationLenght;
            //setting the time it took to accelerate
            timer = motor.AccelerationTime;
            //continune until there is no more race lenght
            while (raceLenght > 0)
            {
                //adding the time it takes for 1 meter every meter
                timer = timer + meterInMiliseconds;
                //minus 1 meter from the race lenght
                raceLenght--;
            }
            //returning the time it took
            return timer;
        }
    }
}
