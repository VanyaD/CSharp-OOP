using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart_1
{
    public class People
    {
        private string name;
        private string comments;

        public People(string name)
        {
            this.Name = name;
        }
        public People(string name, string comments) : this(name)
        {
            this.Comments = comments;
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }        
    }
}
