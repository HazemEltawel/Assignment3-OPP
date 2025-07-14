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


