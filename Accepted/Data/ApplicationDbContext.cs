using System;
using System.Collections.Generic;
using System.Text;
using Accepted.Models;
using Microsoft.EntityFrameworkCore;

namespace AcceptedInterView.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Match> Match { get; set; }
        public DbSet<MatchOdds> MatchOdds { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Match>()
             .Property(f => f.Id)
             .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);




        }


    }
}
