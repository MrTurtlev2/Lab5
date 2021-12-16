using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lab5.Data;
using Lab5.Models;

namespace Lab5.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
{
            using (var context = new TodoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TodoContext>>()))
            {
                // Look for any movies.
                if (context.TodoItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.TodoItems.AddRange(
                    new TodoItem
                    {
                        Name = "Tires",
                        Avilable = false,
                        Amount = 10,
                        Description = "new",
                    },
                    new TodoItem
                    {
                        Name = "Car windshield",
                        Avilable = true,
                        Amount = 10,
                        Description = "old",
                    },
                    new TodoItem
                    {
                        Name = "Engine",
                        Avilable = false,
                        Amount = 30,
                        Description = "new",
                    },
                    new TodoItem
                    {
                        Name = "Exhaust",
                        Avilable = true,
                        Amount = 40,
                        Description = "new",
                    }



                );
                context.SaveChanges();
            }
        }
    }
}