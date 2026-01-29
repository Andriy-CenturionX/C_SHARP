using Data.Database;
using Core.Models;
using Services.Reporting;

class Program
{
    static void Main()
    {
        var db = new DatabaseConnection();
        db.Connect();

        var user = new User { Name = "Ivan" };

        var report = new ReportGenerator();
        report.Generate();
    }
}