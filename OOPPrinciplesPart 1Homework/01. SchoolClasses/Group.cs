using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart_1
{
    public class Group
    {
        private string groupIdentifier;
        private List<Teacher> teachers;
        private List<Discipline> disciplines;


        public Group(string identifier)
        {
            this.GroupIdentifier = identifier;
        }

        public Group(string groupIdentifier, List<Teacher> teachers, List<Discipline> disciplines) : this(groupIdentifier)
        {
            this.Teachers = teachers;
            this.Disciplines = disciplines;
        }

        public string GroupIdentifier
        {
            get
            {
                return this.groupIdentifier;
            }
            set
            {
                this.groupIdentifier = value;
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Group : {0}", this.GroupIdentifier) + Environment.NewLine);
            for (int i = 0; i < this.GroupIdentifier.Count(); i++)
            {
                result.Append(string.Format("Disciplines: {0}", this.Disciplines));
            }

            return result.ToString();
            
        }

    }
}
