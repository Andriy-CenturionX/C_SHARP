using System;
using System.Collections.Generic;
using System.Linq;

class Firm
{
    public string Name { get; set; }
    public DateTime Founded { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorFullName { get; set; }
    public int EmployeesCount { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        List<Firm> firms = new List<Firm>
        {
            new Firm { Name="White Food Ltd", Founded=DateTime.Now.AddYears(-3), BusinessProfile="Marketing", DirectorFullName="John White", EmployeesCount=150, Address="London" },
            new Firm { Name="Black Nig", Founded=DateTime.Now.AddYears(-1), BusinessProfile="IT", DirectorFullName="Nig Black", EmployeesCount=80, Address="New York" }
        };

        var result = firms
            .Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT")
            .Where(f => f.EmployeesCount > 50)
            .ToList();

        foreach (var f in result)
            Console.WriteLine(f.Name);
    }
}
