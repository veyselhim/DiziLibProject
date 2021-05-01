using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entity_Framework
{
    public class NetflixDemoContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NetflixDemo;Trusted_Connection=true");

            }

            public DbSet<User> Users { get; set; }
            public DbSet<Film> Films { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<OperationClaim> OperationClaims { get; set; }
            public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
            public DbSet<Images> FilmImages { get; set; }

    }

}
