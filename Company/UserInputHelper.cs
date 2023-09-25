using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll;

public class UserInputHelper
{
    public static decimal GetSalaryFromUser()
    {
        Console.WriteLine("Enter salary:");
        decimal salary;
        while (!decimal.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine($"Invalid input");
            Console.WriteLine("Enter salary:");
        }
        return salary;
    }

    public static string GetPromptNameFromUser(string prompt)
    {
        Console.WriteLine($"Enter {prompt} name:");
        var promptName = Console.ReadLine();
       
        while (String.IsNullOrWhiteSpace(prompt))
        {
            Console.WriteLine($"Invalid input");
            Console.WriteLine($"Enter {prompt} name:");
            promptName = Console.ReadLine();
        }
        return promptName;
    }
}