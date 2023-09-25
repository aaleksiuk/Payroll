using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll;

public class Employee
{
    private string FirstName;
    private string LastName;
    private decimal Salary;

    public Employee(string firstName, string lastName, decimal salary)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
        SetSalary(salary);
    }
    public void SetFirstName(string firstName) {
        if (firstName == null)
        {
            throw new Exception("Fistname cannot be empty");
        }
        FirstName = firstName;
    }
    public void SetLastName(string lastName) {
        if (lastName == null) 
        {
            throw new Exception("Lastname cannot be empty");
        }
        LastName = lastName;
    }
    public void SetSalary(decimal salary)
    {
        if (salary < 0) 
        {
            throw new Exception("Salary must be greater than 0");
        }
        Salary = salary;
    }
    public string GetFirstName()
    {
        return FirstName;
    }
    public string GetLastName()
    {
        return LastName;
    }
    public decimal GetSalary() 
    {
        return Salary;
    }
    public string GetAllData()
    {
        return ($"Salary for {GetFirstName()} {GetLastName()} is {GetSalary()}");
    }
}

