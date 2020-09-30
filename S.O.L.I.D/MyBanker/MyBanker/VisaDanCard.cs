using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaDanCard : Card
    {
        int maxMonthlyWithdrawal;
        int maxNegativ;

        public VisaDanCard(int maxMonthlyWithdrawal, int maxNegativ, string cardName, string firstName, string lastName, ulong cardNumber, ulong accountNumber, int reginNumber, int saldo, DateTime expireTime, int age) : base(cardName, firstName, lastName, cardNumber, accountNumber, reginNumber, saldo, expireTime, age)
        {
            this.maxMonthlyWithdrawal = maxMonthlyWithdrawal;
            this.maxNegativ = maxNegativ;
        }

        public int MaxMonthlyWithdrawal { get => maxMonthlyWithdrawal; set => maxMonthlyWithdrawal = value; }
        public int MaxNegativ { get => maxNegativ; set => maxNegativ = value; }
    }
}

