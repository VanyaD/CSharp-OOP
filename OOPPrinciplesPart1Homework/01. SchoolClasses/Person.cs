using System;

namespace SchoolClasses
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private string comments;

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public Person(string fName, string lName, string comments) : this(fName, lName)
        {
            this.Comments = comments;
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty!");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty!");
                }

                lastName = value;
            }
        }
    }
}
