using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizLib.Model.Models;

namespace WizLib.DataAccess.FluentConfig
{
    public class FluentBookConfig : IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
        {
            //Books

            modelBuilder.HasKey(x => x.Book_Id);
            modelBuilder.Property(x => x.Title).IsRequired();
            modelBuilder.Property(x => x.ISBN).IsRequired().HasMaxLength(15);
            modelBuilder.Property(x => x.Price).IsRequired();
            modelBuilder.Ignore(x => x.PrinceRange);


            // one to one relationship between book and bookdetail
            modelBuilder
                .HasOne(x => x.Fluent_BookDetail)
                .WithOne(x => x.Fluent_Book)
                .HasForeignKey<Fluent_Book>("BookDetail_Id");

            // one to many relationship between book and publisher
            modelBuilder
                .HasOne(x => x.Fluent_Publisher)
                .WithMany(x => x.Fluent_Books)
                .HasForeignKey(b => b.Publisher_Id);
        }
    }
}
