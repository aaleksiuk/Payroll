using Payroll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

public class Company
{
    private List<Employee> employees = new();
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public decimal GetEmployeeSalary(Employee employee)
    { 
        return employee.GetSalary();
    }
    public decimal CalculateAvgSalary()
    {
        return employees.Average(GetEmployeeSalary);
    }

    public IEnumerable<Employee> GetEmployees()
    { 
        return employees;
    }
    

}
