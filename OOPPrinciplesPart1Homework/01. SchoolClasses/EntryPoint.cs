using System;

namespace SchoolClasses
{
    class EntryPoint
    {
        static void Main()
        {
            Teacher teacher1 = new Teacher("Vanya", "Karaasenova");
            Teacher teacher2 = new Teacher("Maya", "Dobreva");
            teacher1.AddDiscipline(new Discipline("Chemistry", 12, 10));
            teacher1.AddDiscipline(new Discipline("Sport", 7, 5));

            Console.WriteLine("Teachers details:");
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine(teacher2.ToString());
             
            Class testClass = new Class("12");
            testClass.AddDiscipline(new Discipline("Chemistry", 12, 10));
            teacher2.AssignGroup(testClass);

            foreach (Discipline discipline in testClass.Disciplines)
            {
                Console.WriteLine(discipline.ToString());
            }                            
        }
    }
}
