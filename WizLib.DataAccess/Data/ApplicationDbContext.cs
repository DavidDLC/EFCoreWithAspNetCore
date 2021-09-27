using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //BookDetails
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(x => x.BookDetail_Id);
            modelBuilder.Entity<Fluent_BookDetail>().Property(x => x.NumberOfChapters).IsRequired();

            //Books

            modelBuilder.Entity<Fluent_Book>().HasKey(x => x.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Property(x => x.ISBN).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Fluent_Book>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Ignore(x => x.PrinceRange);

            //Author
            modelBuilder.Entity<Fluent_Author>().HasKey(x => x.Author_Id);
            modelBuilder.Entity<Fluent_Author>().Property(x => x.FirstName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Property(x => x.LastName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(x => x.FullName);
            
            //publisher
            modelBuilder.Entity<Fluent_Publisher>().HasKey(x => x.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Fluent_Publisher>().Property(x => x.Location).IsRequired();

            // one to one relationship between book and bookdetail
            modelBuilder.Entity<Fluent_Book>()
                .HasOne(x => x.Fluent_BookDetail)
                .WithOne(x => x.Fluent_Book)
                .HasForeignKey<Fluent_Book>("BookDetail_Id");

            // one to many relationship between book and publisher
            modelBuilder.Entity<Fluent_Book>()
                .HasOne(x => x.Fluent_Publisher)
                .WithMany(x => x.Fluent_Books)
                .HasForeignKey(b=>b.Publisher_Id);



        }

    }
}
