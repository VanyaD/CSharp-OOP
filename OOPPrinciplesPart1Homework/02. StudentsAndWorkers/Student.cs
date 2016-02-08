using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string fName, string lName) : base(fName, lName)
        {
        }

        public Student(string fName, string lName, int grade)
            : this(fName, lName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString() 
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Name: {0} {1}, ", FName, LName));
            result.Append(string.Format("Grade: {0}", Grade));

            return result.ToString();
        }       
    }
}
