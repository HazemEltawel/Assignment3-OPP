using System;
using Assignment3_OPP;
class Program
{
    static void Main()
    {

        #region Design and implement a Class for the employees in a company:

        //Employee employee = new Employee()
        //{
        //    id = 100,
        //    Name = "Hazem",
        //    security = Security.Developer,
        //    Salary = 12000.50m,
        //    HireDate = new DateTime(2023, 10, 1),
        //};
        //Console.WriteLine(employee.ToString());

        #endregion

        #region Develop a Class to represent the Hiring Date Data
        HiringDate hireDate =new HiringDate(12, 5, 2023);
        hireDate.Display();

        Console.WriteLine("Enter Hiring Date for Employee 2:");
        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        HiringDate hireDate2 = new HiringDate(day, month, year);
        Console.WriteLine("\nEmployee 2:");
        hireDate2.Display();

        #endregion
    }
}