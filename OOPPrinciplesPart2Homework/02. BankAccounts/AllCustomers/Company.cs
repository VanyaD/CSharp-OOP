namespace _02.BankAccounts
{
    public class Company : Customer, ICustomer
    {        
        public Company(string companyName, string companyID) : base(companyName, companyID)
        {
        }
    }
}
