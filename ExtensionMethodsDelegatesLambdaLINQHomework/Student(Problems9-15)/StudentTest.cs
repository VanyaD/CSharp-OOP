using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Problems9_15_
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Vanya", "Karaasenova", "FN111111", "+359284210638", "vanyad_dobreva@abv.bg", 2, 2, 5, 6, 3));
            students.Add(new Student("Emil", "Karaasenov", "FN1111112", "0884210638", "emil_dobreva@abv.bg", 2, 3, 2, 2));
            students.Add(new Student("Maya", "Dobreva", "FN1111113", "0884210638", "maya_dobreva@abv.bg", 1, 5, 2));
            students.Add(new Student("Elena", "Dobreva", "FN1111114", "0884210638", "elena_dobreva@gmail.com", 3, 4, 2));
            students.Add(new Student("Dobri", "Dobrev", "FN1111115", "0884210638", "dobri_dobreva@gmail.com", 2, 2));

            Console.WriteLine("Problem 9. All students from group 2, ordered by first name alphabetically: " + System.Environment.NewLine);
            var result2 =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (Student student in result2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Problem 10. All students from group 2, ordered by first name alphabetically: " + System.Environment.NewLine);
            var group2 = students // Problem 10
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName)
                .ToArray();

            foreach (Student student in group2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Problem 11. All students with e-mail in abv.bg: " + System.Environment.NewLine);

            //string test = "vanya";
            //Console.WriteLine(test.Contains("nya"));
            var result11 = students
                .Where(st => st.Email.Contains("@abv.bg"))
                .ToArray();

            foreach (Student student in result11)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Problem 12. All students with phone in Sofia: " + System.Environment.NewLine);

            var result12 = students
                .Where(st => st.Tel.Contains("+3592"))
                .ToArray();

            foreach (Student student in result12)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Problem 13. All students with at least one mark Excellent: " + System.Environment.NewLine);

            var result13 =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarkList = student.Marks
                };

            foreach (var student in result13)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarkList));
                Console.WriteLine();
            }

            //var studentsWithTwoTwos = students.Where(x => x.Marks.FindAll(y => y == 2).Count == 2). 
            //     Select(x => new { 
            //         FullName = x.FirstName + " " + x.LastName, 
            //         MarksList = x.Marks 
            //     }); 
 
 
             Console.WriteLine("Students that have exactly two poor marks, each in new anonymous class with " + 
                               "properties Fullname and MarksList:\n"); 
 
 
             //foreach (var student in studentsWithTwoTwos) 
             //{ 
             //    Console.WriteLine("Full name: {0}", student.FullName); 
             //    Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList)); 
             //    Console.WriteLine(); 
             //} 

       // }
        }
    }
}

