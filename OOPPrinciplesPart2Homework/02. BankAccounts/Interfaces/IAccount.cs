namespace _02.BankAccounts
{
    using System;

    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        DateTime CreatedOn { get; set; }

        decimal CalculateMonthlyInterest();
        decimal DepositMoney(decimal amount);
    }
}
