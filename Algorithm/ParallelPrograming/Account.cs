using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ParallelPrograming
{
    public class Account
    {
        private int AccountId { get; set; }
        private double Balance { get; set; }
        public Account(int accountId, double balacnce)
        {
            AccountId = accountId;
            Balance = balacnce;
        }

        public void Deposit(double ammount)
        {
            Balance = Balance + ammount;
            Console.WriteLine(Balance);
        }
        public void WithDraw(double ammount)
        {
            Balance = Balance - ammount;
            Console.WriteLine(Balance);
        }
        public double GetCurrentBalance()
        {
            Console.WriteLine(Balance);
            return Balance;
        }
    }
}
