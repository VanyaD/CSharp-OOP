namespace _02.BankAccounts
{
    using System;

    public class MortgageAccount : Account, IAccount
    {
        private const decimal DEFAULT_INTEREST_RATE = 0.4m;

        public MortgageAccount(Customer customer, decimal interestRate = DEFAULT_INTEREST_RATE) : base(customer, interestRate)
        {
        }

        public override decimal CalculateMonthlyInterest()
        {
            decimal interest = 0;
            var type = this.Customer.GetType();

            TimeSpan elapsedTime = DateTime.Now.Subtract(this.CreatedOn);
            decimal numberOfMonths = (decimal)elapsedTime.TotalDays / 30;

            if (type.Equals("_02.BankAccounts.IndividualCustomer") && numberOfMonths > 6)
            {
                interest = (numberOfMonths - 6) * this.InterestRate;
            }
            else if (type.Equals("_02.BankAccounts.IndividualCustomer") && numberOfMonths < 6)
            {
                interest = 0;
            }
            else if (type.Equals("_02.BankAccounts.Company") && numberOfMonths > 12)
            {
                interest = (numberOfMonths - 12) * this.InterestRate + 12 * this.InterestRate / 2;
            }
            else if (type.Equals("_02.BankAccounts.Company") && numberOfMonths <= 12)
            {
                interest = numberOfMonths * this.InterestRate / 2;
            }

            if (interest < 0)
            {
                interest = 0;
            }

            return interest;       
        }
    }
}
