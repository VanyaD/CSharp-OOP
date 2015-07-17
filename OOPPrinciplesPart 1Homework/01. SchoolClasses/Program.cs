using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart_1
{
    class Program
    {
        static void Main()
        {
            Teacher teacher1 = new Teacher("Vanya Karaasenova");
            teacher1.AddDiscipline(new Discipline("Chemistry", 12, 10));
            teacher1.AddDiscipline(new Discipline("Sport", 7, 5));
            Console.WriteLine(teacher1);

            Teacher teacher2 = new Teacher("Vanya Dobreva");
            Console.WriteLine(teacher2);
            Console.WriteLine(teacher1.TeacherDisciplines);

            teacher2.AssignGroup(new Group("12"));

            Group myGroup = new Group("12");
            Console.WriteLine(myGroup.Disciplines);

            
                       
        }
    }
}
