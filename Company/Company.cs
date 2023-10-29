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
    public List<Employee> Employees { get; set; } = new();

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public decimal GetEmployeeSalary(Employee employee)
    { 
        return employee.Salary;
    }
    public decimal CalculateAvgSalary()
    {
        return Employees.Average(GetEmployeeSalary);
    }

    public IEnumerable<Employee> GetEmployees()
    { 
        return Employees;
    }
 }
