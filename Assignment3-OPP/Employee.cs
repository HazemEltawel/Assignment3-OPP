using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OPP
{
    using System;
    using System.Globalization;

   

    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Security security { get; set; }

        private decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid salary amount!");
            }
        }

        public DateTime HireDate { get; set; }

        private char gender;
        private Security securityLevel;
        private int v1;
        private string v2;
        private decimal v3;
        private DateTime dateTime;
        private Security dBA;

        public Employee(int id, string name, char gender, decimal salary, DateTime hireDate, Security security)
        {
            this.id = id;
            Name = name;
            this.gender = gender;
            this.salary = salary;
            HireDate = hireDate;
            this.security = this.security;
        }

        public Employee(int v1, string v2, decimal v3, DateTime dateTime, Security dBA)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime = dateTime;
            this.dBA = dBA;
        }

        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Invalid gender. Only 'M' or 'F' allowed.");
            }
        }

        public override string ToString()
        {
            return $"ID: {id}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {(Gender == 'M' ? "Male" : "Female")}\n" +
                   $"Security Level: {security}\n" +
                   $"Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}\n" +
                   $"Hire Date: {HireDate.ToShortDateString()}";
        }















    }
}


