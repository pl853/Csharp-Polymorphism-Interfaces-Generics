using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Simple_Library.Models
{
    public class DatabaseModel:DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<BookAuthor> BookAuthor {get; set;}

        public DatabaseModel(DbContextOptions<DatabaseModel> opt):base(opt){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // N-N relation Teacher-Class
            modelBuilder.Entity<TeacherClass>()
            .HasKey(t => new { t.TeacherId, t.ClassId});

            modelBuilder.Entity<TeacherClass>()
                .HasOne(x => x.Teacher)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.TeacherId);
            modelBuilder.Entity<TeacherClass>()
                .HasOne(x => x.Class)
                .WithMany(x => x.Teachers)
                .HasForeignKey(x => x.ClassId);

            // N-N relation Student-Class
            modelBuilder.Entity<StudentClass>()
            .HasKey(t => new { t.StudentId, t.ClassId});

            modelBuilder.Entity<StudentClass>()
                .HasOne(x => x.Student)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.StudentId);
            modelBuilder.Entity<StudentClass>()
                .HasOne(x => x.Class)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.ClassId);
        }
    }
}