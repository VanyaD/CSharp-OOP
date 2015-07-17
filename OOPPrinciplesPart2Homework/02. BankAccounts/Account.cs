namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    public abstract class Account : IAccount
    {      
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime createdOn;

        public Account(Customer customer, decimal interestRate)
        {
            this.InterestRate = interestRate;
            this.CreatedOn = DateTime.Now;
            this.Balance = 0m;
        }
       
        public DateTime CreatedOn
        {
            get { return this.createdOn; }
            set { this.createdOn = value; }
        }
        
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value;}
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public abstract decimal CalculateMonthlyInterest();

        public decimal DepositMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("The amount cannot be less or equal to zero");
            }
            decimal newBalance = this.Balance + amount;
            this.Balance = newBalance;

            return this.Balance;
        }
    }
}
