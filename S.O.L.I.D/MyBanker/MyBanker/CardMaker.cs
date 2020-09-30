using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class CardMaker
    {
        RandomNumber rng = new RandomNumber();

        public MaestroCard MaestroCardMaker(string firstName, string lastName, int age, int saldo)
        {
            ulong cardNumber = rng.CardNumber(15);
            string prefix = "5018";
            prefix += cardNumber.ToString();
            cardNumber = ulong.Parse(prefix);

            ulong accNumber = rng.CardNumber(10);
            DateTime expire = DateTime.Now.AddYears(5).AddMonths(8);

            MaestroCard maestroCard = new MaestroCard("Maestro", firstName, lastName, cardNumber, accNumber, 3520, saldo, expire, age);

            return maestroCard;
        }

        public CashCard CashCardMaker(string firstName, string lastName, int age, int saldo)
        {

            ulong cardNumber = rng.CardNumber(12);
            string prefix = "2400";
            prefix += cardNumber.ToString();
            cardNumber = ulong.Parse(prefix);

            ulong accNumber = rng.CardNumber(10);
            DateTime expire = DateTime.MaxValue;

            CashCard cashCard = new CashCard("Cash Card", firstName, lastName, cardNumber, accNumber, 3520, saldo, expire, age);

            return cashCard;
        } 

        public VisaElectronicCard VisaElectronicCardMaker (string firstName, string lastName, int age, int saldo)
        {
            ulong cardNumber = rng.CardNumber(12);
            string prefix = "4026";
            prefix += cardNumber.ToString();
            cardNumber = ulong.Parse(prefix);

            ulong accNumber = rng.CardNumber(10);
            DateTime expire = DateTime.Now.AddYears(5);

            VisaElectronicCard visaElectronicCard = new VisaElectronicCard(10000, "Visa Electronic", firstName, lastName, cardNumber, accNumber, 3520, saldo, expire, age);

            return visaElectronicCard;
        }

        public VisaDanCard VisaDanCardMaker (string firstName, string lastName,int age, int saldo)
        {

            ulong cardNumber = rng.CardNumber(15);
            string prefix = "4";
            prefix += cardNumber.ToString();
            cardNumber = ulong.Parse(prefix);

            ulong accNumber = rng.CardNumber(10);
            DateTime expire = DateTime.Now.AddYears(5);

            VisaDanCard visaDanCard = new VisaDanCard(20000, -25000, "Visa", firstName, lastName, cardNumber, accNumber, 3520, saldo, expire, age);
            return visaDanCard;

        }

        public MasterCard MasterCardMaker (string firstName,string lastName, int age, int saldo)
        {

            ulong cardNumber = rng.CardNumber(14);
            string prefix = "51";
            prefix += cardNumber.ToString();
            cardNumber = ulong.Parse(prefix);

            ulong accNumber = rng.CardNumber(10);
            DateTime expire = DateTime.Now.AddYears(5);

            MasterCard masterCard = new MasterCard(30000, 5000, "Master Card", firstName, lastName, cardNumber, accNumber, 3520, saldo, expire, age);
            return masterCard;
        }
    }
}
