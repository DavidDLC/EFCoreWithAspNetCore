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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure FluenAPI, many to many only can be done with fluenAPI
            //compositive key

            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            //fluent API configurations goes here


        }

    }
}
