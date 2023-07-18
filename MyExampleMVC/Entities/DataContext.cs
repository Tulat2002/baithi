using System;
using Microsoft.EntityFrameworkCore;

namespace MyExampleMVC.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

