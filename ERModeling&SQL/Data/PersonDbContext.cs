using ERModeling_SQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Data
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassList> ClassLists { get; set; }
        public DbSet<CourseList> CourseLists { get; set; }
        public DbSet<GradeList> GradeLists { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Administration> Administrations { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VT3LGKNN; Initial Catalog=ERModelingSQL6;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluient API
            modelBuilder.Entity<Result>()
                .HasOne(p => p.Administrations)
                .WithMany(p => p.Results)
                .HasForeignKey(pl => pl.FkAdministrationId);

            //modelBuilder.Entity<Result>()
            //    .HasOne(p => p.ClassLists)
            //    .WithMany(p => p.Results)
            //    .HasForeignKey(pl => pl.FkClassListId);

            modelBuilder.Entity<Result>()
                .HasOne(p => p.CourseLists)
                .WithMany(p => p.Results)
                .HasForeignKey(pl => pl.FkCourseListId);

            modelBuilder.Entity<Result>()
                .HasOne(p => p.GradeLists)
                .WithMany(p => p.Results)
                .HasForeignKey(pl => pl.FkGradeListId);

            modelBuilder.Entity<Result>()
                .HasOne(p => p.Students)
                .WithMany(p => p.Results)
                .HasForeignKey(pl => pl.FkStudentId);

        }
    }
}
