﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp1
{
    public class BankAccount
    {
        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; private set; }

    }
}
