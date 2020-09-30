using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragracing
{
    class Motor
    {
        //super class for both the motors

        int topSpeed;
        float accelerationTime;
        int accelerationLenght;
        //constructor with top speed acctime and acclenght
        public Motor(int topSpeed, float accelerationTime, int accelerationLenght)
        {
            this.topSpeed = topSpeed;
            this.accelerationTime = accelerationTime;
            this.accelerationLenght = accelerationLenght;
        }
        //getting and setting the speed time and lenght
        public int TopSpeed { get => topSpeed; set => topSpeed = value; }
        public float AccelerationTime { get => accelerationTime; set => accelerationTime = value; }
        public int AccelerationLenght { get => accelerationLenght; set => accelerationLenght = value; }
    }
}
