using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 9. Student groups
// • Create a class  Student  with properties  FirstName ,  LastName ,  FN ,  Tel ,  Email ,  Marks  (a List),  GroupNumber .
// • Create a  List<Student>  with sample students. Select only the students that are from group number 2.
// • Use LINQ query. Order the students by FirstName.

namespace Student_Problems9_15_
{
    class Student 
    {
        
        public Student(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public Student(string fName, string lName, string fn) : this(fName, lName)
        {
            this.FN = fn;
        }

        public Student(string fName, string lName, string fn, string tel) : this (fName, lName, fn)
           
        {
            this.Tel = tel;
        }

        public Student(string fName, string lName, string fn, string tel, string eMail) : this (fName, lName, fn, tel)
            
        {
            this.Email = eMail;
        }

        public Student(string fName, string lName, string fn, string tel, string eMail, int group)
            : this(fName, lName, fn, tel, eMail)
        {
            this.GroupNumber = group;        
        }

        public Student(string fName, string lName, string fn, string tel, string eMail, int group, params int[] marks)
            : this(fName, lName, fn, tel, eMail, group)
        {
            this.Marks = marks;
        }

        public Student()
        {
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int[] Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString() 
        {
            StringBuilder result = new StringBuilder();
            string groupNumAsString = this.GroupNumber.ToString();
            result.Append("Student Name: ");
            result.Append(this.FirstName);
            result.Append(" ");
            result.Append(this.LastName);
            result.AppendLine();
            result.Append("FN: ");
            result.Append(this.FN);
            result.AppendLine();
            result.Append("Mobile: ");
            result.Append(this.Tel);
            result.AppendLine();
            result.Append("Email: ");
            result.Append(this.Email);
            result.AppendLine();
            result.Append("Group: ");
            result.Append(groupNumAsString);
            result.AppendLine();

            return result.ToString();
        }

    }
}
