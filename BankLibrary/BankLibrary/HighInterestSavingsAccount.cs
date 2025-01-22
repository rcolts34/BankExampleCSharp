﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class HighInterestSavingsAccount : SavingsAccount
    {
        public HighInterestSavingsAccount(string accountNumber, string accountName, decimal initialBalance, decimal interestRate) :
            base(accountNumber, accountName, initialBalance , interestRate)
        {

        }
        public void ApplyBonusInterest(decimal bonusrate)
        {
            decimal bonusInterestPayment = this.Balance * bonusrate;
            this.Deposit(bonusInterestPayment);
        }
    }   
}
