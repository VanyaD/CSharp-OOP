using System;

namespace _03.FirstBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student()
        {
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {

            this.age = age;
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less or equal to zero");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            string s = Age.ToString();
            return this.firstName + " " + this.lastName + ", " + s;
        }

    }
}
