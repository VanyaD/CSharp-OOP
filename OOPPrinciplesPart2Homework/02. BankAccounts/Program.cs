using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Program
    {
        static void Main()
        {
            IndividualCustomer me = new IndividualCustomer("Vanya Karaasenova", "12555555");
            DepositAccount myDepositAccount = new DepositAccount(me);
            Console.WriteLine(myDepositAccount.InterestRate);
            myDepositAccount.DepositMoney(50000);
            Console.WriteLine(myDepositAccount.Balance);
            decimal result = myDepositAccount.CalculateMonthlyInterest();
            Console.WriteLine(result);
           
        }
    }
}
