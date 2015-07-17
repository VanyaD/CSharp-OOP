using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal moneyEarnedPerHour;

        public decimal MoneyEarnedPerHour
        {
            get { return moneyEarnedPerHour; }
            set { moneyEarnedPerHour = value; }
        }       

        public Worker(string fName, string lName) : base(fName, lName)
        {
            this.FName = fName;
            this.LName = lName;
        }

        public Worker(string fName, string lName, decimal weekSalary) : this(fName, lName)
        {
            this.WeekSalary = weekSalary;
        }

        public Worker(string fName, string lName, decimal weekSalary, int workHoursPerDay)
            : this(fName, lName, weekSalary)
        {
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }
                
        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public decimal CalculateMoneyPerHour()
        {
            decimal result = this.WeekSalary / this.WorkHoursPerDay;

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Name: {0} {1}, ", FName, LName));
            result.Append(string.Format("Money earned per hour: {0}", moneyEarnedPerHour));

            return result.ToString();
        }
    }
}
