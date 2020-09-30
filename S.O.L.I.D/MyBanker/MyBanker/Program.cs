using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI();
            CardMaker cardMaker = new CardMaker();

            Card currentCard;

            string userInput = gui.CardMenu();
            string userFirstName = gui.FirstName();
            string userLastName = gui.LastName();
            int userAge = gui.Age();
            int userSaldo = gui.Saldo();

            switch (userInput)
            {
                case "1":
                    if (17 < userAge)
                    {
                        currentCard = cardMaker.MaestroCardMaker(userFirstName, userLastName, userAge, userSaldo);
                        gui.Result(currentCard);
                    }
                    else if (userAge < 18)
                    {
                        gui.Error("too young");
                    }
                    break;

                case "2":

                    if (17 < userAge)
                    {
                        gui.Error("too old");
                    }
                    else if (userAge < 15)
                    {
                        gui.Error("too young");
                    }
                    else
                    {
                        currentCard = cardMaker.CashCardMaker(userFirstName, userLastName, userAge, userSaldo);
                        gui.Result(currentCard);

                    }
                    break;

                case "3":
                    if (userAge < 15)
                    {
                        gui.Error("too young");
                    }
                    else
                    {
                        currentCard = cardMaker.VisaElectronicCardMaker(userFirstName, userLastName, userAge, userSaldo);
                        gui.Result(currentCard);
                    }
                    break;
                case "4":
                    if (userAge < 18)
                    {
                        gui.Error("too young");
                    }
                    else
                    {
                        currentCard = cardMaker.VisaDanCardMaker(userFirstName, userLastName, userAge, userSaldo);
                        gui.Result(currentCard);
                    }
                    break;
                case "5":
                    if (userAge < 15)
                    {
                        gui.Error("too young");
                    }
                    else
                    {
                        currentCard = cardMaker.MasterCardMaker(userFirstName, userLastName, userAge, userSaldo);
                        gui.Result(currentCard);
                    }
                    break;
            }
        }
    }
}
