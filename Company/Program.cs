using Payroll;
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine($"Add 5 employees to the company list");
Company company = new Company();
for (int i = 0; i < 5; i++)
{
    company.AddEmployee(EmployeeProvider.GetEmployeeFromConsole());
}
string option;
do
{
    Console.WriteLine("1 – Print sum of all employees salary");
    Console.WriteLine("2 – Display all employees data");
    Console.WriteLine("3 – Add new employee");
    Console.WriteLine("4 – End program\n");
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.WriteLine($"{company.CalculateAvgSalary()}\n");
            break;
        case "2":
            foreach (var employee in company.Employees)
            {
                Console.WriteLine($"{employee}\n");
              }
            break;
        case "3":
            company.AddEmployee(EmployeeProvider.GetEmployeeFromConsole());
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Enter correct option.\n");

            break;
    }
} while (option != "4");