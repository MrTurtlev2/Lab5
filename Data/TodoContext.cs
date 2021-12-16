using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5.Data
{
    public class WebApplication3Context : DbContext
    {
        public WebApplication3Context(DbContextOptions<WebApplication3Context> options)
            : base(options)
        {
        }

        public DbSet<Lab5.Models.TodoItem> TodoItems { get; set; }
    }
}