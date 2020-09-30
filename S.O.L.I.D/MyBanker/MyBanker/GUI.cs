using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class GUI
    {
        public string CardMenu()
        {
            Console.WriteLine("What Card Would you like to get\n" +
                "1) Maestro Card\n" +
                "2) Cash Card\n" +
                "3) Visa Electronic Card\n" +
                "4) Visa/Dan Card\n" +
                "5) Master Card");

            string userInput = Console.ReadLine();
            return userInput;

        }

        public string FirstName()
        {
            Console.WriteLine("What is your first name?");
            string userFirstName = Console.ReadLine();
            return userFirstName;
        }

        public string LastName()
        {
            Console.WriteLine("What is your last name?");
            string userLastName = Console.ReadLine();
            return userLastName;
        }

        public int Age()
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            return userAge;
        }

        public int Saldo()
        {
            Console.WriteLine("How much money do you want to deposit?");
            int userMoney = Convert.ToInt32(Console.ReadLine());
            return userMoney;
        }

        public void Error(string error)
        {
            switch (error)
            {
                case "too old":
                    Console.Clear();
                    Console.WriteLine("you are to old for you card choice");
                    Console.Read();
                    break;

                case "too young":
                    Console.Clear();
                    Console.WriteLine("you are too young for your card choice");
                    Console.Read();
                    break;
            }
        }

        public void Result(Card card)
        {
            Console.Clear();
            Console.WriteLine("Card Type : " + card.CardName);
            Console.WriteLine("Card user first name : " + card.FirstName);
            Console.WriteLine("Card user last name : " + card.LastName);
            Console.WriteLine("Card user age : " + card.Age);
            Console.WriteLine("Card saldo : " + card.Saldo);
            Console.WriteLine("Card number : " + card.CardNumber);
            Console.WriteLine("Card accoount number : " + card.AccountNumber);
            Console.WriteLine("Card regin number : " + card.ReginNumber);
            Console.WriteLine("Card expire date : " + card.ExpireTime);

            Console.Read();
        }
    }
}
