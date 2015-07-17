using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, Age = {1}", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());
        }        
    }
}
