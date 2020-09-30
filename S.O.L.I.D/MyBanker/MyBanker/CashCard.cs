using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class CashCard : Card
    {
        public CashCard (string cardName, string firstName, string lastName, ulong cardNumber, ulong accountNumber, int reginNumber, int saldo, DateTime expireTime, int age) : base (cardName, firstName, lastName, cardNumber, accountNumber, reginNumber, saldo, expireTime, age)
        {
            
        }
    }
}
