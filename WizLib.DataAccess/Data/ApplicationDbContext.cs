using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizLib.DataAccess.FluentConfig;
using WizLib.Model.Models;

namespace WizLib.DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Category> Categories { get; set; } //represents or make reference to a Table

        public DbSet<BookDetail> BookDetails { get; set; } //represents or make reference to a Table

        public DbSet<Genre> Genres { get; set; } //represents or make reference to a Table

        public DbSet<Book> Books { get; set; } //represents or make reference to a Table

        public DbSet<Author> Authors { get; set; } //represents or make reference to a Table

        public DbSet<Publisher> Publishers { get; set; } //represents or make reference to a Table

        public DbSet<BookAuthor> BookAuthors { get; set; } //represents or make reference to a Table

        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; } //represents or make reference to a Table

        public DbSet<Fluent_Book> Fluent_Books { get; set; } //represents or make reference to a Table

        public DbSet<Fluent_Author> Fluent_Authors { get; set; } //represents or make reference to a Table

        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; } //represents or make reference to a Table

        //public DbSet<Fluent_BookAuthor> Fluent_BookAuthors { get; set; } //represents or make reference to a Table


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure FluenAPI, many to many only can be done with fluenAPI
            //compositive key

            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            //fluent API configurations goes here

            //category change name and column name with FluentAPI
            modelBuilder.Entity<Category>().ToTable("Tbl_Category");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");

            //compositive key
            modelBuilder.Entity<Fluent_BookAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailsConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());










        }

    }
}
