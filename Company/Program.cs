using Payroll;
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine($"Add 5 employees to the company list");
Company company = new Company();
for (int i = 0; i < 5; i++)
{
    Employee employee = new Employee(
        UserInputHelper.GetPromptNameFromUser("first"),
        UserInputHelper.GetPromptNameFromUser("last"),
        UserInputHelper.GetSalaryFromUser());

    company.AddEmployee(employee);
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
            Console.WriteLine(company.CalculateAvgSalary());
            Console.WriteLine("\n");
            break;
        case "2":
            foreach (var employee in company.GetEmployees())
            {
                Console.WriteLine(employee.GetAllData());
                Console.WriteLine("\n");
            }
            break;
        case "3":
            company.AddEmployee(new Employee(
                UserInputHelper.GetPromptNameFromUser("first"),
                UserInputHelper.GetPromptNameFromUser("last"),
                UserInputHelper.GetSalaryFromUser()));
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Enter correct option.");
            Console.WriteLine("\n");
            break;
    }
} while (option != "4");

