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

        public DbSet<Category> Categories { get; set; } //represents or make reference to a Table

        public DbSet<Genre> Genres { get; set; } //represents or make reference to a Table

        public DbSet<Book> Books { get; set; } //represents or make reference to a Table

        public DbSet<Author> Authors { get; set; } //represents or make reference to a Table

        public DbSet<Publisher> Publishers { get; set; } //represents or make reference to a Table

    }
}
