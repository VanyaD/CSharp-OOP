namespace _02.StudentsAndWorkers
{
    public abstract class Human
    {
        private string fName;
        private string lName;

        public Human(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }   
    
        public void MergeStudentsAndWorkers()
        {

        }
    }
}
