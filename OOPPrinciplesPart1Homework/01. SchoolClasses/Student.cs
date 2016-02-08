namespace SchoolClasses
{
    public class Student : Person
    {
        static int countOfStudents;

        private int id;
        private Class group;       
        
        public Student(string fName, string lName, Class group) : base(fName, lName)
        {           
            this.ID = countOfStudents + 1;
            countOfStudents++;
            this.Group = group;           
        }

        public Student(string fName, string lName, string comments, Class group) : base(fName, lName, comments)
        {
            this.ID = countOfStudents + 1;
            countOfStudents++;
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
            private set { id = value; }
        }

        public Class Group
        {
            get { return group; }
            set { group = value; }
        }        
    }
}
