using Microsoft.EntityFrameworkCore;
using ProjectReportCardBE.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectReportCardBE.Data
{
    public class ReportCardDbContext:DbContext
    {
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Course>  Courses { get; set; }
        public DbSet<AcademicSession> AcademicSessions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ScoreEntry> ScoreEntries { get; set; }

        public ReportCardDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //each user has many sessions
            modelBuilder.Entity<User>()
                .HasMany(t => t.Sessions)
                .WithOne(t => t.User) 
                .OnDelete(DeleteBehavior.Cascade);
            //each session has many Semesters
            modelBuilder.Entity<AcademicSession>()
                .HasMany(s => s.Semesters)
                .WithOne(sem => sem.Session)
                .OnDelete(DeleteBehavior.Cascade);
            
            //Each Semester has many Courses
            modelBuilder.Entity<Semester>()
                .HasMany(s => s.Courses)
                .WithOne(c => c.ParentSemester)
                .OnDelete(DeleteBehavior.Cascade);

            //every course has one Score Entry per user
            modelBuilder.Entity<Course>().HasOne(c => c.Entry).WithOne(e=> e.Course);

        
        }

    
    }
}
