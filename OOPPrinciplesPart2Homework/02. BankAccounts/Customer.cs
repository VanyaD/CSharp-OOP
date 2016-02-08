namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    public abstract class Customer : ICustomer
    {       
        private string fullName;
        private string id;
        private IEnumerable<Account> customerAccounts;

        public Customer(string fullName, string id)
        {
            this.FullName = fullName;
            this.ID = id;
            this.CustomerAccounts = new List<Account>();
        }

        public string FullName
        {
            get { return fullName; }
            set 
            { 
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Name should be at least five letters long");
                }

                fullName = value; 
            }
        }

        public string ID
        {
            get { return id; }
            set 
            { 
                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("ID should be at least 6 digits");
                }

                id = value; 
            }
        }

        public IEnumerable<Account> CustomerAccounts
        {
            get { return customerAccounts; }
            set { customerAccounts = value; }
        }
    }
}
