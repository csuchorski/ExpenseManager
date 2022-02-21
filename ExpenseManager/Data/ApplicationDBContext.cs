using ExpenseManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
