using _06_Assignment_Agenda.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Person> People { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
    }
}
