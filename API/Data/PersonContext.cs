using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class PersonContext :DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> People { get; set; }
    }
}
