using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    struct JoinDate
    {
        private byte day;
        private string month;
        private int year;
        public JoinDate(byte day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            Console.WriteLine("Day : " + this.day);
            Console.WriteLine("Month: " + this.month);
            Console.WriteLine("Year: " + this.year);
        }
    }
    class Employee
    {
        private String id;
        protected double grossSalary=0;

        public Employee(String id, String name, double[] salary)
        {
            this.Id = id;
            this.Name = name;
            this.GrossSalary=TotalSalary(salary);

        }

        internal String Name { get; set; }
        internal String Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal double TotalSalary(double[] salary)
        {
            byte count = 0;
            double totalSalary = 0;
            while (count < salary.Length)
            {
                totalSalary += salary[count];
                count++;
            }
            return totalSalary;            
        }
        
        internal double GrossSalary
        {
            get { return this.grossSalary; }
            set
            {
                if (value > 0)
                    this.grossSalary = value;
                else
                    this.grossSalary = 0;
            }
        }

        public  double TaxPayable()
        {
            return this.GrossSalary * .5 * .1;
        }

        public  void ShowInformation()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Name " + this.Name);
            Console.WriteLine("Salary: " + this.GrossSalary);
            Console.WriteLine("Tax :" + this.TaxPayable());

        }



    }
}
