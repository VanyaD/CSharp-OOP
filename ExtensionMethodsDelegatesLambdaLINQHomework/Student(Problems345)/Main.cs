// Problem 3. First before last
// • Write a method that from a given array of students finds all students whose 
// first name is before its last name alphabetically.
// • Use LINQ query operators.

namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsArr
    {
        static void Main()
        {
            Student[] studentsArray =
            {
                new Student("Vanya", "Karaasenova", 20),
                new Student("Emil", "Karaasenov", 21),
                new Student("Maya", "Dobreva", 36),
                new Student("Emil", "Biserov", 21),
                new Student("Maya", "Dobreva", 36)
            };

            Console.WriteLine("All students:");

            for (int i = 0; i < studentsArray.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": {0}", studentsArray[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Task 3. Students whose first name is before their last name:");

            var result = FirstNameBeforeLast(studentsArray);
            foreach (Student student in result)
            {
                Console.WriteLine("Student" + ": {0}", student);
            }

            Console.WriteLine("----------");

            // Problem 4. Age range
            // • Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            Console.WriteLine("Task 4. All students with age between 18 and 24:");
            FindStudentsWithAgeBetween18And24(studentsArray);

            Console.WriteLine("-----------");

            // Problem 5. Order students
            // • Using the extension methods  OrderBy()  and  ThenBy()  with lambda expressions sort the students by
            // first name and last name in descending order.
            // • Rewrite the same with LINQ.

            Console.WriteLine("Task 5. Students sorted by first and last name in descending order:");
            var resultProblem5 = SortStudents(studentsArray);

            foreach (Student student in resultProblem5)
            {
                Console.WriteLine("Student" + ": {0}", student);
            }
            Console.WriteLine();

            Console.WriteLine("\nStudents sorted by first and then last name using LINQ:");
            var sortedStudents2 =
                from student in studentsArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sortedStudents2)
            {
                Console.WriteLine(student);
            }
        }

        private static IEnumerable<Student> SortStudents(Student[] studentsArray)
        {
            var resultProblem5 = studentsArray
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToArray();

            return resultProblem5;
        }

        private static void FindStudentsWithAgeBetween18And24(Student[] studentsArray)
        {
            var result = studentsArray
                .Where(st => ((st.Age > 18) && (st.Age < 24)))
                .ToArray();

            foreach (Student student in result)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        private static IEnumerable<Student> FirstNameBeforeLast(Student[] studentsArray)
        {
            var result = studentsArray
             .Where(st => st.FirstName.CompareTo(st.LastName) < 0)
             .ToArray();

            return result;
        }
    }
}
