using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll;

public class Employee
{
    private string _firstName;
    private string _lastName;
    private decimal _salary;

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (value == null)
            {
                throw new Exception("Firstname cannot be empty");
            }
            _firstName = value;
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (value == null)
            {
                throw new Exception("Lastname cannot be empty");
            }
            _lastName = value;
        }
    }

    public decimal Salary
    {
        get { return _salary; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Salary must be greater than 0");
            }
            _salary = value;
        }
    }

    public Employee(string firstName, string lastName, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public override string? ToString()
    {
        return ($"Salary for {FirstName} {LastName} is {Salary}");
    }
}