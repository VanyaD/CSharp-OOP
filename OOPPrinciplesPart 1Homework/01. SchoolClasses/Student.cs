using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart_1
{
    public class Student : People
    {
        private int id;
        static int countOfStudents;
        private Group group;       
        
        public Student(string name, Group group) : base(name)
        {
            this.Name = name;
            countOfStudents++;
            this.ID = countOfStudents + 1;
            this.Group = group;           
        }

        public static int CountOfStudents
        {
            get
            {
                return countOfStudents;
            }
            private set
            {
                countOfStudents = value;
            }
        }
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }
        
    }
}
