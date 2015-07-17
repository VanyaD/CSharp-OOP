namespace _02.BankAccounts
{
    using System;

    public class LoanAccount : Account, IAccount
    {
        private const decimal DEFAULT_INTEREST_RATE = 0.5m;

        public LoanAccount(Customer customer, decimal interestRate = DEFAULT_INTEREST_RATE) : base(customer, interestRate)
        {
        }

        public override decimal CalculateMonthlyInterest()
        {
            decimal interest = 0;
            var type = this.Customer.GetType();

            TimeSpan elapsedTime = DateTime.Now.Subtract(this.CreatedOn);
            decimal numberOfMonths = (decimal)elapsedTime.TotalDays / 30;

            if (type.Equals("_02.BankAccounts.IndividualCustomer"))
            {
                interest = (numberOfMonths - 3) * this.InterestRate;

            }
            else if (type.Equals("_02.BankAccounts.Company"))
            {
                interest = (numberOfMonths - 2) * this.InterestRate;
            }

            if (interest < 0)
            {
                interest = 0;
            }

            return interest;
        }
    }
}
