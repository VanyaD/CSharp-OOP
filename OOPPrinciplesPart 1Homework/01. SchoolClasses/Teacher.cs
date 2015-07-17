using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart_1
{
    public class Teacher : People
    {
        private List<Discipline> teacherDisciplines;
        private List<Group> groupsAssigned;

        public List<Group> GroupsAssigned
        {
            get { return groupsAssigned; }
            set { groupsAssigned = value; }
        }
        
        public Teacher(string name) : base(name)
        {
            this.Name = name;
            this.TeacherDisciplines = new List<Discipline>();
            this.GroupsAssigned = new List<Group>();
        }

        public List<Discipline> TeacherDisciplines
        {
            get { return teacherDisciplines; }
            set { teacherDisciplines = value; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.TeacherDisciplines.Add(discipline);
        }

        public void AssignGroup(Group group)
        {
            this.GroupsAssigned.Add(group);
        }

        public override string ToString() 
        {                       
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Teacher Name: {0}", this.Name));
            result.Append(Environment.NewLine);
            if (this.TeacherDisciplines.Count == 0)
            {
                result.Append("Disciplines: None");
                result.AppendLine();
            }
            else
            {
                for (int i = 0; i < this.TeacherDisciplines.Count; i++)
                {
                    result.Append(string.Format("Discipline: {0}; ", this.TeacherDisciplines[i].Name));
                    result.Append(string.Format("Number of lectures: {0}; ", this.TeacherDisciplines[i].NumberOfLectures));
                    result.Append(string.Format("Number of exercises: {0}", this.TeacherDisciplines[i].NumberOfExercises));
                    result.AppendLine();
                    
                }
            }

            return result.ToString();
        }
    }
}
