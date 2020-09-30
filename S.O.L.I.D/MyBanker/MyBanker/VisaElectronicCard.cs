using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectronicCard : Card
    {
        int maxMonthlyWithdrawal;

        public VisaElectronicCard(int maxMonthlyWithdrawal, string cardName, string firstName, string lastName, ulong cardNumber, ulong accountNumber, int reginNumber, int saldo, DateTime expireTime, int age) : base(cardName, firstName, lastName, cardNumber, accountNumber, reginNumber, saldo, expireTime, age)
        {
            this.maxMonthlyWithdrawal = maxMonthlyWithdrawal;
        }

        public int MaxMonthlyWithdrawal { get => maxMonthlyWithdrawal; set => maxMonthlyWithdrawal = value; }
    }
}
