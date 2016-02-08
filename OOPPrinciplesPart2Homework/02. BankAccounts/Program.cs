using System;

namespace _02.BankAccounts
{
    public class Program
    {
        public static void Main()
        {
            IndividualCustomer me = new IndividualCustomer("Vanya Karaasenova", "12555555");
            DepositAccount myDepositAccount = new DepositAccount(me);
            Console.WriteLine("My deposit account interest rate: {0}", myDepositAccount.InterestRate);
            myDepositAccount.DepositMoney(50000);
            Console.WriteLine("My deposit account balance: {0}", myDepositAccount.Balance);
            decimal result = myDepositAccount.CalculateMonthlyInterest();
            Console.WriteLine("My deposit account monthly interest: {0}", result);          
        }
    }
}
