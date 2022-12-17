
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using testexam.Data;
using System;
using System.Linq;
using System.Diagnostics;

namespace testexam.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new EmployeeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<EmployeeContext>>()))
        {
            // Look for any movies.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee { Name = "Minh",
                    Department = "Fpt Aptech", Salary = 1000 },
            new Employee {  Name = "Quang",
                    Department = "Arena Multimedia", Salary = 2000 },
            };
            foreach (Employee s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();
        }
    }
}

