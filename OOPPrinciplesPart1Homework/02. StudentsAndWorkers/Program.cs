using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Program
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Vanya", "Karaasenova", 5));
            listOfStudents.Add(new Student("Maya", "Dobreva", 6));
            listOfStudents.Add(new Student("Elena", "Dobreva", 2));
            listOfStudents.Add(new Student("Dobri", "Dobrev", 2));
            listOfStudents.Add(new Student("Kaloyan", "Georgiev", 3));
            listOfStudents.Add(new Student("Maria", "Ivanova", 4));
            listOfStudents.Add(new Student("Pesho", "Petrov", 2));
            listOfStudents.Add(new Student("Slavi", "Karaasenov", 4));
            listOfStudents.Add(new Student("Georgi", "Mihaylov", 5));
            listOfStudents.Add(new Student("Plamen", "Karaasenova", 3));

            var sortedByGrade = listOfStudents
                .OrderBy(st => st.Grade)
                .ToArray();

            Console.WriteLine("Students sorted by grade: ");
            Console.WriteLine();

            foreach (Student st in sortedByGrade)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>();

            listOfWorkers.Add(new Worker("Vanya", "Karaasenova", 50, 8));
            listOfWorkers.Add(new Worker("Maya", "Dobreva", 60, 8));
            listOfWorkers.Add(new Worker("Elena", "Dobreva", 200, 8));
            listOfWorkers.Add(new Worker("Dobri", "Dobrev", 100, 8));
            listOfWorkers.Add(new Worker("Kaloyan", "Georgiev", 300, 8));
            listOfWorkers.Add(new Worker("Maria", "Ivanova", 400, 7));
            listOfWorkers.Add(new Worker("Pesho", "Petrov", 200, 6));
            listOfWorkers.Add(new Worker("Slavi", "Karaasenov", 40, 8));
            listOfWorkers.Add(new Worker("Georgi", "Mihaylov", 50, 8));
            listOfWorkers.Add(new Worker("Plamen", "Karaasenova", 300, 8));

            List<decimal> moneyPerHour = new List<decimal>();
            foreach(Worker worker in listOfWorkers)
            {
                worker.MoneyEarnedPerHour = worker.CalculateMoneyPerHour();
            }

            var sortedWorkers = listOfWorkers
                .OrderByDescending(x => x.MoneyEarnedPerHour)
                .ToArray();

            Console.WriteLine("Workers sorted by money per hour: ");
            Console.WriteLine();

            foreach (Worker wr in sortedWorkers)
            {
                Console.WriteLine(wr);
            }
            
            List<Human> listOfPeople = new List<Human>();

            for (int i = 0; i < 10; i++)
            {
                listOfPeople.Add(listOfStudents[i]);
                listOfStudents.Add(listOfStudents[i]);
            }

            var sortedPeople = listOfPeople
                .OrderBy(h => h.FName)
                .ThenBy(h => h.LName)
                .ToArray();

            Console.WriteLine();
            Console.WriteLine("People sorted by first and last name: ");
            Console.WriteLine();
            foreach (Human person in sortedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
