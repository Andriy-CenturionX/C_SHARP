using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string FullName { get; set; }
    public string Position { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
}

class Firm
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();
}

class Program
{
    static void Main()
    {
        var firm = new Firm
        {
            Name = "Tech Corp",
            Employees = new List<Employee>
            {
                new Employee { FullName="Lionel Messi", Position="Manager", Phone="148841", Email="blablabla@test.com", Salary=5000 },
                new Employee { FullName="John Smith", Position="Developer", Phone="451234", Email="blableblu@test.com", Salary=3000 }
            }
        };

        
        var allEmployees = firm.Employees;

        
        var highSalary = firm.Employees.Where(e => e.Salary > 4000);

        
        var managers = firm.Employees.Where(e => e.Position == "Manager");

        
        var phone23 = firm.Employees.Where(e => e.Phone.StartsWith("23"));

        
        var emailDi = firm.Employees.Where(e => e.Email.StartsWith("di"));

        
        var lionel = firm.Employees.Where(e => e.FullName.Split(' ')[0] == "Lionel");

        Console.WriteLine("Менеджери");
        foreach (var e in managers)
            Console.WriteLine(e.FullName);
    }
}