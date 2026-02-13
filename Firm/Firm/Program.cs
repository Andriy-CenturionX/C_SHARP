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
            new Firm { Name="Black Nig", Founded=DateTime.Now.AddYears(-1), BusinessProfile="IT", DirectorFullName="Nig Black", EmployeesCount=80, Address="New York" },
            new Firm { Name="Green Food Market", Founded=DateTime.Now.AddDays(-123), BusinessProfile="Marketing", DirectorFullName="Sara White", EmployeesCount=250, Address="London" },
            new Firm { Name="Tech Solutions", Founded=DateTime.Now.AddYears(-5), BusinessProfile="IT", DirectorFullName="Tom Brown", EmployeesCount=400, Address="Berlin" }
        };

        
        var all = from f in firms select f;

        
        var food = from f in firms
                   where f.Name.Contains("Food")
                   select f;

        
        var marketing = from f in firms
                        where f.BusinessProfile == "Marketing"
                        select f;

        
        var marketingOrIt = from f in firms
                            where f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT"
                            select f;

        
        var more100 = from f in firms
                      where f.EmployeesCount > 100
                      select f;

        
        var range = from f in firms
                    where f.EmployeesCount >= 100 && f.EmployeesCount <= 300
                    select f;

        
        var london = from f in firms
                     where f.Address == "London"
                     select f;

        
        var directorWhite = from f in firms
                            where f.DirectorFullName.Split(' ').Last() == "White"
                            select f;

        
        var older2Years = from f in firms
                          where (DateTime.Now - f.Founded).TotalDays > 365 * 2
                          select f;

        
        var exactly123Days = from f in firms
                             where (DateTime.Now - f.Founded).Days == 123
                             select f;

        
        var complex = from f in firms
                      where f.DirectorFullName.Split(' ').Last() == "Black"
                      && f.Name.Contains("White")
                      select f;

        Console.WriteLine("Всі фірми");
        foreach (var f in all)
            Console.WriteLine(f.Name);
    }
}
