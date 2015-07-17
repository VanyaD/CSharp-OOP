using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart_1
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comments;
        private List<Group> groupsAssignedTo;

        public List<Group> GroupsAssignedTo
        {
            get { return groupsAssignedTo; }
            set { groupsAssignedTo = value; }
        }
        
        public static List<Discipline> allDisciplines;

        public List<Discipline> AllDisciplines
        {
            get { return allDisciplines; }
            set { allDisciplines = value; }
        }
        
        public Discipline(string name)
        {
            this.Name = name;
            this.GroupsAssignedTo = groupsAssignedTo;
            //AllDisciplines.Add(new Discipline(name, numberOfLectures, numberOfExercises));
        }

        public Discipline(string name, int numberOfLectures) : this(name)
        {
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises) : this(name, numberOfLectures)
        {
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comments)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comments = comments;
        }
        
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        
        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set { numberOfExercises = value; }
        }
        
        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
