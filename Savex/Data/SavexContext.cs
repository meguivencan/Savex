using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Savex.Models.Expense;

namespace Savex.Data
{
    public class SavexContext : DbContext
    {
        public SavexContext (DbContextOptions<SavexContext> options)
            : base(options)
        {
        }

        public DbSet<Savex.Models.Expense.TypeOfExpense> TypeOfExpense { get; set; }

        public DbSet<Savex.Models.Expense.Expense> Expense { get; set; }
    }
}
