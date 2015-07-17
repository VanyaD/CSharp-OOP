namespace _02.BankAccounts
{
    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string fullName, string personalID) : base(fullName, personalID)
        {
        }
    }
}
