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
            modelBuilder.Entity<BookAuthor>()
                .HasKey(k => new {k.AuthorId,k.BookId});

            modelBuilder.Entity<BookAuthor>()
                .HasOne(x=> x.Author)
                .WithMany(xi => xi.Books)
                .HasForeignKey(x=>x.AuthorId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(x=>x.Book)
                .WithMany(xi=>xi.Authors)
                .HasForeignKey(x=>x.BookId);
        }
    }
}