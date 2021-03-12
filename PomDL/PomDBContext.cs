using Microsoft.EntityFrameworkCore;
using PomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomDL
{
    class PomDBContext : DbContext
    {

        public PomDBContext(DbContextOptions options) : base(options)
        {
        }

        protected PomDBContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<NoteRecord> NoteRecords { get; set; }
        public DbSet<Pomodoro> Pomodoros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
               .HasMany(u => u.Pomodoros)
               .WithOne()
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
               .HasMany(u => u.NoteRecords)
               .WithOne()
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
