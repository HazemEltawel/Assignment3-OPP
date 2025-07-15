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
        //HiringDate hireDate =new HiringDate(12, 5, 2023);
        //hireDate.Display();

        //Console.WriteLine("Enter Hiring Date for Employee 2:");
        //Console.Write("Day: ");
        //int day = int.Parse(Console.ReadLine());

        //Console.Write("Month: ");
        //int month = int.Parse(Console.ReadLine());
        //Console.Write("Year: ");
        //int year = int.Parse(Console.ReadLine());
        //HiringDate hireDate2 = new HiringDate(day, month, year);
        //Console.WriteLine("\nEmployee 2:");
        //hireDate2.Display();

        #endregion

        #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

        //Employee[] EmpArr = new Employee[3];

        //EmpArr[0] = new Employee(
        //    id: 101,
        //    name: "Mahmoud",
        //    gender: 'M',
        //    salary: 18000m,
        //    hireDate: new DateTime(2021, 3, 15),
        //    security: Security.DBA
        //);

        //EmpArr[1] = new Employee(
        //    id: 102,
        //    name: "Laila",
        //    gender: 'F',
        //    salary: 5000m,
        //    hireDate: new DateTime(2022, 7, 10),
        //    security: Security.Guest
        //);

        //EmpArr[2] = new Employee(
        //    id: 103,
        //    name: "Youssef",
        //    gender: 'M',
        //    salary: 22000m,
        //    hireDate: new DateTime(2020, 12, 5),
        //    security: Security.Developer
        //);

        //Console.WriteLine("=== Employee List ===\n");
        //foreach (var emp in EmpArr)
        //{
        //    Console.WriteLine(emp);
        //    Console.WriteLine(new string('-', 30));
        //}

        #endregion

        #region Sort the employees based on their hire date then Print the sorted array.

        Employee[] EmpArr2 = new Employee[3];
        EmpArr2[0] = new Employee(120, "Hazem", 'M', 322321, new DateTime(2023, 10, 6), Security.Developer);
        EmpArr2[1] = new Employee(10, "mahmoud", 'M', 1240.50m, new DateTime(2010, 10, 1), Security.Developer);
        EmpArr2[2] = new Employee(130, "mouhamed", 'M', 13400.50m, new DateTime(2005, 6, 3), Security.Developer);

        Array.Sort(EmpArr2, (emp1, emp2) => emp1.HireDate.CompareTo(emp2.HireDate));
        Console.WriteLine("=== Sorted Employee List by Hire Date ===\n");
        foreach (var emp in EmpArr2)
        {
            Console.WriteLine(emp);
            Console.WriteLine(new string('-', 30));
        }

        #endregion
    }
}
