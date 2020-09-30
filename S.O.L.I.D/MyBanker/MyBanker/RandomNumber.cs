using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class RandomNumber
    {
        Random rng = new Random();

        public ulong CardNumber(int size)
        {
            string finalNum = "";
            for (int i = 0; i < size; i++)
            {
                int firstNumber = rng.Next(0, 9);
                string firstNum = Convert.ToString(firstNumber);

                finalNum += firstNum;

            }

            ulong finalNumber = ulong.Parse(finalNum);
            return finalNumber;
        }
    }
}
