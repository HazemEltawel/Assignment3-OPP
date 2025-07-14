using System;
using Assignment3_OPP;
class Program
{
    static void Main()
    {

        #region
        //Design and implement a Class for the employees in a company:

        Employee employee = new Employee()
        {
            id = 100,
            Name = "Hazem",
            security = Security.Developer,
            Salary = 12000.50m,
            HireDate = new DateTime(2023, 10, 1),
        };
        Console.WriteLine(employee.ToString());
        #endregion
    }
}