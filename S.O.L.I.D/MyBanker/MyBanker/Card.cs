using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Card
    {
        string cardName;
        string firstName;
        string lastName;
        ulong cardNumber;
        ulong accountNumber;
        int reginNumber;
        int saldo;
        DateTime expireTime;
        int age;

        //contructer for the object
        public Card(string cardName, string firstName, string lastName, ulong cardNumber, ulong accountNumber, int reginNumber, int saldo, DateTime expireTime, int age)
        {
            this.cardName = cardName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.cardNumber = cardNumber;
            this.accountNumber = accountNumber;
            this.reginNumber = reginNumber;
            this.saldo = saldo;
            this.expireTime = expireTime;
            this.age = age;
        }

        //properties for the object
        public string CardName { get => cardName; set => cardName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public ulong CardNumber { get => cardNumber; set => cardNumber = value; }
        public ulong AccountNumber { get => accountNumber; set => accountNumber = value; }
        public int ReginNumber { get => reginNumber; set => reginNumber = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public DateTime ExpireTime { get => expireTime; set => expireTime = value; }
        public int Age { get => age; set => age = value; }
    }
}
