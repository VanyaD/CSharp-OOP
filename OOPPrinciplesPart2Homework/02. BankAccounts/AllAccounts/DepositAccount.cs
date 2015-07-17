namespace _02.BankAccounts
{
    using System;

    public class DepositAccount : Account, IAccount
    {
        private const decimal DEFAULT_INTEREST_RATE = 0.4m;
        private const decimal MAX_AMOUNT = 1000m;
        private const decimal MIN_AMOUNT = 0m;

        public DepositAccount(Customer customer, decimal interestRate = DEFAULT_INTEREST_RATE) : base(customer, interestRate)
        {
        }

        public override decimal CalculateMonthlyInterest()
        {           
            decimal interest = 0;

            TimeSpan elapsedTime = DateTime.Now.Subtract(this.CreatedOn);
            decimal numberOfMonths = (decimal)elapsedTime.TotalDays / 30;

            if (this.Balance > MIN_AMOUNT && this.Balance < MAX_AMOUNT)
            {
                interest = 0;
            }
            else
            {
                interest = numberOfMonths * this.InterestRate;
            }
            
            return interest;
        }

        public decimal WithdrawMoney(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("The amount cannot be larger than the account balance");
            }
            decimal newBalance = this.Balance - amount;
            this.Balance = newBalance;

            return this.Balance;
        }
    }
}
