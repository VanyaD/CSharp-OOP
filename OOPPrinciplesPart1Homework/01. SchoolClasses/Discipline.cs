using System;
using System.Text;

namespace SchoolClasses
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comments;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
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
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The nuber of exercises cannot be less or equal to zero!");
                }

                numberOfExercises = value;
            }
        }
        
        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The nuber of lectures cannot be less or equal to zero!");
                }

                numberOfLectures = value;
            }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Discipline: {0}", this.Name));
            sb.AppendLine(string.Format("Number of lectures: {0}", this.NumberOfLectures));
            sb.AppendLine(string.Format("Number of exercises: {0}", this.NumberOfExercises));

            return sb.ToString();
        }
    }
}
