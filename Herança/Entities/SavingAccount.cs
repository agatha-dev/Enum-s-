﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    sealed public class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        
        public void UpdateBalace()
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void WithDraw(double amount)
        {
           base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
