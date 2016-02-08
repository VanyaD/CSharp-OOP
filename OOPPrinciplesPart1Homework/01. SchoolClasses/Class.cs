using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Class
    {
        private string id;
        private List<Teacher> teachers;
        private List<Discipline> disciplines;

        public Class(string id)
        {
            this.Id = id;
            this.Teachers = new List<Teacher>();
            this.Disciplines = new List<Discipline>();
        }

        public Class(string id, List<Teacher> teachers, List<Discipline> disciplines) : this(id)
        {
            this.Teachers = new List<Teacher>();
            this.Disciplines = new List<Discipline>();
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Class id: {0}", this.Id) + Environment.NewLine);
            result.AppendLine("Disciplines:");

            for (int i = 0; i < this.Disciplines.Count(); i++)
            {
                result.AppendLine(this.Disciplines[i].ToString());
            }

            return result.ToString();           
        }
    }
}
