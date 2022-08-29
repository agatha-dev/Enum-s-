using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    public class Account
    {
        public int Number { get; private set; } //Não pode ser alterado
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //Só pode ser alterado pela classe ou sub classe
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
