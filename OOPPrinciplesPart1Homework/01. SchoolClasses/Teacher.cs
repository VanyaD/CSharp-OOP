using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class Teacher : Person
    {
        private List<Discipline> setOfDisciplines;
        private List<Class> groupsAssigned;

        public Teacher(string fName, string lName) : base(fName, lName)
        {
            this.SetOfDisciplines = new List<Discipline>();
            this.GroupsAssigned = new List<Class>();
        }

        public Teacher(string fName, string lName, string comments) : base(fName, lName, comments)
        {
            this.SetOfDisciplines = new List<Discipline>();
            this.GroupsAssigned = new List<Class>();
        }

        public List<Discipline> SetOfDisciplines
        {
            get { return setOfDisciplines; }
            set { setOfDisciplines = value; }
        }

        public List<Class> GroupsAssigned
        {
            get { return groupsAssigned; }
            set { groupsAssigned = value; }
        }    

        public void AddDiscipline(Discipline discipline)
        {
            this.SetOfDisciplines.Add(discipline);
        }

        public void AssignGroup(Class group)
        {
            this.GroupsAssigned.Add(group);
        }

        public override string ToString() 
        {                       
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Fullname: {0} {1}", this.FirstName, this.LastName));
            result.Append(Environment.NewLine);

            if (this.SetOfDisciplines.Count == 0)
            {
                result.Append("Disciplines: None");
                result.AppendLine();
            }
            else
            {
                for (int i = 0; i < this.SetOfDisciplines.Count; i++)
                {
                    result.AppendLine(this.SetOfDisciplines[i].ToString());                 
                }
            }
            result.Append("------------------------");

            return result.ToString();
        }
    }
}
