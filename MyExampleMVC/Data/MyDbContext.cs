using System;
using Microsoft.EntityFrameworkCore;
using MyExampleMVC.Models.Domain;

namespace MyExampleMVC.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contacts> contactss { get; set; }
    }
}

