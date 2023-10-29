using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll;

public class EmployeeProvider 
{
public static Employee GetEmployeeFromConsole () {
        return new Employee(
        UserInputHelper.GetPromptNameFromUser("first"),
        UserInputHelper.GetPromptNameFromUser("last"),
        UserInputHelper.GetSalaryFromUser());
    }
}