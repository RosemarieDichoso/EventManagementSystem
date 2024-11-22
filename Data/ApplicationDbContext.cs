using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagementSystem.Models;


namespace EventManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<EventItem> EventItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EventDB;Trusted_Connection=True;");
        }
    }
}
