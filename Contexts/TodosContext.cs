using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Contexts
{
    public class TodosContext : DbContext
    {
        public DbSet<Todos> Todos => Set<Todos>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
        }
    }
}