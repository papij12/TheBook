#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheBook.Models;

namespace TheBook.Data
{
    public class TheBookContext : DbContext
    {
        public TheBookContext (DbContextOptions<TheBookContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<TheBook.Models.Admin> Admin { get; set; }

        public DbSet<TheBook.Models.Books> Books { get; set; }

        public DbSet<TheBook.Models.Clients> Clients { get; set; }
    }
}
